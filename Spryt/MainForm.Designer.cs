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
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup( "Selection", System.Windows.Forms.HorizontalAlignment.Left );
            System.Windows.Forms.ListViewGroup listViewGroup2 = new System.Windows.Forms.ListViewGroup( "Drawing", System.Windows.Forms.HorizontalAlignment.Left );
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem( "", "cursor.png" );
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem( "", 3 );
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem( "", 2 );
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem( "", "paintcan.png" );
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem( "", "shape_square.png" );
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager( typeof( MainForm ) );
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.listView1 = new System.Windows.Forms.ListView();
            this.toolsImageList = new System.Windows.Forms.ImageList( this.components );
            this.canvas = new Spryt.Canvas( this.components );
            this.menuStrip.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabControl1.SuspendLayout();
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
            this.menuStrip.Size = new System.Drawing.Size( 1024, 24 );
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
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size( 44, 20 );
            this.viewToolStripMenuItem.Text = "View";
            // 
            // statusStrip
            // 
            this.statusStrip.Location = new System.Drawing.Point( 0, 618 );
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size( 1024, 22 );
            this.statusStrip.TabIndex = 3;
            this.statusStrip.Text = "statusStrip";
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.tabPage1.Controls.Add( this.canvas );
            this.tabPage1.Location = new System.Drawing.Point( 4, 22 );
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding( 3 );
            this.tabPage1.Size = new System.Drawing.Size( 867, 568 );
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "untitled";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add( this.tabPage1 );
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point( 149, 24 );
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size( 875, 594 );
            this.tabControl1.TabIndex = 5;
            // 
            // listView1
            // 
            this.listView1.Dock = System.Windows.Forms.DockStyle.Left;
            listViewGroup1.Header = "Selection";
            listViewGroup1.Name = "selectionGroup";
            listViewGroup2.Header = "Drawing";
            listViewGroup2.Name = "drawingGroup";
            this.listView1.Groups.AddRange( new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1,
            listViewGroup2} );
            listViewItem1.Group = listViewGroup1;
            listViewItem2.Group = listViewGroup1;
            listViewItem3.Group = listViewGroup2;
            listViewItem4.Group = listViewGroup2;
            listViewItem5.Group = listViewGroup2;
            this.listView1.Items.AddRange( new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4,
            listViewItem5} );
            this.listView1.LargeImageList = this.toolsImageList;
            this.listView1.Location = new System.Drawing.Point( 0, 24 );
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size( 149, 594 );
            this.listView1.SmallImageList = this.toolsImageList;
            this.listView1.StateImageList = this.toolsImageList;
            this.listView1.TabIndex = 5;
            this.listView1.TileSize = new System.Drawing.Size( 64, 32 );
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Tile;
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
            // canvas
            // 
            this.canvas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.canvas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.canvas.Location = new System.Drawing.Point( 108, 32 );
            this.canvas.Margin = new System.Windows.Forms.Padding( 8 );
            this.canvas.Name = "canvas";
            this.canvas.Size = new System.Drawing.Size( 512, 512 );
            this.canvas.TabIndex = 4;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 13F );
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size( 1024, 640 );
            this.Controls.Add( this.tabControl1 );
            this.Controls.Add( this.listView1 );
            this.Controls.Add( this.statusStrip );
            this.Controls.Add( this.menuStrip );
            this.Name = "MainForm";
            this.Text = "Spryt";
            this.menuStrip.ResumeLayout( false );
            this.menuStrip.PerformLayout();
            this.tabPage1.ResumeLayout( false );
            this.tabControl1.ResumeLayout( false );
            this.ResumeLayout( false );
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.TabPage tabPage1;
        private Canvas canvas;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ImageList toolsImageList;

    }
}

