namespace Explorer
{
  partial class RenameForm
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
      this.lbOldName = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.txNewName = new System.Windows.Forms.TextBox();
      this.bOK = new System.Windows.Forms.Button();
      this.bCancel = new System.Windows.Forms.Button();
      this.SuspendLayout();
       
       
       
      this.lbOldName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.lbOldName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lbOldName.Location = new System.Drawing.Point(87, 9);
      this.lbOldName.Name = "lbOldName";
      this.lbOldName.Size = new System.Drawing.Size(190, 23);
      this.lbOldName.TabIndex = 0;
      this.lbOldName.Text = "OldName";
      this.lbOldName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
       
       
       
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.Location = new System.Drawing.Point(12, 13);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(41, 15);
      this.label1.TabIndex = 1;
      this.label1.Text = "Name";
       
       
       
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label2.Location = new System.Drawing.Point(12, 38);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(55, 15);
      this.label2.TabIndex = 2;
      this.label2.Text = "Rename";
       
       
       
      this.txNewName.BackColor = System.Drawing.Color.White;
      this.txNewName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txNewName.Location = new System.Drawing.Point(87, 35);
      this.txNewName.Name = "txNewName";
      this.txNewName.Size = new System.Drawing.Size(190, 21);
      this.txNewName.TabIndex = 3;
       
       
       
      this.bOK.DialogResult = System.Windows.Forms.DialogResult.OK;
      this.bOK.Location = new System.Drawing.Point(124, 62);
      this.bOK.Name = "bOK";
      this.bOK.Size = new System.Drawing.Size(75, 23);
      this.bOK.TabIndex = 4;
      this.bOK.Text = "OK";
      this.bOK.UseVisualStyleBackColor = true;
       
       
       
      this.bCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.bCancel.Location = new System.Drawing.Point(205, 62);
      this.bCancel.Name = "bCancel";
      this.bCancel.Size = new System.Drawing.Size(75, 23);
      this.bCancel.TabIndex = 5;
      this.bCancel.Text = "Cancel";
      this.bCancel.UseVisualStyleBackColor = true;
       
       
       
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(292, 92);
      this.Controls.Add(this.bCancel);
      this.Controls.Add(this.bOK);
      this.Controls.Add(this.txNewName);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.lbOldName);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "RenameForm";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
      this.Text = "MASA - Rename Folder Or File";
      this.Shown += new System.EventHandler(this.RenameForm_Shown);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label lbOldName;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox txNewName;
    private System.Windows.Forms.Button bOK;
    private System.Windows.Forms.Button bCancel;
  }
}