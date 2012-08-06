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
        private ImageInfo myImage;

        public ImageInfo Image
        {
            get { return myImage; }
            set
            {
                if ( myImage != null )
                    myImage.Canvas.ImageChanged -= ImageChanged;

                myImage = value;

                if ( value != null )
                {
                    value.Canvas.ImageChanged += ImageChanged;
                    myBitmap = new Bitmap( value.Width, value.Height );
                }
                else
                    myBitmap = null;

                Redraw();
            }
        }

        private Bitmap myBitmap;

        public PreviewPanel()
        {
            InitializeComponent();
        }

        private void ImageChanged( object sender, EventArgs e )
        {
            Redraw();
        }

        public void Redraw()
        {
            if ( Image != null )
            {
                Graphics g = Graphics.FromImage( myBitmap );
                g.Clear( Color.Transparent );

                foreach ( Layer layer in Image.Layers )
                    g.DrawImage( layer.Bitmap, Point.Empty );
            }

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
