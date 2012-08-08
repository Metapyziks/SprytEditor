namespace Spryt
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager( typeof( MainForm ) );
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.recentFilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gridToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showGridToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gridSizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tiledViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.areaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.magicWandToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.pencilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fillToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.boxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.fileImageList = new System.Windows.Forms.ImageList( this.components );
            this.toolsImageList = new System.Windows.Forms.ImageList( this.components );
            this.mainLayoutTable = new System.Windows.Forms.TableLayoutPanel();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colourPalettePanel = new Spryt.ColourPalettePanel();
            this.toolPanel = new Spryt.ToolPanel();
            this.canvasTabs = new Spryt.CanvasTabControl();
            this.layerPanel = new Spryt.LayerPanel();
            this.previewPanel = new Spryt.PreviewPanel();
            this.menuStrip.SuspendLayout();
            this.mainLayoutTable.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange( new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.toolsToolStripMenuItem} );
            this.menuStrip.Location = new System.Drawing.Point( 0, 0 );
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size( 973, 24 );
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange( new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.toolStripSeparator1,
            this.closeToolStripMenuItem,
            this.closeAllToolStripMenuItem,
            this.toolStripSeparator2,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.saveAllToolStripMenuItem,
            this.toolStripSeparator3,
            this.recentFilesToolStripMenuItem,
            this.toolStripSeparator4,
            this.exitToolStripMenuItem} );
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size( 37, 20 );
            this.fileToolStripMenuItem.Text = "File";
            this.fileToolStripMenuItem.DropDownOpening += new System.EventHandler( this.fileToolStripMenuItem_DropDownOpening );
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size( 136, 22 );
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler( this.newToolStripMenuItem_Click );
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size( 136, 22 );
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler( this.openToolStripMenuItem_Click );
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size( 133, 6 );
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size( 136, 22 );
            this.closeToolStripMenuItem.Text = "Close";
            // 
            // closeAllToolStripMenuItem
            // 
            this.closeAllToolStripMenuItem.Name = "closeAllToolStripMenuItem";
            this.closeAllToolStripMenuItem.Size = new System.Drawing.Size( 136, 22 );
            this.closeAllToolStripMenuItem.Text = "Close All";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size( 133, 6 );
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size( 136, 22 );
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler( this.saveToolStripMenuItem_Click );
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size( 136, 22 );
            this.saveAsToolStripMenuItem.Text = "Save As...";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler( this.saveAsToolStripMenuItem_Click );
            // 
            // saveAllToolStripMenuItem
            // 
            this.saveAllToolStripMenuItem.Name = "saveAllToolStripMenuItem";
            this.saveAllToolStripMenuItem.Size = new System.Drawing.Size( 136, 22 );
            this.saveAllToolStripMenuItem.Text = "Save All";
            this.saveAllToolStripMenuItem.Click += new System.EventHandler( this.saveAllToolStripMenuItem_Click );
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size( 133, 6 );
            // 
            // recentFilesToolStripMenuItem
            // 
            this.recentFilesToolStripMenuItem.Name = "recentFilesToolStripMenuItem";
            this.recentFilesToolStripMenuItem.Size = new System.Drawing.Size( 136, 22 );
            this.recentFilesToolStripMenuItem.Text = "Recent Files";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size( 133, 6 );
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size( 136, 22 );
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange( new System.Windows.Forms.ToolStripItem[] {
            this.undoToolStripMenuItem,
            this.redoToolStripMenuItem} );
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size( 39, 20 );
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.DropDownOpening += new System.EventHandler( this.editToolStripMenuItem_DropDownOpening );
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange( new System.Windows.Forms.ToolStripItem[] {
            this.zoomToolStripMenuItem,
            this.gridToolStripMenuItem,
            this.tiledViewToolStripMenuItem} );
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size( 44, 20 );
            this.viewToolStripMenuItem.Text = "View";
            this.viewToolStripMenuItem.DropDownOpening += new System.EventHandler( this.viewToolStripMenuItem_DropDownOpening );
            // 
            // zoomToolStripMenuItem
            // 
            this.zoomToolStripMenuItem.Name = "zoomToolStripMenuItem";
            this.zoomToolStripMenuItem.Size = new System.Drawing.Size( 137, 22 );
            this.zoomToolStripMenuItem.Text = "Zoom (8.0x)";
            // 
            // gridToolStripMenuItem
            // 
            this.gridToolStripMenuItem.DropDownItems.AddRange( new System.Windows.Forms.ToolStripItem[] {
            this.showGridToolStripMenuItem,
            this.gridSizeToolStripMenuItem} );
            this.gridToolStripMenuItem.Name = "gridToolStripMenuItem";
            this.gridToolStripMenuItem.Size = new System.Drawing.Size( 137, 22 );
            this.gridToolStripMenuItem.Text = "Grid";
            // 
            // showGridToolStripMenuItem
            // 
            this.showGridToolStripMenuItem.CheckOnClick = true;
            this.showGridToolStripMenuItem.Name = "showGridToolStripMenuItem";
            this.showGridToolStripMenuItem.Size = new System.Drawing.Size( 141, 22 );
            this.showGridToolStripMenuItem.Text = "Show Grid";
            this.showGridToolStripMenuItem.Click += new System.EventHandler( this.showGridToolStripMenuItem_Click );
            // 
            // gridSizeToolStripMenuItem
            // 
            this.gridSizeToolStripMenuItem.Name = "gridSizeToolStripMenuItem";
            this.gridSizeToolStripMenuItem.Size = new System.Drawing.Size( 141, 22 );
            this.gridSizeToolStripMenuItem.Text = "Grid Options";
            this.gridSizeToolStripMenuItem.Click += new System.EventHandler( this.gridSizeToolStripMenuItem_Click );
            // 
            // tiledViewToolStripMenuItem
            // 
            this.tiledViewToolStripMenuItem.CheckOnClick = true;
            this.tiledViewToolStripMenuItem.Name = "tiledViewToolStripMenuItem";
            this.tiledViewToolStripMenuItem.Size = new System.Drawing.Size( 137, 22 );
            this.tiledViewToolStripMenuItem.Text = "Tiled View";
            this.tiledViewToolStripMenuItem.Click += new System.EventHandler( this.tiledViewToolStripMenuItem_Click );
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange( new System.Windows.Forms.ToolStripItem[] {
            this.selectToolStripMenuItem,
            this.areaToolStripMenuItem,
            this.magicWandToolStripMenuItem,
            this.toolStripSeparator6,
            this.pencilToolStripMenuItem,
            this.fillToolStripMenuItem,
            this.boxToolStripMenuItem} );
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size( 48, 20 );
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // selectToolStripMenuItem
            // 
            this.selectToolStripMenuItem.Name = "selectToolStripMenuItem";
            this.selectToolStripMenuItem.Size = new System.Drawing.Size( 141, 22 );
            this.selectToolStripMenuItem.Text = "Select";
            // 
            // areaToolStripMenuItem
            // 
            this.areaToolStripMenuItem.Name = "areaToolStripMenuItem";
            this.areaToolStripMenuItem.Size = new System.Drawing.Size( 141, 22 );
            this.areaToolStripMenuItem.Text = "Area";
            // 
            // magicWandToolStripMenuItem
            // 
            this.magicWandToolStripMenuItem.Name = "magicWandToolStripMenuItem";
            this.magicWandToolStripMenuItem.Size = new System.Drawing.Size( 141, 22 );
            this.magicWandToolStripMenuItem.Text = "Magic Wand";
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size( 138, 6 );
            // 
            // pencilToolStripMenuItem
            // 
            this.pencilToolStripMenuItem.Name = "pencilToolStripMenuItem";
            this.pencilToolStripMenuItem.Size = new System.Drawing.Size( 141, 22 );
            this.pencilToolStripMenuItem.Text = "Pencil";
            // 
            // fillToolStripMenuItem
            // 
            this.fillToolStripMenuItem.Name = "fillToolStripMenuItem";
            this.fillToolStripMenuItem.Size = new System.Drawing.Size( 141, 22 );
            this.fillToolStripMenuItem.Text = "Fill";
            // 
            // boxToolStripMenuItem
            // 
            this.boxToolStripMenuItem.Name = "boxToolStripMenuItem";
            this.boxToolStripMenuItem.Size = new System.Drawing.Size( 141, 22 );
            this.boxToolStripMenuItem.Text = "Box";
            // 
            // statusStrip
            // 
            this.statusStrip.Location = new System.Drawing.Point( 0, 685 );
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size( 973, 22 );
            this.statusStrip.TabIndex = 3;
            this.statusStrip.Text = "statusStrip";
            // 
            // fileImageList
            // 
            this.fileImageList.ImageStream = ( (System.Windows.Forms.ImageListStreamer) ( resources.GetObject( "fileImageList.ImageStream" ) ) );
            this.fileImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.fileImageList.Images.SetKeyName( 0, "page.png" );
            // 
            // toolsImageList
            // 
            this.toolsImageList.ImageStream = ( (System.Windows.Forms.ImageListStreamer) ( resources.GetObject( "toolsImageList.ImageStream" ) ) );
            this.toolsImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.toolsImageList.Images.SetKeyName( 0, "cursor.png" );
            this.toolsImageList.Images.SetKeyName( 1, "paintcan.png" );
            this.toolsImageList.Images.SetKeyName( 2, "pencil.png" );
            this.toolsImageList.Images.SetKeyName( 3, "shading.png" );
            this.toolsImageList.Images.SetKeyName( 4, "shape_square.png" );
            // 
            // mainLayoutTable
            // 
            this.mainLayoutTable.ColumnCount = 3;
            this.mainLayoutTable.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle() );
            this.mainLayoutTable.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent, 100F ) );
            this.mainLayoutTable.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Absolute, 162F ) );
            this.mainLayoutTable.Controls.Add( this.colourPalettePanel, 0, 1 );
            this.mainLayoutTable.Controls.Add( this.toolPanel, 0, 0 );
            this.mainLayoutTable.Controls.Add( this.canvasTabs, 1, 0 );
            this.mainLayoutTable.Controls.Add( this.layerPanel, 2, 1 );
            this.mainLayoutTable.Controls.Add( this.previewPanel, 2, 0 );
            this.mainLayoutTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainLayoutTable.Location = new System.Drawing.Point( 0, 24 );
            this.mainLayoutTable.Name = "mainLayoutTable";
            this.mainLayoutTable.RowCount = 2;
            this.mainLayoutTable.RowStyles.Add( new System.Windows.Forms.RowStyle() );
            this.mainLayoutTable.RowStyles.Add( new System.Windows.Forms.RowStyle() );
            this.mainLayoutTable.Size = new System.Drawing.Size( 973, 661 );
            this.mainLayoutTable.TabIndex = 4;
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Enabled = false;
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.Size = new System.Drawing.Size( 152, 22 );
            this.undoToolStripMenuItem.Text = "Undo";
            this.undoToolStripMenuItem.Click += new System.EventHandler( this.undoToolStripMenuItem_Click );
            // 
            // redoToolStripMenuItem
            // 
            this.redoToolStripMenuItem.Enabled = false;
            this.redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            this.redoToolStripMenuItem.Size = new System.Drawing.Size( 152, 22 );
            this.redoToolStripMenuItem.Text = "Redo";
            this.redoToolStripMenuItem.Click += new System.EventHandler( this.redoToolStripMenuItem_Click );
            // 
            // colourPalettePanel
            // 
            this.colourPalettePanel.AutoSize = true;
            this.colourPalettePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.colourPalettePanel.Location = new System.Drawing.Point( 3, 210 );
            this.colourPalettePanel.MaximumSize = new System.Drawing.Size( 156, 429 );
            this.colourPalettePanel.MinimumSize = new System.Drawing.Size( 156, 429 );
            this.colourPalettePanel.Name = "colourPalettePanel";
            this.colourPalettePanel.SelectedIndex = 0;
            this.colourPalettePanel.Size = new System.Drawing.Size( 156, 429 );
            this.colourPalettePanel.TabIndex = 0;
            this.colourPalettePanel.PaletteChanged += new System.EventHandler<Spryt.PaletteChangedEventArgs>( this.colourPalettePanel_PaletteChanged );
            this.colourPalettePanel.SelectedColourChanged += new System.EventHandler<Spryt.SelectedColourChangedEventArgs>( this.colourPalettePanel_SelectedColourChanged );
            // 
            // toolPanel
            // 
            this.toolPanel.CurrentTool = Spryt.Tool.Pencil;
            this.toolPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolPanel.Location = new System.Drawing.Point( 3, 3 );
            this.toolPanel.Name = "toolPanel";
            this.toolPanel.Size = new System.Drawing.Size( 156, 201 );
            this.toolPanel.TabIndex = 0;
            this.toolPanel.CurrentToolChanged += new System.EventHandler<Spryt.CurrentToolChangedEventArgs>( this.toolPanel_CurrentToolChanged );
            // 
            // canvasTabs
            // 
            this.canvasTabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.canvasTabs.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.canvasTabs.ImageList = this.fileImageList;
            this.canvasTabs.ItemSize = new System.Drawing.Size( 0, 24 );
            this.canvasTabs.Location = new System.Drawing.Point( 165, 3 );
            this.canvasTabs.Name = "canvasTabs";
            this.canvasTabs.Padding = new System.Drawing.Point( 16, 0 );
            this.mainLayoutTable.SetRowSpan( this.canvasTabs, 2 );
            this.canvasTabs.SelectedIndex = 0;
            this.canvasTabs.Size = new System.Drawing.Size( 643, 655 );
            this.canvasTabs.TabIndex = 6;
            this.canvasTabs.TabStop = false;
            this.canvasTabs.TabClosed += new Spryt.CanvasTabControl.TabClosedDelegate( this.canvasTabs_TabClosed );
            this.canvasTabs.SelectedIndexChanged += new System.EventHandler( this.canvasTabs_SelectedIndexChanged );
            // 
            // layerPanel
            // 
            this.layerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layerPanel.Enabled = false;
            this.layerPanel.Image = null;
            this.layerPanel.Location = new System.Drawing.Point( 814, 210 );
            this.layerPanel.Name = "layerPanel";
            this.layerPanel.Size = new System.Drawing.Size( 156, 448 );
            this.layerPanel.TabIndex = 7;
            // 
            // previewPanel
            // 
            this.previewPanel.AutoSize = true;
            this.previewPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.previewPanel.Enabled = false;
            this.previewPanel.Image = null;
            this.previewPanel.Location = new System.Drawing.Point( 814, 3 );
            this.previewPanel.Name = "previewPanel";
            this.previewPanel.Size = new System.Drawing.Size( 156, 201 );
            this.previewPanel.TabIndex = 8;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 13F );
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size( 973, 707 );
            this.Controls.Add( this.mainLayoutTable );
            this.Controls.Add( this.statusStrip );
            this.Controls.Add( this.menuStrip );
            this.MinimumSize = new System.Drawing.Size( 425, 543 );
            this.Name = "MainForm";
            this.Text = "Spryt";
            this.menuStrip.ResumeLayout( false );
            this.menuStrip.PerformLayout();
            this.mainLayoutTable.ResumeLayout( false );
            this.mainLayoutTable.PerformLayout();
            this.ResumeLayout( false );
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ImageList toolsImageList;
        private System.Windows.Forms.ImageList fileImageList;
        private System.Windows.Forms.ToolStripMenuItem zoomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem recentFilesToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem areaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem magicWandToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem pencilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fillToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem boxToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel mainLayoutTable;
        private ColourPalettePanel colourPalettePanel;
        private ToolPanel toolPanel;
        private CanvasTabControl canvasTabs;
        private LayerPanel layerPanel;
        private PreviewPanel previewPanel;
        private System.Windows.Forms.ToolStripMenuItem gridToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showGridToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gridSizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tiledViewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redoToolStripMenuItem;

    }
}

