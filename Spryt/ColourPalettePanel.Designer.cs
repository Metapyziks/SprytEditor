namespace Spryt
{
    partial class ColourPalettePanel
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose( bool disposing )
        {
            if ( disposing && ( components != null ) )
            {
                components.Dispose();
            }
            base.Dispose( disposing );
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.presetGroup = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.loadBtn = new System.Windows.Forms.Button();
            this.presetComboBox = new System.Windows.Forms.ComboBox();
            this.saveBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.paletteGroup = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.selectedGroup = new System.Windows.Forms.GroupBox();
            this.selectedColourPanel = new System.Windows.Forms.Panel();
            this.editHexStrip = new System.Windows.Forms.ContextMenuStrip( this.components );
            this.editHexTxt = new System.Windows.Forms.ToolStripTextBox();
            this.oKToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel2.SuspendLayout();
            this.presetGroup.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.paletteGroup.SuspendLayout();
            this.selectedGroup.SuspendLayout();
            this.editHexStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent, 100F ) );
            this.tableLayoutPanel2.Controls.Add( this.presetGroup, 0, 2 );
            this.tableLayoutPanel2.Controls.Add( this.paletteGroup, 0, 1 );
            this.tableLayoutPanel2.Controls.Add( this.selectedGroup, 0, 0 );
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point( 0, 0 );
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Absolute, 64F ) );
            this.tableLayoutPanel2.RowStyles.Add( new System.Windows.Forms.RowStyle() );
            this.tableLayoutPanel2.RowStyles.Add( new System.Windows.Forms.RowStyle() );
            this.tableLayoutPanel2.Size = new System.Drawing.Size( 156, 429 );
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // presetGroup
            // 
            this.presetGroup.AutoSize = true;
            this.presetGroup.Controls.Add( this.tableLayoutPanel1 );
            this.presetGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.presetGroup.Location = new System.Drawing.Point( 3, 348 );
            this.presetGroup.Name = "presetGroup";
            this.presetGroup.Size = new System.Drawing.Size( 150, 78 );
            this.presetGroup.TabIndex = 2;
            this.presetGroup.TabStop = false;
            this.presetGroup.Text = "Presets";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent, 33.33333F ) );
            this.tableLayoutPanel1.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent, 33.33333F ) );
            this.tableLayoutPanel1.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent, 33.33333F ) );
            this.tableLayoutPanel1.Controls.Add( this.loadBtn, 0, 1 );
            this.tableLayoutPanel1.Controls.Add( this.presetComboBox, 0, 0 );
            this.tableLayoutPanel1.Controls.Add( this.saveBtn, 1, 1 );
            this.tableLayoutPanel1.Controls.Add( this.deleteBtn, 2, 1 );
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point( 3, 16 );
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Absolute, 27F ) );
            this.tableLayoutPanel1.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Absolute, 32F ) );
            this.tableLayoutPanel1.Size = new System.Drawing.Size( 144, 59 );
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // loadBtn
            // 
            this.loadBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loadBtn.Enabled = false;
            this.loadBtn.Image = global::Spryt.Properties.Resources.folder_palette;
            this.loadBtn.Location = new System.Drawing.Point( 3, 30 );
            this.loadBtn.Name = "loadBtn";
            this.loadBtn.Size = new System.Drawing.Size( 42, 26 );
            this.loadBtn.TabIndex = 4;
            this.loadBtn.UseVisualStyleBackColor = true;
            this.loadBtn.Click += new System.EventHandler( this.loadBtn_Click );
            // 
            // presetComboBox
            // 
            this.tableLayoutPanel1.SetColumnSpan( this.presetComboBox, 3 );
            this.presetComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.presetComboBox.FormattingEnabled = true;
            this.presetComboBox.Location = new System.Drawing.Point( 3, 3 );
            this.presetComboBox.Name = "presetComboBox";
            this.presetComboBox.Size = new System.Drawing.Size( 138, 21 );
            this.presetComboBox.TabIndex = 0;
            this.presetComboBox.DropDown += new System.EventHandler( this.presetComboBox_DropDown );
            this.presetComboBox.SelectionChangeCommitted += new System.EventHandler( this.presetComboBox_TextUpdate );
            this.presetComboBox.TextUpdate += new System.EventHandler( this.presetComboBox_TextUpdate );
            this.presetComboBox.SelectedValueChanged += new System.EventHandler( this.presetComboBox_TextUpdate );
            // 
            // saveBtn
            // 
            this.saveBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.saveBtn.Enabled = false;
            this.saveBtn.Image = global::Spryt.Properties.Resources.disk;
            this.saveBtn.Location = new System.Drawing.Point( 51, 30 );
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size( 42, 26 );
            this.saveBtn.TabIndex = 1;
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler( this.saveBtn_Click );
            // 
            // deleteBtn
            // 
            this.deleteBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.deleteBtn.Enabled = false;
            this.deleteBtn.Image = global::Spryt.Properties.Resources.delete;
            this.deleteBtn.Location = new System.Drawing.Point( 99, 30 );
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size( 42, 26 );
            this.deleteBtn.TabIndex = 2;
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler( this.deleteBtn_Click );
            // 
            // paletteGroup
            // 
            this.paletteGroup.Controls.Add( this.tableLayoutPanel3 );
            this.paletteGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.paletteGroup.Location = new System.Drawing.Point( 3, 67 );
            this.paletteGroup.Name = "paletteGroup";
            this.paletteGroup.Size = new System.Drawing.Size( 150, 275 );
            this.paletteGroup.TabIndex = 3;
            this.paletteGroup.TabStop = false;
            this.paletteGroup.Text = "Palette";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent, 100F ) );
            this.tableLayoutPanel3.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Absolute, 32F ) );
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point( 3, 16 );
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 8;
            this.tableLayoutPanel3.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Absolute, 32F ) );
            this.tableLayoutPanel3.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Absolute, 32F ) );
            this.tableLayoutPanel3.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Absolute, 32F ) );
            this.tableLayoutPanel3.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Absolute, 32F ) );
            this.tableLayoutPanel3.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Absolute, 32F ) );
            this.tableLayoutPanel3.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Absolute, 32F ) );
            this.tableLayoutPanel3.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Absolute, 32F ) );
            this.tableLayoutPanel3.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Absolute, 32F ) );
            this.tableLayoutPanel3.Size = new System.Drawing.Size( 144, 256 );
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // selectedGroup
            // 
            this.selectedGroup.Controls.Add( this.selectedColourPanel );
            this.selectedGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.selectedGroup.Location = new System.Drawing.Point( 3, 3 );
            this.selectedGroup.Name = "selectedGroup";
            this.selectedGroup.Size = new System.Drawing.Size( 150, 58 );
            this.selectedGroup.TabIndex = 4;
            this.selectedGroup.TabStop = false;
            this.selectedGroup.Text = "Selected Colour";
            // 
            // selectedColourPanel
            // 
            this.selectedColourPanel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.selectedColourPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.selectedColourPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.selectedColourPanel.Location = new System.Drawing.Point( 3, 16 );
            this.selectedColourPanel.Name = "selectedColourPanel";
            this.selectedColourPanel.Size = new System.Drawing.Size( 144, 39 );
            this.selectedColourPanel.TabIndex = 0;
            // 
            // editHexStrip
            // 
            this.editHexStrip.Items.AddRange( new System.Windows.Forms.ToolStripItem[] {
            this.editHexTxt,
            this.oKToolStripMenuItem} );
            this.editHexStrip.Name = "editHexStrip";
            this.editHexStrip.Size = new System.Drawing.Size( 161, 73 );
            this.editHexStrip.Closed += new System.Windows.Forms.ToolStripDropDownClosedEventHandler( this.editHexStrip_Closed );
            this.editHexStrip.Opened += new System.EventHandler( this.editHexStrip_Opened );
            // 
            // editHexTxt
            // 
            this.editHexTxt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.editHexTxt.Font = new System.Drawing.Font( "Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( (byte) ( 0 ) ) );
            this.editHexTxt.MaxLength = 6;
            this.editHexTxt.Name = "editHexTxt";
            this.editHexTxt.Size = new System.Drawing.Size( 100, 23 );
            this.editHexTxt.TextChanged += new System.EventHandler( this.editHexTxt_TextChanged );
            // 
            // oKToolStripMenuItem
            // 
            this.oKToolStripMenuItem.Name = "oKToolStripMenuItem";
            this.oKToolStripMenuItem.Size = new System.Drawing.Size( 160, 22 );
            this.oKToolStripMenuItem.Text = "Done";
            this.oKToolStripMenuItem.Click += new System.EventHandler( this.oKToolStripMenuItem_Click );
            // 
            // ColourPalettePanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 13F );
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add( this.tableLayoutPanel2 );
            this.MaximumSize = new System.Drawing.Size( 156, 429 );
            this.MinimumSize = new System.Drawing.Size( 156, 429 );
            this.Name = "ColourPalettePanel";
            this.Size = new System.Drawing.Size( 156, 429 );
            this.tableLayoutPanel2.ResumeLayout( false );
            this.tableLayoutPanel2.PerformLayout();
            this.presetGroup.ResumeLayout( false );
            this.presetGroup.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout( false );
            this.paletteGroup.ResumeLayout( false );
            this.selectedGroup.ResumeLayout( false );
            this.editHexStrip.ResumeLayout( false );
            this.editHexStrip.PerformLayout();
            this.ResumeLayout( false );
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.GroupBox presetGroup;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ComboBox presetComboBox;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.GroupBox paletteGroup;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button loadBtn;
        private System.Windows.Forms.GroupBox selectedGroup;
        private System.Windows.Forms.Panel selectedColourPanel;
        private System.Windows.Forms.ContextMenuStrip editHexStrip;
        private System.Windows.Forms.ToolStripTextBox editHexTxt;
        private System.Windows.Forms.ToolStripMenuItem oKToolStripMenuItem;

    }
}
