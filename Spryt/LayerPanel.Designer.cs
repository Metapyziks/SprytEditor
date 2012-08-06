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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.layerGrid = new System.Windows.Forms.DataGridView();
            this.imagePreviewCol = new System.Windows.Forms.DataGridViewImageColumn();
            this.layerNameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.moveUpBtn = new System.Windows.Forms.Button();
            this.moveDownBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ( (System.ComponentModel.ISupportInitialize) ( this.layerGrid ) ).BeginInit();
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
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle() );
            this.tableLayoutPanel1.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle() );
            this.tableLayoutPanel1.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Absolute, 54F ) );
            this.tableLayoutPanel1.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle() );
            this.tableLayoutPanel1.Controls.Add( this.layerGrid, 0, 0 );
            this.tableLayoutPanel1.Controls.Add( this.moveUpBtn, 0, 1 );
            this.tableLayoutPanel1.Controls.Add( this.moveDownBtn, 1, 1 );
            this.tableLayoutPanel1.Controls.Add( this.addBtn, 2, 1 );
            this.tableLayoutPanel1.Controls.Add( this.deleteBtn, 3, 1 );
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point( 3, 16 );
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Percent, 100F ) );
            this.tableLayoutPanel1.RowStyles.Add( new System.Windows.Forms.RowStyle() );
            this.tableLayoutPanel1.Size = new System.Drawing.Size( 150, 335 );
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // layerGrid
            // 
            this.layerGrid.AllowUserToAddRows = false;
            this.layerGrid.AllowUserToDeleteRows = false;
            this.layerGrid.AllowUserToOrderColumns = true;
            this.layerGrid.AllowUserToResizeColumns = false;
            this.layerGrid.AllowUserToResizeRows = false;
            this.layerGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.layerGrid.ColumnHeadersVisible = false;
            this.layerGrid.Columns.AddRange( new System.Windows.Forms.DataGridViewColumn[] {
            this.imagePreviewCol,
            this.layerNameCol} );
            this.tableLayoutPanel1.SetColumnSpan( this.layerGrid, 4 );
            this.layerGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layerGrid.Location = new System.Drawing.Point( 3, 3 );
            this.layerGrid.Name = "layerGrid";
            this.layerGrid.RowHeadersVisible = false;
            this.layerGrid.Size = new System.Drawing.Size( 144, 297 );
            this.layerGrid.TabIndex = 0;
            // 
            // imagePreviewCol
            // 
            this.imagePreviewCol.HeaderText = "Preview";
            this.imagePreviewCol.MinimumWidth = 64;
            this.imagePreviewCol.Name = "imagePreviewCol";
            this.imagePreviewCol.ReadOnly = true;
            this.imagePreviewCol.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.imagePreviewCol.Width = 64;
            // 
            // layerNameCol
            // 
            this.layerNameCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.layerNameCol.HeaderText = "Name";
            this.layerNameCol.MaxInputLength = 32;
            this.layerNameCol.Name = "layerNameCol";
            this.layerNameCol.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.layerNameCol.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // moveUpBtn
            // 
            this.moveUpBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.moveUpBtn.Image = global::Spryt.Properties.Resources.arrow_up;
            this.moveUpBtn.Location = new System.Drawing.Point( 3, 306 );
            this.moveUpBtn.Name = "moveUpBtn";
            this.moveUpBtn.Size = new System.Drawing.Size( 26, 26 );
            this.moveUpBtn.TabIndex = 1;
            this.moveUpBtn.UseVisualStyleBackColor = true;
            this.moveUpBtn.Click += new System.EventHandler( this.moveUpBtn_Click );
            // 
            // moveDownBtn
            // 
            this.moveDownBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.moveDownBtn.Image = global::Spryt.Properties.Resources.arrow_down;
            this.moveDownBtn.Location = new System.Drawing.Point( 35, 306 );
            this.moveDownBtn.Name = "moveDownBtn";
            this.moveDownBtn.Size = new System.Drawing.Size( 26, 26 );
            this.moveDownBtn.TabIndex = 2;
            this.moveDownBtn.UseVisualStyleBackColor = true;
            this.moveDownBtn.Click += new System.EventHandler( this.moveDownBtn_Click );
            // 
            // addBtn
            // 
            this.addBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addBtn.Image = global::Spryt.Properties.Resources.add;
            this.addBtn.Location = new System.Drawing.Point( 67, 306 );
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size( 48, 26 );
            this.addBtn.TabIndex = 3;
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler( this.addBtn_Click );
            // 
            // deleteBtn
            // 
            this.deleteBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.deleteBtn.Image = global::Spryt.Properties.Resources.delete;
            this.deleteBtn.Location = new System.Drawing.Point( 121, 306 );
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size( 26, 26 );
            this.deleteBtn.TabIndex = 4;
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler( this.deleteBtn_Click );
            // 
            // LayerPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 13F );
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add( this.groupBox1 );
            this.Name = "LayerPanel";
            this.Size = new System.Drawing.Size( 156, 354 );
            this.groupBox1.ResumeLayout( false );
            this.tableLayoutPanel1.ResumeLayout( false );
            ( (System.ComponentModel.ISupportInitialize) ( this.layerGrid ) ).EndInit();
            this.ResumeLayout( false );

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView layerGrid;
        private System.Windows.Forms.Button moveUpBtn;
        private System.Windows.Forms.Button moveDownBtn;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.DataGridViewImageColumn imagePreviewCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn layerNameCol;
    }
}
