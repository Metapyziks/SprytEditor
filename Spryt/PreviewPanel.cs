using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Spryt
{
    partial class PreviewPanel : UserControl
    {
        public ImageInfo Image { get; private set; }

        private Bitmap myBitmap;

        public PreviewPanel()
        {
            InitializeComponent();
        }

        public void SetImage( ImageInfo image )
        {
            if ( Image != null )
                Image.Canvas.ImageChanged -= ImageChanged;

            Image = image;

            if ( Image != null )
                Image.Canvas.ImageChanged += ImageChanged;

            if ( Image != null )
                myBitmap = new Bitmap( image.Width, image.Height );
            else
                myBitmap = null;

            Redraw();
        }

        private void ImageChanged( object sender, EventArgs e )
        {
            Redraw();
        }

        public void Redraw()
        {
            Graphics g = Graphics.FromImage( myBitmap );
            g.Clear( Color.Transparent );

            if ( Image != null )
                foreach ( Layer layer in Image.Layers )
                    g.DrawImage( layer.Bitmap, Point.Empty );

            displayPanel.Invalidate();
        }

        private void displayPanel_Paint( object sender, PaintEventArgs e )
        {
            if ( Image != null )
            {
                if ( tileCheckBox.Checked )
                    e.Graphics.FillRectangle( new TextureBrush( myBitmap, System.Drawing.Drawing2D.WrapMode.Tile ), displayPanel.ClientRectangle );
                else
                    e.Graphics.DrawImage( myBitmap, new Point(
                        displayPanel.ClientRectangle.Left + ( displayPanel.ClientRectangle.Width - Image.Width ) / 2,
                        displayPanel.ClientRectangle.Top + ( displayPanel.ClientRectangle.Height - Image.Height ) / 2 ) );
            }
        }

        private void tileCheckBox_CheckStateChanged( object sender, EventArgs e )
        {
            Redraw();
        }
    }
}
