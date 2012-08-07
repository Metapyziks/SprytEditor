using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Spryt
{
    class Layer
    {
        public Pixel[ , ] Pixels { get; private set; }
        public Bitmap Bitmap { get; private set; }

        public ImageInfo Image { get; private set; }
        public String Label { get; set; }

        public Size Size { get { return Image.Size; } }
        public int Width { get { return Image.Width; } }
        public int Height { get { return Image.Height; } }

        public Layer( ImageInfo image, String label = null )
        {
            Image = image;

            if ( label == null )
            {
                int i = 1;
                while ( image.Layers.Exists( x => x.Label.ToLower().Equals( "layer " + i ) ) )
                    ++i;

                label = "layer " + i;
            }

            Label = label;

            Pixels = new Pixel[ Width, Height ];
            Bitmap = new Bitmap( Width, Height );

            for ( int x = 0; x < Width; ++x )
                for ( int y = 0; y < Height; ++y )
                    SetPixel( x, y, Pixel.Empty );
        }

        private int Wrap( int a, int b )
        {
            return a - (int) Math.Floor( (float) a / b ) * b;
        }

        public void SetPixel( int x, int y, Pixel colour )
        {
            if ( Image.TiledView )
            {
                x = Wrap( x, Image.Width );
                y = Wrap( y, Image.Height );
            }

            Pixels[ x, y ] = colour;
            DrawPixel( x, y );
        }

        public void UpdateBitmap()
        {
            for ( int x = 0; x < Width; ++x )
                for ( int y = 0; y < Height; ++y )
                    DrawPixel( x, y );
        }

        private void DrawPixel( int x, int y )
        {
            Pixel pix = Pixels[ x, y ];
            if ( pix == Pixel.Empty )
                Bitmap.SetPixel( x, y, Color.Transparent );
            else
                Bitmap.SetPixel( x, y, Image.Palette[ (int) pix & 0x7 ] );
        }
    }
}
