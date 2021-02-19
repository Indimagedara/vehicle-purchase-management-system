
namespace VehicleManagementSystem
{
  partial class frmDashboard
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
      this.components = new System.ComponentModel.Container();
      this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
      this.menuStrip1 = new System.Windows.Forms.MenuStrip();
      this.usersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.vehicleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.vehicleTypesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.vehicleCategoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.employeesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.inventoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.menuStrip1.SuspendLayout();
      this.SuspendLayout();
      // 
      // contextMenuStrip1
      // 
      this.contextMenuStrip1.Name = "contextMenuStrip1";
      this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
      // 
      // menuStrip1
      // 
      this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usersToolStripMenuItem,
            this.vehicleToolStripMenuItem,
            this.employeesToolStripMenuItem,
            this.inventoryToolStripMenuItem});
      this.menuStrip1.Location = new System.Drawing.Point(0, 0);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Size = new System.Drawing.Size(800, 24);
      this.menuStrip1.TabIndex = 1;
      this.menuStrip1.Text = "menuStrip1";
      // 
      // usersToolStripMenuItem
      // 
      this.usersToolStripMenuItem.Name = "usersToolStripMenuItem";
      this.usersToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
      this.usersToolStripMenuItem.Text = "Users";
      this.usersToolStripMenuItem.Click += new System.EventHandler(this.usersToolStripMenuItem_Click);
      // 
      // vehicleToolStripMenuItem
      // 
      this.vehicleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vehicleTypesToolStripMenuItem,
            this.vehicleCategoryToolStripMenuItem});
      this.vehicleToolStripMenuItem.Name = "vehicleToolStripMenuItem";
      this.vehicleToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
      this.vehicleToolStripMenuItem.Text = "Vehicle";
      // 
      // vehicleTypesToolStripMenuItem
      // 
      this.vehicleTypesToolStripMenuItem.Name = "vehicleTypesToolStripMenuItem";
      this.vehicleTypesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
      this.vehicleTypesToolStripMenuItem.Text = "Vehicle Types";
      this.vehicleTypesToolStripMenuItem.Click += new System.EventHandler(this.vehicleTypesToolStripMenuItem_Click);
      // 
      // vehicleCategoryToolStripMenuItem
      // 
      this.vehicleCategoryToolStripMenuItem.Name = "vehicleCategoryToolStripMenuItem";
      this.vehicleCategoryToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
      this.vehicleCategoryToolStripMenuItem.Text = "Vehicle Category";
      this.vehicleCategoryToolStripMenuItem.Click += new System.EventHandler(this.vehicleCategoryToolStripMenuItem_Click);
      // 
      // employeesToolStripMenuItem
      // 
      this.employeesToolStripMenuItem.Name = "employeesToolStripMenuItem";
      this.employeesToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
      this.employeesToolStripMenuItem.Text = "Employees";
      this.employeesToolStripMenuItem.Click += new System.EventHandler(this.employeesToolStripMenuItem_Click);
      // 
      // inventoryToolStripMenuItem
      // 
      this.inventoryToolStripMenuItem.Name = "inventoryToolStripMenuItem";
      this.inventoryToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
      this.inventoryToolStripMenuItem.Text = "Inventory";
      this.inventoryToolStripMenuItem.Click += new System.EventHandler(this.inventoryToolStripMenuItem_Click);
      // 
      // frmDashboard
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.menuStrip1);
      this.MainMenuStrip = this.menuStrip1;
      this.Name = "frmDashboard";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Dashboard";
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem vehicleToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem vehicleTypesToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem vehicleCategoryToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem employeesToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem inventoryToolStripMenuItem;
  }
}