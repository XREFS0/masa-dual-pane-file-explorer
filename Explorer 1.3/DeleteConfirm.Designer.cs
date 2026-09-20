namespace Explorer
{
  partial class DeleteConfirm
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
      this.label1 = new System.Windows.Forms.Label();
      this.bYes = new System.Windows.Forms.Button();
      this.bNo = new System.Windows.Forms.Button();
      this.SuspendLayout();
       
       
       
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.Location = new System.Drawing.Point(39, 32);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(237, 15);
      this.label1.TabIndex = 0;
      this.label1.Text = "Are you sure to proceed delete operation ?";
      this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
       
       
       
      this.bYes.DialogResult = System.Windows.Forms.DialogResult.Yes;
      this.bYes.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.bYes.Location = new System.Drawing.Point(171, 71);
      this.bYes.Name = "bYes";
      this.bYes.Size = new System.Drawing.Size(75, 23);
      this.bYes.TabIndex = 1;
      this.bYes.Text = "Yes";
      this.bYes.UseVisualStyleBackColor = true;
       
       
       
      this.bNo.DialogResult = System.Windows.Forms.DialogResult.No;
      this.bNo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.bNo.Location = new System.Drawing.Point(252, 71);
      this.bNo.Name = "bNo";
      this.bNo.Size = new System.Drawing.Size(75, 23);
      this.bNo.TabIndex = 2;
      this.bNo.Text = "No";
      this.bNo.UseVisualStyleBackColor = true;
       
       
       
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(330, 97);
      this.Controls.Add(this.bNo);
      this.Controls.Add(this.bYes);
      this.Controls.Add(this.label1);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "DeleteConfirm";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
      this.Text = "MASA - Delete Confirmation";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Button bYes;
    private System.Windows.Forms.Button bNo;
  }
}