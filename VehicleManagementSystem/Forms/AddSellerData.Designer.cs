
namespace VehicleManagementSystem.Forms
{
  partial class frmAddSellerData
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.btnClose = new System.Windows.Forms.Button();
      this.btnSave = new System.Windows.Forms.Button();
      this.label14 = new System.Windows.Forms.Label();
      this.label10 = new System.Windows.Forms.Label();
      this.label6 = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      this.txtName = new System.Windows.Forms.TextBox();
      this.txtPhone = new System.Windows.Forms.TextBox();
      this.txtAddress = new System.Windows.Forms.TextBox();
      this.cmbType = new System.Windows.Forms.ComboBox();
      this.label2 = new System.Windows.Forms.Label();
      this.lblRegNum = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // btnClose
      // 
      this.btnClose.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnClose.Location = new System.Drawing.Point(231, 153);
      this.btnClose.Name = "btnClose";
      this.btnClose.Size = new System.Drawing.Size(75, 23);
      this.btnClose.TabIndex = 0;
      this.btnClose.Text = "&Close";
      this.btnClose.UseVisualStyleBackColor = true;
      this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
      // 
      // btnSave
      // 
      this.btnSave.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnSave.Location = new System.Drawing.Point(150, 153);
      this.btnSave.Name = "btnSave";
      this.btnSave.Size = new System.Drawing.Size(75, 23);
      this.btnSave.TabIndex = 1;
      this.btnSave.Text = "&Save";
      this.btnSave.UseVisualStyleBackColor = true;
      this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
      // 
      // label14
      // 
      this.label14.AutoSize = true;
      this.label14.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label14.Location = new System.Drawing.Point(12, 117);
      this.label14.Name = "label14";
      this.label14.Size = new System.Drawing.Size(67, 15);
      this.label14.TabIndex = 42;
      this.label14.Text = "Seller Type";
      // 
      // label10
      // 
      this.label10.AutoSize = true;
      this.label10.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label10.Location = new System.Drawing.Point(12, 90);
      this.label10.Name = "label10";
      this.label10.Size = new System.Drawing.Size(53, 15);
      this.label10.TabIndex = 41;
      this.label10.Text = "Address";
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label6.Location = new System.Drawing.Point(12, 65);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(91, 15);
      this.label6.TabIndex = 40;
      this.label6.Text = "Phone Number";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.Location = new System.Drawing.Point(12, 40);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(76, 15);
      this.label1.TabIndex = 39;
      this.label1.Text = "Seller Name";
      // 
      // txtName
      // 
      this.txtName.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtName.Location = new System.Drawing.Point(150, 38);
      this.txtName.Name = "txtName";
      this.txtName.Size = new System.Drawing.Size(156, 21);
      this.txtName.TabIndex = 43;
      // 
      // txtPhone
      // 
      this.txtPhone.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtPhone.Location = new System.Drawing.Point(150, 65);
      this.txtPhone.Name = "txtPhone";
      this.txtPhone.Size = new System.Drawing.Size(156, 21);
      this.txtPhone.TabIndex = 44;
      // 
      // txtAddress
      // 
      this.txtAddress.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtAddress.Location = new System.Drawing.Point(150, 91);
      this.txtAddress.Name = "txtAddress";
      this.txtAddress.Size = new System.Drawing.Size(156, 21);
      this.txtAddress.TabIndex = 45;
      // 
      // cmbType
      // 
      this.cmbType.FormattingEnabled = true;
      this.cmbType.Items.AddRange(new object[] {
            "Individual",
            "Car Sale",
            "Auction"});
      this.cmbType.Location = new System.Drawing.Point(150, 117);
      this.cmbType.Name = "cmbType";
      this.cmbType.Size = new System.Drawing.Size(156, 21);
      this.cmbType.TabIndex = 46;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label2.Location = new System.Drawing.Point(12, 15);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(122, 15);
      this.label2.TabIndex = 47;
      this.label2.Text = "Registration Number";
      // 
      // lblRegNum
      // 
      this.lblRegNum.AutoSize = true;
      this.lblRegNum.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblRegNum.Location = new System.Drawing.Point(147, 15);
      this.lblRegNum.Name = "lblRegNum";
      this.lblRegNum.Size = new System.Drawing.Size(19, 15);
      this.lblRegNum.TabIndex = 48;
      this.lblRegNum.Text = "---";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(231, 13);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(35, 13);
      this.label3.TabIndex = 49;
      this.label3.Text = "label3";
      // 
      // frmAddSellerData
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(334, 193);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.lblRegNum);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.cmbType);
      this.Controls.Add(this.txtAddress);
      this.Controls.Add(this.txtPhone);
      this.Controls.Add(this.txtName);
      this.Controls.Add(this.label14);
      this.Controls.Add(this.label10);
      this.Controls.Add(this.label6);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.btnSave);
      this.Controls.Add(this.btnClose);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "frmAddSellerData";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "AddSellerData";
      this.Load += new System.EventHandler(this.frmAddSellerData_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button btnClose;
    private System.Windows.Forms.Button btnSave;
    private System.Windows.Forms.Label label14;
    private System.Windows.Forms.Label label10;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox txtName;
    private System.Windows.Forms.TextBox txtPhone;
    private System.Windows.Forms.TextBox txtAddress;
    private System.Windows.Forms.ComboBox cmbType;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label lblRegNum;
    private System.Windows.Forms.Label label3;
  }
}