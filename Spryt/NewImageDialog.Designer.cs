namespace Spryt
{
    partial class NewImageDialog
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.widthNUD = new System.Windows.Forms.NumericUpDown();
            this.heightNUD = new System.Windows.Forms.NumericUpDown();
            this.createBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ( (System.ComponentModel.ISupportInitialize) ( this.widthNUD ) ).BeginInit();
            ( (System.ComponentModel.ISupportInitialize) ( this.heightNUD ) ).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel2.SetColumnSpan( this.groupBox1, 3 );
            this.groupBox1.Controls.Add( this.tableLayoutPanel1 );
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point( 15, 15 );
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size( 252, 58 );
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dimentions";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent, 50F ) );
            this.tableLayoutPanel1.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent, 50F ) );
            this.tableLayoutPanel1.Controls.Add( this.label1, 0, 0 );
            this.tableLayoutPanel1.Controls.Add( this.label2, 1, 0 );
            this.tableLayoutPanel1.Controls.Add( this.widthNUD, 0, 1 );
            this.tableLayoutPanel1.Controls.Add( this.heightNUD, 1, 1 );
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point( 3, 16 );
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add( new System.Windows.Forms.RowStyle() );
            this.tableLayoutPanel1.RowStyles.Add( new System.Windows.Forms.RowStyle() );
            this.tableLayoutPanel1.Size = new System.Drawing.Size( 246, 39 );
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point( 3, 0 );
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size( 117, 13 );
            this.label1.TabIndex = 0;
            this.label1.Text = "Width";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point( 126, 0 );
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size( 117, 13 );
            this.label2.TabIndex = 1;
            this.label2.Text = "Height";
            // 
            // widthNUD
            // 
            this.widthNUD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.widthNUD.Location = new System.Drawing.Point( 3, 16 );
            this.widthNUD.Maximum = new decimal( new int[] {
            256,
            0,
            0,
            0} );
            this.widthNUD.Minimum = new decimal( new int[] {
            1,
            0,
            0,
            0} );
            this.widthNUD.Name = "widthNUD";
            this.widthNUD.Size = new System.Drawing.Size( 117, 20 );
            this.widthNUD.TabIndex = 2;
            this.widthNUD.Value = new decimal( new int[] {
            16,
            0,
            0,
            0} );
            // 
            // heightNUD
            // 
            this.heightNUD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.heightNUD.Location = new System.Drawing.Point( 126, 16 );
            this.heightNUD.Maximum = new decimal( new int[] {
            256,
            0,
            0,
            0} );
            this.heightNUD.Minimum = new decimal( new int[] {
            1,
            0,
            0,
            0} );
            this.heightNUD.Name = "heightNUD";
            this.heightNUD.Size = new System.Drawing.Size( 117, 20 );
            this.heightNUD.TabIndex = 3;
            this.heightNUD.Value = new decimal( new int[] {
            16,
            0,
            0,
            0} );
            // 
            // createBtn
            // 
            this.createBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.createBtn.Location = new System.Drawing.Point( 111, 79 );
            this.createBtn.Name = "createBtn";
            this.createBtn.Size = new System.Drawing.Size( 75, 23 );
            this.createBtn.TabIndex = 1;
            this.createBtn.Text = "Create";
            this.createBtn.UseVisualStyleBackColor = true;
            this.createBtn.Click += new System.EventHandler( this.createBtn_Click );
            // 
            // cancelBtn
            // 
            this.cancelBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cancelBtn.Location = new System.Drawing.Point( 192, 79 );
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size( 75, 23 );
            this.cancelBtn.TabIndex = 2;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler( this.cancelBtn_Click );
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent, 100F ) );
            this.tableLayoutPanel2.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle() );
            this.tableLayoutPanel2.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle() );
            this.tableLayoutPanel2.Controls.Add( this.groupBox1, 0, 0 );
            this.tableLayoutPanel2.Controls.Add( this.cancelBtn, 2, 1 );
            this.tableLayoutPanel2.Controls.Add( this.createBtn, 1, 1 );
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point( 0, 0 );
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.Padding = new System.Windows.Forms.Padding( 12 );
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add( new System.Windows.Forms.RowStyle() );
            this.tableLayoutPanel2.RowStyles.Add( new System.Windows.Forms.RowStyle() );
            this.tableLayoutPanel2.Size = new System.Drawing.Size( 282, 117 );
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // NewImageDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 13F );
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size( 282, 117 );
            this.Controls.Add( this.tableLayoutPanel2 );
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "NewImageDialog";
            this.Text = "New Image";
            this.groupBox1.ResumeLayout( false );
            this.groupBox1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout( false );
            this.tableLayoutPanel1.PerformLayout();
            ( (System.ComponentModel.ISupportInitialize) ( this.widthNUD ) ).EndInit();
            ( (System.ComponentModel.ISupportInitialize) ( this.heightNUD ) ).EndInit();
            this.tableLayoutPanel2.ResumeLayout( false );
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout( false );
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown widthNUD;
        private System.Windows.Forms.NumericUpDown heightNUD;
        private System.Windows.Forms.Button createBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
    }
}