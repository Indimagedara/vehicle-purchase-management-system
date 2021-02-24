
namespace VehicleManagementSystem.Forms
{
  partial class frmAddVehicle
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
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.cmbFuelType = new System.Windows.Forms.ComboBox();
      this.btnSave = new System.Windows.Forms.Button();
      this.btnUpdate = new System.Windows.Forms.Button();
      this.btnClear = new System.Windows.Forms.Button();
      this.label11 = new System.Windows.Forms.Label();
      this.txtEngineCapacity = new System.Windows.Forms.TextBox();
      this.label10 = new System.Windows.Forms.Label();
      this.txtMilage = new System.Windows.Forms.TextBox();
      this.label9 = new System.Windows.Forms.Label();
      this.txtChassieNumber = new System.Windows.Forms.TextBox();
      this.label8 = new System.Windows.Forms.Label();
      this.txtEngineNumber = new System.Windows.Forms.TextBox();
      this.label7 = new System.Windows.Forms.Label();
      this.txtRegYear = new System.Windows.Forms.TextBox();
      this.label6 = new System.Windows.Forms.Label();
      this.txtRegNum = new System.Windows.Forms.TextBox();
      this.label5 = new System.Windows.Forms.Label();
      this.cmbVehicleCategory = new System.Windows.Forms.ComboBox();
      this.label4 = new System.Windows.Forms.Label();
      this.cmbType = new System.Windows.Forms.ComboBox();
      this.label3 = new System.Windows.Forms.Label();
      this.txtModelYear = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.txtModel = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.groupBox2 = new System.Windows.Forms.GroupBox();
      this.label14 = new System.Windows.Forms.Label();
      this.label12 = new System.Windows.Forms.Label();
      this.btnRemovePart = new System.Windows.Forms.Button();
      this.btnSelectItem = new System.Windows.Forms.Button();
      this.lbSelectedItems = new System.Windows.Forms.ListBox();
      this.txtNote = new System.Windows.Forms.TextBox();
      this.label13 = new System.Windows.Forms.Label();
      this.listPartInventory = new System.Windows.Forms.ListView();
      this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.btnClose = new System.Windows.Forms.Button();
      this.label15 = new System.Windows.Forms.Label();
      this.label16 = new System.Windows.Forms.Label();
      this.label17 = new System.Windows.Forms.Label();
      this.cmbTransmission = new System.Windows.Forms.ComboBox();
      this.cmbCondition = new System.Windows.Forms.ComboBox();
      this.cmbBrand = new System.Windows.Forms.ComboBox();
      this.vehiclePurchaseManagementsDataSet = new VehicleManagementSystem.VehiclePurchaseManagementsDataSet();
      this.groupBox1.SuspendLayout();
      this.groupBox2.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.vehiclePurchaseManagementsDataSet)).BeginInit();
      this.SuspendLayout();
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.cmbBrand);
      this.groupBox1.Controls.Add(this.cmbCondition);
      this.groupBox1.Controls.Add(this.cmbTransmission);
      this.groupBox1.Controls.Add(this.label17);
      this.groupBox1.Controls.Add(this.label16);
      this.groupBox1.Controls.Add(this.label15);
      this.groupBox1.Controls.Add(this.cmbFuelType);
      this.groupBox1.Controls.Add(this.btnSave);
      this.groupBox1.Controls.Add(this.btnUpdate);
      this.groupBox1.Controls.Add(this.btnClear);
      this.groupBox1.Controls.Add(this.label11);
      this.groupBox1.Controls.Add(this.txtEngineCapacity);
      this.groupBox1.Controls.Add(this.label10);
      this.groupBox1.Controls.Add(this.txtMilage);
      this.groupBox1.Controls.Add(this.label9);
      this.groupBox1.Controls.Add(this.txtChassieNumber);
      this.groupBox1.Controls.Add(this.label8);
      this.groupBox1.Controls.Add(this.txtEngineNumber);
      this.groupBox1.Controls.Add(this.label7);
      this.groupBox1.Controls.Add(this.txtRegYear);
      this.groupBox1.Controls.Add(this.label6);
      this.groupBox1.Controls.Add(this.txtRegNum);
      this.groupBox1.Controls.Add(this.label5);
      this.groupBox1.Controls.Add(this.cmbVehicleCategory);
      this.groupBox1.Controls.Add(this.label4);
      this.groupBox1.Controls.Add(this.cmbType);
      this.groupBox1.Controls.Add(this.label3);
      this.groupBox1.Controls.Add(this.txtModelYear);
      this.groupBox1.Controls.Add(this.label2);
      this.groupBox1.Controls.Add(this.txtModel);
      this.groupBox1.Controls.Add(this.label1);
      this.groupBox1.Location = new System.Drawing.Point(12, 53);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(1078, 205);
      this.groupBox1.TabIndex = 0;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Vehicle Details";
      // 
      // cmbFuelType
      // 
      this.cmbFuelType.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.cmbFuelType.FormattingEnabled = true;
      this.cmbFuelType.Items.AddRange(new object[] {
            "Petrol",
            "Diesel",
            "Hybrid",
            "Electrical",
            "Gas"});
      this.cmbFuelType.Location = new System.Drawing.Point(891, 119);
      this.cmbFuelType.Name = "cmbFuelType";
      this.cmbFuelType.Size = new System.Drawing.Size(166, 26);
      this.cmbFuelType.TabIndex = 20;
      // 
      // btnSave
      // 
      this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnSave.Location = new System.Drawing.Point(934, 161);
      this.btnSave.Name = "btnSave";
      this.btnSave.Size = new System.Drawing.Size(123, 26);
      this.btnSave.TabIndex = 3;
      this.btnSave.Text = "&Save";
      this.btnSave.UseVisualStyleBackColor = true;
      this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
      // 
      // btnUpdate
      // 
      this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnUpdate.Location = new System.Drawing.Point(934, 162);
      this.btnUpdate.Name = "btnUpdate";
      this.btnUpdate.Size = new System.Drawing.Size(123, 26);
      this.btnUpdate.TabIndex = 2;
      this.btnUpdate.Text = "&Update";
      this.btnUpdate.UseVisualStyleBackColor = true;
      this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
      // 
      // btnClear
      // 
      this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnClear.Location = new System.Drawing.Point(787, 161);
      this.btnClear.Name = "btnClear";
      this.btnClear.Size = new System.Drawing.Size(123, 26);
      this.btnClear.TabIndex = 1;
      this.btnClear.Text = "&Clear";
      this.btnClear.UseVisualStyleBackColor = true;
      this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
      // 
      // label11
      // 
      this.label11.AutoSize = true;
      this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label11.Location = new System.Drawing.Point(784, 122);
      this.label11.Name = "label11";
      this.label11.Size = new System.Drawing.Size(84, 18);
      this.label11.TabIndex = 19;
      this.label11.Text = "Fuel Type : ";
      // 
      // txtEngineCapacity
      // 
      this.txtEngineCapacity.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtEngineCapacity.Location = new System.Drawing.Point(615, 119);
      this.txtEngineCapacity.Name = "txtEngineCapacity";
      this.txtEngineCapacity.Size = new System.Drawing.Size(157, 24);
      this.txtEngineCapacity.TabIndex = 18;
      // 
      // label10
      // 
      this.label10.AutoSize = true;
      this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label10.Location = new System.Drawing.Point(528, 122);
      this.label10.Name = "label10";
      this.label10.Size = new System.Drawing.Size(91, 18);
      this.label10.TabIndex = 17;
      this.label10.Text = "Engine CC : ";
      // 
      // txtMilage
      // 
      this.txtMilage.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtMilage.Location = new System.Drawing.Point(340, 119);
      this.txtMilage.Name = "txtMilage";
      this.txtMilage.Size = new System.Drawing.Size(174, 24);
      this.txtMilage.TabIndex = 16;
      // 
      // label9
      // 
      this.label9.AutoSize = true;
      this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label9.Location = new System.Drawing.Point(256, 125);
      this.label9.Name = "label9";
      this.label9.Size = new System.Drawing.Size(63, 18);
      this.label9.TabIndex = 15;
      this.label9.Text = "Milage : ";
      // 
      // txtChassieNumber
      // 
      this.txtChassieNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtChassieNumber.Location = new System.Drawing.Point(125, 122);
      this.txtChassieNumber.Name = "txtChassieNumber";
      this.txtChassieNumber.Size = new System.Drawing.Size(120, 24);
      this.txtChassieNumber.TabIndex = 14;
      // 
      // label8
      // 
      this.label8.AutoSize = true;
      this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label8.Location = new System.Drawing.Point(16, 125);
      this.label8.Name = "label8";
      this.label8.Size = new System.Drawing.Size(110, 18);
      this.label8.TabIndex = 13;
      this.label8.Text = "Chassie Num : ";
      // 
      // txtEngineNumber
      // 
      this.txtEngineNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtEngineNumber.Location = new System.Drawing.Point(891, 79);
      this.txtEngineNumber.Name = "txtEngineNumber";
      this.txtEngineNumber.Size = new System.Drawing.Size(166, 24);
      this.txtEngineNumber.TabIndex = 12;
      // 
      // label7
      // 
      this.label7.AutoSize = true;
      this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label7.Location = new System.Drawing.Point(784, 82);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(101, 18);
      this.label7.TabIndex = 11;
      this.label7.Text = "Engine Num : ";
      // 
      // txtRegYear
      // 
      this.txtRegYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtRegYear.Location = new System.Drawing.Point(615, 79);
      this.txtRegYear.Name = "txtRegYear";
      this.txtRegYear.Size = new System.Drawing.Size(157, 24);
      this.txtRegYear.TabIndex = 10;
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label6.Location = new System.Drawing.Point(528, 82);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(81, 18);
      this.label6.TabIndex = 9;
      this.label6.Text = "Reg Year : ";
      // 
      // txtRegNum
      // 
      this.txtRegNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtRegNum.Location = new System.Drawing.Point(340, 79);
      this.txtRegNum.Name = "txtRegNum";
      this.txtRegNum.Size = new System.Drawing.Size(174, 24);
      this.txtRegNum.TabIndex = 8;
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label5.Location = new System.Drawing.Point(256, 82);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(83, 18);
      this.label5.TabIndex = 7;
      this.label5.Text = "Reg Num : ";
      // 
      // cmbVehicleCategory
      // 
      this.cmbVehicleCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.cmbVehicleCategory.FormattingEnabled = true;
      this.cmbVehicleCategory.Location = new System.Drawing.Point(125, 77);
      this.cmbVehicleCategory.Name = "cmbVehicleCategory";
      this.cmbVehicleCategory.Size = new System.Drawing.Size(120, 26);
      this.cmbVehicleCategory.TabIndex = 6;
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label4.Location = new System.Drawing.Point(18, 82);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(85, 18);
      this.label4.TabIndex = 5;
      this.label4.Text = "Body Cat. : ";
      // 
      // cmbType
      // 
      this.cmbType.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.cmbType.FormattingEnabled = true;
      this.cmbType.Location = new System.Drawing.Point(891, 37);
      this.cmbType.Name = "cmbType";
      this.cmbType.Size = new System.Drawing.Size(166, 26);
      this.cmbType.TabIndex = 4;
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label3.Location = new System.Drawing.Point(784, 40);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(103, 18);
      this.label3.TabIndex = 2;
      this.label3.Text = "Vehicle Type : ";
      // 
      // txtModelYear
      // 
      this.txtModelYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtModelYear.Location = new System.Drawing.Point(615, 37);
      this.txtModelYear.Name = "txtModelYear";
      this.txtModelYear.Size = new System.Drawing.Size(157, 24);
      this.txtModelYear.TabIndex = 3;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label2.Location = new System.Drawing.Point(528, 40);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(91, 18);
      this.label2.TabIndex = 2;
      this.label2.Text = "Model Year: ";
      // 
      // txtModel
      // 
      this.txtModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtModel.Location = new System.Drawing.Point(340, 37);
      this.txtModel.Name = "txtModel";
      this.txtModel.Size = new System.Drawing.Size(174, 24);
      this.txtModel.TabIndex = 1;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.Location = new System.Drawing.Point(256, 40);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(61, 18);
      this.label1.TabIndex = 0;
      this.label1.Text = "Model : ";
      // 
      // groupBox2
      // 
      this.groupBox2.Controls.Add(this.label14);
      this.groupBox2.Controls.Add(this.label12);
      this.groupBox2.Controls.Add(this.btnRemovePart);
      this.groupBox2.Controls.Add(this.btnSelectItem);
      this.groupBox2.Controls.Add(this.lbSelectedItems);
      this.groupBox2.Controls.Add(this.txtNote);
      this.groupBox2.Controls.Add(this.label13);
      this.groupBox2.Controls.Add(this.listPartInventory);
      this.groupBox2.Location = new System.Drawing.Point(12, 264);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Size = new System.Drawing.Size(1078, 296);
      this.groupBox2.TabIndex = 1;
      this.groupBox2.TabStop = false;
      this.groupBox2.Text = "Part Inventory";
      // 
      // label14
      // 
      this.label14.AutoSize = true;
      this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label14.Location = new System.Drawing.Point(439, 32);
      this.label14.Name = "label14";
      this.label14.Size = new System.Drawing.Size(116, 18);
      this.label14.TabIndex = 31;
      this.label14.Text = "Available Parts : ";
      // 
      // label12
      // 
      this.label12.AutoSize = true;
      this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label12.Location = new System.Drawing.Point(18, 32);
      this.label12.Name = "label12";
      this.label12.Size = new System.Drawing.Size(74, 18);
      this.label12.TabIndex = 30;
      this.label12.Text = "Part List : ";
      // 
      // btnRemovePart
      // 
      this.btnRemovePart.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnRemovePart.Location = new System.Drawing.Point(342, 151);
      this.btnRemovePart.Name = "btnRemovePart";
      this.btnRemovePart.Size = new System.Drawing.Size(74, 26);
      this.btnRemovePart.TabIndex = 29;
      this.btnRemovePart.Text = "<<";
      this.btnRemovePart.UseVisualStyleBackColor = true;
      this.btnRemovePart.Click += new System.EventHandler(this.btnRemovePart_Click);
      // 
      // btnSelectItem
      // 
      this.btnSelectItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnSelectItem.Location = new System.Drawing.Point(342, 119);
      this.btnSelectItem.Name = "btnSelectItem";
      this.btnSelectItem.Size = new System.Drawing.Size(74, 26);
      this.btnSelectItem.TabIndex = 28;
      this.btnSelectItem.Text = ">>";
      this.btnSelectItem.UseVisualStyleBackColor = true;
      this.btnSelectItem.Click += new System.EventHandler(this.btnSelectItem_Click);
      // 
      // lbSelectedItems
      // 
      this.lbSelectedItems.FormattingEnabled = true;
      this.lbSelectedItems.Location = new System.Drawing.Point(442, 53);
      this.lbSelectedItems.Name = "lbSelectedItems";
      this.lbSelectedItems.Size = new System.Drawing.Size(294, 212);
      this.lbSelectedItems.TabIndex = 27;
      this.lbSelectedItems.SelectedIndexChanged += new System.EventHandler(this.lbSelectedItems_SelectedIndexChanged);
      // 
      // txtNote
      // 
      this.txtNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtNote.Location = new System.Drawing.Point(805, 53);
      this.txtNote.Multiline = true;
      this.txtNote.Name = "txtNote";
      this.txtNote.Size = new System.Drawing.Size(252, 217);
      this.txtNote.TabIndex = 23;
      // 
      // label13
      // 
      this.label13.AutoSize = true;
      this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label13.Location = new System.Drawing.Point(756, 53);
      this.label13.Name = "label13";
      this.label13.Size = new System.Drawing.Size(52, 18);
      this.label13.TabIndex = 22;
      this.label13.Text = "Note : ";
      // 
      // listPartInventory
      // 
      this.listPartInventory.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
      this.listPartInventory.FullRowSelect = true;
      this.listPartInventory.GridLines = true;
      this.listPartInventory.HideSelection = false;
      this.listPartInventory.Location = new System.Drawing.Point(19, 53);
      this.listPartInventory.Name = "listPartInventory";
      this.listPartInventory.Size = new System.Drawing.Size(305, 217);
      this.listPartInventory.TabIndex = 0;
      this.listPartInventory.UseCompatibleStateImageBehavior = false;
      this.listPartInventory.View = System.Windows.Forms.View.Details;
      this.listPartInventory.SelectedIndexChanged += new System.EventHandler(this.listPartInventory_SelectedIndexChanged);
      // 
      // columnHeader1
      // 
      this.columnHeader1.Text = "Part Id";
      this.columnHeader1.Width = 100;
      // 
      // columnHeader2
      // 
      this.columnHeader2.Text = "Part Name";
      this.columnHeader2.Width = 200;
      // 
      // btnClose
      // 
      this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnClose.Location = new System.Drawing.Point(946, 566);
      this.btnClose.Name = "btnClose";
      this.btnClose.Size = new System.Drawing.Size(123, 26);
      this.btnClose.TabIndex = 2;
      this.btnClose.Text = "&Close";
      this.btnClose.UseVisualStyleBackColor = true;
      this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
      // 
      // label15
      // 
      this.label15.AutoSize = true;
      this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label15.Location = new System.Drawing.Point(18, 40);
      this.label15.Name = "label15";
      this.label15.Size = new System.Drawing.Size(59, 18);
      this.label15.TabIndex = 21;
      this.label15.Text = "Brand : ";
      // 
      // label16
      // 
      this.label16.AutoSize = true;
      this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label16.Location = new System.Drawing.Point(18, 166);
      this.label16.Name = "label16";
      this.label16.Size = new System.Drawing.Size(110, 18);
      this.label16.TabIndex = 23;
      this.label16.Text = "Transmission : ";
      // 
      // label17
      // 
      this.label17.AutoSize = true;
      this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label17.Location = new System.Drawing.Point(256, 165);
      this.label17.Name = "label17";
      this.label17.Size = new System.Drawing.Size(83, 18);
      this.label17.TabIndex = 25;
      this.label17.Text = "Condition : ";
      // 
      // cmbTransmission
      // 
      this.cmbTransmission.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.cmbTransmission.FormattingEnabled = true;
      this.cmbTransmission.Items.AddRange(new object[] {
            "Manual",
            "Automatic"});
      this.cmbTransmission.Location = new System.Drawing.Point(125, 162);
      this.cmbTransmission.Name = "cmbTransmission";
      this.cmbTransmission.Size = new System.Drawing.Size(120, 26);
      this.cmbTransmission.TabIndex = 26;
      // 
      // cmbCondition
      // 
      this.cmbCondition.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.cmbCondition.FormattingEnabled = true;
      this.cmbCondition.Items.AddRange(new object[] {
            "Used",
            "Unregistered"});
      this.cmbCondition.Location = new System.Drawing.Point(340, 162);
      this.cmbCondition.Name = "cmbCondition";
      this.cmbCondition.Size = new System.Drawing.Size(174, 26);
      this.cmbCondition.TabIndex = 27;
      // 
      // cmbBrand
      // 
      this.cmbBrand.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.cmbBrand.FormattingEnabled = true;
      this.cmbBrand.Location = new System.Drawing.Point(124, 37);
      this.cmbBrand.Name = "cmbBrand";
      this.cmbBrand.Size = new System.Drawing.Size(121, 26);
      this.cmbBrand.TabIndex = 28;
      // 
      // vehiclePurchaseManagementsDataSet
      // 
      this.vehiclePurchaseManagementsDataSet.DataSetName = "VehiclePurchaseManagementsDataSet";
      this.vehiclePurchaseManagementsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
      // 
      // frmAddVehicle
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1102, 605);
      this.Controls.Add(this.btnClose);
      this.Controls.Add(this.groupBox2);
      this.Controls.Add(this.groupBox1);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "frmAddVehicle";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "  ";
      this.Load += new System.EventHandler(this.frmAddVehicle_Load);
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.groupBox2.ResumeLayout(false);
      this.groupBox2.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.vehiclePurchaseManagementsDataSet)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.Button btnSave;
    private System.Windows.Forms.Button btnUpdate;
    private System.Windows.Forms.Button btnClear;
    private System.Windows.Forms.Label label11;
    private System.Windows.Forms.TextBox txtEngineCapacity;
    private System.Windows.Forms.Label label10;
    private System.Windows.Forms.TextBox txtMilage;
    private System.Windows.Forms.Label label9;
    private System.Windows.Forms.TextBox txtChassieNumber;
    private System.Windows.Forms.Label label8;
    private System.Windows.Forms.TextBox txtEngineNumber;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.TextBox txtRegYear;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.TextBox txtRegNum;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.ComboBox cmbVehicleCategory;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.ComboBox cmbType;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TextBox txtModelYear;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox txtModel;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.GroupBox groupBox2;
    private System.Windows.Forms.ListView listPartInventory;
    private System.Windows.Forms.ColumnHeader columnHeader1;
    private System.Windows.Forms.ColumnHeader columnHeader2;
    private System.Windows.Forms.TextBox txtNote;
    private System.Windows.Forms.Label label13;
    private System.Windows.Forms.Button btnClose;
    private System.Windows.Forms.Button btnSelectItem;
    private System.Windows.Forms.ListBox lbSelectedItems;
    private System.Windows.Forms.Button btnRemovePart;
    private System.Windows.Forms.Label label14;
    private System.Windows.Forms.Label label12;
    private System.Windows.Forms.ComboBox cmbFuelType;
    private System.Windows.Forms.ComboBox cmbCondition;
    private System.Windows.Forms.ComboBox cmbTransmission;
    private System.Windows.Forms.Label label17;
    private System.Windows.Forms.Label label16;
    private System.Windows.Forms.Label label15;
    private System.Windows.Forms.ComboBox cmbBrand;
    private VehiclePurchaseManagementsDataSet vehiclePurchaseManagementsDataSet;
  }
}