
namespace VehicleManagementSystem.Forms
{
  partial class frmEmployees
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
      this.listVehicleCategory = new System.Windows.Forms.ListView();
      this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.btnSave = new System.Windows.Forms.Button();
      this.btnUpdate = new System.Windows.Forms.Button();
      this.btnClear = new System.Windows.Forms.Button();
      this.label1 = new System.Windows.Forms.Label();
      this.txtName = new System.Windows.Forms.TextBox();
      this.btnClose = new System.Windows.Forms.Button();
      this.label2 = new System.Windows.Forms.Label();
      this.txtNic = new System.Windows.Forms.TextBox();
      this.label3 = new System.Windows.Forms.Label();
      this.txtSalary = new System.Windows.Forms.TextBox();
      this.label4 = new System.Windows.Forms.Label();
      this.label5 = new System.Windows.Forms.Label();
      this.cmbEmpType = new System.Windows.Forms.ComboBox();
      this.cmbSalType = new System.Windows.Forms.ComboBox();
      this.label6 = new System.Windows.Forms.Label();
      this.txtPhone = new System.Windows.Forms.TextBox();
      this.SuspendLayout();
      // 
      // listVehicleCategory
      // 
      this.listVehicleCategory.Activation = System.Windows.Forms.ItemActivation.OneClick;
      this.listVehicleCategory.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
      this.listVehicleCategory.FullRowSelect = true;
      this.listVehicleCategory.GridLines = true;
      this.listVehicleCategory.HideSelection = false;
      this.listVehicleCategory.Location = new System.Drawing.Point(21, 197);
      this.listVehicleCategory.MultiSelect = false;
      this.listVehicleCategory.Name = "listVehicleCategory";
      this.listVehicleCategory.Size = new System.Drawing.Size(635, 168);
      this.listVehicleCategory.TabIndex = 28;
      this.listVehicleCategory.UseCompatibleStateImageBehavior = false;
      this.listVehicleCategory.View = System.Windows.Forms.View.Details;
      this.listVehicleCategory.SelectedIndexChanged += new System.EventHandler(this.listVehicleCategory_SelectedIndexChanged);
      // 
      // columnHeader1
      // 
      this.columnHeader1.Text = "Id";
      // 
      // columnHeader2
      // 
      this.columnHeader2.Text = "Name";
      this.columnHeader2.Width = 150;
      // 
      // columnHeader3
      // 
      this.columnHeader3.Text = "NIC";
      this.columnHeader3.Width = 100;
      // 
      // columnHeader4
      // 
      this.columnHeader4.Text = "Phone";
      this.columnHeader4.Width = 100;
      // 
      // columnHeader5
      // 
      this.columnHeader5.Text = "Emp Type";
      this.columnHeader5.Width = 100;
      // 
      // columnHeader6
      // 
      this.columnHeader6.Text = "SalaryTpe";
      // 
      // columnHeader7
      // 
      this.columnHeader7.Text = "Salary";
      // 
      // btnSave
      // 
      this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnSave.Location = new System.Drawing.Point(565, 144);
      this.btnSave.Name = "btnSave";
      this.btnSave.Size = new System.Drawing.Size(77, 23);
      this.btnSave.TabIndex = 27;
      this.btnSave.Text = "&Save";
      this.btnSave.UseVisualStyleBackColor = true;
      this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
      // 
      // btnUpdate
      // 
      this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnUpdate.Location = new System.Drawing.Point(564, 144);
      this.btnUpdate.Name = "btnUpdate";
      this.btnUpdate.Size = new System.Drawing.Size(75, 23);
      this.btnUpdate.TabIndex = 26;
      this.btnUpdate.Text = "&Update";
      this.btnUpdate.UseVisualStyleBackColor = true;
      this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
      // 
      // btnClear
      // 
      this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnClear.Location = new System.Drawing.Point(484, 144);
      this.btnClear.Name = "btnClear";
      this.btnClear.Size = new System.Drawing.Size(75, 23);
      this.btnClear.TabIndex = 25;
      this.btnClear.Text = "&Clear";
      this.btnClear.UseVisualStyleBackColor = true;
      this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.Location = new System.Drawing.Point(18, 42);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(51, 16);
      this.label1.TabIndex = 24;
      this.label1.Text = "Name :";
      // 
      // txtName
      // 
      this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtName.Location = new System.Drawing.Point(141, 39);
      this.txtName.Name = "txtName";
      this.txtName.Size = new System.Drawing.Size(176, 22);
      this.txtName.TabIndex = 23;
      // 
      // btnClose
      // 
      this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnClose.Location = new System.Drawing.Point(581, 387);
      this.btnClose.Name = "btnClose";
      this.btnClose.Size = new System.Drawing.Size(75, 23);
      this.btnClose.TabIndex = 22;
      this.btnClose.Text = "&Close";
      this.btnClose.UseVisualStyleBackColor = true;
      this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label2.Location = new System.Drawing.Point(339, 42);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(36, 16);
      this.label2.TabIndex = 30;
      this.label2.Text = "NIC :";
      // 
      // txtNic
      // 
      this.txtNic.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtNic.Location = new System.Drawing.Point(462, 39);
      this.txtNic.Name = "txtNic";
      this.txtNic.Size = new System.Drawing.Size(176, 22);
      this.txtNic.TabIndex = 29;
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label3.Location = new System.Drawing.Point(339, 101);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(53, 16);
      this.label3.TabIndex = 32;
      this.label3.Text = "Salary :";
      // 
      // txtSalary
      // 
      this.txtSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtSalary.Location = new System.Drawing.Point(462, 98);
      this.txtSalary.Name = "txtSalary";
      this.txtSalary.Size = new System.Drawing.Size(176, 22);
      this.txtSalary.TabIndex = 31;
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label4.Location = new System.Drawing.Point(339, 71);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(111, 16);
      this.label4.TabIndex = 33;
      this.label4.Text = "Employee Type :";
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label5.Location = new System.Drawing.Point(17, 95);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(88, 16);
      this.label5.TabIndex = 34;
      this.label5.Text = "Salary Type :";
      // 
      // cmbEmpType
      // 
      this.cmbEmpType.FormattingEnabled = true;
      this.cmbEmpType.Items.AddRange(new object[] {
            "Permanent",
            "Temporary"});
      this.cmbEmpType.Location = new System.Drawing.Point(462, 71);
      this.cmbEmpType.Name = "cmbEmpType";
      this.cmbEmpType.Size = new System.Drawing.Size(176, 21);
      this.cmbEmpType.TabIndex = 35;
      // 
      // cmbSalType
      // 
      this.cmbSalType.FormattingEnabled = true;
      this.cmbSalType.Items.AddRange(new object[] {
            "Daily",
            "Monthly"});
      this.cmbSalType.Location = new System.Drawing.Point(141, 96);
      this.cmbSalType.Name = "cmbSalType";
      this.cmbSalType.Size = new System.Drawing.Size(176, 21);
      this.cmbSalType.TabIndex = 36;
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label6.Location = new System.Drawing.Point(18, 71);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(53, 16);
      this.label6.TabIndex = 37;
      this.label6.Text = "Phone :";
      // 
      // txtPhone
      // 
      this.txtPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtPhone.Location = new System.Drawing.Point(141, 67);
      this.txtPhone.Name = "txtPhone";
      this.txtPhone.Size = new System.Drawing.Size(176, 22);
      this.txtPhone.TabIndex = 38;
      // 
      // frmEmployees
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(668, 429);
      this.Controls.Add(this.txtPhone);
      this.Controls.Add(this.label6);
      this.Controls.Add(this.cmbSalType);
      this.Controls.Add(this.cmbEmpType);
      this.Controls.Add(this.label5);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.txtSalary);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.txtNic);
      this.Controls.Add(this.listVehicleCategory);
      this.Controls.Add(this.btnSave);
      this.Controls.Add(this.btnUpdate);
      this.Controls.Add(this.btnClear);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.txtName);
      this.Controls.Add(this.btnClose);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "frmEmployees";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Employees";
      this.Load += new System.EventHandler(this.frmEmployees_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.ListView listVehicleCategory;
    private System.Windows.Forms.ColumnHeader columnHeader1;
    private System.Windows.Forms.ColumnHeader columnHeader2;
    private System.Windows.Forms.Button btnSave;
    private System.Windows.Forms.Button btnUpdate;
    private System.Windows.Forms.Button btnClear;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox txtName;
    private System.Windows.Forms.Button btnClose;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox txtNic;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TextBox txtSalary;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.ComboBox cmbEmpType;
    private System.Windows.Forms.ComboBox cmbSalType;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.TextBox txtPhone;
    private System.Windows.Forms.ColumnHeader columnHeader3;
    private System.Windows.Forms.ColumnHeader columnHeader4;
    private System.Windows.Forms.ColumnHeader columnHeader5;
    private System.Windows.Forms.ColumnHeader columnHeader6;
    private System.Windows.Forms.ColumnHeader columnHeader7;
  }
}