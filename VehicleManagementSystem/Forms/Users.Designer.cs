
namespace VehicleManagementSystem.Forms
{
  partial class frmUsers
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
      this.txtUsername = new System.Windows.Forms.TextBox();
      this.button1 = new System.Windows.Forms.Button();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.txtPassword = new System.Windows.Forms.TextBox();
      this.dataGridView1 = new System.Windows.Forms.DataGridView();
      this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.btnClose = new System.Windows.Forms.Button();
      this.vehiclePurchaseManagementsDataSet = new VehicleManagementSystem.VehiclePurchaseManagementsDataSet();
      this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.userTableAdapter = new VehicleManagementSystem.VehiclePurchaseManagementsDataSetTableAdapters.UserTableAdapter();
      this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.button2 = new System.Windows.Forms.Button();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.vehiclePurchaseManagementsDataSet)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
      this.SuspendLayout();
      // 
      // txtUsername
      // 
      this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtUsername.Location = new System.Drawing.Point(122, 48);
      this.txtUsername.Name = "txtUsername";
      this.txtUsername.Size = new System.Drawing.Size(187, 22);
      this.txtUsername.TabIndex = 0;
      // 
      // button1
      // 
      this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.button1.Location = new System.Drawing.Point(234, 102);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(75, 23);
      this.button1.TabIndex = 1;
      this.button1.Text = "&Save";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.Location = new System.Drawing.Point(39, 51);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(77, 16);
      this.label1.TabIndex = 2;
      this.label1.Text = "Username :";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label2.Location = new System.Drawing.Point(39, 77);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(74, 16);
      this.label2.TabIndex = 4;
      this.label2.Text = "Password :";
      // 
      // txtPassword
      // 
      this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtPassword.Location = new System.Drawing.Point(122, 74);
      this.txtPassword.Name = "txtPassword";
      this.txtPassword.Size = new System.Drawing.Size(187, 22);
      this.txtPassword.TabIndex = 3;
      // 
      // dataGridView1
      // 
      this.dataGridView1.AutoGenerateColumns = false;
      this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
      this.dataGridView1.DataSource = this.userBindingSource;
      this.dataGridView1.Location = new System.Drawing.Point(42, 164);
      this.dataGridView1.Name = "dataGridView1";
      this.dataGridView1.Size = new System.Drawing.Size(267, 152);
      this.dataGridView1.TabIndex = 5;
      // 
      // usersBindingSource
      // 
      this.usersBindingSource.DataMember = "Users";
      // 
      // btnClose
      // 
      this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnClose.Location = new System.Drawing.Point(234, 340);
      this.btnClose.Name = "btnClose";
      this.btnClose.Size = new System.Drawing.Size(75, 23);
      this.btnClose.TabIndex = 6;
      this.btnClose.Text = "&Close";
      this.btnClose.UseVisualStyleBackColor = true;
      this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
      // 
      // vehiclePurchaseManagementsDataSet
      // 
      this.vehiclePurchaseManagementsDataSet.DataSetName = "VehiclePurchaseManagementsDataSet";
      this.vehiclePurchaseManagementsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
      // 
      // userBindingSource
      // 
      this.userBindingSource.DataMember = "User";
      this.userBindingSource.DataSource = this.vehiclePurchaseManagementsDataSet;
      // 
      // userTableAdapter
      // 
      this.userTableAdapter.ClearBeforeFill = true;
      // 
      // dataGridViewTextBoxColumn1
      // 
      this.dataGridViewTextBoxColumn1.DataPropertyName = "UserId";
      this.dataGridViewTextBoxColumn1.HeaderText = "UserId";
      this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
      this.dataGridViewTextBoxColumn1.ReadOnly = true;
      // 
      // dataGridViewTextBoxColumn2
      // 
      this.dataGridViewTextBoxColumn2.DataPropertyName = "Username";
      this.dataGridViewTextBoxColumn2.HeaderText = "Username";
      this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
      // 
      // button2
      // 
      this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.button2.Location = new System.Drawing.Point(153, 102);
      this.button2.Name = "button2";
      this.button2.Size = new System.Drawing.Size(75, 23);
      this.button2.TabIndex = 7;
      this.button2.Text = "&Clear";
      this.button2.UseVisualStyleBackColor = true;
      // 
      // frmUsers
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(334, 395);
      this.Controls.Add(this.button2);
      this.Controls.Add(this.btnClose);
      this.Controls.Add(this.dataGridView1);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.txtPassword);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.button1);
      this.Controls.Add(this.txtUsername);
      this.Name = "frmUsers";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Users";
      this.Load += new System.EventHandler(this.frmUsers_Load);
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.vehiclePurchaseManagementsDataSet)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TextBox txtUsername;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox txtPassword;
    private System.Windows.Forms.DataGridView dataGridView1;
    private System.Windows.Forms.BindingSource usersBindingSource;
    private System.Windows.Forms.DataGridViewTextBoxColumn userIdDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
    private System.Windows.Forms.Button btnClose;
    private VehiclePurchaseManagementsDataSet vehiclePurchaseManagementsDataSet;
    private System.Windows.Forms.BindingSource userBindingSource;
    private VehiclePurchaseManagementsDataSetTableAdapters.UserTableAdapter userTableAdapter;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    private System.Windows.Forms.Button button2;
  }
}