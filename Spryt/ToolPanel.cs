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
    public partial class ToolPanel : UserControl
    {
        private RadioButton[] myToolBtns;
        private Tool myCurrentTool;

        public Tool CurrentTool
        {
            get { return myCurrentTool; }
            set
            {
                myCurrentTool = value;

                myToolBtns[ (int) value ].Checked = true;

                if ( CurrentToolChanged != null )
                    CurrentToolChanged( this, new CurrentToolChangedEventArgs( value ) );
            }
        }

        public event EventHandler<CurrentToolChangedEventArgs> CurrentToolChanged;

        public ToolPanel()
        {
            InitializeComponent();

            myToolBtns = new RadioButton[]
            {
                selectBtn, areaBtn, wandBtn,
                pencilBtn, fillBtn, boxBtn
            };

            for ( int i = 0; i < myToolBtns.Length; ++i )
            {
                Tool tool = (Tool) i;
                myToolBtns[ i ].Click += ( sender, e ) =>
                {
                    CurrentTool = tool;
                };
            }

            CurrentTool = Tool.Pencil;
        }
    }

    public class CurrentToolChangedEventArgs : EventArgs
    {
        public readonly Tool Tool;

        public CurrentToolChangedEventArgs( Tool tool )
        {
            Tool = tool;
        }
    }
}
