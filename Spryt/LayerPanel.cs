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
    partial class LayerPanel : UserControl
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

                layerGrid.Rows.Clear();

                if ( value != null )
                {
                    for ( int i = 0; i < value.Layers.Count; ++i )
                    {
                        layerGrid.Rows.Add( null, "layer " + ( i + 1 ) );
                        layerGrid.Rows[ i ].Height = 64;
                        layerGrid[ 0, i ] = new DataGridViewLayerCell() { Value = value.Layers[ i ].Bitmap };
                    }
                }

                ImageChanged();

                if ( value != null )
                    value.Canvas.ImageChanged += ImageChanged;

                Invalidate();
            }
        }

        public LayerPanel()
        {
            DoubleBuffered = true;

            InitializeComponent();
        }

        private void ImageChanged( object sender = null, EventArgs e = null )
        {
            layerGrid.Invalidate( true );
        }

        private void moveUpBtn_Click( object sender, EventArgs e )
        {

        }

        private void moveDownBtn_Click( object sender, EventArgs e )
        {

        }

        private void addBtn_Click( object sender, EventArgs e )
        {

        }

        private void deleteBtn_Click( object sender, EventArgs e )
        {

        }
    }
}
