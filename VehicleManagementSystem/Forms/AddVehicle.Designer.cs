
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
      this.label1 = new System.Windows.Forms.Label();
      this.txtModel = new System.Windows.Forms.TextBox();
      this.txtModelYear = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.cmbType = new System.Windows.Forms.ComboBox();
      this.cmbVehicleCategory = new System.Windows.Forms.ComboBox();
      this.label4 = new System.Windows.Forms.Label();
      this.txtRegNum = new System.Windows.Forms.TextBox();
      this.label5 = new System.Windows.Forms.Label();
      this.txtRegYear = new System.Windows.Forms.TextBox();
      this.label6 = new System.Windows.Forms.Label();
      this.txtEngineNumber = new System.Windows.Forms.TextBox();
      this.label7 = new System.Windows.Forms.Label();
      this.txtChassieNumber = new System.Windows.Forms.TextBox();
      this.label8 = new System.Windows.Forms.Label();
      this.txtMilage = new System.Windows.Forms.TextBox();
      this.label9 = new System.Windows.Forms.Label();
      this.txtEngineCapacity = new System.Windows.Forms.TextBox();
      this.label10 = new System.Windows.Forms.Label();
      this.txtFuelType = new System.Windows.Forms.TextBox();
      this.label11 = new System.Windows.Forms.Label();
      this.btnClear = new System.Windows.Forms.Button();
      this.btnUpdate = new System.Windows.Forms.Button();
      this.btnSave = new System.Windows.Forms.Button();
      this.groupBox2 = new System.Windows.Forms.GroupBox();
      this.listPartInventory = new System.Windows.Forms.ListView();
      this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.groupBox1.SuspendLayout();
      this.groupBox2.SuspendLayout();
      this.SuspendLayout();
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.btnSave);
      this.groupBox1.Controls.Add(this.btnUpdate);
      this.groupBox1.Controls.Add(this.btnClear);
      this.groupBox1.Controls.Add(this.txtFuelType);
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
      this.groupBox1.Size = new System.Drawing.Size(1078, 172);
      this.groupBox1.TabIndex = 0;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Vehicle Details";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.Location = new System.Drawing.Point(16, 38);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(61, 18);
      this.label1.TabIndex = 0;
      this.label1.Text = "Model : ";
      // 
      // txtModel
      // 
      this.txtModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtModel.Location = new System.Drawing.Point(73, 35);
      this.txtModel.Name = "txtModel";
      this.txtModel.Size = new System.Drawing.Size(172, 24);
      this.txtModel.TabIndex = 1;
      // 
      // txtModelYear
      // 
      this.txtModelYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtModelYear.Location = new System.Drawing.Point(342, 35);
      this.txtModelYear.Name = "txtModelYear";
      this.txtModelYear.Size = new System.Drawing.Size(172, 24);
      this.txtModelYear.TabIndex = 3;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label2.Location = new System.Drawing.Point(256, 38);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(91, 18);
      this.label2.TabIndex = 2;
      this.label2.Text = "Model Year: ";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label3.Location = new System.Drawing.Point(528, 39);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(103, 18);
      this.label3.TabIndex = 2;
      this.label3.Text = "Vehicle Type : ";
      // 
      // cmbType
      // 
      this.cmbType.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.cmbType.FormattingEnabled = true;
      this.cmbType.Location = new System.Drawing.Point(627, 35);
      this.cmbType.Name = "cmbType";
      this.cmbType.Size = new System.Drawing.Size(145, 26);
      this.cmbType.TabIndex = 4;
      // 
      // cmbVehicleCategory
      // 
      this.cmbVehicleCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.cmbVehicleCategory.FormattingEnabled = true;
      this.cmbVehicleCategory.Location = new System.Drawing.Point(912, 35);
      this.cmbVehicleCategory.Name = "cmbVehicleCategory";
      this.cmbVehicleCategory.Size = new System.Drawing.Size(145, 26);
      this.cmbVehicleCategory.TabIndex = 6;
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label4.Location = new System.Drawing.Point(784, 39);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(131, 18);
      this.label4.TabIndex = 5;
      this.label4.Text = "Vehicle Category : ";
      // 
      // txtRegNum
      // 
      this.txtRegNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtRegNum.Location = new System.Drawing.Point(166, 76);
      this.txtRegNum.Name = "txtRegNum";
      this.txtRegNum.Size = new System.Drawing.Size(79, 24);
      this.txtRegNum.TabIndex = 8;
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label5.Location = new System.Drawing.Point(16, 79);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(156, 18);
      this.label5.TabIndex = 7;
      this.label5.Text = "Registration Number : ";
      // 
      // txtRegYear
      // 
      this.txtRegYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtRegYear.Location = new System.Drawing.Point(386, 76);
      this.txtRegYear.Name = "txtRegYear";
      this.txtRegYear.Size = new System.Drawing.Size(128, 24);
      this.txtRegYear.TabIndex = 10;
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label6.Location = new System.Drawing.Point(256, 79);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(133, 18);
      this.label6.TabIndex = 9;
      this.label6.Text = "Registration Year : ";
      // 
      // txtEngineNumber
      // 
      this.txtEngineNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtEngineNumber.Location = new System.Drawing.Point(644, 76);
      this.txtEngineNumber.Name = "txtEngineNumber";
      this.txtEngineNumber.Size = new System.Drawing.Size(128, 24);
      this.txtEngineNumber.TabIndex = 12;
      // 
      // label7
      // 
      this.label7.AutoSize = true;
      this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label7.Location = new System.Drawing.Point(528, 79);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(122, 18);
      this.label7.TabIndex = 11;
      this.label7.Text = "Engine Number : ";
      // 
      // txtChassieNumber
      // 
      this.txtChassieNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtChassieNumber.Location = new System.Drawing.Point(914, 76);
      this.txtChassieNumber.Name = "txtChassieNumber";
      this.txtChassieNumber.Size = new System.Drawing.Size(143, 24);
      this.txtChassieNumber.TabIndex = 14;
      // 
      // label8
      // 
      this.label8.AutoSize = true;
      this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label8.Location = new System.Drawing.Point(784, 79);
      this.label8.Name = "label8";
      this.label8.Size = new System.Drawing.Size(131, 18);
      this.label8.TabIndex = 13;
      this.label8.Text = "Chassie Number : ";
      // 
      // txtMilage
      // 
      this.txtMilage.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtMilage.Location = new System.Drawing.Point(73, 113);
      this.txtMilage.Name = "txtMilage";
      this.txtMilage.Size = new System.Drawing.Size(172, 24);
      this.txtMilage.TabIndex = 16;
      // 
      // label9
      // 
      this.label9.AutoSize = true;
      this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label9.Location = new System.Drawing.Point(16, 116);
      this.label9.Name = "label9";
      this.label9.Size = new System.Drawing.Size(63, 18);
      this.label9.TabIndex = 15;
      this.label9.Text = "Milage : ";
      // 
      // txtEngineCapacity
      // 
      this.txtEngineCapacity.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtEngineCapacity.Location = new System.Drawing.Point(378, 113);
      this.txtEngineCapacity.Name = "txtEngineCapacity";
      this.txtEngineCapacity.Size = new System.Drawing.Size(136, 24);
      this.txtEngineCapacity.TabIndex = 18;
      // 
      // label10
      // 
      this.label10.AutoSize = true;
      this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label10.Location = new System.Drawing.Point(256, 116);
      this.label10.Name = "label10";
      this.label10.Size = new System.Drawing.Size(126, 18);
      this.label10.TabIndex = 17;
      this.label10.Text = "Engine Capacity : ";
      // 
      // txtFuelType
      // 
      this.txtFuelType.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtFuelType.Location = new System.Drawing.Point(609, 113);
      this.txtFuelType.Name = "txtFuelType";
      this.txtFuelType.Size = new System.Drawing.Size(163, 24);
      this.txtFuelType.TabIndex = 20;
      // 
      // label11
      // 
      this.label11.AutoSize = true;
      this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label11.Location = new System.Drawing.Point(528, 116);
      this.label11.Name = "label11";
      this.label11.Size = new System.Drawing.Size(84, 18);
      this.label11.TabIndex = 19;
      this.label11.Text = "Fuel Type : ";
      // 
      // btnClear
      // 
      this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnClear.Location = new System.Drawing.Point(787, 113);
      this.btnClear.Name = "btnClear";
      this.btnClear.Size = new System.Drawing.Size(123, 26);
      this.btnClear.TabIndex = 1;
      this.btnClear.Text = "&Clear";
      this.btnClear.UseVisualStyleBackColor = true;
      // 
      // btnUpdate
      // 
      this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnUpdate.Location = new System.Drawing.Point(934, 113);
      this.btnUpdate.Name = "btnUpdate";
      this.btnUpdate.Size = new System.Drawing.Size(123, 26);
      this.btnUpdate.TabIndex = 2;
      this.btnUpdate.Text = "&Update";
      this.btnUpdate.UseVisualStyleBackColor = true;
      this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
      // 
      // btnSave
      // 
      this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnSave.Location = new System.Drawing.Point(934, 113);
      this.btnSave.Name = "btnSave";
      this.btnSave.Size = new System.Drawing.Size(123, 26);
      this.btnSave.TabIndex = 3;
      this.btnSave.Text = "&Save";
      this.btnSave.UseVisualStyleBackColor = true;
      // 
      // groupBox2
      // 
      this.groupBox2.Controls.Add(this.listPartInventory);
      this.groupBox2.Location = new System.Drawing.Point(12, 231);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Size = new System.Drawing.Size(1078, 302);
      this.groupBox2.TabIndex = 1;
      this.groupBox2.TabStop = false;
      this.groupBox2.Text = "Part Inventory";
      // 
      // listPartInventory
      // 
      this.listPartInventory.CheckBoxes = true;
      this.listPartInventory.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
      this.listPartInventory.FullRowSelect = true;
      this.listPartInventory.GridLines = true;
      this.listPartInventory.HideSelection = false;
      this.listPartInventory.Location = new System.Drawing.Point(19, 53);
      this.listPartInventory.Name = "listPartInventory";
      this.listPartInventory.Size = new System.Drawing.Size(707, 217);
      this.listPartInventory.TabIndex = 0;
      this.listPartInventory.UseCompatibleStateImageBehavior = false;
      this.listPartInventory.View = System.Windows.Forms.View.Details;
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
      // columnHeader3
      // 
      this.columnHeader3.Text = "Status";
      this.columnHeader3.Width = 100;
      // 
      // columnHeader4
      // 
      this.columnHeader4.Text = "Note";
      this.columnHeader4.Width = 300;
      // 
      // frmAddVehicle
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1102, 560);
      this.Controls.Add(this.groupBox2);
      this.Controls.Add(this.groupBox1);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "frmAddVehicle";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Add Vehicle";
      this.Load += new System.EventHandler(this.frmAddVehicle_Load);
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.groupBox2.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.Button btnSave;
    private System.Windows.Forms.Button btnUpdate;
    private System.Windows.Forms.Button btnClear;
    private System.Windows.Forms.TextBox txtFuelType;
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
    private System.Windows.Forms.ColumnHeader columnHeader3;
    private System.Windows.Forms.ColumnHeader columnHeader4;
  }
}