
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
      this.contractorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.listVehicles = new System.Windows.Forms.ListView();
      this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.txtSearch = new System.Windows.Forms.TextBox();
      this.btnSearch = new System.Windows.Forms.Button();
      this.btnResetSearch = new System.Windows.Forms.Button();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.btnOpen = new System.Windows.Forms.Button();
      this.groupBox2 = new System.Windows.Forms.GroupBox();
      this.btnClearSalary = new System.Windows.Forms.Button();
      this.txtDescription = new System.Windows.Forms.TextBox();
      this.label3 = new System.Windows.Forms.Label();
      this.btnDeleteSalary = new System.Windows.Forms.Button();
      this.btnUpdateSalary = new System.Windows.Forms.Button();
      this.btnAddSalary = new System.Windows.Forms.Button();
      this.listEmpSalary = new System.Windows.Forms.ListView();
      this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.txtSalaryAmount = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      this.cmbEmployees = new System.Windows.Forms.ComboBox();
      this.menuStrip1.SuspendLayout();
      this.groupBox1.SuspendLayout();
      this.groupBox2.SuspendLayout();
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
      this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 3, 0, 3);
      this.menuStrip1.Size = new System.Drawing.Size(1509, 25);
      this.menuStrip1.TabIndex = 1;
      this.menuStrip1.Text = "menuStrip1";
      // 
      // usersToolStripMenuItem
      // 
      this.usersToolStripMenuItem.Name = "usersToolStripMenuItem";
      this.usersToolStripMenuItem.Size = new System.Drawing.Size(12, 19);
      // 
      // vehicleToolStripMenuItem
      // 
      this.vehicleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addVehicleToolStripMenuItem,
            this.vehicleTypesToolStripMenuItem,
            this.vehicleCategoryToolStripMenuItem,
            this.brandsToolStripMenuItem});
      this.vehicleToolStripMenuItem.Name = "vehicleToolStripMenuItem";
      this.vehicleToolStripMenuItem.Size = new System.Drawing.Size(130, 19);
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
      this.employeesToolStripMenuItem.Size = new System.Drawing.Size(12, 19);
      // 
      // inventoryToolStripMenuItem
      // 
      this.inventoryToolStripMenuItem.Name = "inventoryToolStripMenuItem";
      this.inventoryToolStripMenuItem.Size = new System.Drawing.Size(69, 19);
      this.inventoryToolStripMenuItem.Text = "Inventory";
      this.inventoryToolStripMenuItem.Click += new System.EventHandler(this.inventoryToolStripMenuItem_Click);
      // 
      // toolStripMenuItem1
      // 
      this.toolStripMenuItem1.Name = "toolStripMenuItem1";
      this.toolStripMenuItem1.Size = new System.Drawing.Size(12, 19);
      // 
      // staffManagementToolStripMenuItem
      // 
      this.staffManagementToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.employeesToolStripMenuItem1,
            this.usersToolStripMenuItem1,
            this.contractorsToolStripMenuItem});
      this.staffManagementToolStripMenuItem.Name = "staffManagementToolStripMenuItem";
      this.staffManagementToolStripMenuItem.Size = new System.Drawing.Size(117, 19);
      this.staffManagementToolStripMenuItem.Text = "Staff Management";
      // 
      // employeesToolStripMenuItem1
      // 
      this.employeesToolStripMenuItem1.Name = "employeesToolStripMenuItem1";
      this.employeesToolStripMenuItem1.Size = new System.Drawing.Size(136, 22);
      this.employeesToolStripMenuItem1.Text = "Employees";
      this.employeesToolStripMenuItem1.Click += new System.EventHandler(this.employeesToolStripMenuItem_Click);
      // 
      // usersToolStripMenuItem1
      // 
      this.usersToolStripMenuItem1.Name = "usersToolStripMenuItem1";
      this.usersToolStripMenuItem1.Size = new System.Drawing.Size(136, 22);
      this.usersToolStripMenuItem1.Text = "Users";
      this.usersToolStripMenuItem1.Click += new System.EventHandler(this.usersToolStripMenuItem_Click);
      // 
      // contractorsToolStripMenuItem
      // 
      this.contractorsToolStripMenuItem.Name = "contractorsToolStripMenuItem";
      this.contractorsToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
      this.contractorsToolStripMenuItem.Text = "Contractors";
      this.contractorsToolStripMenuItem.Click += new System.EventHandler(this.contractorsToolStripMenuItem_Click);
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
      this.listVehicles.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.listVehicles.FullRowSelect = true;
      this.listVehicles.GridLines = true;
      this.listVehicles.HideSelection = false;
      this.listVehicles.Location = new System.Drawing.Point(8, 73);
      this.listVehicles.Margin = new System.Windows.Forms.Padding(4);
      this.listVehicles.MultiSelect = false;
      this.listVehicles.Name = "listVehicles";
      this.listVehicles.Size = new System.Drawing.Size(865, 777);
      this.listVehicles.TabIndex = 0;
      this.listVehicles.UseCompatibleStateImageBehavior = false;
      this.listVehicles.View = System.Windows.Forms.View.Details;
      this.listVehicles.SelectedIndexChanged += new System.EventHandler(this.listVehicles_SelectedIndexChanged);
      // 
      // columnHeader1
      // 
      this.columnHeader1.Text = "Id";
      this.columnHeader1.Width = 40;
      // 
      // columnHeader2
      // 
      this.columnHeader2.Text = "RegNum";
      this.columnHeader2.Width = 150;
      // 
      // columnHeader3
      // 
      this.columnHeader3.Text = "Model";
      this.columnHeader3.Width = 200;
      // 
      // columnHeader4
      // 
      this.columnHeader4.Text = "Brand";
      this.columnHeader4.Width = 150;
      // 
      // columnHeader5
      // 
      this.columnHeader5.Text = "Type";
      this.columnHeader5.Width = 150;
      // 
      // columnHeader6
      // 
      this.columnHeader6.Text = "Category";
      this.columnHeader6.Width = 150;
      // 
      // columnHeader7
      // 
      this.columnHeader7.Text = "Date";
      this.columnHeader7.Width = 150;
      // 
      // txtSearch
      // 
      this.txtSearch.Location = new System.Drawing.Point(8, 31);
      this.txtSearch.Margin = new System.Windows.Forms.Padding(4);
      this.txtSearch.Name = "txtSearch";
      this.txtSearch.Size = new System.Drawing.Size(360, 25);
      this.txtSearch.TabIndex = 1;
      // 
      // btnSearch
      // 
      this.btnSearch.Location = new System.Drawing.Point(547, 30);
      this.btnSearch.Margin = new System.Windows.Forms.Padding(4);
      this.btnSearch.Name = "btnSearch";
      this.btnSearch.Size = new System.Drawing.Size(113, 28);
      this.btnSearch.TabIndex = 3;
      this.btnSearch.Text = "&Search";
      this.btnSearch.UseVisualStyleBackColor = true;
      this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
      // 
      // btnResetSearch
      // 
      this.btnResetSearch.Location = new System.Drawing.Point(668, 30);
      this.btnResetSearch.Margin = new System.Windows.Forms.Padding(4);
      this.btnResetSearch.Name = "btnResetSearch";
      this.btnResetSearch.Size = new System.Drawing.Size(113, 28);
      this.btnResetSearch.TabIndex = 4;
      this.btnResetSearch.Text = "&Reset";
      this.btnResetSearch.UseVisualStyleBackColor = true;
      this.btnResetSearch.Click += new System.EventHandler(this.btnResetSearch_Click);
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.btnOpen);
      this.groupBox1.Controls.Add(this.btnResetSearch);
      this.groupBox1.Controls.Add(this.btnSearch);
      this.groupBox1.Controls.Add(this.txtSearch);
      this.groupBox1.Controls.Add(this.listVehicles);
      this.groupBox1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.groupBox1.Location = new System.Drawing.Point(13, 40);
      this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
      this.groupBox1.Size = new System.Drawing.Size(884, 859);
      this.groupBox1.TabIndex = 2;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Vehicles";
      // 
      // btnOpen
      // 
      this.btnOpen.Location = new System.Drawing.Point(789, 30);
      this.btnOpen.Margin = new System.Windows.Forms.Padding(4);
      this.btnOpen.Name = "btnOpen";
      this.btnOpen.Size = new System.Drawing.Size(84, 28);
      this.btnOpen.TabIndex = 5;
      this.btnOpen.Text = "&Open";
      this.btnOpen.UseVisualStyleBackColor = true;
      this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
      // 
      // groupBox2
      // 
      this.groupBox2.Controls.Add(this.btnClearSalary);
      this.groupBox2.Controls.Add(this.txtDescription);
      this.groupBox2.Controls.Add(this.label3);
      this.groupBox2.Controls.Add(this.btnDeleteSalary);
      this.groupBox2.Controls.Add(this.btnUpdateSalary);
      this.groupBox2.Controls.Add(this.btnAddSalary);
      this.groupBox2.Controls.Add(this.listEmpSalary);
      this.groupBox2.Controls.Add(this.txtSalaryAmount);
      this.groupBox2.Controls.Add(this.label2);
      this.groupBox2.Controls.Add(this.label1);
      this.groupBox2.Controls.Add(this.cmbEmployees);
      this.groupBox2.Location = new System.Drawing.Point(904, 40);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Size = new System.Drawing.Size(593, 286);
      this.groupBox2.TabIndex = 3;
      this.groupBox2.TabStop = false;
      this.groupBox2.Text = "Salary";
      // 
      // btnClearSalary
      // 
      this.btnClearSalary.Location = new System.Drawing.Point(519, 63);
      this.btnClearSalary.Name = "btnClearSalary";
      this.btnClearSalary.Size = new System.Drawing.Size(68, 27);
      this.btnClearSalary.TabIndex = 36;
      this.btnClearSalary.Text = "&Clear";
      this.btnClearSalary.UseVisualStyleBackColor = true;
      this.btnClearSalary.Click += new System.EventHandler(this.btnClearSalary_Click);
      // 
      // txtDescription
      // 
      this.txtDescription.Location = new System.Drawing.Point(95, 65);
      this.txtDescription.Multiline = true;
      this.txtDescription.Name = "txtDescription";
      this.txtDescription.Size = new System.Drawing.Size(353, 49);
      this.txtDescription.TabIndex = 35;
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(16, 68);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(82, 17);
      this.label3.TabIndex = 34;
      this.label3.Text = "Description";
      // 
      // btnDeleteSalary
      // 
      this.btnDeleteSalary.Location = new System.Drawing.Point(454, 63);
      this.btnDeleteSalary.Name = "btnDeleteSalary";
      this.btnDeleteSalary.Size = new System.Drawing.Size(60, 27);
      this.btnDeleteSalary.TabIndex = 33;
      this.btnDeleteSalary.Text = "&Delete";
      this.btnDeleteSalary.UseVisualStyleBackColor = true;
      // 
      // btnUpdateSalary
      // 
      this.btnUpdateSalary.Location = new System.Drawing.Point(519, 29);
      this.btnUpdateSalary.Name = "btnUpdateSalary";
      this.btnUpdateSalary.Size = new System.Drawing.Size(68, 27);
      this.btnUpdateSalary.TabIndex = 32;
      this.btnUpdateSalary.Text = "&Update";
      this.btnUpdateSalary.UseVisualStyleBackColor = true;
      this.btnUpdateSalary.Click += new System.EventHandler(this.btnUpdateSalary_Click);
      // 
      // btnAddSalary
      // 
      this.btnAddSalary.Location = new System.Drawing.Point(454, 29);
      this.btnAddSalary.Name = "btnAddSalary";
      this.btnAddSalary.Size = new System.Drawing.Size(60, 27);
      this.btnAddSalary.TabIndex = 31;
      this.btnAddSalary.Text = "&Add";
      this.btnAddSalary.UseVisualStyleBackColor = true;
      this.btnAddSalary.Click += new System.EventHandler(this.btnAddSalary_Click);
      // 
      // listEmpSalary
      // 
      this.listEmpSalary.Activation = System.Windows.Forms.ItemActivation.OneClick;
      this.listEmpSalary.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader12});
      this.listEmpSalary.FullRowSelect = true;
      this.listEmpSalary.GridLines = true;
      this.listEmpSalary.HideSelection = false;
      this.listEmpSalary.Location = new System.Drawing.Point(6, 144);
      this.listEmpSalary.MultiSelect = false;
      this.listEmpSalary.Name = "listEmpSalary";
      this.listEmpSalary.Size = new System.Drawing.Size(567, 136);
      this.listEmpSalary.TabIndex = 30;
      this.listEmpSalary.UseCompatibleStateImageBehavior = false;
      this.listEmpSalary.View = System.Windows.Forms.View.Details;
      // 
      // columnHeader8
      // 
      this.columnHeader8.Text = "Id";
      // 
      // columnHeader9
      // 
      this.columnHeader9.Text = "Employee";
      this.columnHeader9.Width = 150;
      // 
      // columnHeader10
      // 
      this.columnHeader10.Text = "Amount";
      this.columnHeader10.Width = 100;
      // 
      // columnHeader11
      // 
      this.columnHeader11.Text = "Desc.";
      this.columnHeader11.Width = 150;
      // 
      // columnHeader12
      // 
      this.columnHeader12.Text = "Date";
      this.columnHeader12.Width = 150;
      // 
      // txtSalaryAmount
      // 
      this.txtSalaryAmount.Location = new System.Drawing.Point(301, 30);
      this.txtSalaryAmount.Name = "txtSalaryAmount";
      this.txtSalaryAmount.Size = new System.Drawing.Size(147, 25);
      this.txtSalaryAmount.TabIndex = 3;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(246, 34);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(49, 17);
      this.label2.TabIndex = 2;
      this.label2.Text = "Salary";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(16, 34);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(73, 17);
      this.label1.TabIndex = 1;
      this.label1.Text = "Employee";
      // 
      // cmbEmployees
      // 
      this.cmbEmployees.FormattingEnabled = true;
      this.cmbEmployees.Location = new System.Drawing.Point(95, 31);
      this.cmbEmployees.Name = "cmbEmployees";
      this.cmbEmployees.Size = new System.Drawing.Size(145, 25);
      this.cmbEmployees.TabIndex = 0;
      // 
      // frmDashboard
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1509, 953);
      this.Controls.Add(this.groupBox2);
      this.Controls.Add(this.groupBox1);
      this.Controls.Add(this.menuStrip1);
      this.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.MainMenuStrip = this.menuStrip1;
      this.Margin = new System.Windows.Forms.Padding(4);
      this.Name = "frmDashboard";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Dashboard";
      this.Load += new System.EventHandler(this.frmDashboard_Load);
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.groupBox2.ResumeLayout(false);
      this.groupBox2.PerformLayout();
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
    private System.Windows.Forms.Button btnSearch;
    private System.Windows.Forms.Button btnResetSearch;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.Button btnOpen;
    private System.Windows.Forms.ToolStripMenuItem contractorsToolStripMenuItem;
    private System.Windows.Forms.GroupBox groupBox2;
    private System.Windows.Forms.TextBox txtSalaryAmount;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.ComboBox cmbEmployees;
    private System.Windows.Forms.Button btnDeleteSalary;
    private System.Windows.Forms.Button btnUpdateSalary;
    private System.Windows.Forms.Button btnAddSalary;
    private System.Windows.Forms.ListView listEmpSalary;
    private System.Windows.Forms.ColumnHeader columnHeader8;
    private System.Windows.Forms.ColumnHeader columnHeader9;
    private System.Windows.Forms.ColumnHeader columnHeader10;
    private System.Windows.Forms.ColumnHeader columnHeader11;
    private System.Windows.Forms.ColumnHeader columnHeader12;
    private System.Windows.Forms.Button btnClearSalary;
    private System.Windows.Forms.TextBox txtDescription;
    private System.Windows.Forms.Label label3;
  }
}