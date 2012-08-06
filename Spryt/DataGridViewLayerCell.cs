using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace Spryt
{
    class DataGridViewLayerCell : DataGridViewImageCell
    {
        protected override void Paint( System.Drawing.Graphics graphics, System.Drawing.Rectangle clipBounds, System.Drawing.Rectangle cellBounds, int rowIndex, DataGridViewElementStates elementState, object value, object formattedValue, string errorText, DataGridViewCellStyle cellStyle, DataGridViewAdvancedBorderStyle advancedBorderStyle, DataGridViewPaintParts paintParts )
        {
            base.Paint( graphics, clipBounds, cellBounds, rowIndex, elementState, null, formattedValue, errorText, cellStyle, advancedBorderStyle, paintParts & ~DataGridViewPaintParts.ContentForeground & ~DataGridViewPaintParts.SelectionBackground );

            if ( value != null )
            {
                Image image = (Image) value;
                RectangleF destRect = new RectangleF( cellBounds.Left, cellBounds.Top, 48, 48 );
                RectangleF srcRect = new RectangleF( -0.5f, -0.5f, image.Width, image.Height );
                graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.NearestNeighbor;
                graphics.DrawImage( image, destRect, srcRect, GraphicsUnit.Pixel );
            }
        }
    }
}
