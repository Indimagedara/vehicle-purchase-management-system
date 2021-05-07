
namespace VehicleManagementSystem.Forms
{
  partial class frmContractor
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
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.txtName = new System.Windows.Forms.TextBox();
      this.txtPhone = new System.Windows.Forms.TextBox();
      this.txtNic = new System.Windows.Forms.TextBox();
      this.cmbType = new System.Windows.Forms.ComboBox();
      this.btnSave = new System.Windows.Forms.Button();
      this.btnUpdate = new System.Windows.Forms.Button();
      this.btnClear = new System.Windows.Forms.Button();
      this.listContractors = new System.Windows.Forms.ListView();
      this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.btnDelete = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(30, 36);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(47, 17);
      this.label1.TabIndex = 0;
      this.label1.Text = "Name";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(30, 70);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(50, 17);
      this.label2.TabIndex = 1;
      this.label2.Text = "Phone";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(30, 105);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(32, 17);
      this.label3.TabIndex = 2;
      this.label3.Text = "NIC";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(30, 139);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(39, 17);
      this.label4.TabIndex = 3;
      this.label4.Text = "Type";
      // 
      // txtName
      // 
      this.txtName.Location = new System.Drawing.Point(99, 28);
      this.txtName.Name = "txtName";
      this.txtName.Size = new System.Drawing.Size(344, 25);
      this.txtName.TabIndex = 4;
      // 
      // txtPhone
      // 
      this.txtPhone.Location = new System.Drawing.Point(99, 62);
      this.txtPhone.Name = "txtPhone";
      this.txtPhone.Size = new System.Drawing.Size(344, 25);
      this.txtPhone.TabIndex = 5;
      // 
      // txtNic
      // 
      this.txtNic.Location = new System.Drawing.Point(99, 97);
      this.txtNic.Name = "txtNic";
      this.txtNic.Size = new System.Drawing.Size(344, 25);
      this.txtNic.TabIndex = 6;
      // 
      // cmbType
      // 
      this.cmbType.FormattingEnabled = true;
      this.cmbType.Items.AddRange(new object[] {
            "Paint",
            "Tinker",
            "Mechanic"});
      this.cmbType.Location = new System.Drawing.Point(99, 132);
      this.cmbType.Name = "cmbType";
      this.cmbType.Size = new System.Drawing.Size(344, 25);
      this.cmbType.TabIndex = 7;
      // 
      // btnSave
      // 
      this.btnSave.Location = new System.Drawing.Point(461, 27);
      this.btnSave.Name = "btnSave";
      this.btnSave.Size = new System.Drawing.Size(86, 27);
      this.btnSave.TabIndex = 8;
      this.btnSave.Text = "&Save";
      this.btnSave.UseVisualStyleBackColor = true;
      this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
      // 
      // btnUpdate
      // 
      this.btnUpdate.Location = new System.Drawing.Point(461, 60);
      this.btnUpdate.Name = "btnUpdate";
      this.btnUpdate.Size = new System.Drawing.Size(86, 27);
      this.btnUpdate.TabIndex = 9;
      this.btnUpdate.Text = "&Update";
      this.btnUpdate.UseVisualStyleBackColor = true;
      this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
      // 
      // btnClear
      // 
      this.btnClear.Location = new System.Drawing.Point(461, 130);
      this.btnClear.Name = "btnClear";
      this.btnClear.Size = new System.Drawing.Size(86, 27);
      this.btnClear.TabIndex = 10;
      this.btnClear.Text = "&Clear";
      this.btnClear.UseVisualStyleBackColor = true;
      this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
      // 
      // listContractors
      // 
      this.listContractors.Activation = System.Windows.Forms.ItemActivation.OneClick;
      this.listContractors.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
      this.listContractors.FullRowSelect = true;
      this.listContractors.GridLines = true;
      this.listContractors.HideSelection = false;
      this.listContractors.Location = new System.Drawing.Point(33, 194);
      this.listContractors.MultiSelect = false;
      this.listContractors.Name = "listContractors";
      this.listContractors.Size = new System.Drawing.Size(514, 382);
      this.listContractors.TabIndex = 29;
      this.listContractors.UseCompatibleStateImageBehavior = false;
      this.listContractors.View = System.Windows.Forms.View.Details;
      this.listContractors.SelectedIndexChanged += new System.EventHandler(this.listContractors_SelectedIndexChanged);
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
      this.columnHeader5.Text = "Con. Type";
      this.columnHeader5.Width = 100;
      // 
      // btnDelete
      // 
      this.btnDelete.Location = new System.Drawing.Point(461, 93);
      this.btnDelete.Name = "btnDelete";
      this.btnDelete.Size = new System.Drawing.Size(86, 27);
      this.btnDelete.TabIndex = 30;
      this.btnDelete.Text = "&Delete";
      this.btnDelete.UseVisualStyleBackColor = true;
      this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
      // 
      // frmContractor
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(572, 601);
      this.Controls.Add(this.btnDelete);
      this.Controls.Add(this.listContractors);
      this.Controls.Add(this.btnClear);
      this.Controls.Add(this.btnUpdate);
      this.Controls.Add(this.btnSave);
      this.Controls.Add(this.cmbType);
      this.Controls.Add(this.txtNic);
      this.Controls.Add(this.txtPhone);
      this.Controls.Add(this.txtName);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "frmContractor";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Contractor";
      this.Load += new System.EventHandler(this.frmContractor_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.TextBox txtName;
    private System.Windows.Forms.TextBox txtPhone;
    private System.Windows.Forms.TextBox txtNic;
    private System.Windows.Forms.ComboBox cmbType;
    private System.Windows.Forms.Button btnSave;
    private System.Windows.Forms.Button btnUpdate;
    private System.Windows.Forms.Button btnClear;
    private System.Windows.Forms.ListView listContractors;
    private System.Windows.Forms.ColumnHeader columnHeader1;
    private System.Windows.Forms.ColumnHeader columnHeader2;
    private System.Windows.Forms.ColumnHeader columnHeader3;
    private System.Windows.Forms.ColumnHeader columnHeader4;
    private System.Windows.Forms.ColumnHeader columnHeader5;
    private System.Windows.Forms.Button btnDelete;
  }
}