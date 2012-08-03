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
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup( "Selection", System.Windows.Forms.HorizontalAlignment.Left );
            System.Windows.Forms.ListViewGroup listViewGroup2 = new System.Windows.Forms.ListViewGroup( "Drawing", System.Windows.Forms.HorizontalAlignment.Left );
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem( "", "cursor.png" );
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem( "", 3 );
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem( "", 2 );
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem( "", "paintcan.png" );
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem( "", "shape_square.png" );
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
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.fileImageList = new System.Windows.Forms.ImageList( this.components );
            this.toolList = new System.Windows.Forms.ListView();
            this.toolsImageList = new System.Windows.Forms.ImageList( this.components );
            this.vertSplit = new System.Windows.Forms.SplitContainer();
            this.leftSplit = new System.Windows.Forms.SplitContainer();
            this.colourPalettePanel = new Spryt.ColourPalettePanel();
            this.canvasTabs = new Spryt.CanvasTabControl();
            this.menuStrip.SuspendLayout();
            ( (System.ComponentModel.ISupportInitialize) ( this.vertSplit ) ).BeginInit();
            this.vertSplit.Panel1.SuspendLayout();
            this.vertSplit.Panel2.SuspendLayout();
            this.vertSplit.SuspendLayout();
            ( (System.ComponentModel.ISupportInitialize) ( this.leftSplit ) ).BeginInit();
            this.leftSplit.Panel1.SuspendLayout();
            this.leftSplit.Panel2.SuspendLayout();
            this.leftSplit.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange( new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.viewToolStripMenuItem} );
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
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size( 136, 22 );
            this.saveAsToolStripMenuItem.Text = "Save As...";
            // 
            // saveAllToolStripMenuItem
            // 
            this.saveAllToolStripMenuItem.Name = "saveAllToolStripMenuItem";
            this.saveAllToolStripMenuItem.Size = new System.Drawing.Size( 136, 22 );
            this.saveAllToolStripMenuItem.Text = "Save All";
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
            this.editToolStripMenuItem.Enabled = false;
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size( 39, 20 );
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange( new System.Windows.Forms.ToolStripItem[] {
            this.zoomToolStripMenuItem} );
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size( 44, 20 );
            this.viewToolStripMenuItem.Text = "View";
            // 
            // zoomToolStripMenuItem
            // 
            this.zoomToolStripMenuItem.Name = "zoomToolStripMenuItem";
            this.zoomToolStripMenuItem.Size = new System.Drawing.Size( 137, 22 );
            this.zoomToolStripMenuItem.Text = "Zoom (8.0x)";
            // 
            // statusStrip
            // 
            this.statusStrip.Location = new System.Drawing.Point( 0, 631 );
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
            // toolList
            // 
            this.toolList.Dock = System.Windows.Forms.DockStyle.Fill;
            listViewGroup1.Header = "Selection";
            listViewGroup1.Name = "selectionGroup";
            listViewGroup2.Header = "Drawing";
            listViewGroup2.Name = "drawingGroup";
            this.toolList.Groups.AddRange( new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1,
            listViewGroup2} );
            listViewItem1.Group = listViewGroup1;
            listViewItem2.Group = listViewGroup1;
            listViewItem3.Group = listViewGroup2;
            listViewItem4.Group = listViewGroup2;
            listViewItem5.Group = listViewGroup2;
            this.toolList.Items.AddRange( new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4,
            listViewItem5} );
            this.toolList.LargeImageList = this.toolsImageList;
            this.toolList.Location = new System.Drawing.Point( 0, 0 );
            this.toolList.MultiSelect = false;
            this.toolList.Name = "toolList";
            this.toolList.Size = new System.Drawing.Size( 150, 154 );
            this.toolList.SmallImageList = this.toolsImageList;
            this.toolList.StateImageList = this.toolsImageList;
            this.toolList.TabIndex = 5;
            this.toolList.TileSize = new System.Drawing.Size( 64, 32 );
            this.toolList.UseCompatibleStateImageBehavior = false;
            this.toolList.View = System.Windows.Forms.View.Tile;
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
            // vertSplit
            // 
            this.vertSplit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vertSplit.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.vertSplit.Location = new System.Drawing.Point( 0, 24 );
            this.vertSplit.Name = "vertSplit";
            // 
            // vertSplit.Panel1
            // 
            this.vertSplit.Panel1.Controls.Add( this.leftSplit );
            this.vertSplit.Panel1MinSize = 150;
            // 
            // vertSplit.Panel2
            // 
            this.vertSplit.Panel2.Controls.Add( this.canvasTabs );
            this.vertSplit.Panel2MinSize = 256;
            this.vertSplit.Size = new System.Drawing.Size( 973, 607 );
            this.vertSplit.SplitterDistance = 150;
            this.vertSplit.TabIndex = 6;
            // 
            // leftSplit
            // 
            this.leftSplit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.leftSplit.Location = new System.Drawing.Point( 0, 0 );
            this.leftSplit.Name = "leftSplit";
            this.leftSplit.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // leftSplit.Panel1
            // 
            this.leftSplit.Panel1.Controls.Add( this.toolList );
            this.leftSplit.Panel1MinSize = 150;
            // 
            // leftSplit.Panel2
            // 
            this.leftSplit.Panel2.Controls.Add( this.colourPalettePanel );
            this.leftSplit.Panel2MinSize = 419;
            this.leftSplit.Size = new System.Drawing.Size( 150, 607 );
            this.leftSplit.SplitterDistance = 154;
            this.leftSplit.TabIndex = 7;
            // 
            // colourPalettePanel
            // 
            this.colourPalettePanel.AutoSize = true;
            this.colourPalettePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.colourPalettePanel.Location = new System.Drawing.Point( 0, 0 );
            this.colourPalettePanel.MaximumSize = new System.Drawing.Size( 156, 429 );
            this.colourPalettePanel.MinimumSize = new System.Drawing.Size( 156, 429 );
            this.colourPalettePanel.Name = "colourPalettePanel";
            this.colourPalettePanel.SelectedIndex = 0;
            this.colourPalettePanel.Size = new System.Drawing.Size( 156, 429 );
            this.colourPalettePanel.TabIndex = 0;
            this.colourPalettePanel.PaletteChanged += new System.EventHandler<Spryt.PaletteChangedEventArgs>( this.colourPalettePanel_PaletteChanged );
            // 
            // canvasTabs
            // 
            this.canvasTabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.canvasTabs.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.canvasTabs.ImageList = this.fileImageList;
            this.canvasTabs.ItemSize = new System.Drawing.Size( 0, 24 );
            this.canvasTabs.Location = new System.Drawing.Point( 0, 0 );
            this.canvasTabs.Name = "canvasTabs";
            this.canvasTabs.Padding = new System.Drawing.Point( 16, 0 );
            this.canvasTabs.SelectedIndex = 0;
            this.canvasTabs.Size = new System.Drawing.Size( 819, 607 );
            this.canvasTabs.TabIndex = 5;
            this.canvasTabs.TabStop = false;
            this.canvasTabs.SelectedIndexChanged += new System.EventHandler( this.canvasTabs_SelectedIndexChanged );
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 13F );
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size( 973, 653 );
            this.Controls.Add( this.vertSplit );
            this.Controls.Add( this.statusStrip );
            this.Controls.Add( this.menuStrip );
            this.MinimumSize = new System.Drawing.Size( 425, 543 );
            this.Name = "MainForm";
            this.Text = "Spryt";
            this.menuStrip.ResumeLayout( false );
            this.menuStrip.PerformLayout();
            this.vertSplit.Panel1.ResumeLayout( false );
            this.vertSplit.Panel2.ResumeLayout( false );
            ( (System.ComponentModel.ISupportInitialize) ( this.vertSplit ) ).EndInit();
            this.vertSplit.ResumeLayout( false );
            this.leftSplit.Panel1.ResumeLayout( false );
            this.leftSplit.Panel2.ResumeLayout( false );
            this.leftSplit.Panel2.PerformLayout();
            ( (System.ComponentModel.ISupportInitialize) ( this.leftSplit ) ).EndInit();
            this.leftSplit.ResumeLayout( false );
            this.ResumeLayout( false );
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip;
        private CanvasTabControl canvasTabs;
        private System.Windows.Forms.ListView toolList;
        private System.Windows.Forms.ImageList toolsImageList;
        private System.Windows.Forms.ImageList fileImageList;
        private System.Windows.Forms.ToolStripMenuItem zoomToolStripMenuItem;
        private System.Windows.Forms.SplitContainer vertSplit;
        private System.Windows.Forms.SplitContainer leftSplit;
        private ColourPalettePanel colourPalettePanel;
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

    }
}

