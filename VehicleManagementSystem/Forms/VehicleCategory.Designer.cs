
namespace VehicleManagementSystem.Forms
{
  partial class frmVehicleCategory
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
      this.btnSave = new System.Windows.Forms.Button();
      this.btnUpdate = new System.Windows.Forms.Button();
      this.btnClear = new System.Windows.Forms.Button();
      this.label1 = new System.Windows.Forms.Label();
      this.txtCategory = new System.Windows.Forms.TextBox();
      this.btnClose = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // listVehicleCategory
      // 
      this.listVehicleCategory.Activation = System.Windows.Forms.ItemActivation.OneClick;
      this.listVehicleCategory.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
      this.listVehicleCategory.FullRowSelect = true;
      this.listVehicleCategory.GridLines = true;
      this.listVehicleCategory.HideSelection = false;
      this.listVehicleCategory.Location = new System.Drawing.Point(44, 143);
      this.listVehicleCategory.MultiSelect = false;
      this.listVehicleCategory.Name = "listVehicleCategory";
      this.listVehicleCategory.Size = new System.Drawing.Size(267, 168);
      this.listVehicleCategory.TabIndex = 21;
      this.listVehicleCategory.UseCompatibleStateImageBehavior = false;
      this.listVehicleCategory.View = System.Windows.Forms.View.Details;
      this.listVehicleCategory.SelectedIndexChanged += new System.EventHandler(this.listVehicleCategory_SelectedIndexChanged);
      // 
      // columnHeader1
      // 
      this.columnHeader1.Text = "Id";
      this.columnHeader1.Width = 100;
      // 
      // columnHeader2
      // 
      this.columnHeader2.Text = "Vehicle Category";
      this.columnHeader2.Width = 150;
      // 
      // btnSave
      // 
      this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnSave.Location = new System.Drawing.Point(235, 93);
      this.btnSave.Name = "btnSave";
      this.btnSave.Size = new System.Drawing.Size(75, 23);
      this.btnSave.TabIndex = 20;
      this.btnSave.Text = "&Save";
      this.btnSave.UseVisualStyleBackColor = true;
      this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
      // 
      // btnUpdate
      // 
      this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnUpdate.Location = new System.Drawing.Point(235, 93);
      this.btnUpdate.Name = "btnUpdate";
      this.btnUpdate.Size = new System.Drawing.Size(75, 23);
      this.btnUpdate.TabIndex = 19;
      this.btnUpdate.Text = "&Update";
      this.btnUpdate.UseVisualStyleBackColor = true;
      this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
      // 
      // btnClear
      // 
      this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnClear.Location = new System.Drawing.Point(155, 93);
      this.btnClear.Name = "btnClear";
      this.btnClear.Size = new System.Drawing.Size(75, 23);
      this.btnClear.TabIndex = 18;
      this.btnClear.Text = "&Clear";
      this.btnClear.UseVisualStyleBackColor = true;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.Location = new System.Drawing.Point(12, 42);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(117, 16);
      this.label1.TabIndex = 17;
      this.label1.Text = "Vehicle Category :";
      // 
      // txtCategory
      // 
      this.txtCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtCategory.Location = new System.Drawing.Point(135, 39);
      this.txtCategory.Name = "txtCategory";
      this.txtCategory.Size = new System.Drawing.Size(176, 22);
      this.txtCategory.TabIndex = 16;
      // 
      // btnClose
      // 
      this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnClose.Location = new System.Drawing.Point(235, 332);
      this.btnClose.Name = "btnClose";
      this.btnClose.Size = new System.Drawing.Size(75, 23);
      this.btnClose.TabIndex = 15;
      this.btnClose.Text = "&Close";
      this.btnClose.UseVisualStyleBackColor = true;
      this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
      // 
      // frmVehicleCategory
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(334, 395);
      this.Controls.Add(this.listVehicleCategory);
      this.Controls.Add(this.btnSave);
      this.Controls.Add(this.btnUpdate);
      this.Controls.Add(this.btnClear);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.txtCategory);
      this.Controls.Add(this.btnClose);
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "frmVehicleCategory";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "VehicleCategory";
      this.Load += new System.EventHandler(this.VehicleCategory_Load);
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
    private System.Windows.Forms.TextBox txtCategory;
    private System.Windows.Forms.Button btnClose;
  }
}