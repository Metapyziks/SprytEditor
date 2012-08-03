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
                    if ( check != item.Checked )
                        item.Checked = check;

                    item.Enabled = !item.Checked;
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
                item.CheckOnClick = true;
                item.CheckedChanged += xToolStripMenuItem_CheckedChanged;
            }
        }

        protected override void OnLoad( EventArgs e )
        {
            base.OnLoad( e );

            if ( !Directory.Exists( "palettes" ) )
                Directory.CreateDirectory( "palettes" );

            ZoomScale = 8.0f;

            CreateNew();
        }

        private ImageInfo CreateNew( int width = 16, int height = 16, string name = "untitled.png" )
        {
            ImageInfo newImage = new ImageInfo( width, height, name );
            newImage.Palette = (Color[]) colourPalettePanel.Palette.Clone();
            newImage.ZoomScale = ZoomScale;
            canvasTabs.TabPages.Add( newImage.Tab );
            myCurrentImages.Add( newImage );
            return newImage;
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

        private void xToolStripMenuItem_CheckedChanged( object sender, EventArgs e )
        {
            ToolStripMenuItem item = (ToolStripMenuItem) sender;

            if ( item.Checked )
            {
                zoomToolStripMenuItem.Text = "Zoom (" + item.Text + ")";
                ZoomScale = float.Parse( item.Text.Substring( 0, item.Text.Length - 1 ) );
            }
        }

        private void newToolStripMenuItem_Click( object sender, EventArgs e )
        {
            CreateNew();
        }

        private void fileToolStripMenuItem_DropDownOpening( object sender, EventArgs e )
        {

        }

        private void colourPalettePanel_PaletteChanged( object sender, PaletteChangedEventArgs e )
        {
            if( CurrentImage != null )
                CurrentImage.Palette = (Color[]) e.Palette.Clone();
        }

        private void canvasTabs_SelectedIndexChanged( object sender, EventArgs e )
        {
            if ( CurrentImage != null )
            {
                colourPalettePanel.SetPalette( (Color[]) CurrentImage.Palette.Clone() );
                ZoomScale = CurrentImage.ZoomScale;
            }
        }
    }
}
