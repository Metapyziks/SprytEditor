namespace Spryt
{
    partial class PreviewPanel
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.displayPanel = new PreviewDisplayPanel();
            this.tileCheckBox = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add( this.tableLayoutPanel1 );
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point( 0, 0 );
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size( 156, 192 );
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Preview";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent, 100F ) );
            this.tableLayoutPanel1.Controls.Add( this.displayPanel, 0, 0 );
            this.tableLayoutPanel1.Controls.Add( this.tileCheckBox, 0, 1 );
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point( 3, 16 );
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add( new System.Windows.Forms.RowStyle() );
            this.tableLayoutPanel1.RowStyles.Add( new System.Windows.Forms.RowStyle() );
            this.tableLayoutPanel1.Size = new System.Drawing.Size( 150, 173 );
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // displayPanel
            // 
            this.displayPanel.BackgroundImage = global::Spryt.Properties.Resources.background;
            this.displayPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.displayPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.displayPanel.Location = new System.Drawing.Point( 10, 10 );
            this.displayPanel.Margin = new System.Windows.Forms.Padding( 10 );
            this.displayPanel.Name = "displayPanel";
            this.displayPanel.Size = new System.Drawing.Size( 130, 130 );
            this.displayPanel.TabIndex = 0;
            this.displayPanel.Paint += new System.Windows.Forms.PaintEventHandler( this.displayPanel_Paint );
            // 
            // tileCheckBox
            // 
            this.tileCheckBox.AutoSize = true;
            this.tileCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tileCheckBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tileCheckBox.Location = new System.Drawing.Point( 3, 153 );
            this.tileCheckBox.Name = "tileCheckBox";
            this.tileCheckBox.Size = new System.Drawing.Size( 144, 17 );
            this.tileCheckBox.TabIndex = 1;
            this.tileCheckBox.Text = "Tile Wrap";
            this.tileCheckBox.UseVisualStyleBackColor = true;
            this.tileCheckBox.CheckStateChanged += new System.EventHandler( this.tileCheckBox_CheckStateChanged );
            // 
            // PreviewPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 13F );
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add( this.groupBox1 );
            this.Name = "PreviewPanel";
            this.Size = new System.Drawing.Size( 156, 192 );
            this.groupBox1.ResumeLayout( false );
            this.groupBox1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout( false );
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout( false );
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private PreviewDisplayPanel displayPanel;
        private System.Windows.Forms.CheckBox tileCheckBox;
    }
}
