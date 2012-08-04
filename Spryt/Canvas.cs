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
        private Control myOldParent;
        private EventHandler myOnParentResizeHandler;
        private EventHandler myOnParentMouseEnterHandler;
        private EventHandler myOnParentDisposedHandler;

        private bool myDrawing;
        private Point myLastDrawPos;

        private ToolPanel myToolPanel;

        internal readonly ImageInfo Image;

        public Canvas( ImageInfo image, ToolPanel toolInfoPanel )
        {
            myOnParentResizeHandler = new EventHandler( OnParentResize );
            myOnParentMouseEnterHandler = new EventHandler( OnParentMouseEnter );
            myOnParentDisposedHandler = new EventHandler( OnParentDisposed );

            myDrawing = false;

            Image = image;
            myToolPanel = toolInfoPanel;

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
                    case Tool.Pencil:
                        myDrawing = true;
                        myLastDrawPos = new Point( x, y );

                        if ( e.Button == MouseButtons.Left )
                            Draw( x, y, Image.CurrentPixel );
                        else
                            Draw( x, y, Pixel.Empty );

                        break;
                    case Tool.Fill:
                        if ( e.Button == MouseButtons.Left )
                            Fill( x, y, Image.CurrentPixel );
                        else if ( e.Button == MouseButtons.Right )
                            Fill( x, y, Pixel.Empty );

                        break;
                }
            }
        }

        private void Draw( int x, int y, Pixel pixel )
        {
            LineRasterEnumerator line = new LineRasterEnumerator( myLastDrawPos, new Point( x, y ) );
            while ( line.MoveNext() )
            {
                int lx = line.Current.X;
                int ly = line.Current.Y;

                if ( lx >= 0 && ly >= 0 && lx < Image.Width && ly < Image.Height )
                {
                    Image.Layers[ 0 ].SetPixel( lx, ly, pixel );
                }
            }

            myLastDrawPos = new Point( x, y );

            Invalidate();
        }

        private void Fill( int x, int y, Pixel pixel )
        {
            Stack<Point> stack = new Stack<Point>();
            stack.Push( new Point( x, y ) );

            Layer layer = Image.Layers[ 0 ];
            Pixel match = layer.Pixels[ x, y ];

            if ( match == pixel )
                return;

            while ( stack.Count > 0 )
            {
                Point pos = stack.Pop();
                if ( layer.Pixels[ pos.X, pos.Y ] == match )
                {
                    layer.SetPixel( pos.X, pos.Y, pixel );

                    if ( pos.X > 0 )
                        stack.Push( new Point( pos.X - 1, pos.Y ) );
                    if ( pos.X < Image.Width - 1 )
                        stack.Push( new Point( pos.X + 1, pos.Y ) );
                    if ( pos.Y > 0 )
                        stack.Push( new Point( pos.X, pos.Y - 1 ) );
                    if ( pos.Y < Image.Height - 1 )
                        stack.Push( new Point( pos.X, pos.Y + 1 ) );
                }
            }

            Invalidate();
        }

        protected override void OnMouseMove( MouseEventArgs e )
        {
            if ( myDrawing )
            {
                int x = (int) ( ( e.X - ClientRectangle.Left ) / Image.ZoomScale );
                int y = (int) ( ( e.Y - ClientRectangle.Top ) / Image.ZoomScale );

                if ( MouseButtons.HasFlag( MouseButtons.Left ) )
                    Draw( x, y, Image.CurrentPixel );
                else
                    Draw( x, y, Pixel.Empty );
            }
        }

        protected override void OnMouseUp( MouseEventArgs e )
        {
            myDrawing = false;
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

            TextureBrush brush = new TextureBrush( Spryt.Properties.Resources.background, System.Drawing.Drawing2D.WrapMode.Tile );

            e.Graphics.FillRectangle( brush, ClientRectangle );

            e.Graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.NearestNeighbor;

            RectangleF destRect = new RectangleF( ClientRectangle.X, ClientRectangle.Y, ClientRectangle.Width, ClientRectangle.Height );
            RectangleF srcRect = new RectangleF( -0.5f, -0.5f, Image.Width, Image.Height );

            foreach ( Layer layer in Image.Layers )
                e.Graphics.DrawImage( layer.Bitmap, destRect, srcRect, GraphicsUnit.Pixel );

            e.Graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.Default;
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
