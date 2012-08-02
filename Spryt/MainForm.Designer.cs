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
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.canvasTabs = new System.Windows.Forms.TabControl();
            this.fileImageList = new System.Windows.Forms.ImageList( this.components );
            this.toolList = new System.Windows.Forms.ListView();
            this.toolsImageList = new System.Windows.Forms.ImageList( this.components );
            this.vertSplit = new System.Windows.Forms.SplitContainer();
            this.leftSplit = new System.Windows.Forms.SplitContainer();
            this.colourPalettePanel = new Spryt.ColourPalettePanel();
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
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size( 37, 20 );
            this.fileToolStripMenuItem.Text = "File";
            // 
            // editToolStripMenuItem
            // 
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
            // canvasTabs
            // 
            this.canvasTabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.canvasTabs.ImageList = this.fileImageList;
            this.canvasTabs.Location = new System.Drawing.Point( 0, 0 );
            this.canvasTabs.Name = "canvasTabs";
            this.canvasTabs.SelectedIndex = 0;
            this.canvasTabs.Size = new System.Drawing.Size( 819, 607 );
            this.canvasTabs.TabIndex = 5;
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
            this.toolList.Size = new System.Drawing.Size( 150, 210 );
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
            this.leftSplit.Panel2MinSize = 391;
            this.leftSplit.Size = new System.Drawing.Size( 150, 607 );
            this.leftSplit.SplitterDistance = 210;
            this.leftSplit.TabIndex = 7;
            // 
            // colourPalettePanel
            // 
            this.colourPalettePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.colourPalettePanel.Location = new System.Drawing.Point( 0, 0 );
            this.colourPalettePanel.MaximumSize = new System.Drawing.Size( 150, 391 );
            this.colourPalettePanel.MinimumSize = new System.Drawing.Size( 150, 391 );
            this.colourPalettePanel.Name = "colourPalettePanel";
            this.colourPalettePanel.Size = new System.Drawing.Size( 150, 391 );
            this.colourPalettePanel.TabIndex = 0;
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
        private System.Windows.Forms.TabControl canvasTabs;
        private System.Windows.Forms.ListView toolList;
        private System.Windows.Forms.ImageList toolsImageList;
        private System.Windows.Forms.ImageList fileImageList;
        private System.Windows.Forms.ToolStripMenuItem zoomToolStripMenuItem;
        private System.Windows.Forms.SplitContainer vertSplit;
        private System.Windows.Forms.SplitContainer leftSplit;
        private ColourPalettePanel colourPalettePanel;

    }
}

