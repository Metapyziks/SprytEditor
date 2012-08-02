using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace Spryt
{
    partial class Canvas : Panel
    {
        private Control myOldParent;

        internal readonly ImageInfo Image;

        public Canvas( ImageInfo image )
        {
            Image = image;

            Size = new Size( image.Width * 8, image.Height * 8 );
            BorderStyle = BorderStyle.FixedSingle;

            InitializeComponent();
        }

        private void Centre()
        {
            if( Parent != null )
                Location = new Point( ( Parent.Width - Width ) / 2, ( Parent.Height - Height ) / 2 );
        }

        public void SetZoomScale( float scale )
        {
            Size = new Size( (int) Math.Round( Image.Width * scale ), (int) Math.Round( Image.Height * scale ) );
            Centre();
        }

        private void OnParentResize( object sender, EventArgs e )
        {
            Centre();
        }

        protected override void OnResize( EventArgs eventargs )
        {
            base.OnResize( eventargs );

            Centre();
        }

        protected override void OnParentChanged( EventArgs e )
        {
            base.OnParentChanged( e );

            if ( myOldParent != null )
                myOldParent.Resize -= OnParentResize;

            if( Parent != null )
                Parent.Resize += OnParentResize;

            Centre();

            myOldParent = Parent;
        }

        protected override void OnPaint( PaintEventArgs e )
        {
            base.OnPaint( e );

            e.Graphics.FillRectangle( new SolidBrush( Color.White ), new Rectangle( Point.Empty, Size ) );
        }
    }
}
