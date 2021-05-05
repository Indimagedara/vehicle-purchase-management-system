
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
      this.addVehicleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.vehicleTypesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.vehicleCategoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.brandsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.employeesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.inventoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
      this.staffManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.employeesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
      this.usersToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
      this.listVehicles = new System.Windows.Forms.ListView();
      this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.txtSearch = new System.Windows.Forms.TextBox();
      this.cmSearchType = new System.Windows.Forms.ComboBox();
      this.btnSearch = new System.Windows.Forms.Button();
      this.btnReset = new System.Windows.Forms.Button();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.btnOpen = new System.Windows.Forms.Button();
      this.contractorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.menuStrip1.SuspendLayout();
      this.groupBox1.SuspendLayout();
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
            this.inventoryToolStripMenuItem,
            this.toolStripMenuItem1,
            this.staffManagementToolStripMenuItem});
      this.menuStrip1.Location = new System.Drawing.Point(0, 0);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Size = new System.Drawing.Size(1077, 24);
      this.menuStrip1.TabIndex = 1;
      this.menuStrip1.Text = "menuStrip1";
      // 
      // usersToolStripMenuItem
      // 
      this.usersToolStripMenuItem.Name = "usersToolStripMenuItem";
      this.usersToolStripMenuItem.Size = new System.Drawing.Size(12, 20);
      // 
      // vehicleToolStripMenuItem
      // 
      this.vehicleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addVehicleToolStripMenuItem,
            this.vehicleTypesToolStripMenuItem,
            this.vehicleCategoryToolStripMenuItem,
            this.brandsToolStripMenuItem});
      this.vehicleToolStripMenuItem.Name = "vehicleToolStripMenuItem";
      this.vehicleToolStripMenuItem.Size = new System.Drawing.Size(130, 20);
      this.vehicleToolStripMenuItem.Text = "Vehicle Management";
      // 
      // addVehicleToolStripMenuItem
      // 
      this.addVehicleToolStripMenuItem.Name = "addVehicleToolStripMenuItem";
      this.addVehicleToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
      this.addVehicleToolStripMenuItem.Text = "Add Vehicle";
      this.addVehicleToolStripMenuItem.Click += new System.EventHandler(this.addVehicleToolStripMenuItem_Click);
      // 
      // vehicleTypesToolStripMenuItem
      // 
      this.vehicleTypesToolStripMenuItem.Name = "vehicleTypesToolStripMenuItem";
      this.vehicleTypesToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
      this.vehicleTypesToolStripMenuItem.Text = "Vehicle Types";
      this.vehicleTypesToolStripMenuItem.Click += new System.EventHandler(this.vehicleTypesToolStripMenuItem_Click);
      // 
      // vehicleCategoryToolStripMenuItem
      // 
      this.vehicleCategoryToolStripMenuItem.Name = "vehicleCategoryToolStripMenuItem";
      this.vehicleCategoryToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
      this.vehicleCategoryToolStripMenuItem.Text = "Vehicle Category";
      this.vehicleCategoryToolStripMenuItem.Click += new System.EventHandler(this.vehicleCategoryToolStripMenuItem_Click);
      // 
      // brandsToolStripMenuItem
      // 
      this.brandsToolStripMenuItem.Name = "brandsToolStripMenuItem";
      this.brandsToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
      this.brandsToolStripMenuItem.Text = "Brands";
      this.brandsToolStripMenuItem.Click += new System.EventHandler(this.brandsToolStripMenuItem_Click);
      // 
      // employeesToolStripMenuItem
      // 
      this.employeesToolStripMenuItem.Name = "employeesToolStripMenuItem";
      this.employeesToolStripMenuItem.Size = new System.Drawing.Size(12, 20);
      // 
      // inventoryToolStripMenuItem
      // 
      this.inventoryToolStripMenuItem.Name = "inventoryToolStripMenuItem";
      this.inventoryToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
      this.inventoryToolStripMenuItem.Text = "Inventory";
      this.inventoryToolStripMenuItem.Click += new System.EventHandler(this.inventoryToolStripMenuItem_Click);
      // 
      // toolStripMenuItem1
      // 
      this.toolStripMenuItem1.Name = "toolStripMenuItem1";
      this.toolStripMenuItem1.Size = new System.Drawing.Size(12, 20);
      // 
      // staffManagementToolStripMenuItem
      // 
      this.staffManagementToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.employeesToolStripMenuItem1,
            this.usersToolStripMenuItem1,
            this.contractorsToolStripMenuItem});
      this.staffManagementToolStripMenuItem.Name = "staffManagementToolStripMenuItem";
      this.staffManagementToolStripMenuItem.Size = new System.Drawing.Size(117, 20);
      this.staffManagementToolStripMenuItem.Text = "Staff Management";
      // 
      // employeesToolStripMenuItem1
      // 
      this.employeesToolStripMenuItem1.Name = "employeesToolStripMenuItem1";
      this.employeesToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
      this.employeesToolStripMenuItem1.Text = "Employees";
      this.employeesToolStripMenuItem1.Click += new System.EventHandler(this.employeesToolStripMenuItem_Click);
      // 
      // usersToolStripMenuItem1
      // 
      this.usersToolStripMenuItem1.Name = "usersToolStripMenuItem1";
      this.usersToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
      this.usersToolStripMenuItem1.Text = "Users";
      this.usersToolStripMenuItem1.Click += new System.EventHandler(this.usersToolStripMenuItem_Click);
      // 
      // listVehicles
      // 
      this.listVehicles.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
      this.listVehicles.Cursor = System.Windows.Forms.Cursors.Hand;
      this.listVehicles.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.listVehicles.FullRowSelect = true;
      this.listVehicles.GridLines = true;
      this.listVehicles.HideSelection = false;
      this.listVehicles.Location = new System.Drawing.Point(6, 56);
      this.listVehicles.MultiSelect = false;
      this.listVehicles.Name = "listVehicles";
      this.listVehicles.Size = new System.Drawing.Size(650, 595);
      this.listVehicles.TabIndex = 0;
      this.listVehicles.UseCompatibleStateImageBehavior = false;
      this.listVehicles.View = System.Windows.Forms.View.Details;
      this.listVehicles.SelectedIndexChanged += new System.EventHandler(this.listVehicles_SelectedIndexChanged);
      // 
      // columnHeader1
      // 
      this.columnHeader1.Text = "Ve.Id";
      this.columnHeader1.Width = 40;
      // 
      // columnHeader2
      // 
      this.columnHeader2.Text = "RegNum";
      this.columnHeader2.Width = 100;
      // 
      // columnHeader3
      // 
      this.columnHeader3.Text = "Model";
      this.columnHeader3.Width = 120;
      // 
      // columnHeader4
      // 
      this.columnHeader4.Text = "Brand";
      this.columnHeader4.Width = 100;
      // 
      // columnHeader5
      // 
      this.columnHeader5.Text = "Type";
      this.columnHeader5.Width = 80;
      // 
      // columnHeader6
      // 
      this.columnHeader6.Text = "Category";
      this.columnHeader6.Width = 80;
      // 
      // columnHeader7
      // 
      this.columnHeader7.Text = "Date";
      this.columnHeader7.Width = 100;
      // 
      // txtSearch
      // 
      this.txtSearch.Location = new System.Drawing.Point(6, 25);
      this.txtSearch.Name = "txtSearch";
      this.txtSearch.Size = new System.Drawing.Size(271, 24);
      this.txtSearch.TabIndex = 1;
      // 
      // cmSearchType
      // 
      this.cmSearchType.FormattingEnabled = true;
      this.cmSearchType.Location = new System.Drawing.Point(283, 24);
      this.cmSearchType.Name = "cmSearchType";
      this.cmSearchType.Size = new System.Drawing.Size(121, 26);
      this.cmSearchType.TabIndex = 2;
      // 
      // btnSearch
      // 
      this.btnSearch.Location = new System.Drawing.Point(410, 23);
      this.btnSearch.Name = "btnSearch";
      this.btnSearch.Size = new System.Drawing.Size(85, 27);
      this.btnSearch.TabIndex = 3;
      this.btnSearch.Text = "&Search";
      this.btnSearch.UseVisualStyleBackColor = true;
      // 
      // btnReset
      // 
      this.btnReset.Location = new System.Drawing.Point(501, 23);
      this.btnReset.Name = "btnReset";
      this.btnReset.Size = new System.Drawing.Size(85, 27);
      this.btnReset.TabIndex = 4;
      this.btnReset.Text = "&Reset";
      this.btnReset.UseVisualStyleBackColor = true;
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.btnOpen);
      this.groupBox1.Controls.Add(this.btnReset);
      this.groupBox1.Controls.Add(this.btnSearch);
      this.groupBox1.Controls.Add(this.cmSearchType);
      this.groupBox1.Controls.Add(this.txtSearch);
      this.groupBox1.Controls.Add(this.listVehicles);
      this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.groupBox1.Location = new System.Drawing.Point(12, 60);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(663, 657);
      this.groupBox1.TabIndex = 2;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Vehicles";
      // 
      // btnOpen
      // 
      this.btnOpen.Location = new System.Drawing.Point(592, 23);
      this.btnOpen.Name = "btnOpen";
      this.btnOpen.Size = new System.Drawing.Size(64, 27);
      this.btnOpen.TabIndex = 5;
      this.btnOpen.Text = "&Open";
      this.btnOpen.UseVisualStyleBackColor = true;
      this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
      // 
      // contractorsToolStripMenuItem
      // 
      this.contractorsToolStripMenuItem.Name = "contractorsToolStripMenuItem";
      this.contractorsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
      this.contractorsToolStripMenuItem.Text = "Contractors";
      this.contractorsToolStripMenuItem.Click += new System.EventHandler(this.contractorsToolStripMenuItem_Click);
      // 
      // frmDashboard
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1077, 729);
      this.Controls.Add(this.groupBox1);
      this.Controls.Add(this.menuStrip1);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.MainMenuStrip = this.menuStrip1;
      this.Name = "frmDashboard";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Dashboard";
      this.Load += new System.EventHandler(this.frmDashboard_Load);
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
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
    private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
    private System.Windows.Forms.ToolStripMenuItem staffManagementToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem employeesToolStripMenuItem1;
    private System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem1;
    private System.Windows.Forms.ToolStripMenuItem addVehicleToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem brandsToolStripMenuItem;
    private System.Windows.Forms.ListView listVehicles;
    private System.Windows.Forms.ColumnHeader columnHeader1;
    private System.Windows.Forms.ColumnHeader columnHeader2;
    private System.Windows.Forms.ColumnHeader columnHeader3;
    private System.Windows.Forms.ColumnHeader columnHeader4;
    private System.Windows.Forms.ColumnHeader columnHeader5;
    private System.Windows.Forms.ColumnHeader columnHeader6;
    private System.Windows.Forms.ColumnHeader columnHeader7;
    private System.Windows.Forms.TextBox txtSearch;
    private System.Windows.Forms.ComboBox cmSearchType;
    private System.Windows.Forms.Button btnSearch;
    private System.Windows.Forms.Button btnReset;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.Button btnOpen;
    private System.Windows.Forms.ToolStripMenuItem contractorsToolStripMenuItem;
  }
}