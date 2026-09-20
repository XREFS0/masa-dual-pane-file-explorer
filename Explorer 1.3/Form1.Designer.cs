namespace Explorer
{
  partial class Form1
  {
     
     
     
    private System.ComponentModel.IContainer components = null;

     
     
     
     
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

     
     
     
     
    private void InitializeComponent()
    {
      this.components = new System.ComponentModel.Container();
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
      this.listView1 = new System.Windows.Forms.ListView();
      this.popUp1 = new System.Windows.Forms.ContextMenuStrip(this.components);
      this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.renameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
      this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.moveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
      this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.imageList1 = new System.Windows.Forms.ImageList(this.components);
      this.listView2 = new System.Windows.Forms.ListView();
      this.popUp2 = new System.Windows.Forms.ContextMenuStrip(this.components);
      this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
      this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
      this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
      this.lbStatus1 = new System.Windows.Forms.Label();
      this.lbStatus2 = new System.Windows.Forms.Label();
      this.cmbDrive1 = new System.Windows.Forms.ComboBox();
      this.cmbDrive2 = new System.Windows.Forms.ComboBox();
      this.bBack1 = new System.Windows.Forms.Button();
      this.bBack2 = new System.Windows.Forms.Button();
      this.popUp1.SuspendLayout();
      this.popUp2.SuspendLayout();
      this.SuspendLayout();
       
       
       
      this.listView1.ContextMenuStrip = this.popUp1;
      this.listView1.LabelEdit = true;
      this.listView1.LabelWrap = false;
      this.listView1.Location = new System.Drawing.Point(12, 39);
      this.listView1.Name = "listView1";
      this.listView1.ShowItemToolTips = true;
      this.listView1.Size = new System.Drawing.Size(242, 399);
      this.listView1.SmallImageList = this.imageList1;
      this.listView1.TabIndex = 0;
      this.listView1.UseCompatibleStateImageBehavior = false;
      this.listView1.View = System.Windows.Forms.View.List;
      this.listView1.DoubleClick += new System.EventHandler(this.listView1_DoubleClick);
       
       
       
      this.popUp1.BackColor = System.Drawing.Color.White;
      this.popUp1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.popUp1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.renameToolStripMenuItem,
            this.toolStripSeparator1,
            this.copyToolStripMenuItem,
            this.moveToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.toolStripSeparator2,
            this.newToolStripMenuItem});
      this.popUp1.Name = "popUp1";
      this.popUp1.ShowImageMargin = false;
      this.popUp1.ShowItemToolTips = false;
      this.popUp1.Size = new System.Drawing.Size(93, 148);
      this.popUp1.Opening += new System.ComponentModel.CancelEventHandler(this.popUp1_Opening);
       
       
       
      this.openToolStripMenuItem.Name = "openToolStripMenuItem";
      this.openToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
      this.openToolStripMenuItem.Text = "Open";
      this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
       
       
       
      this.renameToolStripMenuItem.Name = "renameToolStripMenuItem";
      this.renameToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
      this.renameToolStripMenuItem.Text = "Rename";
       
       
       
      this.toolStripSeparator1.Name = "toolStripSeparator1";
      this.toolStripSeparator1.Size = new System.Drawing.Size(124, 6);
       
       
       
      this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
      this.copyToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
      this.copyToolStripMenuItem.Text = "Copy";
       
       
       
      this.moveToolStripMenuItem.Name = "moveToolStripMenuItem";
      this.moveToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
      this.moveToolStripMenuItem.Text = "Move";
       
       
       
      this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
      this.deleteToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
      this.deleteToolStripMenuItem.Text = "Delete";
      this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
       
       
       
      this.toolStripSeparator2.Name = "toolStripSeparator2";
      this.toolStripSeparator2.Size = new System.Drawing.Size(124, 6);
       
       
       
      this.newToolStripMenuItem.Name = "newToolStripMenuItem";
      this.newToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
      this.newToolStripMenuItem.Text = "New";
      this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
       
       
       
      this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
      this.imageList1.TransparentColor = System.Drawing.Color.White;
      this.imageList1.Images.SetKeyName(0, "FolderClose.bmp");
       
       
       
      this.listView2.ContextMenuStrip = this.popUp2;
      this.listView2.LabelEdit = true;
      this.listView2.LabelWrap = false;
      this.listView2.Location = new System.Drawing.Point(260, 39);
      this.listView2.Name = "listView2";
      this.listView2.ShowItemToolTips = true;
      this.listView2.Size = new System.Drawing.Size(242, 399);
      this.listView2.SmallImageList = this.imageList1;
      this.listView2.TabIndex = 1;
      this.listView2.UseCompatibleStateImageBehavior = false;
      this.listView2.View = System.Windows.Forms.View.List;
      this.listView2.DoubleClick += new System.EventHandler(this.listView2_DoubleClick);
       
       
       
      this.popUp2.BackColor = System.Drawing.Color.White;
      this.popUp2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.popUp2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.toolStripSeparator3,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4,
            this.toolStripMenuItem5,
            this.toolStripSeparator4,
            this.toolStripMenuItem6});
      this.popUp2.Name = "popUp1";
      this.popUp2.ShowImageMargin = false;
      this.popUp2.ShowItemToolTips = false;
      this.popUp2.Size = new System.Drawing.Size(93, 148);
      this.popUp2.Opening += new System.ComponentModel.CancelEventHandler(this.popUp2_Opening);
       
       
       
      this.toolStripMenuItem1.Name = "toolStripMenuItem1";
      this.toolStripMenuItem1.Size = new System.Drawing.Size(92, 22);
      this.toolStripMenuItem1.Text = "Open";
      this.toolStripMenuItem1.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
       
       
       
      this.toolStripMenuItem2.Name = "toolStripMenuItem2";
      this.toolStripMenuItem2.Size = new System.Drawing.Size(92, 22);
      this.toolStripMenuItem2.Text = "Rename";
       
       
       
      this.toolStripSeparator3.Name = "toolStripSeparator3";
      this.toolStripSeparator3.Size = new System.Drawing.Size(89, 6);
       
       
       
      this.toolStripMenuItem3.Name = "toolStripMenuItem3";
      this.toolStripMenuItem3.Size = new System.Drawing.Size(92, 22);
      this.toolStripMenuItem3.Text = "Copy";
       
       
       
      this.toolStripMenuItem4.Name = "toolStripMenuItem4";
      this.toolStripMenuItem4.Size = new System.Drawing.Size(92, 22);
      this.toolStripMenuItem4.Text = "Move";
       
       
       
      this.toolStripMenuItem5.Name = "toolStripMenuItem5";
      this.toolStripMenuItem5.Size = new System.Drawing.Size(92, 22);
      this.toolStripMenuItem5.Text = "Delete";
      this.toolStripMenuItem5.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
       
       
       
      this.toolStripSeparator4.Name = "toolStripSeparator4";
      this.toolStripSeparator4.Size = new System.Drawing.Size(89, 6);
       
       
       
      this.toolStripMenuItem6.Name = "toolStripMenuItem6";
      this.toolStripMenuItem6.Size = new System.Drawing.Size(127, 22);
      this.toolStripMenuItem6.Text = "New";
      this.toolStripMenuItem6.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
       
       
       
      this.lbStatus1.BackColor = System.Drawing.Color.White;
      this.lbStatus1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.lbStatus1.Location = new System.Drawing.Point(12, 441);
      this.lbStatus1.Name = "lbStatus1";
      this.lbStatus1.Size = new System.Drawing.Size(242, 23);
      this.lbStatus1.TabIndex = 2;
      this.lbStatus1.Text = "label1";
      this.lbStatus1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
       
       
       
      this.lbStatus2.BackColor = System.Drawing.Color.White;
      this.lbStatus2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.lbStatus2.Location = new System.Drawing.Point(260, 441);
      this.lbStatus2.Name = "lbStatus2";
      this.lbStatus2.Size = new System.Drawing.Size(242, 23);
      this.lbStatus2.TabIndex = 3;
      this.lbStatus2.Text = "label2";
      this.lbStatus2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
       
       
       
      this.cmbDrive1.BackColor = System.Drawing.Color.White;
      this.cmbDrive1.FormattingEnabled = true;
      this.cmbDrive1.Location = new System.Drawing.Point(49, 12);
      this.cmbDrive1.Name = "cmbDrive1";
      this.cmbDrive1.Size = new System.Drawing.Size(205, 21);
      this.cmbDrive1.TabIndex = 4;
      this.cmbDrive1.SelectedIndexChanged += new System.EventHandler(this.cmbDrive1_SelectedIndexChanged);
       
       
       
      this.cmbDrive2.BackColor = System.Drawing.Color.White;
      this.cmbDrive2.FormattingEnabled = true;
      this.cmbDrive2.Location = new System.Drawing.Point(297, 12);
      this.cmbDrive2.Name = "cmbDrive2";
      this.cmbDrive2.Size = new System.Drawing.Size(205, 21);
      this.cmbDrive2.TabIndex = 5;
      this.cmbDrive2.SelectedIndexChanged += new System.EventHandler(this.cmbDrive2_SelectedIndexChanged);
       
       
       
      this.bBack1.Location = new System.Drawing.Point(12, 10);
      this.bBack1.Name = "bBack1";
      this.bBack1.Size = new System.Drawing.Size(31, 23);
      this.bBack1.TabIndex = 6;
      this.bBack1.Text = "<--";
      this.bBack1.UseVisualStyleBackColor = true;
      this.bBack1.Click += new System.EventHandler(this.bBack1_Click);
       
       
       
      this.bBack2.Location = new System.Drawing.Point(260, 10);
      this.bBack2.Name = "bBack2";
      this.bBack2.Size = new System.Drawing.Size(31, 23);
      this.bBack2.TabIndex = 7;
      this.bBack2.Text = "<--";
      this.bBack2.UseVisualStyleBackColor = true;
      this.bBack2.Click += new System.EventHandler(this.bBack2_Click);
       
       
       
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(697, 531);
      this.Controls.Add(this.bBack2);
      this.Controls.Add(this.bBack1);
      this.Controls.Add(this.cmbDrive2);
      this.Controls.Add(this.cmbDrive1);
      this.Controls.Add(this.lbStatus2);
      this.Controls.Add(this.lbStatus1);
      this.Controls.Add(this.listView2);
      this.Controls.Add(this.listView1);
      this.DoubleBuffered = true;
      this.MinimumSize = new System.Drawing.Size(500, 300);
      this.Name = "Form1";
      this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
      this.Text = "MASA - Explorer";
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
      this.Resize += new System.EventHandler(this.Form1_Resize);
      this.popUp1.ResumeLayout(false);
      this.popUp2.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.ListView listView1;
    private System.Windows.Forms.ListView listView2;
    private System.Windows.Forms.Label lbStatus1;
    private System.Windows.Forms.Label lbStatus2;
    private System.Windows.Forms.ComboBox cmbDrive1;
    private System.Windows.Forms.ComboBox cmbDrive2;
    private System.Windows.Forms.Button bBack1;
    private System.Windows.Forms.Button bBack2;
    private System.Windows.Forms.ImageList imageList1;
    private System.Windows.Forms.ContextMenuStrip popUp1;
    private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem renameToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem moveToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
    private System.Windows.Forms.ContextMenuStrip popUp2;
    private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
    private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
    private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
    private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
    private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
    private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;


  }
}

