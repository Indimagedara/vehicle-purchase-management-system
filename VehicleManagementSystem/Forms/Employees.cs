using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VehicleManagementSystem.Forms
{
  public partial class frmEmployees : Form
  {
    VehicleManagementEntities ve;
    int Id = 0;
    public frmEmployees()
    {
      InitializeComponent();
    }

    private void btnSave_Click(object sender, EventArgs e)
    {
      if(txtName.Text != null && txtNic.Text != null && txtPhone.Text != null && cmbEmpType.SelectedItem != null && cmbSalType.SelectedItem != null)
      {
        ve = new VehicleManagementEntities();
        Employee employee = new Employee()
        {
          EmployeeName = txtName.Text,
          Nic = txtNic.Text,
          Phone = txtPhone.Text,
          EmpType = cmbEmpType.Text,
          SalaryType = cmbSalType.Text,
          Salary = Int32.Parse(txtSalary.Text)
        };
        ve.Employees.Add(employee);
        ve.SaveChanges();
        txtName.Text = "";
        txtNic.Text = "";
        txtPhone.Text = "";
        txtSalary.Text = "";
        cmbEmpType.Text = "";
        cmbSalType.Text = "";
        displayData();
        MessageBox.Show("Saved successfully");
      }
      else
      {
        MessageBox.Show("All fields are required");
      }
    }

    private void btnClose_Click(object sender, EventArgs e)
    {
      this.Hide();
    }
    private void displayData()
    {
      Cursor.Current = Cursors.WaitCursor;
      btnSave.Visible = true;
      btnUpdate.Visible = false;
      listVehicleCategory.Items.Clear();
      using(ve = new VehicleManagementEntities())
      {
        List<Employee> list = ve.Employees.ToList();
        foreach(Employee e in list)
        {
          ListViewItem item = new ListViewItem(e.EmployeeId.ToString());
          item.SubItems.Add(e.EmployeeName);
          item.SubItems.Add(e.Nic);
          item.SubItems.Add(e.Phone);
          item.SubItems.Add(e.EmpType);
          item.SubItems.Add(e.SalaryType);
          item.SubItems.Add(e.Salary.ToString());
          listVehicleCategory.Items.Add(item);
        }

      }
      Cursor.Current = Cursors.Default;
    }

    private void frmEmployees_Load(object sender, EventArgs e)
    {
      displayData();
    }

    private void listVehicleCategory_SelectedIndexChanged(object sender, EventArgs e)
    {
      ListView.SelectedListViewItemCollection selectedEmployee = this.listVehicleCategory.SelectedItems;
      string empName = "";
      string nic = "";
      string phone = "";
      string empType = "";
      string salaryType = "";
      string salary = "";
      foreach(ListViewItem item in selectedEmployee)
      {
        Id = Int32.Parse(item.SubItems[0].Text);
        empName = item.SubItems[1].Text;
        nic = item.SubItems[2].Text;
        phone = item.SubItems[3].Text;
        empType = item.SubItems[4].Text;
        salaryType = item.SubItems[5].Text;
        salary = item.SubItems[6].Text;
      }
      txtName.Text = empName;
      txtNic.Text = nic;
      txtPhone.Text = phone;
      cmbEmpType.Text = empType;
      cmbSalType.Text = salaryType;
      txtSalary.Text = salary;
      btnSave.Visible = false;
      btnUpdate.Visible = true;
    }

    private void clearFields()
    {
      txtName.Text = "";
      txtNic.Text = "";
      txtPhone.Text = "";
      cmbEmpType.Text = "";
      cmbSalType.Text = "";
      txtSalary.Text = "";
      btnSave.Visible = true;
      btnUpdate.Visible = false;
    }

    private void btnClear_Click(object sender, EventArgs e)
    {
      clearFields();
    }

    private void btnUpdate_Click(object sender, EventArgs e)
    {
      if(!String.IsNullOrEmpty(txtName.Text) && !string.IsNullOrEmpty(txtNic.Text) && !string.IsNullOrEmpty(txtPhone.Text) && !string.IsNullOrEmpty(cmbEmpType.Text) && !string.IsNullOrEmpty(cmbSalType.Text) && !string.IsNullOrEmpty(txtSalary.Text))
      {
        ve = new VehicleManagementEntities();
        var singleEmployee = ve.Employees.Where(r => r.EmployeeId == Id).First();
        singleEmployee.EmployeeName = txtName.Text;
        singleEmployee.Nic = txtNic.Text;
        singleEmployee.Phone = txtPhone.Text;
        singleEmployee.EmpType = cmbEmpType.Text;
        singleEmployee.SalaryType = cmbSalType.Text;
        singleEmployee.Salary = Int32.Parse(txtSalary.Text);
        ve.SaveChanges();
        MessageBox.Show("Successfully saved!");
        displayData();
        clearFields();
      }
      else
      {
        MessageBox.Show("Cannnot submit empty fields.");
      }
    }
  }
}
