using System;
using System.IO;
using System.Diagnostics;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using IWshRuntimeLibrary;

namespace Explorer
{
    public partial class Form1 : Form
  {
    #region Variables Declare

    private  FileSystemObject fso = new FileSystemObject();
    private DriveInfo[] allDrives = DriveInfo.GetDrives();
    private Hashtable hFileExt = new Hashtable();
    private int foldercount1, foldercount2;
    private int filecount1, filecount2;
    private long filesize1, filesize2;
    private int index = 1;
    public string path1, path2;
    private int activePopUp;

    #endregion

    #region Form Setup

    public Form1()
    {
      InitializeComponent();
      this.SetBounds(100, 100, 700, 500);
      int w = this.ClientSize.Width / 2;
      int h = this.ClientSize.Height - 49;
      bBack1.SetBounds(0, 0, 30, 21);
      cmbDrive1.SetBounds(32, 0, w - 33, 21);
      listView1.SetBounds(0, 23, w - 1, h);
      lbStatus1.SetBounds(0, this.ClientSize.Height - 24, w - 1, 24);
      bBack2.SetBounds(w + 1, 0, 30, 21);
      cmbDrive2.SetBounds(w + 33, 0, w - 33, 21);
      listView2.SetBounds(w + 1, 23, w - 1, h);
      lbStatus2.SetBounds(w + 1, this.ClientSize.Height - 24, w - 1, 24);
      foreach (DriveInfo di in allDrives)
      {
        if (di.IsReady)
        {
          cmbDrive1.Items.Add(di.ToString());
          cmbDrive2.Items.Add(di.ToString());
        }
      }
      path1 = "C:\\"; cmbDrive1.Text = path1;
      path2 = "D:\\"; cmbDrive2.Text = path2;
    }

    private void Form1_Resize(object sender, EventArgs e)
    {
      int w = this.ClientSize.Width / 2;
      int h = this.ClientSize.Height - 49;
      cmbDrive1.Width = w - 33;
      listView1.Width = w - 1; listView1.Height = h;
      lbStatus1.Top = this.ClientSize.Height - 24;
      lbStatus1.Width = w - 1;
      bBack2.Left = w + 1;
      cmbDrive2.Left = w + 33; cmbDrive2.Width = w - 33;
      listView2.SetBounds(w + 1, 23, w - 1, h);
      lbStatus2.SetBounds(w + 1, this.ClientSize.Height - 24, w - 1, 24);
    }

    private void Form1_FormClosing(object sender, FormClosingEventArgs e)
    {
      Marshal.ReleaseComObject(fso);
    }

    #endregion

    #region ComboDrivesBox Events

    private void cmbDrive1_SelectedIndexChanged(object sender, EventArgs e)
    {
      path1 = cmbDrive1.Text; ScanFolder(1, path1); listView1.Focus();
      lbStatus1.Text = string.Format("Folders:{0}, Files:{1}, Size:{2}", foldercount1, filecount1,
        SizeFilesToString(filesize1));
    }

    private void cmbDrive2_SelectedIndexChanged(object sender, EventArgs e)
    {
      path2 = cmbDrive2.Text; ScanFolder(2, path2); listView2.Focus();
      lbStatus2.Text = string.Format("Folders:{0}, Files:{1}, Size:{2}", foldercount2, filecount2,
        SizeFilesToString(filesize2));
    }

    #endregion

    #region ListView Events 
     
    private void listView1_DoubleClick(object sender, EventArgs e)
    {
      int i= listView1.SelectedIndices[0];
      if (i < foldercount1)
      {
        path1 = path1 + "\\" + listView1.SelectedItems[0].Text;
        cmbDrive1.Text = path1; ScanFolder(1, path1);
        lbStatus1.Text = string.Format("Folders:{0}, Files:{1}, Size:{2}", foldercount1, filecount1,
          SizeFilesToString(filesize1));
      }
      else
      {
        try
        {
          Process proc = new Process();
          proc.EnableRaisingEvents = false;
          proc.StartInfo.FileName = path1 + "\\" + listView1.SelectedItems[0].Text;
          proc.Start(); proc.Close();
        }
        catch
        {
          MessageBox.Show("No application associated with this type file", "Error type file");
        }
      }
    }

    private void listView2_DoubleClick(object sender, EventArgs e)
    {
      int i = listView2.SelectedIndices[0];
      if (i < foldercount2)
      {
        path2 = path2 + "\\" + listView2.SelectedItems[0].Text;
        cmbDrive2.Text = path2; ScanFolder(2, path2);
        lbStatus2.Text = string.Format("Folders:{0}, Files:{1}, Size:{2}", foldercount2, filecount2, 
          SizeFilesToString(filesize2));
      }
      else
      {
        try
        {
          Process proc = new Process();
          proc.EnableRaisingEvents = false;
          proc.StartInfo.FileName = path2 + "\\" + listView2.SelectedItems[0].Text;
          proc.Start(); proc.Close();
        }
        catch
        {
          MessageBox.Show("No application associated with this type file", "Error type file");
        }
      }
    }

    #endregion

    #region ButtonBack Events

    private void bBack1_Click(object sender, EventArgs e)
    {
      int poz = path1.LastIndexOf('\\');
      if (poz > 2)
      {
        path1 = path1.Substring(0, poz);
        cmbDrive1.Text = path1; ScanFolder(1, path1);
        lbStatus1.Text = string.Format("Folders:{0}, Files:{1}, Size:{2}", foldercount1, filecount1, 
          SizeFilesToString(filesize1));
      }
    }

    private void bBack2_Click(object sender, EventArgs e)
    {
      int poz = path2.LastIndexOf('\\');
      if (poz > 2)
      {
        path2 = path2.Substring(0, poz);
        cmbDrive2.Text = path2; ScanFolder(2, path2);
        lbStatus2.Text = string.Format("Folders:{0}, Files:{1}, Size:{2}", foldercount2, filecount2, 
          SizeFilesToString(filesize2));
      }
    }

    #endregion

    #region PopUpMenu Events
     
     
    private void popUp1_Opening(object sender, CancelEventArgs e)
    {
      activePopUp = 1;
      if (listView1.SelectedIndices.Count == 0)
      {
        popUp1.Items[0].Enabled = false;  
        popUp1.Items[1].Enabled = false;  
        popUp1.Items[3].Enabled = false;  
        popUp1.Items[4].Enabled = false;  
        popUp1.Items[5].Enabled = false;  
        popUp1.Items[7].Enabled = true;   
      }
      else if (listView1.SelectedIndices.Count == 1)
      {
        popUp1.Items[0].Enabled = true;
        popUp1.Items[1].Enabled = true;
        popUp1.Items[3].Enabled = true;
        popUp1.Items[4].Enabled = true;
        popUp1.Items[5].Enabled = true;
        popUp1.Items[7].Enabled = false;
      }
      else
      {
        popUp1.Items[0].Enabled = false;
        popUp1.Items[1].Enabled = false;
        popUp1.Items[3].Enabled = true;
        popUp1.Items[4].Enabled = true;
        popUp1.Items[5].Enabled = true;
        popUp1.Items[7].Enabled = false;
      }
    }

    private void popUp2_Opening(object sender, CancelEventArgs e)
    {
      activePopUp = 2;
      if (listView2.SelectedIndices.Count == 0)
      {
        popUp2.Items[0].Enabled = false;
        popUp2.Items[1].Enabled = false;
        popUp2.Items[3].Enabled = false;
        popUp2.Items[4].Enabled = false;
        popUp2.Items[5].Enabled = false;
        popUp2.Items[7].Enabled = true;
      }
      else if (listView2.SelectedIndices.Count == 1)
      {
        popUp2.Items[0].Enabled = true;
        popUp2.Items[1].Enabled = true;
        popUp2.Items[3].Enabled = true;
        popUp2.Items[4].Enabled = true;
        popUp2.Items[5].Enabled = true;
        popUp2.Items[7].Enabled = false;
      }
      else
      {
        popUp2.Items[0].Enabled = false;
        popUp2.Items[1].Enabled = false;
        popUp2.Items[3].Enabled = true;
        popUp2.Items[4].Enabled = true;
        popUp2.Items[5].Enabled = true;
        popUp2.Items[7].Enabled = false;
      }
    }

    private void openToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (activePopUp == 1)
      {
        int i = listView1.SelectedIndices[0];
        if (i < foldercount1)
        {
          path1 = path1 + "\\" + listView1.SelectedItems[0].Text;
          cmbDrive1.Text = path1; ScanFolder(1, path1);
          lbStatus1.Text = string.Format("Folders:{0}, Files:{1}, Size:{2}", foldercount1, filecount1,
            SizeFilesToString(filesize1));
        }
        else
        {
          try
          {
            Process proc = new Process();
            proc.EnableRaisingEvents = false;
            proc.StartInfo.FileName = path1 + "\\" + listView1.SelectedItems[0].Text;
            proc.Start(); proc.Close();
          }
          catch
          {
            MessageBox.Show("No application associated with this type file", "Error type file");
          }
        }
      }
      else
      {
        int i = listView2.SelectedIndices[0];
        if (i < foldercount2)
        {
          path2 = path2 + "\\" + listView2.SelectedItems[0].Text;
          cmbDrive2.Text = path2; ScanFolder(2, path2);
          lbStatus2.Text = string.Format("Folders:{0}, Files:{1}, Size:{2}", foldercount2, filecount2,
            SizeFilesToString(filesize2));
        }
        else
        {
          try
          {
            Process proc = new Process();
            proc.EnableRaisingEvents = false;
            proc.StartInfo.FileName = path2 + "\\" + listView2.SelectedItems[0].Text;
            proc.Start(); proc.Close();
          }
          catch
          {
            MessageBox.Show("No application associated with this type file", "Error type file");
          }
        }
      }
    }

    private void newToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (activePopUp == 1)
      {
        if (NewFolder(path1 + "\\NewFolder"))
        {
          ScanFolder(1, path1);
          lbStatus1.Text = string.Format("Folders:{0}, Files:{1}, Size:{2}", foldercount1, filecount1,
            SizeFilesToString(filesize1));
        }
      }
      else
      {
        if (NewFolder(path2 + "\\NewFolder"))
        {
          ScanFolder(2, path2);
          lbStatus2.Text = string.Format("Folders:{0}, Files:{1}, Size:{2}", foldercount2, filecount2,
            SizeFilesToString(filesize2));
        }
      }
    }

    private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
    {
      DeleteConfirm frmDeleteConfirm = new DeleteConfirm();
      if (frmDeleteConfirm.ShowDialog() == DialogResult.Yes) Delete();
      frmDeleteConfirm.Dispose();
    }

    #endregion

    #region Methods & Functions Implements
    
     
     
     
     
     
    public void ScanFolder(int n, string path)
    {
      int i = 0;
      Icon IC16;
      DirectoryInfo d = new DirectoryInfo(path);
      DirectoryInfo[] folders = d.GetDirectories();
      FileInfo[] files = d.GetFiles();
      try
      {
        if (n == 1)
        {
          listView1.Clear(); listView1.Cursor = Cursors.WaitCursor;
          foldercount1 = 0;
          foreach (DirectoryInfo di in folders)
          {
            if ((di.Attributes & FileAttributes.Hidden) == 0)
            {
              listView1.Items.Add(di.Name);
              listView1.Items[i].ImageIndex = 0;
              i++; foldercount1++;
            }
          }
          filecount1 = 0; filesize1 = 0;
          Application.DoEvents();
          listView1.BeginUpdate();
          foreach (FileInfo file in files)
          {
            if ((file.Attributes & FileAttributes.Hidden) == 0)
            {
              if (file.Extension == ".exe")
              {
                if (!hFileExt.ContainsKey(file.Name))
                {
                  IC16 = IconExtractor.Extract(file.FullName);
                  imageList1.Images.Add(IC16);
                  hFileExt.Add(file.Name, index);
                  index++;
                }
                listView1.Items.Add(file.Name);
                listView1.Items[i].ImageIndex = (int)hFileExt[file.Name];
              }
              else
              {
                if (!hFileExt.ContainsKey(file.Extension))
                {
                  IC16 = IconExtractor.Extract(file.FullName);
                  imageList1.Images.Add(IC16);
                  hFileExt.Add(file.Extension, index);
                  index++;
                }
                listView1.Items.Add(file.Name);
                listView1.Items[i].ImageIndex = (int)hFileExt[file.Extension];
              }
              listView1.Items[i].ToolTipText = SizeFilesToString(file.Length);
              i++; filecount1++; filesize1 += file.Length;
            }
          }
          listView1.EndUpdate(); listView1.Cursor = Cursors.Default;
        }
        else
        {
          listView2.Clear(); listView2.Cursor = Cursors.WaitCursor;
          foldercount2 = 0;
          foreach (DirectoryInfo di in folders)
          {
            if ((di.Attributes & FileAttributes.Hidden) == 0)
            {
              listView2.Items.Add(di.Name);
              listView2.Items[i].ImageIndex = 0;
              i++; foldercount2++;
            }
          }
          filecount2 = 0; filesize2 = 0;
          Application.DoEvents();
          listView2.BeginUpdate();
          foreach (FileInfo file in files)
          {
            if ((file.Attributes & FileAttributes.Hidden) == 0)
            {
              if (file.Extension == ".exe")
              {
                if (!hFileExt.ContainsKey(file.Name))
                {
                  IC16 = IconExtractor.Extract(file.FullName);
                  imageList1.Images.Add(IC16);
                  hFileExt.Add(file.Name, index);
                  index++;
                }
                listView2.Items.Add(file.Name);
                listView2.Items[i].ImageIndex = (int)hFileExt[file.Name];
              }
              else
              {
                if (!hFileExt.ContainsKey(file.Extension))
                {
                  IC16 = IconExtractor.Extract(file.FullName);
                  imageList1.Images.Add(IC16);
                  hFileExt.Add(file.Extension, index);
                  index++;
                }
                listView2.Items.Add(file.Name);
                listView2.Items[i].ImageIndex = (int)hFileExt[file.Extension];
              }
              listView2.Items[i].ToolTipText = SizeFilesToString(file.Length);
              i++; filecount2++; filesize2 += file.Length;
            }
          }
          listView2.EndUpdate(); listView2.Cursor = Cursors.Default;
        }
      }
      catch { }
    }

     
     
     
     
     
    public long GetFolderSize(string path)
    {
             
            return 100;
    }

     
     
     
     
     
    public long GetFileSize(string path)
    {
      FileInfo f = new FileInfo(path);
      return f.Length;
    }

     
     
     
     
     
     
    public string SizeFilesToString(long a)
    {
      if (a < 1024) return string.Format("{0} bytes", a);
      else if (a < 1048576) return string.Format("{0:0.00} KB", a / 1024.0);
      else if (a < 1073741824) return string.Format("{0:0.00} MB", a / 1048576.0);
      else return string.Format("{0:0.00} GB", a / 1073741824.0);
    }

    public bool NewFolder(string path)
    {
      int i = 0;
      string pth = path;
      try
      {
        while(Directory.Exists(pth))
        {
          i++; pth = path + string.Format("({0})", i);
        }
        DirectoryInfo nd = Directory.CreateDirectory(pth);
        return true;
      }
      catch { return false; }
    }

    public bool Rename(string oldName, string newName)
    {
      try
      {

        return true;
      }
      catch { return false; }
    }

    public bool Delete()
    {
      if (activePopUp == 1)
      {
        foreach (int i in listView1.SelectedIndices)
        {
          try
          {
            if (i < foldercount1) Directory.Delete(path1 + "\\" + listView1.Items[i].Text, true);
            else System.IO.File.Delete(path1 + "\\" + listView1.Items[i].Text);
          }
          catch { }
        }
        ScanFolder(1, path1);
        lbStatus1.Text = string.Format("Folders:{0}, Files:{1}, Size:{2}", foldercount1, filecount1,
            SizeFilesToString(filesize1));
      }
      else
      {
        foreach (int i in listView2.SelectedIndices)
        {
          try
          {
            if (i < foldercount2) Directory.Delete(path2 + "\\" + listView2.Items[i].Text, true);
            else System.IO.File.Delete(path2 + "\\" + listView2.Items[i].Text);
          }
          catch { }
        }
        ScanFolder(2, path2);
        lbStatus2.Text = string.Format("Folders:{0}, Files:{1}, Size:{2}", foldercount2, filecount2,
            SizeFilesToString(filesize2));
      }
      return true;
    }

    #endregion

    
  } 
}
