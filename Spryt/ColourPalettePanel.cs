using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.IO;

namespace Spryt
{
    public partial class ColourPalettePanel : UserControl
    {
        private static readonly int[] stDefaultPalette = new int[]
        {
            0x000000, 0x242424, 0x484848, 0x6d6d6d, 0x919191, 0xb6b6b6, 0xdadada, 0xffffff
        };

        private RadioButton[] myColourBtns;
        private Button[] myPickerBtns;

        private int mySelectedIndex;

        public Color[] Palette { get; private set; }
        public int SelectedIndex
        {
            get { return mySelectedIndex; }
            set
            {
                value -= (int) Math.Floor( (float) value / 8 ) * 8;

                mySelectedIndex = value;
                selectedColourPanel.BackColor = Palette[ value ];

                if ( !myColourBtns[ value ].Checked )
                    myColourBtns[ value ].Checked = true;

                if ( SelectedColourChanged != null )
                    SelectedColourChanged( this, new SelectedColourChangedEventArgs( this ) );
            }
        }

        public Color SelectedColour
        {
            get { return Palette[ mySelectedIndex ]; }
        }

        private Color myOriginalColour;
        private Color myNewColour;

        public event EventHandler<PaletteChangedEventArgs> PaletteChanged;
        public event EventHandler<SelectedColourChangedEventArgs> SelectedColourChanged;

        public ColourPalettePanel()
        {
            Palette = new Color[ 8 ];

            InitializeComponent();

            myColourBtns = new RadioButton[ 8 ];
            myPickerBtns = new Button[ 8 ];
            for ( int i = 0; i < 8; ++i )
            {
                int index = i;

                RadioButton clrBtn = myColourBtns[ i ] = new RadioButton();
                tableLayoutPanel3.Controls.Add( clrBtn, 0, i );

                clrBtn.Dock = System.Windows.Forms.DockStyle.Fill;
                clrBtn.Name = "colour" + i;
                clrBtn.Appearance = Appearance.Button;
                clrBtn.Size = new System.Drawing.Size( 100, 26 );
                clrBtn.Font = new Font( new FontFamily( "consolas" ), 10.0f );
                clrBtn.TabIndex = 1;
                clrBtn.UseVisualStyleBackColor = false;
                clrBtn.ContextMenuStrip = editHexStrip;

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
                    {
                        SetColour( index, dialog.Color );

                        if ( PaletteChanged != null )
                            PaletteChanged( this, new PaletteChangedEventArgs( Palette ) );
                    
                        if( SelectedIndex == index && SelectedColourChanged != null )
                            SelectedColourChanged( this, new SelectedColourChangedEventArgs( this ) );
                    }
                };

                int r = ( stDefaultPalette[ i ] >> 16 ) & 0xff;
                int g = ( stDefaultPalette[ i ] >> 08 ) & 0xff;
                int b = ( stDefaultPalette[ i ] >> 00 ) & 0xff;

                SetColour( i, Color.FromArgb( r, g, b ) );
            }

            SelectedIndex = 0;
        }

        public void SetPalette( Color[] palette )
        {
            for ( int i = 0; i < 8; ++i )
                SetColour( i, palette[ i ] );

            if ( PaletteChanged != null )
                PaletteChanged( this, new PaletteChangedEventArgs( Palette ) );
        }

        private void SetColour( int index, Color colour )
        {
            Palette[ index ] = colour;

            int r = ( colour.R + 128 ) % 256;
            int g = ( colour.G + 128 ) % 256;
            int b = ( colour.B + 128 ) % 256;

            myColourBtns[ index ].BackColor = colour;
            myColourBtns[ index ].ForeColor = Color.FromArgb( r, g, b );

            myColourBtns[ index ].Text = String.Format( "#{0:X2}{1:X2}{2:X2}", colour.R, colour.G, colour.B );

            if ( index == SelectedIndex )
                selectedColourPanel.BackColor = Palette[ index ];
        }

        private void presetComboBox_DropDown( object sender, EventArgs e )
        {
            presetComboBox.Items.Clear();

            if ( Directory.Exists( "palettes" ) )
                foreach ( String file in Directory.EnumerateFiles( "palettes/" ) )
                    if ( file.EndsWith( ".spf" ) )
                        presetComboBox.Items.Add( file.Substring( 9, file.Length - 13 ) );
        }

        private void saveBtn_Click( object sender, EventArgs e )
        {
            String filePath = "palettes/" + presetComboBox.Text + ".spf";

            if ( File.Exists( filePath ) && MessageBox.Show( "Overwrite existing palette?",
                "Save Palette", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation ) == DialogResult.No )
                return;

            using ( FileStream stream = new FileStream( filePath, FileMode.Create, FileAccess.Write ) )
            {
                using ( StreamWriter writer = new StreamWriter( stream ) )
                {
                    for ( int i = 0; i < 8; ++i )
                    {
                        Color colour = Palette[ i ];
                        writer.WriteLine( "#{0:X2}{1:X2}{2:X2}", colour.R, colour.G, colour.B );
                    }
                }
            }
        }

        private void loadBtn_Click( object sender, EventArgs e )
        {
            String filePath = "palettes/" + presetComboBox.Text + ".spf";

            if ( !File.Exists( filePath ) )
            {
                MessageBox.Show( "Palette file not found.", "Load Palette", MessageBoxButtons.OK, MessageBoxIcon.Error );
                return;
            }

            using ( FileStream stream = new FileStream( filePath, FileMode.Open, FileAccess.Read ) )
            {
                using ( StreamReader reader = new StreamReader( stream ) )
                {
                    for ( int i = 0; i < 8; ++i )
                    {
                        String line;
                        do
                        {
                            if ( reader.EndOfStream )
                            {
                                MessageBox.Show( "Palette file corrupted.", "Load Palette", MessageBoxButtons.OK, MessageBoxIcon.Error );
                                return;
                            }

                            line = reader.ReadLine();
                        }
                        while ( line.Length != 7 || !Regex.IsMatch( line, "^#[0-9a-fA-F][0-9a-fA-F][0-9a-fA-F][0-9a-fA-F][0-9a-fA-F][0-9a-fA-F]$" ) );

                        int r = int.Parse( line.Substring( 1, 2 ), System.Globalization.NumberStyles.HexNumber );
                        int g = int.Parse( line.Substring( 3, 2 ), System.Globalization.NumberStyles.HexNumber );
                        int b = int.Parse( line.Substring( 5, 2 ), System.Globalization.NumberStyles.HexNumber );

                        SetColour( i, Color.FromArgb( r, g, b ) );
                    }
                }
            }

            if ( PaletteChanged != null )
                PaletteChanged( this, new PaletteChangedEventArgs( Palette ) );
        }

        private void deleteBtn_Click( object sender, EventArgs e )
        {
            String filePath = "palettes/" + presetComboBox.Text + ".spf";

            if ( !File.Exists( filePath ) || MessageBox.Show( "Are you sure you want to delete this palette?",
                "Delete Palette", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation ) == DialogResult.No )
                return;

            File.Delete( filePath );

            presetComboBox.Text = null;
        }

        private void presetComboBox_TextUpdate( object sender, EventArgs e )
        {
            loadBtn.Enabled = saveBtn.Enabled = deleteBtn.Enabled = presetComboBox.Text != null && presetComboBox.Text.Length > 0;
        }

        private void editHexStrip_Opened( object sender, EventArgs e )
        {
            RadioButton btn = editHexStrip.SourceControl as RadioButton;
            int index = Array.IndexOf( myColourBtns, btn );
            myOriginalColour = Palette[ index ];
            editHexTxt.Text = btn.Text.Substring( 1 );
        }

        private void editHexStrip_Closed( object sender, ToolStripDropDownClosedEventArgs e )
        {
            int index = Array.IndexOf( myColourBtns, ( editHexStrip.SourceControl as RadioButton ) );
            myNewColour = Palette[ index ];
            SetColour( index, myOriginalColour );
        }

        private void editHexTxt_TextChanged( object sender, EventArgs e )
        {
            int index = Array.IndexOf( myColourBtns, ( editHexStrip.SourceControl as RadioButton ) );
            String text = editHexTxt.Text;

            if ( System.Text.RegularExpressions.Regex.IsMatch( editHexTxt.Text, "^[0-9A-F]*$" ) )
            {
                int r = 0, g = 0, b = 0;

                if( text.Length == 1 )
                    r = int.Parse( editHexTxt.Text.Substring( 0, 1 ), System.Globalization.NumberStyles.HexNumber ) << 4;
                else if ( text.Length >= 2 )
                    r = int.Parse( editHexTxt.Text.Substring( 0, 2 ), System.Globalization.NumberStyles.HexNumber );

                if ( text.Length == 3 )
                    g = int.Parse( editHexTxt.Text.Substring( 2, 1 ), System.Globalization.NumberStyles.HexNumber ) << 4;
                else if ( text.Length >= 4 )
                    g = int.Parse( editHexTxt.Text.Substring( 2, 2 ), System.Globalization.NumberStyles.HexNumber );

                if ( text.Length == 5 )
                    b = int.Parse( editHexTxt.Text.Substring( 4, 1 ), System.Globalization.NumberStyles.HexNumber ) << 4;
                else if ( text.Length >= 6 )
                    b = int.Parse( editHexTxt.Text.Substring( 4, 2 ), System.Globalization.NumberStyles.HexNumber );

                SetColour( index, Color.FromArgb( r, g, b ) );
            }
        }

        private void oKToolStripMenuItem_Click( object sender, EventArgs e )
        {
            int index = Array.IndexOf( myColourBtns, ( editHexStrip.SourceControl as RadioButton ) );
            SetColour( index, myNewColour );
        }
    }

    public class PaletteChangedEventArgs : EventArgs
    {
        public readonly Color[] Palette;

        public PaletteChangedEventArgs( Color[] palette )
        {
            Palette = palette;
        }
    }

    public class SelectedColourChangedEventArgs : EventArgs
    {
        public readonly int SelectedIndex;
        public readonly Color SelectedColour;

        public Pixel SelectedPixed
        {
            get { return (Pixel) ( 8 | SelectedIndex ); }
        }

        public SelectedColourChangedEventArgs( ColourPalettePanel panel )
        {
            SelectedIndex = panel.SelectedIndex;
            SelectedColour = panel.Palette[ panel.SelectedIndex ];
        }
    }
}
