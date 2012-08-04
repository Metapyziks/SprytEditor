namespace Spryt
{
    partial class ToolPanel
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.selectBtn = new System.Windows.Forms.RadioButton();
            this.areaBtn = new System.Windows.Forms.RadioButton();
            this.wandBtn = new System.Windows.Forms.RadioButton();
            this.pencilBtn = new System.Windows.Forms.RadioButton();
            this.fillBtn = new System.Windows.Forms.RadioButton();
            this.boxBtn = new System.Windows.Forms.RadioButton();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent, 100F ) );
            this.tableLayoutPanel1.Controls.Add( this.groupBox1, 0, 0 );
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point( 0, 0 );
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add( new System.Windows.Forms.RowStyle() );
            this.tableLayoutPanel1.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Percent, 100F ) );
            this.tableLayoutPanel1.Size = new System.Drawing.Size( 156, 150 );
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox1.Controls.Add( this.tableLayoutPanel2 );
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point( 3, 3 );
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size( 150, 85 );
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tools";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel2.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Absolute, 32F ) );
            this.tableLayoutPanel2.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Absolute, 32F ) );
            this.tableLayoutPanel2.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Absolute, 32F ) );
            this.tableLayoutPanel2.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Absolute, 32F ) );
            this.tableLayoutPanel2.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent, 100F ) );
            this.tableLayoutPanel2.Controls.Add( this.label1, 0, 1 );
            this.tableLayoutPanel2.Controls.Add( this.selectBtn, 0, 0 );
            this.tableLayoutPanel2.Controls.Add( this.areaBtn, 1, 0 );
            this.tableLayoutPanel2.Controls.Add( this.wandBtn, 2, 0 );
            this.tableLayoutPanel2.Controls.Add( this.pencilBtn, 0, 2 );
            this.tableLayoutPanel2.Controls.Add( this.fillBtn, 2, 2 );
            this.tableLayoutPanel2.Controls.Add( this.boxBtn, 1, 2 );
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point( 3, 16 );
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Absolute, 32F ) );
            this.tableLayoutPanel2.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Absolute, 2F ) );
            this.tableLayoutPanel2.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Absolute, 32F ) );
            this.tableLayoutPanel2.Size = new System.Drawing.Size( 144, 66 );
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tableLayoutPanel2.SetColumnSpan( this.label1, 3 );
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point( 3, 32 );
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size( 90, 2 );
            this.label1.TabIndex = 1;
            // 
            // selectBtn
            // 
            this.selectBtn.Appearance = System.Windows.Forms.Appearance.Button;
            this.selectBtn.AutoSize = true;
            this.selectBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.selectBtn.Image = global::Spryt.Properties.Resources.cursor;
            this.selectBtn.Location = new System.Drawing.Point( 3, 3 );
            this.selectBtn.Name = "selectBtn";
            this.selectBtn.Size = new System.Drawing.Size( 26, 26 );
            this.selectBtn.TabIndex = 2;
            this.selectBtn.UseVisualStyleBackColor = true;
            // 
            // areaBtn
            // 
            this.areaBtn.Appearance = System.Windows.Forms.Appearance.Button;
            this.areaBtn.AutoSize = true;
            this.areaBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.areaBtn.Image = global::Spryt.Properties.Resources.shading;
            this.areaBtn.Location = new System.Drawing.Point( 35, 3 );
            this.areaBtn.Name = "areaBtn";
            this.areaBtn.Size = new System.Drawing.Size( 26, 26 );
            this.areaBtn.TabIndex = 3;
            this.areaBtn.UseVisualStyleBackColor = true;
            // 
            // wandBtn
            // 
            this.wandBtn.Appearance = System.Windows.Forms.Appearance.Button;
            this.wandBtn.AutoSize = true;
            this.wandBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wandBtn.Image = global::Spryt.Properties.Resources.wand;
            this.wandBtn.Location = new System.Drawing.Point( 67, 3 );
            this.wandBtn.Name = "wandBtn";
            this.wandBtn.Size = new System.Drawing.Size( 26, 26 );
            this.wandBtn.TabIndex = 4;
            this.wandBtn.UseVisualStyleBackColor = true;
            // 
            // pencilBtn
            // 
            this.pencilBtn.Appearance = System.Windows.Forms.Appearance.Button;
            this.pencilBtn.AutoSize = true;
            this.pencilBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pencilBtn.Image = global::Spryt.Properties.Resources.pencil;
            this.pencilBtn.Location = new System.Drawing.Point( 3, 37 );
            this.pencilBtn.Name = "pencilBtn";
            this.pencilBtn.Size = new System.Drawing.Size( 26, 26 );
            this.pencilBtn.TabIndex = 5;
            this.pencilBtn.UseVisualStyleBackColor = true;
            // 
            // fillBtn
            // 
            this.fillBtn.Appearance = System.Windows.Forms.Appearance.Button;
            this.fillBtn.AutoSize = true;
            this.fillBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fillBtn.Image = global::Spryt.Properties.Resources.paintcan;
            this.fillBtn.Location = new System.Drawing.Point( 67, 37 );
            this.fillBtn.Name = "fillBtn";
            this.fillBtn.Size = new System.Drawing.Size( 26, 26 );
            this.fillBtn.TabIndex = 6;
            this.fillBtn.UseVisualStyleBackColor = true;
            // 
            // boxBtn
            // 
            this.boxBtn.Appearance = System.Windows.Forms.Appearance.Button;
            this.boxBtn.AutoSize = true;
            this.boxBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.boxBtn.Image = global::Spryt.Properties.Resources.shape_square;
            this.boxBtn.Location = new System.Drawing.Point( 35, 37 );
            this.boxBtn.Name = "boxBtn";
            this.boxBtn.Size = new System.Drawing.Size( 26, 26 );
            this.boxBtn.TabIndex = 7;
            this.boxBtn.UseVisualStyleBackColor = true;
            // 
            // ToolPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 13F );
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add( this.tableLayoutPanel1 );
            this.Name = "ToolPanel";
            this.Size = new System.Drawing.Size( 156, 150 );
            this.tableLayoutPanel1.ResumeLayout( false );
            this.tableLayoutPanel1.PerformLayout();
            this.groupBox1.ResumeLayout( false );
            this.groupBox1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout( false );
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout( false );

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton wandBtn;
        private System.Windows.Forms.RadioButton selectBtn;
        private System.Windows.Forms.RadioButton areaBtn;
        private System.Windows.Forms.RadioButton pencilBtn;
        private System.Windows.Forms.RadioButton fillBtn;
        private System.Windows.Forms.RadioButton boxBtn;
    }
}
