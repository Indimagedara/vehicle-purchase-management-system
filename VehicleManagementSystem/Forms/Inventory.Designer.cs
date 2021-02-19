
namespace VehicleManagementSystem.Forms
{
  partial class frmInventory
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
      this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.listInventoryItem = new System.Windows.Forms.ListView();
      this.btnSave = new System.Windows.Forms.Button();
      this.btnUpdate = new System.Windows.Forms.Button();
      this.btnClear = new System.Windows.Forms.Button();
      this.label1 = new System.Windows.Forms.Label();
      this.txtItem = new System.Windows.Forms.TextBox();
      this.SuspendLayout();
      // 
      // btnClose
      // 
      this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnClose.Location = new System.Drawing.Point(239, 306);
      this.btnClose.Name = "btnClose";
      this.btnClose.Size = new System.Drawing.Size(75, 23);
      this.btnClose.TabIndex = 22;
      this.btnClose.Text = "&Close";
      this.btnClose.UseVisualStyleBackColor = true;
      this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
      // 
      // columnHeader1
      // 
      this.columnHeader1.Text = "Id";
      this.columnHeader1.Width = 100;
      // 
      // columnHeader2
      // 
      this.columnHeader2.Text = "Item Name";
      this.columnHeader2.Width = 160;
      // 
      // listInventoryItem
      // 
      this.listInventoryItem.Activation = System.Windows.Forms.ItemActivation.OneClick;
      this.listInventoryItem.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
      this.listInventoryItem.FullRowSelect = true;
      this.listInventoryItem.GridLines = true;
      this.listInventoryItem.HideSelection = false;
      this.listInventoryItem.Location = new System.Drawing.Point(47, 115);
      this.listInventoryItem.MultiSelect = false;
      this.listInventoryItem.Name = "listInventoryItem";
      this.listInventoryItem.Size = new System.Drawing.Size(267, 168);
      this.listInventoryItem.TabIndex = 28;
      this.listInventoryItem.UseCompatibleStateImageBehavior = false;
      this.listInventoryItem.View = System.Windows.Forms.View.Details;
      this.listInventoryItem.SelectedIndexChanged += new System.EventHandler(this.listInventoryItem_SelectedIndexChanged);
      // 
      // btnSave
      // 
      this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnSave.Location = new System.Drawing.Point(238, 69);
      this.btnSave.Name = "btnSave";
      this.btnSave.Size = new System.Drawing.Size(75, 23);
      this.btnSave.TabIndex = 27;
      this.btnSave.Text = "&Save";
      this.btnSave.UseVisualStyleBackColor = true;
      this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
      // 
      // btnUpdate
      // 
      this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnUpdate.Location = new System.Drawing.Point(238, 69);
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
      this.btnClear.Location = new System.Drawing.Point(158, 69);
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
      this.label1.Location = new System.Drawing.Point(15, 31);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(39, 16);
      this.label1.TabIndex = 24;
      this.label1.Text = "Item :";
      // 
      // txtItem
      // 
      this.txtItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtItem.Location = new System.Drawing.Point(138, 28);
      this.txtItem.Name = "txtItem";
      this.txtItem.Size = new System.Drawing.Size(176, 22);
      this.txtItem.TabIndex = 23;
      // 
      // frmInventory
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(346, 353);
      this.Controls.Add(this.btnClose);
      this.Controls.Add(this.listInventoryItem);
      this.Controls.Add(this.btnSave);
      this.Controls.Add(this.btnUpdate);
      this.Controls.Add(this.btnClear);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.txtItem);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "frmInventory";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Inventory";
      this.Load += new System.EventHandler(this.frmInventory_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button btnClose;
    private System.Windows.Forms.ColumnHeader columnHeader1;
    private System.Windows.Forms.ColumnHeader columnHeader2;
    private System.Windows.Forms.ListView listInventoryItem;
    private System.Windows.Forms.Button btnSave;
    private System.Windows.Forms.Button btnUpdate;
    private System.Windows.Forms.Button btnClear;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox txtItem;
  }
}