using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace Spryt
{
    class ImageInfo
    {
        private string myFileName;
        private Color[] myPalette;
        private float myZoomScale;

        public String FileName
        {
            get
            {
                return myFileName;
            }
            set
            {
                myFileName = value;

                if ( Tab != null )
                    Tab.Text = myFileName;
            }
        }

        public TabPage Tab { get; private set; }
        public Canvas Canvas { get; private set; }

        public Size Size { get; private set; }
        public int Width
        {
            get { return Size.Width; }
        }
        public int Height
        {
            get { return Size.Height; }
        }

        public Color[] Palette
        {
            get { return myPalette; }
            set
            {
                myPalette = value;

                foreach ( Layer layer in Layers )
                    layer.UpdateBitmap();
            }
        }

        public float ZoomScale
        {
            get { return myZoomScale; }
            set
            {
                myZoomScale = value;
                Canvas.UpdateZoomScale();
            }
        }

        public List<Layer> Layers { get; set; }

        public ImageInfo( int width = 16, int height = 16, String name = "untitled.png" )
        {
            Size = new Size( width, height );
            FileName = name;

            Tab = new TabPage( name );
            Tab.ImageIndex = 0;
            Tab.BackColor = SystemColors.ControlDark;

            Canvas = new Canvas( this );
            Canvas.Name = "canvas";
            Tab.Controls.Add( Canvas );

            Layers = new List<Layer>();
            Layers.Add( new Layer( this ) );
        }
    }
}
