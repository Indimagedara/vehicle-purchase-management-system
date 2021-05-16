using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VehicleManagementSystem.Forms;

namespace VehicleManagementSystem
{
  public partial class frmDashboard : Form
  {
    VehicleManagementEntities ve;
    public static int Id = 0;
    public static string selectedRegNum;
    public int selectedSalId = 0;
    public decimal totalIncomeForPeriod = 0;
    public decimal totalExpenseForPeriod = 0;
    public decimal totalExpenses = 0;
    public decimal totalSalaries = 0;
    public decimal totalJobAmount = 0;
    public frmDashboard()
    {
      InitializeComponent();
    }

    private void vehicleTypesToolStripMenuItem_Click(object sender, EventArgs e)
    {
      frmVehicleType vehicleType = new frmVehicleType();
      vehicleType.Show();
    }

    private void vehicleCategoryToolStripMenuItem_Click(object sender, EventArgs e)
    {
      frmVehicleCategory vehicleCategory = new frmVehicleCategory();
      vehicleCategory.Show();
    }


    private void inventoryToolStripMenuItem_Click(object sender, EventArgs e)
    {
      frmInventory inventory = new frmInventory();
      inventory.Show();
    }

    private void employeesToolStripMenuItem_Click(object sender, EventArgs e)
    {
      frmEmployees employees = new frmEmployees();
      employees.Show();
    }

    private void usersToolStripMenuItem_Click(object sender, EventArgs e)
    {
      frmUsers users = new frmUsers();
      users.Show();
    }

    private void addVehicleToolStripMenuItem_Click(object sender, EventArgs e)
    {
      frmAddVehicle addVehicle = new frmAddVehicle();
      addVehicle.Show();
    }

    private void brandsToolStripMenuItem_Click(object sender, EventArgs e)
    {
      frmBrands brands = new frmBrands();
      brands.Show();
    }

    private void frmDashboard_Load(object sender, EventArgs e)
    {
      fetchVehicleData();
      fetchEmpSalary();
      fetchEmployees();
      fetchStats();
    }

    private void fetchVehicleData()
    {
      Cursor.Current = Cursors.WaitCursor;
      listVehicles.Items.Clear();
      using(ve = new VehicleManagementEntities())
      {
        var query = ve.Vehicles
          .Join(
            ve.Categories,
            vh => vh.CategoryId,
            vc => vc.CategoryId,
            (vh,vc) => new {vh,vc}
          )
          .Join(
            ve.VehicleTypes,
            v => v.vh.TypeId,
            vt => vt.VehicleTypeId,
            (v, vt) => new
            {
              VehicleId = v.vh.VehicleId,
              Brand = v.vh.Brand,
              Model = v.vh.Model,
              RegNum = v.vh.RegNum,
              VehicleType = vt.VehiType,
              VehicleCategory = v.vc.Category1,
              Date = v.vh.DateCreated
            }
          ).ToList();
        foreach(var vehi in query)
        {
          ListViewItem item = new ListViewItem(vehi.VehicleId.ToString());
          item.SubItems.Add(vehi.RegNum);
          item.SubItems.Add(vehi.Model);
          item.SubItems.Add(vehi.Brand);
          item.SubItems.Add(vehi.VehicleType);
          item.SubItems.Add(vehi.VehicleCategory);
          item.SubItems.Add(vehi.Date.ToString("dd/MM/yyyy"));
          listVehicles.Items.Add(item);
        }

      }
      Cursor.Current = Cursors.Default;
    }

    private void btnOpen_Click(object sender, EventArgs e)
    {
      frmSingleVehicle singleVehicle = new frmSingleVehicle();
      singleVehicle.Show();
    }

    private void listVehicles_SelectedIndexChanged(object sender, EventArgs e)
    {
      ListView.SelectedListViewItemCollection selectedVehicle = this.listVehicles.SelectedItems;
      string vehicleType = "";
      foreach (ListViewItem item in selectedVehicle)
      {
        Id = Int32.Parse(item.SubItems[0].Text);
        selectedRegNum = item.SubItems[1].Text;
      }
    }

    private void contractorsToolStripMenuItem_Click(object sender, EventArgs e)
    {
      frmContractor contractor = new frmContractor();
      contractor.Show();
    }

    private void btnSearch_Click(object sender, EventArgs e)
    {
      if (!string.IsNullOrEmpty(txtSearch.Text))
      {
        using (ve = new VehicleManagementEntities()) { 
          var query = ve.Vehicles
            .Join(
              ve.Categories,
              vh => vh.CategoryId,
              vc => vc.CategoryId,
              (vh, vc) => new { vh, vc }
            )
            .Join(
              ve.VehicleTypes,
              v => v.vh.TypeId,
              vt => vt.VehicleTypeId,
              (v, vt) => new
              {
                VehicleId = v.vh.VehicleId,
                Brand = v.vh.Brand,
                Model = v.vh.Model,
                RegNum = v.vh.RegNum,
                VehicleType = vt.VehiType,
                VehicleCategory = v.vc.Category1,
                Date = v.vh.DateCreated
              }
            ).Where(r => r.RegNum.Contains(txtSearch.Text)).ToList();
          listVehicles.Items.Clear();
        foreach (var vehi in query)
        {
          ListViewItem item = new ListViewItem(vehi.VehicleId.ToString());
          item.SubItems.Add(vehi.RegNum);
          item.SubItems.Add(vehi.Model);
          item.SubItems.Add(vehi.Brand);
          item.SubItems.Add(vehi.VehicleType);
          item.SubItems.Add(vehi.VehicleCategory);
          item.SubItems.Add(vehi.Date.ToString("dd/MM/yyyy"));
          listVehicles.Items.Add(item);
        }

      }
      Cursor.Current = Cursors.Default;
    }
    }

    private void btnResetSearch_Click(object sender, EventArgs e)
    {
      txtSearch.Text = "";
      fetchVehicleData();
    }

    private void fetchEmpSalary()
    {
      using (ve = new VehicleManagementEntities())
      {
        int year = DateTime.Now.Year;
        int month = DateTime.Now.Month;
        listEmpSalary.Items.Clear();
        List<EmployeeSalaries> list = ve.EmployeeSalaries1.Where(r=>r.DatePayed.Year == (year) && r.DatePayed.Month == (month)).ToList();
        foreach (EmployeeSalaries eSal in list)
        {
          ListViewItem item = new ListViewItem(eSal.SalaryId.ToString());
          item.SubItems.Add(eSal.Employee.EmployeeName);
          item.SubItems.Add(eSal.Amount.ToString());
          item.SubItems.Add(eSal.Description);
          item.SubItems.Add(eSal.DatePayed.ToString());
          listEmpSalary.Items.Add(item);
        }
      }
    }

    private void fetchEmployees()
    {
      using (ve = new VehicleManagementEntities())
      {
        cmbEmployees.Items.Clear();
        List<Employee> list = ve.Employees.ToList();
        List<cmbBoxValues> cmbData = new List<cmbBoxValues>();
        foreach (Employee c in list)
        {
          cmbData.Add(new cmbBoxValues() { cmbVal = Int32.Parse(c.EmployeeId.ToString()), cmbName = c.EmployeeName, extraValues = c.Salary.ToString(), extraValues2 = c.SalaryType });
        }
        cmbEmployees.DataSource = cmbData;
        cmbEmployees.DisplayMember = "cmbName";
      }
    }

    private void btnAddSalary_Click(object sender, EventArgs e)
    {
      if(!string.IsNullOrEmpty(cmbEmployees.Text) && !string.IsNullOrEmpty(txtSalaryAmount.Text))
      {
        ve = new VehicleManagementEntities();
        cmbBoxValues selEmp = cmbEmployees.SelectedItem as cmbBoxValues;
        int selectedEmployee = selEmp.cmbVal;
        EmployeeSalaries employeeSalary = new EmployeeSalaries()
        {
          EmployeeId = long.Parse(selectedEmployee.ToString()),
          Amount = double.Parse(txtSalaryAmount.Text),
          Description = txtDescription.Text,
          Status = "1",
          DatePayed = DateTime.Now
        };
        ve.EmployeeSalaries1.Add(employeeSalary);
        ve.SaveChanges();
        MessageBox.Show("Salary saved successfully!");
        fetchEmpSalary();
      }
      else
      {
        MessageBox.Show("You must fill all fields!");
      }
    }

    private void btnClearSalary_Click(object sender, EventArgs e)
    {
      clearSalFields();
    }

    private void clearSalFields()
    {
      txtDescription.Text = "";
      cmbEmployees.Text = "";
      txtSalaryAmount.Text = "";
      btnUpdateSalary.Enabled = false;
      btnDeleteSalary.Enabled = false;
      btnAddSalary.Enabled = true;
      btnClearSalary.Enabled = true;      
    }

    private void btnUpdateSalary_Click(object sender, EventArgs e)
    {
      if (!string.IsNullOrEmpty(cmbEmployees.Text) && !string.IsNullOrEmpty(txtSalaryAmount.Text))
      {
        ve = new VehicleManagementEntities();
        cmbBoxValues selEmp = cmbEmployees.SelectedItem as cmbBoxValues;
        int selectedEmployee = selEmp.cmbVal;

        var singleContractor = ve.EmployeeSalaries1.Where(r => r.SalaryId == selectedSalId).First();
        singleContractor.EmployeeId = long.Parse(selectedEmployee.ToString());
        singleContractor.Amount = double.Parse(txtSalaryAmount.Text);
        singleContractor.Description = txtDescription.Text;
        singleContractor.Status = "1";
        ve.SaveChanges();
        MessageBox.Show("Salary successfully updated!");
        fetchEmpSalary();
        clearSalFields();
        selectedSalId = 0;
      }
      else
      {
        MessageBox.Show("You must fill all fields!");
      }
    }

    private void listEmpSalary_SelectedIndexChanged(object sender, EventArgs e)
    {
      ListView.SelectedListViewItemCollection selectedSalary = this.listEmpSalary.SelectedItems;
      string vehicleType = "";
      foreach (ListViewItem item in selectedSalary)
      {
        selectedSalId = Int32.Parse(item.SubItems[0].Text);
        cmbEmployees.Text = item.SubItems[1].Text;
        txtSalaryAmount.Text = item.SubItems[2].Text;
        txtDescription.Text = item.SubItems[3].Text;
      }
      btnUpdateSalary.Enabled = true;
      btnDeleteSalary.Enabled = true;
      btnAddSalary.Enabled = false;
      btnClearSalary.Enabled = true;
    }

    private void btnDeleteSalary_Click(object sender, EventArgs e)
    {
      DialogResult res = MessageBox.Show("Are you sure you want to Delete this Salary? You cannot reverse this action.", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
      if (res == DialogResult.OK)
      {
        ve = new VehicleManagementEntities();
        var singleSalary = ve.EmployeeSalaries1.Where(r => r.SalaryId == selectedSalId).First();
        ve.EmployeeSalaries1.Remove(singleSalary);
        ve.SaveChanges();
        MessageBox.Show("Payment successfully deleted!");
        fetchEmpSalary();
        clearSalFields();
        selectedSalId = 0;
      }
    }

    private void cmbEmployees_SelectedIndexChanged(object sender, EventArgs e)
    {
      cmbBoxValues cmbBoxValues = cmbEmployees.SelectedItem as cmbBoxValues;
      txtSalaryAmount.Text = cmbBoxValues.extraValues.ToString();
      lblSalType.Text = cmbBoxValues.extraValues2.ToString();
    }

    private void fetchStats()
    {
      lblCurrentMonth.Text = DateTime.Now.Year.ToString() + "-" + DateTime.Now.Month.ToString();
    }

    private void calculateIncome()
    {
      decimal totalIncome = 0;
      ve = new VehicleManagementEntities();
      List<Payment> payments = ve.Payments.Where(r => r.DatePayed.Year == (DateTime.Now.Year) && r.DatePayed.Month == (DateTime.Now.Month)).ToList();
      foreach(Payment payment in payments)
      {
        totalIncome = totalIncome + (decimal)payment.Amount;
      }
      totalIncomeForPeriod = totalIncome;
    }
    
    private void calculateExpense()
    {
      decimal totalExp = 0;
      //Calculate expenses
      ve = new VehicleManagementEntities();
      List<Expens> expenses = ve.Expenses.Where(s => s.DateCreated.Year == (DateTime.Now.Year) && s.DateCreated.Month == (DateTime.Now.Month)).ToList();
      foreach (Expens exp in expenses)
      {
        totalExp = totalExp + (decimal)exp.Amount;
      }
      totalExpenseForPeriod = totalExpenseForPeriod+totalExp;
      
      //Calculate Salary
      ve = new VehicleManagementEntities();
      List<EmployeeSalaries> salaries = ve.EmployeeSalaries1.Where(s => s.DatePayed.Year == (DateTime.Now.Year) && s.DatePayed.Month == (DateTime.Now.Month)).ToList();
      foreach (EmployeeSalaries sal in salaries)
      {
        totalExp = totalExp + (decimal)sal.Amount;
      }
      totalExpenseForPeriod = totalExpenseForPeriod+totalExp;
      
      //Calculate Salary
      ve = new VehicleManagementEntities();
      List<Job> jobs = ve.Jobs.Where(s => s.CreatedDate.Year == (DateTime.Now.Year) && s.CreatedDate.Month == (DateTime.Now.Month)).ToList();
      foreach (Job job in jobs)
      {
        totalExp = totalExp + (decimal)job.Amount;
      }
      totalExpenseForPeriod = totalExpenseForPeriod+totalExp;

      //Calculate SUM of Income and expense

    }
  }
}
