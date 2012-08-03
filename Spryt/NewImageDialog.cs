using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Spryt
{
    public partial class NewImageDialog : Form
    {
        public Size ImageSize
        {
            get { return new Size( (int) widthNUD.Value, (int) heightNUD.Value ); }
            set
            {
                widthNUD.Value = value.Width;
                heightNUD.Value = value.Height;
            }
        }

        public NewImageDialog()
        {
            InitializeComponent();
        }

        private void createBtn_Click( object sender, EventArgs e )
        {
            DialogResult = DialogResult.OK;

            Close();
        }

        private void cancelBtn_Click( object sender, EventArgs e )
        {
            DialogResult = DialogResult.Cancel;

            Close();
        }
    }
}
