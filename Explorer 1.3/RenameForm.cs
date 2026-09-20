using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Explorer
{
  public partial class RenameForm : Form
  {
    public string OldName
    {
      get { return lbOldName.Text; }
      set { lbOldName.Text = value; }
    }

    public string NewName
    {
      get { return txNewName.Text; }
      set { txNewName.Text = value; }
    }

    public RenameForm()
    {
      InitializeComponent();
      lbOldName.Text = "";
      txNewName.Text = "";
    }

    private void RenameForm_Shown(object sender, EventArgs e)
    {
      txNewName.Text = "";
      txNewName.Focus();
    }


  } 
}
