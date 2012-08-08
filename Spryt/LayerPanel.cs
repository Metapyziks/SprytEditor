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

        public int SelectedIndex
        {
            get { return myImage.Canvas.CurrentLayerIndex; }
            set
            {
                myImage.Canvas.CurrentLayerIndex = value;
                if ( !layerGrid.Rows[ layerGrid.Rows.Count - value - 1 ].Selected )
                {
                    layerGrid.Rows[ layerGrid.Rows.Count - value - 1 ].Selected = true;
                    layerGrid.Invalidate();
                }
            }
        }

        public ImageInfo Image
        {
            get { return myImage; }
            set
            {
                if ( myImage != null )
                {
                    myImage.Canvas.ImageChanged -= ImageChanged;
                    myImage.LayersChanged -= LayersChanged;
                }

                myImage = value;

                LayersChanged();

                if ( value != null )
                {
                    value.Canvas.ImageChanged += ImageChanged;
                    value.LayersChanged += LayersChanged;
                }
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

        private void LayersChanged( object sender = null, EventArgs e = null )
        {
            layerGrid.Rows.Clear();

            if ( Image != null )
            {
                for ( int i = 0; i < Image.Layers.Count; ++i )
                {
                    layerGrid.Rows.Insert( 0, null, Image.Layers[ i ].Label );
                    layerGrid.Rows[ 0 ].Height = 48;
                    layerGrid[ 0, 0 ] = new DataGridViewLayerCell() { Value = Image.Layers[ i ].Bitmap };
                }
            }

            ImageChanged();
        }

        private void moveUpBtn_Click( object sender, EventArgs e )
        {
            if ( Image != null )
            {
                if ( SelectedIndex < Image.Layers.Count - 1 )
                {
                    int index = SelectedIndex + 1;
                    Image.SwapLayers( SelectedIndex, index );
                    SelectedIndex = index;
                }
            }
        }

        private void moveDownBtn_Click( object sender, EventArgs e )
        {
            if ( Image != null )
            {
                if ( SelectedIndex > 0 )
                {
                    int index = SelectedIndex - 1;
                    Image.SwapLayers( SelectedIndex, index );
                    SelectedIndex = index;
                }
            }
        }

        private void addBtn_Click( object sender, EventArgs e )
        {
            if ( Image != null )
            {
                int index = SelectedIndex + 1;
                Image.AddLayer( index );
                SelectedIndex = index;
            }
        }

        private void deleteBtn_Click( object sender, EventArgs e )
        {
            if ( Image != null )
            {
                int index = SelectedIndex;
                Image.RemoveLayer( index );
                SelectedIndex = Math.Min( index, Image.Layers.Count - 1 );
            }
        }

        private void layerGrid_SelectionChanged( object sender, EventArgs e )
        {
            if( layerGrid.SelectedRows.Count > 0 )
                SelectedIndex = layerGrid.Rows.Count - layerGrid.SelectedRows[ 0 ].Index - 1;
        }

        private void layerGrid_CellValueChanged( object sender, DataGridViewCellEventArgs e )
        {
            if ( e.ColumnIndex == 1 && Image != null )
            {
                Image.Layers[ Image.Layers.Count - e.RowIndex - 1 ].Label = layerGrid[ 1, e.RowIndex ].Value.ToString();
                Image.PushState();
            }
        }
    }
}
