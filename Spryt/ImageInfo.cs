using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.IO;
using System.Drawing.Imaging;

namespace Spryt
{
    class LayerRemovedEventArgs : EventArgs
    {
        public readonly int Index;

        public LayerRemovedEventArgs( int index )
        {
            Index = index;
        }
    }

    class ImageInfo
    {
        public const UInt16 Version = 0x0001;

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

                Canvas.Invalidate();
            }
        }

        public int ColourIndex { get; set; }
        public Pixel CurrentPixel
        {
            get { return (Pixel) ( 8 | ColourIndex ); }
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

        public event EventHandler LayersChanged;

        public ImageInfo( ToolPanel toolInfoPanel, int width = 16, int height = 16, String name = "untitled" )
        {
            Size = new Size( width, height );
            FileName = name;

            Tab = new TabPage( name );
            Tab.ImageIndex = 0;
            Tab.BackColor = SystemColors.ControlDark;

            Canvas = new Canvas( this, toolInfoPanel );
            Canvas.Name = "canvas";
            Tab.Controls.Add( Canvas );

            Layers = new List<Layer>();
            Layers.Add( new Layer( this ) );
        }


        public ImageInfo( ToolPanel toolInfoPanel, String filePath )
        {
            FileName = Path.GetFileNameWithoutExtension( filePath );

            Load( filePath );

            Tab = new TabPage( FileName );
            Tab.ImageIndex = 0;
            Tab.BackColor = SystemColors.ControlDark;

            Canvas = new Canvas( this, toolInfoPanel );
            Canvas.Name = "canvas";
            Tab.Controls.Add( Canvas );
        }

        public bool InBounds( int x, int y )
        {
            return x >= 0 && y >= 0 && x < Width && y < Height;
        }

        public void AddLayer( int index = -1, string label = null )
        {
            if ( index == -1 )
                index = Layers.Count;

            Layers.Insert( index, new Layer( this, label ) );

            if( LayersChanged != null )
                LayersChanged( this, new EventArgs() );
        }

        public void RemoveLayer( int index )
        {
            Layers.RemoveAt( index );

            if ( Layers.Count == 0 )
                Layers.Add( new Layer( this ) );

            if ( LayersChanged != null )
                LayersChanged( this, new EventArgs() );

            Canvas.SendImageChange();
        }

        public void SwapLayers( int indexA, int indexB )
        {
            Layer a = Layers[ indexA ];
            Layer b = Layers[ indexB ];

            Layers.RemoveAt( indexA );
            Layers.Insert( indexA, b );

            Layers.RemoveAt( indexB );
            Layers.Insert( indexB, a );

            if ( LayersChanged != null )
                LayersChanged( this, new EventArgs() );

            Canvas.SendImageChange();
        }

        public void Save( String filePath )
        {
            Bitmap bmp = new Bitmap( Width, Height );
            Graphics g = Graphics.FromImage( bmp );

            g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.NearestNeighbor;

            foreach ( Layer layer in Layers )
                g.DrawImage( layer.Bitmap, Point.Empty );

            MemoryStream stream = new MemoryStream();
            bmp.Save( stream, ImageFormat.Png );
            long pos = stream.Position;
            Save( stream );

            BinaryWriter writer = new BinaryWriter( stream );
            writer.Write( "SPRY".ToCharArray() );
            writer.Write( pos );

            stream.Position = 0;
            byte[] buffer = new byte[ stream.Length ];
            stream.Read( buffer, 0, (int) stream.Length );
            stream.Close();

            File.WriteAllBytes( filePath, buffer );
        }

        private void Save( Stream stream )
        {
            BinaryWriter writer = new BinaryWriter( stream );
            writer.Write( Version );

            writer.Write( Width );
            writer.Write( Height );

            writer.Write( Palette.Length );
            for ( int i = 0; i < Palette.Length; ++i )
            {
                writer.Write( (byte) Palette[ i ].R );
                writer.Write( (byte) Palette[ i ].G );
                writer.Write( (byte) Palette[ i ].B );
            }

            writer.Write( Layers.Count );
            for ( int i = 0; i < Layers.Count; ++i )
            {
                writer.Write( Layers[ i ].Label );
                Pixel[ , ] data = Layers[ i ].Pixels;
                for ( int x = 0; x < Width; ++x )
                    for ( int y = 0; y < Height; ++y )
                        writer.Write( (byte) data[ x, y ] );
            }
        }

        private void Load( String filePath )
        {
            using ( FileStream stream = new FileStream( filePath, FileMode.Open, FileAccess.Read ) )
            {
                BinaryReader reader = new BinaryReader( stream );

                if ( stream.Length > 12 )
                {
                    stream.Seek( -12, SeekOrigin.End );
                    if ( new String( reader.ReadChars( 4 ) ) == "SPRY" )
                    {
                        stream.Seek( reader.ReadInt64(), SeekOrigin.Begin );
                        Load( stream );
                        return;
                    }
                }

                stream.Seek( 0, SeekOrigin.Begin );

                Bitmap bmp = new Bitmap( stream );
                Size = new Size( bmp.Width, bmp.Height );

                Dictionary<Color, int> colours = new Dictionary<Color, int>();

                for ( int x = 0; x < bmp.Width; ++x )
                {
                    for ( int y = 0; y < bmp.Height; ++y )
                    {
                        Color clr = bmp.GetPixel( x, y );
                        if ( clr.A < 128 )
                            continue;
                        else
                            clr = Color.FromArgb( clr.R, clr.G, clr.B );

                        if ( !colours.ContainsKey( clr ) )
                            colours.Add( clr, 1 );
                        else
                            ++colours[ clr ];
                    }
                }

                List<Color> sorted = colours.Select( x => x.Key ).OrderByDescending( x => colours[ x ] ).ToList();

                while ( sorted.Count < 8 )
                    sorted.Add( Color.Black );

                while ( sorted.Count > 8 )
                    sorted.RemoveAt( sorted.Count - 1 );

                if ( sorted.Count != 8 )
                {
                    MessageBox.Show( "Too many colours (" + sorted.Count + ")! Colour merging will be implemented later.", "Import Image", MessageBoxButtons.OK, MessageBoxIcon.Error );
                    return;
                }

                myPalette = sorted.ToArray();

                Layers = new List<Layer>();
                AddLayer();
                for ( int x = 0; x < bmp.Width; ++x )
                {
                    for ( int y = 0; y < bmp.Height; ++y )
                    {
                        Color clr = bmp.GetPixel( x, y );
                        Pixel pix;
                        if ( clr.A < 128 )
                            pix = Pixel.Empty;
                        else
                        {
                            clr = Color.FromArgb( clr.R, clr.G, clr.B );
                            pix = (Pixel) ( 8 | sorted.IndexOf( clr ) );
                        }

                        Layers[ 0 ].SetPixel( x, y, pix );
                    }
                }
            }
        }

        private void Load( Stream stream )
        {
            BinaryReader reader = new BinaryReader( stream );
            ushort version = reader.ReadUInt16();

            Size = new Size( reader.ReadInt32(), reader.ReadInt32() );

            int paletteLength = reader.ReadInt32();
            Color[] palette = new Color[ paletteLength ];

            for ( int i = 0; i < paletteLength; ++i )
                palette[ i ] = Color.FromArgb( reader.ReadByte(), reader.ReadByte(), reader.ReadByte() );

            myPalette = palette;

            int layerCount = reader.ReadInt32();
            Layers = new List<Layer>();

            for ( int i = 0; i < layerCount; ++i )
            {
                Layers.Add( new Layer( this, reader.ReadString() ) );
                for ( int x = 0; x < Width; ++x )
                    for ( int y = 0; y < Height; ++y )
                        Layers[ i ].SetPixel( x, y, (Pixel) reader.ReadByte() );
            }
        }
    }
}
