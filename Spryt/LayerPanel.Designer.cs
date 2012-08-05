namespace Spryt
{
    partial class LayerPanel
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ( (System.ComponentModel.ISupportInitialize) ( this.dataGridView1 ) ).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add( this.tableLayoutPanel1 );
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point( 0, 0 );
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size( 156, 354 );
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Layers";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableLayoutPanel1.SetColumnSpan( this.dataGridView1, 4 );
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point( 3, 3 );
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size( 144, 297 );
            this.dataGridView1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle() );
            this.tableLayoutPanel1.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle() );
            this.tableLayoutPanel1.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent, 100F ) );
            this.tableLayoutPanel1.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle() );
            this.tableLayoutPanel1.Controls.Add( this.dataGridView1, 0, 0 );
            this.tableLayoutPanel1.Controls.Add( this.button1, 0, 1 );
            this.tableLayoutPanel1.Controls.Add( this.button2, 1, 1 );
            this.tableLayoutPanel1.Controls.Add( this.button3, 2, 1 );
            this.tableLayoutPanel1.Controls.Add( this.button4, 3, 1 );
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point( 3, 16 );
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Percent, 100F ) );
            this.tableLayoutPanel1.RowStyles.Add( new System.Windows.Forms.RowStyle() );
            this.tableLayoutPanel1.Size = new System.Drawing.Size( 150, 335 );
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Image = global::Spryt.Properties.Resources.arrow_up;
            this.button1.Location = new System.Drawing.Point( 3, 306 );
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size( 26, 26 );
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Image = global::Spryt.Properties.Resources.arrow_down;
            this.button2.Location = new System.Drawing.Point( 35, 306 );
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size( 26, 26 );
            this.button2.TabIndex = 2;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button3.Image = global::Spryt.Properties.Resources.add;
            this.button3.Location = new System.Drawing.Point( 67, 306 );
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size( 48, 26 );
            this.button3.TabIndex = 3;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Image = global::Spryt.Properties.Resources.delete;
            this.button4.Location = new System.Drawing.Point( 121, 306 );
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size( 26, 26 );
            this.button4.TabIndex = 4;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // LayerPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 13F );
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add( this.groupBox1 );
            this.Name = "LayerPanel";
            this.Size = new System.Drawing.Size( 156, 354 );
            this.groupBox1.ResumeLayout( false );
            ( (System.ComponentModel.ISupportInitialize) ( this.dataGridView1 ) ).EndInit();
            this.tableLayoutPanel1.ResumeLayout( false );
            this.ResumeLayout( false );

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}
