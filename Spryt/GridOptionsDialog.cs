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
    public partial class GridOptionsDialog : Form
    {
        public int MaxWidth
        {
            get { return (int) widthNUD.Maximum; }
            set
            {
                widthNUD.Maximum = value;
            }
        }

        public int MaxHeight
        {
            get { return (int) heightNUD.Maximum; }
            set
            {
                heightNUD.Maximum = value;
            }
        }

        public int GridWidth
        {
            get { return (int) widthNUD.Value; }
            set
            {
                widthNUD.Value = value;
            }
        }

        public int GridHeight
        {
            get { return (int) heightNUD.Value; }
            set
            {
                heightNUD.Value = value;
            }
        }

        public int GridHorizontalOffset
        {
            get { return (int) horzNUD.Value; }
            set
            {
                horzNUD.Value = value;
            }
        }

        public int GridVerticalOffset
        {
            get { return (int) vertNUD.Value; }
            set
            {
                vertNUD.Value = value;
            }
        }

        public Color GridColour
        {
            get
            {
                return Color.FromArgb( (int) Math.Round( ( alphaNUD.Value * 255 ) / 100 ), pickColourBtn.BackColor );
            }
            set
            {
                alphaNUD.Value = (Decimal) Math.Round( ( value.A * 100.0 ) / 255.0 );
                pickColourBtn.BackColor = Color.FromArgb( value.R, value.G, value.B );
            }
        }

        public GridOptionsDialog()
        {
            InitializeComponent();
        }

        private void pickColourBtn_Click( object sender, EventArgs e )
        {
            ColorDialog dialog = new ColorDialog();
            dialog.Color = pickColourBtn.BackColor;
            if ( dialog.ShowDialog() == DialogResult.OK )
                pickColourBtn.BackColor = dialog.Color;
        }

        private void okayBtn_Click( object sender, EventArgs e )
        {
            DialogResult = DialogResult.OK;
        }

        private void cancelBtn_Click( object sender, EventArgs e )
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void widthNUD_ValueChanged( object sender, EventArgs e )
        {
            horzNUD.Maximum = widthNUD.Value - 1;
        }

        private void heightNUD_ValueChanged( object sender, EventArgs e )
        {
            vertNUD.Maximum = heightNUD.Value - 1;
        }
    }
}
