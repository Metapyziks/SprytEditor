using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

/// <summary>
/// A tab control that can be used to close tabs with a custom drawn button.
/// From: http://www.primordialcode.com/blog/post/windows-forms-closeable-tabcontrol
/// </summary>

namespace Spryt
{
    public class ClosingEventArgs
    {
        private readonly int _nTabIndex = -1;
        public ClosingEventArgs( int nTabIndex )
        {
            _nTabIndex = nTabIndex;
            Cancel = false;
        }
        public bool Cancel { get; set; }
        /// <summary>
        /// Get/Set the tab index value where the close button is clicked
        /// </summary>
        public int TabIndex
        {
            get
            {
                return _nTabIndex;
            }
        }
    }
    public class ClosedEventArgs : EventArgs
    {
        private readonly TabPage _tab;
        public ClosedEventArgs( TabPage tab )
        {
            _tab = tab;
        }
        /// <summary>
        /// Get/Set the tab index value where the close button is clicked
        /// </summary>
        public TabPage Tab
        {
            get
            {
                return _tab;
            }
        }
    }

    public class CanvasTabControl : System.Windows.Forms.TabControl
    {
        public CanvasTabControl()
        {
            SetStyle( ControlStyles.DoubleBuffer, true );
            TabStop = false;
            DrawMode = TabDrawMode.OwnerDrawFixed;
            ItemSize = new Size( ItemSize.Width, 24 );
            // used to expand the tab header, find a better way
            Padding = new Point( 16, 0 );
        }
        protected override void Dispose( bool disposing )
        {
            if ( disposing )
            {
                _stringFormat.Dispose();
            }
            base.Dispose( disposing );
        }
        public delegate void TabClosedDelegate( object sender, ClosedEventArgs e );
        public delegate void TabClosingDelegate( object sender, ClosingEventArgs e );
        public event TabClosedDelegate TabClosed;
        public event TabClosingDelegate TabClosing;
        private int _buttonWidth = 16;
        [DefaultValue( 16 ), Category( "Action Buttons" )]
        public int ButtonWidth
        {
            get { return _buttonWidth; }
            set { _buttonWidth = value; }
        }
        private int _crossOffset = 3;
        [DefaultValue( 3 ), Category( "Action Buttons" )]
        public int CrossOffset
        {
            get { return _crossOffset; }
            set { _crossOffset = value; }
        }
        private readonly StringFormat _stringFormat = new StringFormat
        {
            Alignment = StringAlignment.Near,
            LineAlignment = StringAlignment.Center
        };
        protected override void OnDrawItem( DrawItemEventArgs e )
        {
            if ( e.Bounds != RectangleF.Empty )
            {
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                for ( int nIndex = 0; nIndex < TabCount; nIndex++ )
                {
                    Rectangle tabArea = GetTabRect( nIndex );
                    Rectangle closeBtnRect = GetCloseBtnRect( tabArea );
                    DrawCross( e, closeBtnRect );
                    string str = TabPages[ nIndex ].Text;
                    tabArea = new Rectangle( tabArea.Left + 8, tabArea.Top, tabArea.Width - 16, tabArea.Height );
                    e.Graphics.DrawString( str, Font, new SolidBrush( TabPages[ nIndex ].ForeColor ), tabArea, _stringFormat );
                }
            }
        }
        private void DrawCross( DrawItemEventArgs e, Rectangle btnRect )
        {
            e.Graphics.DrawImage( Spryt.Properties.Resources.cross, btnRect );
        }

        private Rectangle GetCloseBtnRect( Rectangle tabRect )
        {
            Rectangle rect = new Rectangle( tabRect.X + tabRect.Width - ButtonWidth - 4, ( tabRect.Height - ButtonWidth ) / 2 + 2, ButtonWidth, ButtonWidth );
            return rect;
        }
        protected override void OnMouseDown( MouseEventArgs e )
        {
            if ( !DesignMode )
            {
                Rectangle rect = GetTabRect( SelectedIndex );
                rect = GetCloseBtnRect( rect );
                Point pt = new Point( e.X, e.Y );
                if ( rect.Contains( pt ) )
                {
                    CloseTab( SelectedTab );
                }
            }
        }
        public void CloseTab( int tabindex )
        {
            CloseTab( TabPages[ tabindex ] );
        }
        public void CloseTab( TabPage tp )
        {
            ClosingEventArgs args = new ClosingEventArgs( TabPages.IndexOf( tp ) );
            OnTabClosing( args );
            //Remove the tab and fir the event tot he client
            if ( !args.Cancel )
            {
                // close and remove the tab, dispose it too
                TabPages.Remove( tp );
                OnTabClosed( new ClosedEventArgs( tp ) );
                tp.Dispose();
            }
        }
        protected void OnTabClosed( ClosedEventArgs e )
        {
            if ( TabClosed != null )
            {
                TabClosed( this, e );
            }
        }
        protected void OnTabClosing( ClosingEventArgs e )
        {
            if ( TabClosing != null )
                TabClosing( this, e );
        }
    }
}
