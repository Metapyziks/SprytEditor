using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Spryt
{
    public partial class MainForm : Form
    {
        private static readonly float[] stZoomLevels = new float[]
        {
            0.5f, 1.0f, 2.0f, 4.0f, 8.0f, 16.0f, 32.0f, 64.0f
        };

        private int myZoomLevel = 0;
        private List<ImageInfo> myCurrentImages;

        private ToolStripMenuItem[] myToolMenuButtons;

        private ImageInfo CurrentImage
        {
            get
            {
                if ( canvasTabs.TabCount == 0 )
                    return null;

                return myCurrentImages[ canvasTabs.SelectedIndex ];
            }
        }

        public float ZoomScale
        {
            get
            {
                return stZoomLevels[ myZoomLevel ];
            }
            set
            {
                for ( myZoomLevel = 0; myZoomLevel < stZoomLevels.Length - 1; ++myZoomLevel )
                    if ( stZoomLevels[ myZoomLevel ] >= value )
                        break;

                foreach ( ToolStripMenuItem item in zoomToolStripMenuItem.DropDownItems )
                {
                    bool check = float.Parse( item.Text.Substring( 0, item.Text.Length - 1 ) ) == ZoomScale;
                    item.Checked = check;
                }

                if( CurrentImage != null )
                    CurrentImage.ZoomScale = ZoomScale;
            }
        }

        public MainForm()
        {
            myCurrentImages = new List<ImageInfo>();

            InitializeComponent();

            foreach ( float zl in stZoomLevels )
            {
                ToolStripMenuItem item = (ToolStripMenuItem) zoomToolStripMenuItem.DropDownItems.Add( zl.ToString( "#.0" ) + "x" );
                item.Click += ( sender, e ) =>
                {
                    if ( !item.Checked )
                    {
                        zoomToolStripMenuItem.Text = "Zoom (" + item.Text + ")";
                        ZoomScale = float.Parse( item.Text.Substring( 0, item.Text.Length - 1 ) );
                    }
                };
            }

            myToolMenuButtons = new ToolStripMenuItem[]
            {
                selectToolStripMenuItem, areaToolStripMenuItem, magicWandToolStripMenuItem,
                pencilToolStripMenuItem, fillToolStripMenuItem, boxToolStripMenuItem
            };

            for ( int i = 0; i < myToolMenuButtons.Length; ++i )
            {
                Tool tool = (Tool) i;
                myToolMenuButtons[ i ].Click += ( sender, e ) =>
                {
                    toolPanel.CurrentTool = tool;
                };
            }
        }

        protected override void OnLoad( EventArgs e )
        {
            base.OnLoad( e );

            if ( !Directory.Exists( "palettes" ) )
                Directory.CreateDirectory( "palettes" );

            ZoomScale = 1.0f;
        }

        private ImageInfo CreateNewImage( int width = 16, int height = 16, string name = "untitled" )
        {
            ImageInfo newImage = new ImageInfo( toolPanel, width, height, name );
            newImage.Palette = (Color[]) colourPalettePanel.Palette.Clone();
            newImage.ColourIndex = colourPalettePanel.SelectedIndex;
            newImage.ZoomScale = ZoomScale;
            canvasTabs.TabPages.Add( newImage.Tab );
            myCurrentImages.Add( newImage );
            ChangeImage( newImage );
            return newImage;
        }

        private void ChangeImage( ImageInfo image )
        {
            canvasTabs.SelectedIndex = myCurrentImages.IndexOf( image );
            canvasTabs_SelectedIndexChanged( null, null );
        }

        protected override void OnMouseWheel( MouseEventArgs e )
        {
            if ( !ModifierKeys.HasFlag( Keys.Control ) )
                colourPalettePanel.SelectedIndex -= Math.Sign( e.Delta );
            else
            {
                myZoomLevel += Math.Sign( e.Delta );

                if ( myZoomLevel < 0 )
                    myZoomLevel = 0;
                else if ( myZoomLevel >= stZoomLevels.Length )
                    myZoomLevel = stZoomLevels.Length - 1;

                ZoomScale = stZoomLevels[ myZoomLevel ];
            }

            base.OnMouseWheel( e );
        }

        private void newToolStripMenuItem_Click( object sender, EventArgs e )
        {
            NewImageDialog dialog = new NewImageDialog();
            if ( dialog.ShowDialog() == DialogResult.OK )
                CreateNewImage( dialog.ImageSize.Width, dialog.ImageSize.Height );
        }

        private void fileToolStripMenuItem_DropDownOpening( object sender, EventArgs e )
        {
            saveAsToolStripMenuItem.Enabled = saveAllToolStripMenuItem.Enabled =
                saveToolStripMenuItem.Enabled = exportpngToolStripMenuItem.Enabled =
                closeAllToolStripMenuItem.Enabled = closeToolStripMenuItem.Enabled =
                myCurrentImages.Count > 0;

            recentFilesToolStripMenuItem.Enabled = recentFilesToolStripMenuItem.DropDownItems.Count > 0;
        }

        private void colourPalettePanel_PaletteChanged( object sender, PaletteChangedEventArgs e )
        {
            if( CurrentImage != null )
                CurrentImage.Palette = (Color[]) e.Palette.Clone();
        }

        private void canvasTabs_SelectedIndexChanged( object sender, EventArgs e )
        {
            previewPanel.Image = CurrentImage;
            layerPanel.Image = CurrentImage;

            previewPanel.Enabled = layerPanel.Enabled = CurrentImage != null;

            if ( CurrentImage != null )
            {
                colourPalettePanel.SetPalette( (Color[]) CurrentImage.Palette.Clone() );
                ZoomScale = CurrentImage.ZoomScale;
                colourPalettePanel.SelectedIndex = CurrentImage.ColourIndex;
            }
        }

        private void canvasTabs_TabClosed( object sender, ClosedEventArgs e )
        {
            myCurrentImages.RemoveAt( e.TabIndex );
            canvasTabs_SelectedIndexChanged( sender, e );
        }

        private void colourPalettePanel_SelectedColourChanged( object sender, SelectedColourChangedEventArgs e )
        {
            if( CurrentImage != null )
                CurrentImage.ColourIndex = colourPalettePanel.SelectedIndex;
        }

        private void importpngToolStripMenuItem_Click( object sender, EventArgs e )
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.DefaultExt = "png";
            dialog.Filter = "PNG Image (*.png)|*.png";
            dialog.Title = "Import Image";
            if ( dialog.ShowDialog() == DialogResult.OK )
            {
                Bitmap bmp = new Bitmap( dialog.FileName );
                String trimmedName = Path.GetFileNameWithoutExtension( dialog.FileName );
                ImageInfo image = CreateNewImage( bmp.Width, bmp.Height, trimmedName );

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

                image.Palette = sorted.ToArray();

                if ( CurrentImage == image )
                    colourPalettePanel.SetPalette( sorted.ToArray() );

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

                        image.Layers[ 0 ].SetPixel( x, y, pix );
                    }
                }

                ChangeImage( image );
            }
        }

        private void exportpngToolStripMenuItem_Click( object sender, EventArgs e )
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.DefaultExt = "png";
            dialog.Filter = "PNG Image (*.png)|*.png";
            dialog.Title = "Export Image";
            dialog.FileName = CurrentImage.FileName + ".png";
            dialog.OverwritePrompt = true;
            if ( dialog.ShowDialog() == DialogResult.OK )
            {
                Bitmap bmp = new Bitmap( CurrentImage.Width, CurrentImage.Height );
                Graphics g = Graphics.FromImage( bmp );

                g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.NearestNeighbor;

                foreach ( Layer layer in CurrentImage.Layers )
                    g.DrawImage( layer.Bitmap, Point.Empty );

                bmp.Save( dialog.FileName, System.Drawing.Imaging.ImageFormat.Png );
            }
        }

        private void toolPanel_CurrentToolChanged( object sender, CurrentToolChangedEventArgs e )
        {
            for ( int i = 0; i < myToolMenuButtons.Length; ++i )
                myToolMenuButtons[ i ].Checked = i == (int) e.Tool;
        }
    }
}
