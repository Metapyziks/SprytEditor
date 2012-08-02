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
    public partial class ColourPalettePanel : UserControl
    {
        private static readonly int[] stDefaultPalette = new int[]
        {
            0x000000, 0x242424, 0x484848, 0x6d6d6d, 0x919191, 0xb6b6b6, 0xdadada, 0xffffff
        };

        private Button[] myColourBtns;
        private Button[] myPickerBtns;

        private int mySelectedIndex;

        public Color[] Palette { get; private set; }
        public int SelectedIndex
        {
            get { return mySelectedIndex; }
            set
            {
                mySelectedIndex = value;

                for ( int i = 0; i < 8; ++i )
                {
                    if ( i == value )
                        myColourBtns[ i ].FlatAppearance.BorderSize = 3;
                    else
                        myColourBtns[ i ].FlatAppearance.BorderSize = 1;
                }
            }
        }

        public Color SelectedColour
        {
            get { return Palette[ mySelectedIndex ]; }
        }

        public ColourPalettePanel()
        {
            Palette = new Color[ 8 ];

            InitializeComponent();

            myColourBtns = new Button[ 8 ];
            myPickerBtns = new Button[ 8 ];
            for ( int i = 0; i < 8; ++i )
            {
                int index = i;

                Button clrBtn = myColourBtns[ i ] = new Button();
                tableLayoutPanel3.Controls.Add( clrBtn, 0, i );

                clrBtn.Dock = System.Windows.Forms.DockStyle.Fill;
                clrBtn.Name = "colour" + i;
                clrBtn.Size = new System.Drawing.Size( 100, 26 );
                clrBtn.TabIndex = 1;
                clrBtn.UseVisualStyleBackColor = false;
                clrBtn.FlatStyle = FlatStyle.Flat;
                clrBtn.FlatAppearance.BorderSize = 1;

                clrBtn.Click += ( sender, args ) =>
                {
                    SelectedIndex = index;
                };

                Button pickBtn = myPickerBtns[ i ] = new Button();
                tableLayoutPanel3.Controls.Add( pickBtn, 1, i );

                pickBtn.Dock = System.Windows.Forms.DockStyle.Fill;
                pickBtn.Image = global::Spryt.Properties.Resources.color_wheel;
                pickBtn.Name = "picker1";
                pickBtn.Size = new System.Drawing.Size( 26, 26 );
                pickBtn.TabIndex = 0;
                pickBtn.UseVisualStyleBackColor = true;

                pickBtn.Click += ( sender, args ) =>
                {
                    ColorDialog dialog = new ColorDialog();
                    dialog.Color = clrBtn.BackColor;
                    DialogResult res = dialog.ShowDialog();

                    if ( res == DialogResult.OK )
                        SetColour( index, dialog.Color );
                };

                SetColour( i, Color.FromArgb( ( 0xff << 24 ) | stDefaultPalette[ i ] ) );
            }

            SelectedIndex = 0;
        }

        public void SetColour( int index, Color colour )
        {
            Palette[ index ] = colour;

            int r = ( colour.R + 128 ) % 256;
            int g = ( colour.G + 128 ) % 256;
            int b = ( colour.B + 128 ) % 256;

            myColourBtns[ index ].BackColor = colour;
            myColourBtns[ index ].ForeColor = Color.FromArgb( r, g, b );

            myColourBtns[ index ].Text = String.Format( "#{0:X2}{1:X2}{2:X2}", colour.R, colour.G, colour.B );
        }
    }
}
