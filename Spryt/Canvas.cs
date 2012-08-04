using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Imaging;

namespace Spryt
{
    partial class Canvas : Panel, IDisposable
    {
        private static readonly Brush stBackgroundBrush = new TextureBrush( Spryt.Properties.Resources.background, System.Drawing.Drawing2D.WrapMode.Tile );
        private static readonly Pen stBoxPreviewPen = new Pen( Color.FromArgb( 127, SystemColors.Highlight ) );
        private static readonly Brush stBoxPreviewBrush = new SolidBrush( Color.FromArgb( 63, SystemColors.Highlight ) );
        private static readonly Brush stSelectedAreaBrush = new TextureBrush( Spryt.Properties.Resources.shaded );
        private Control myOldParent;
        private EventHandler myOnParentResizeHandler;
        private EventHandler myOnParentMouseEnterHandler;
        private EventHandler myOnParentDisposedHandler;

        private bool mySelectingPixels;
        private bool[ , ] mySelectedPixels;
        private int mySelectedArea;
        private Region mySelectedRegion;
        private Region myScaledRegion;

        private bool myDrawingPencil;
        private bool myDrawingBox;
        private Point myLastDrawPos;
        private Rectangle myBoxPreview;

        private ToolPanel myToolPanel;

        internal readonly ImageInfo Image;

        public Canvas( ImageInfo image, ToolPanel toolInfoPanel )
        {
            myOnParentResizeHandler = new EventHandler( OnParentResize );
            myOnParentMouseEnterHandler = new EventHandler( OnParentMouseEnter );
            myOnParentDisposedHandler = new EventHandler( OnParentDisposed );

            myDrawingPencil = false;
            myDrawingBox = false;

            Image = image;
            myToolPanel = toolInfoPanel;

            mySelectedPixels = new bool[ image.Width, image.Height ];
            mySelectedArea = 0;
            mySelectedRegion = new Region( Rectangle.Empty );
            myScaledRegion = new Region( Rectangle.Empty );

            Size = new Size( image.Width * 8, image.Height * 8 );
            BorderStyle = BorderStyle.FixedSingle;

            DoubleBuffered = true;

            InitializeComponent();
        }

        private void Centre()
        {
            if( Parent != null )
                Location = new Point( ( Parent.Width - Width ) / 2, ( Parent.Height - Height ) / 2 );
        }

        public void UpdateZoomScale()
        {
            ClientSize = new Size( (int) Math.Round( Image.Width * Image.ZoomScale ), 
                (int) Math.Round( Image.Height * Image.ZoomScale ) );
            Centre();

            Invalidate();
        }

        private void OnParentResize( object sender, EventArgs e )
        {
            Centre();
        }

        protected override void OnResize( EventArgs eventargs )
        {
            base.OnResize( eventargs );

            Centre();
        }

        protected override void OnMouseEnter( EventArgs e )
        {
            Focus();
        }

        private void OnParentMouseEnter( object sender, EventArgs e )
        {
            Focus();
        }

        protected override void OnMouseDown( MouseEventArgs e )
        {
            if ( e.Button == MouseButtons.Left || e.Button == MouseButtons.Right )
            {
                int x = (int) ( ( e.X - ClientRectangle.Left ) / Image.ZoomScale );
                int y = (int) ( ( e.Y - ClientRectangle.Top ) / Image.ZoomScale );

                switch ( myToolPanel.CurrentTool )
                {
                    case Tool.Area:
                        mySelectingPixels = true;
                        myLastDrawPos = new Point( x, y );
                        myBoxPreview = new Rectangle( x, y, 1, 1 );
                        break;
                    case Tool.Pencil:
                        myDrawingPencil = true;
                        myLastDrawPos = new Point( x, y );

                        if ( e.Button == MouseButtons.Left )
                            DrawPencil( x, y, Image.CurrentPixel );
                        else
                            DrawPencil( x, y, Pixel.Empty );

                        break;
                    case Tool.Fill:
                        if ( e.Button == MouseButtons.Left )
                            Fill( x, y, Image.CurrentPixel );
                        else if ( e.Button == MouseButtons.Right )
                            Fill( x, y, Pixel.Empty );

                        break;
                    case Tool.Box:
                        myDrawingBox = true;
                        myLastDrawPos = new Point( x, y );
                        myBoxPreview = new Rectangle( x, y, 1, 1 );
                        break;
                }
            }
        }

        protected override void OnMouseMove( MouseEventArgs e )
        {
            int x = (int) ( ( e.X - ClientRectangle.Left ) / Image.ZoomScale );
            int y = (int) ( ( e.Y - ClientRectangle.Top ) / Image.ZoomScale );

            if ( myDrawingPencil )
            {
                if ( MouseButtons.HasFlag( MouseButtons.Left ) )
                    DrawPencil( x, y, Image.CurrentPixel );
                else
                    DrawPencil( x, y, Pixel.Empty );
            }

            if ( mySelectingPixels || myDrawingBox )
                UpdateBoxPreview( x, y );
        }

        protected override void OnMouseUp( MouseEventArgs e )
        {
            if ( e.Button == MouseButtons.Left || e.Button == MouseButtons.Right )
            {
                if ( myDrawingPencil )
                    myDrawingPencil = false;

                if ( myDrawingBox || mySelectingPixels )
                {
                    int x = (int) ( ( e.X - ClientRectangle.Left ) / Image.ZoomScale );
                    int y = (int) ( ( e.Y - ClientRectangle.Top ) / Image.ZoomScale );

                    if ( mySelectingPixels )
                    {
                        SelectArea( x, y, e.Button == MouseButtons.Right );

                        mySelectingPixels = false;
                    }

                    if ( myDrawingBox )
                    {
                        if ( e.Button == MouseButtons.Left )
                            DrawBox( x, y, Image.CurrentPixel );
                        else
                            DrawBox( x, y, Pixel.Empty );

                        myDrawingBox = false;
                    }
                }
            }
        }

        private void SelectArea( int x, int y, bool deselect = false )
        {
            int left = Math.Max( Math.Min( x, myLastDrawPos.X ), 0 );
            int right = Math.Min( Math.Max( x, myLastDrawPos.X ), Image.Width - 1 );
            int top = Math.Max( Math.Min( y, myLastDrawPos.Y ), 0 );
            int bottom = Math.Min( Math.Max( y, myLastDrawPos.Y ), Image.Height - 1 );

            for ( int px = left; px <= right; ++px )
            {
                for ( int py = top; py <= bottom; ++py )
                {
                    if ( mySelectedPixels[ px, py ] == deselect )
                        mySelectedArea += ( deselect ? -1 : 1 );

                    mySelectedPixels[ px, py ] = !deselect;
                }
            }

            Rectangle rect = new Rectangle( left, top, right - left + 1, bottom - top + 1 );

            if ( deselect )
                mySelectedRegion.Exclude( rect );
            else
                mySelectedRegion.Union( rect );

            UpdateScaledRegion();
            Invalidate();
        }

        private void UpdateScaledRegion()
        {
            myScaledRegion = mySelectedRegion.Clone();
            myScaledRegion.Transform( new System.Drawing.Drawing2D.Matrix( Image.ZoomScale, 0.0f, 0.0f, Image.ZoomScale, 0.0f, 0.0f ) );
        }

        private bool CanDraw( int x, int y )
        {
            return x >= 0 && y >= 0 && x < Image.Width && y < Image.Height && ( mySelectedArea == 0 || mySelectedPixels[ x, y ] );
        }

        private void DrawPencil( int x, int y, Pixel pixel )
        {
            LineRasterEnumerator line = new LineRasterEnumerator( myLastDrawPos, new Point( x, y ) );
            while ( line.MoveNext() )
            {
                int lx = line.Current.X;
                int ly = line.Current.Y;

                if ( CanDraw( lx, ly ) )
                    Image.Layers[ 0 ].SetPixel( lx, ly, pixel );
            }

            myLastDrawPos = new Point( x, y );

            Invalidate();
        }

        private void Fill( int x, int y, Pixel pixel )
        {
            if ( !CanDraw( x, y ) )
                return;

            Stack<Point> stack = new Stack<Point>();
            stack.Push( new Point( x, y ) );

            Layer layer = Image.Layers[ 0 ];
            Pixel match = layer.Pixels[ x, y ];

            if ( match == pixel )
                return;

            while ( stack.Count > 0 )
            {
                Point pos = stack.Pop();
                if ( CanDraw( pos.X, pos.Y ) && layer.Pixels[ pos.X, pos.Y ] == match )
                {
                    layer.SetPixel( pos.X, pos.Y, pixel );

                    stack.Push( new Point( pos.X - 1, pos.Y ) );
                    stack.Push( new Point( pos.X + 1, pos.Y ) );
                    stack.Push( new Point( pos.X, pos.Y - 1 ) );
                    stack.Push( new Point( pos.X, pos.Y + 1 ) );
                }
            }

            Invalidate();
        }

        private void DrawBox( int x, int y, Pixel pixel )
        {
            int left = Math.Max( Math.Min( x, myLastDrawPos.X ), 0 );
            int right = Math.Min( Math.Max( x, myLastDrawPos.X ), Image.Width - 1 );
            int top = Math.Max( Math.Min( y, myLastDrawPos.Y ), 0 );
            int bottom = Math.Min( Math.Max( y, myLastDrawPos.Y ), Image.Height - 1 );

            Layer layer = Image.Layers[ 0 ];

            for ( int px = left; px <= right; ++px )
                for ( int py = top; py <= bottom; ++py )
                    if( CanDraw( px, py ) )
                        layer.SetPixel( px, py, pixel );

            Invalidate();
        }

        private void UpdateBoxPreview( int x, int y )
        {
            int left = Math.Max( Math.Min( x, myLastDrawPos.X ), 0 );
            int right = Math.Min( Math.Max( x + 1, myLastDrawPos.X + 1 ), Image.Width );
            int top = Math.Max( Math.Min( y, myLastDrawPos.Y ), 0 );
            int bottom = Math.Min( Math.Max( y + 1, myLastDrawPos.Y + 1 ), Image.Height );

            myBoxPreview = new Rectangle( (int) Math.Round( left * Image.ZoomScale ),
                (int) Math.Round( top * Image.ZoomScale ),
                (int) Math.Round( ( right - left ) * Image.ZoomScale ),
                (int) Math.Round( ( bottom - top ) * Image.ZoomScale ) );

            Invalidate();
        }

        protected override void OnParentChanged( EventArgs e )
        {
            base.OnParentChanged( e );

            if ( myOldParent != null )
            {
                myOldParent.Resize -= myOnParentResizeHandler;
                myOldParent.MouseEnter -= myOnParentMouseEnterHandler;
                myOldParent.Disposed -= myOnParentDisposedHandler;
            }

            if ( Parent != null )
            {
                Parent.Resize += myOnParentResizeHandler;
                Parent.MouseEnter += myOnParentMouseEnterHandler;
                Parent.Disposed += myOnParentDisposedHandler;

                Centre();
            }

            myOldParent = Parent;
        }

        protected override void OnPaint( PaintEventArgs e )
        {
            base.OnPaint( e );

            e.Graphics.FillRectangle( stBackgroundBrush, ClientRectangle );

            e.Graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.NearestNeighbor;

            RectangleF destRect = new RectangleF( ClientRectangle.X, ClientRectangle.Y, ClientRectangle.Width, ClientRectangle.Height );
            RectangleF srcRect = new RectangleF( -0.5f, -0.5f, Image.Width, Image.Height );

            foreach ( Layer layer in Image.Layers )
                e.Graphics.DrawImage( layer.Bitmap, destRect, srcRect, GraphicsUnit.Pixel );

            e.Graphics.FillRegion( stSelectedAreaBrush, myScaledRegion );

            e.Graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.Default;

            if ( mySelectingPixels || myDrawingBox )
            {
                e.Graphics.FillRectangle( stBoxPreviewBrush, myBoxPreview );
                e.Graphics.DrawRectangle( stBoxPreviewPen, myBoxPreview );
            }
        }

        private void OnParentDisposed( object sender, EventArgs e )
        {
            Dispose();
        }

        public new void Dispose()
        {
            Parent = null;
            OnParentChanged( null );

            base.Dispose();
        }
    }
}
