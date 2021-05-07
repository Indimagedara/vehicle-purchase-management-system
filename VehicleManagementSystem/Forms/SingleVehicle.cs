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
  public partial class frmSingleVehicle : Form
  {
    VehicleManagementEntities ve;
    public static int selectedId = frmDashboard.Id;
    public static string vehicleNumber = frmDashboard.selectedRegNum;
    public int vehicleId = 0;
    public int selectedJobID = 0;
    public int selectedExpenseId = 0;
    string partInventory;
    public frmSingleVehicle()
    {
      InitializeComponent();
    }

    private void frmSingleVehicle_Load(object sender, EventArgs e)
    {
      fetchData();
      fetchSellerData();
      fetchJobs();
      fetchExpenses();
      //btnAddSeller.Visible = false;
    }
    public void fetchSellerData()
    {
      using (ve = new VehicleManagementEntities())
      {
        List<VehicleSeller> vehicleSellers = ve.VehicleSellers.Where(v => v.VehicleNumber == vehicleNumber).ToList();
        if (vehicleSellers.Any())
        {
          btnAddSeller.Text = "&Add / Update Info";
          foreach(VehicleSeller seller in vehicleSellers)
          {
            lblSellerName.Text = seller.SellerName;
            lblSellerPhone.Text = seller.SellerContactNumber;
            lblSellerAddress.Text = seller.SellerAddress;
            lblSellerType.Text = seller.SellerType;
          }
        }
        else
        {
          btnAddSeller.Text = "&Add Info";
        }
      }
    }
    
    private void fetchData()
    {
      Cursor.Current = Cursors.WaitCursor;
      using (ve = new VehicleManagementEntities())
      {
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
              RegYear = v.vh.RegYear,
              Model = v.vh.Model,
              ModelYear = v.vh.ModelYear,
              Condition = v.vh.Condition,
              Transmission = v.vh.Transmission,
              EngineNumber = v.vh.EngineNumber,
              ChassieNumber = v.vh.ChassieNumber,
              Milage = v.vh.Milage,
              EngineCapacity = v.vh.EngineCapacity,
              FuelType = v.vh.FuelType,
              Note = v.vh.Note,
              PartInventory = v.vh.PartInventory,
              RegNum = v.vh.RegNum,
              VehicleType = vt.VehiType,
              VehicleCategory = v.vc.Category1,
              Date = v.vh.DateCreated
            }
          ).Where(v => v.VehicleId == selectedId).ToList();
        foreach (var vehi in query)
        {
          ListViewItem item = new ListViewItem(vehi.VehicleId.ToString());
          vehicleId = Int32.Parse(vehi.VehicleId.ToString());
          this.Text = vehi.RegNum;
          lblRegNum.Text = vehi.RegNum;
          vehicleNumber = vehi.RegNum;
          lblModel.Text = vehi.Model;
          lblBrand.Text =vehi.Brand;
          lblType.Text = vehi.VehicleType;
          lblCategory.Text = vehi.VehicleCategory;
          lblRegYear.Text = vehi.RegYear.ToString();
          lblTransmission.Text = vehi.Transmission;
          lblCondition.Text = vehi.Condition;
          if(vehi.Condition == "Used")
          {
            lblCondition.BackColor = System.Drawing.Color.Yellow;
          }
          else if(vehi.Condition == "Unregistered")
          {
            lblCondition.BackColor = System.Drawing.Color.Green;
          }else if(vehi.Condition == "Damaged")
          {
            lblCondition.BackColor = System.Drawing.Color.Red;
          }
          lblEngineCap.Text = vehi.EngineCapacity.ToString()+" CC";
          lblEngineNum.Text = vehi.EngineNumber;
          lblChassieNum.Text = vehi.ChassieNumber;
          lblMilage.Text = vehi.Milage.ToString()+" Km";
          lblFuelType.Text = vehi.FuelType;
          lblModelYear.Text = vehi.ModelYear.ToString();
          lblDateCreated.Text = vehi.Date.ToString("dd/MM/yyyy");
          partInventory = vehi.PartInventory;
        }
        string[] partArray = partInventory.Split(',');
        foreach(string part in partArray)
        {
          lbParts.Items.Add(part);
        }

      }
      loadContractors();
      Cursor.Current = Cursors.Default;
    }

    private void loadContractors()
    {
      using(ve = new VehicleManagementEntities())
      {
        cmbContractors.Items.Clear();
        List<Contractor> list = ve.Contractors.ToList();
        List<cmbBoxValues> cmbData = new List<cmbBoxValues>();
        foreach (Contractor c in list)
        {
          cmbData.Add(new cmbBoxValues() { cmbVal = Int32.Parse(c.ContractorId.ToString()), cmbName = c.ContractorName, extraValues = c.ContractorType.ToString() });
        }
        cmbContractors.DataSource = cmbData;
        cmbContractors.DisplayMember = "cmbName";
      }
    }
    
    private void fetchJobs()
    {
      btnAddJob.Enabled = true;
      btnUpdateJob.Enabled = false;
      btnDeleteJob.Enabled = false;
      using(ve = new VehicleManagementEntities())
      {
        List<Job> jobList = ve.Jobs.Where(r => r.VehicleId == vehicleId).ToList();
        listJobs.Items.Clear();
        if (jobList.Any())
        {
          foreach (Job j in jobList)
          {
            ListViewItem item = new ListViewItem(j.JobId.ToString());
            item.SubItems.Add(j.JobTitle);
            item.SubItems.Add(j.Contractor1.ContractorName);
            item.SubItems.Add(j.Contractor1.ContractorType);
            item.SubItems.Add(j.Amount.ToString());
            item.SubItems.Add(j.Status.ToString());
            item.SubItems.Add(j.CreatedDate.ToString());
            listJobs.Items.Add(item);
          }
        }
      }
    }
    private void btnAddSeller_Click(object sender, EventArgs e)
    {
      frmAddSellerData addSellerData = new frmAddSellerData();
      addSellerData.Show();
    }

    private void btnAddJob_Click(object sender, EventArgs e)
    {
      if(!string.IsNullOrEmpty(txtJobTitle.Text) && !string.IsNullOrEmpty(cmbContractors.Text) && !string.IsNullOrEmpty(cmbConStatus.Text))
      {
        ve = new VehicleManagementEntities();
        if(ve.Jobs.Any(r => r.JobTitle == txtJobTitle.Text))
        {
          MessageBox.Show("This job is already exists!");
        }
        else
        {
          cmbBoxValues selCon = cmbContractors.SelectedItem as cmbBoxValues;
          int selectedContractor = selCon.cmbVal;
          Job job = new Job()
          {
            JobTitle = txtJobTitle.Text,
            VehicleId = vehicleId,
            Contractor = long.Parse(selectedContractor.ToString()),
            Amount = float.Parse(txtJobAmount.Value.ToString()),
            Status = cmbConStatus.Text,
            CreatedDate = DateTime.Now
          };
          ve.Jobs.Add(job);
          ve.SaveChanges();
          MessageBox.Show("Contractor successfully added!");
          fetchJobs();
          clearJobFields();
        }

      }
      else
      {
        MessageBox.Show("You must fill all fields!");
      }
    }

    private void clearJobFields()
    {
      txtJobTitle.Text = "";
      txtJobAmount.Text = "";
      cmbContractors.Text = "";
      cmbConStatus.Text = "";
      lblConType.Text = "-";
    }

    private void cmbContractors_SelectedIndexChanged(object sender, EventArgs e)
    {
      cmbBoxValues cmbBoxValues = cmbContractors.SelectedItem as cmbBoxValues;
      lblConType.Text = cmbBoxValues.extraValues.ToString();
    }

    private void btnUpdateJob_Click(object sender, EventArgs e)
    {
      if (!string.IsNullOrEmpty(txtJobTitle.Text) && !string.IsNullOrEmpty(cmbContractors.Text) && !string.IsNullOrEmpty(cmbConStatus.Text))
      {
        ve = new VehicleManagementEntities();
        cmbBoxValues selCon = cmbContractors.SelectedItem as cmbBoxValues;
        int selectedContractor = selCon.cmbVal;

        var singleJob = ve.Jobs.Where(r => r.JobId == selectedJobID).First();
        singleJob.JobTitle = txtJobTitle.Text;
        singleJob.Contractor = long.Parse(selectedContractor.ToString());
        singleJob.Amount = float.Parse(txtJobAmount.Value.ToString());
        singleJob.Status = cmbConStatus.Text;
        ve.SaveChanges();
        MessageBox.Show("Job successfully updated!");
        fetchJobs();
        clearJobFields();
        selectedJobID = 0;
      }
      else
      {
        MessageBox.Show("You must fill all fields!");
      }
    }

    private void listJobs_SelectedIndexChanged(object sender, EventArgs e)
    {
      btnAddJob.Enabled = false;
      btnUpdateJob.Enabled = true;
      btnDeleteJob.Enabled = true;
      ListView.SelectedListViewItemCollection itemCollection = listJobs.SelectedItems;
      foreach (ListViewItem item in itemCollection)
      {
        selectedJobID = Int32.Parse(item.SubItems[0].Text);
        txtJobTitle.Text = item.SubItems[1].Text;
        cmbContractors.Text = item.SubItems[2].Text;
        txtJobAmount.Value = Int32.Parse(item.SubItems[4].Text);
        cmbConStatus.Text = item.SubItems[5].Text;
      }
    }

    private void btnClearJob_Click(object sender, EventArgs e)
    {
      btnAddJob.Enabled = true;
      btnUpdateJob.Enabled = false;
      btnDeleteJob.Enabled = false;
      clearJobFields();
    }

    private void btnDeleteJob_Click(object sender, EventArgs e)
    {
      DialogResult res = MessageBox.Show("Are you sure you want to Delete this Job?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
      if (res == DialogResult.OK)
      {
        ve = new VehicleManagementEntities();
        var singleJob = ve.Jobs.Where(r => r.JobId == selectedJobID).First();
        ve.Jobs.Remove(singleJob);
        ve.SaveChanges();
        MessageBox.Show("Job successfully deleted!");
        fetchJobs();
        clearJobFields();
      }
    }

    private void btnAddExpense_Click(object sender, EventArgs e)
    {
      if (!string.IsNullOrEmpty(txtExpTitle.Text) && !string.IsNullOrEmpty(cmbExpType.Text))
      {
        ve = new VehicleManagementEntities();
        if (ve.Expenses.Any(r => r.ExpenseTitle == txtExpTitle.Text))
        {
          MessageBox.Show("This expense is already exists!");
        }
        else
        {
          Expenses expenses = new Expenses()
          {
            ExpenseTitle = txtExpTitle.Text,
            VehicleId = vehicleId,
            ExpenseType = cmbExpType.Text,
            Amount = long.Parse(numExpAmount.Value.ToString()),
            DateCreated = DateTime.Now
          };
          ve.Expenses.Add(expenses);
          ve.SaveChanges();
          MessageBox.Show("Expense successfully added!");
          fetchExpenses();
          clearExpenseFields();
        }
      }
      else
      {
        MessageBox.Show("You must fill all fields!");
      }
    }

    private void clearExpenseFields()
    {
      txtExpTitle.Text = "";
      cmbExpType.Text = "";
      numExpAmount.Value = 0;
      selectedExpenseId = 0;
      btnAddExpense.Enabled = true;
      btnDeleteExpense.Enabled = false;
      btnDeleteExpense.Enabled = false;
    }

    private void fetchExpenses()
    {
      btnAddExpense.Enabled = true;
      btnDeleteExpense.Enabled = false;
      btnDeleteExpense.Enabled = false;
      using (ve = new VehicleManagementEntities())
      {
        List<Expenses> expenseList = ve.Expenses.Where(r => r.VehicleId == vehicleId).ToList();
        listExpenses.Items.Clear();
        if (expenseList.Any())
        {
          foreach (Expenses exp in expenseList)
          {
            ListViewItem item = new ListViewItem(exp.ExpenseId.ToString());
            item.SubItems.Add(exp.ExpenseTitle);
            item.SubItems.Add(exp.ExpenseType);
            item.SubItems.Add(exp.Amount.ToString());
            item.SubItems.Add(exp.DateCreated.ToString());
            listExpenses.Items.Add(item);
          }
        }
      }
    }

    private void btnUpdateExpense_Click(object sender, EventArgs e)
    {
      if (!string.IsNullOrEmpty(txtExpTitle.Text) && !string.IsNullOrEmpty(cmbExpType.Text))
      {
        ve = new VehicleManagementEntities();

        var singleExp = ve.Expenses.Where(r => r.ExpenseId == selectedExpenseId).First();
        singleExp.ExpenseTitle = txtExpTitle.Text;
        singleExp.ExpenseType = cmbExpType.Text;
        singleExp.Amount = float.Parse(numExpAmount.Value.ToString());
        ve.SaveChanges();
        MessageBox.Show("Expense successfully updated!");
        fetchExpenses();
        clearExpenseFields();
        selectedExpenseId = 0;
      }
      else
      {
        MessageBox.Show("You must fill all fields!");
      }
    }

    private void listExpenses_SelectedIndexChanged(object sender, EventArgs e)
    {
      btnAddExpense.Enabled = false;
      btnUpdateExpense.Enabled = true;
      btnDeleteExpense.Enabled = true;
      ListView.SelectedListViewItemCollection itemCollection = listExpenses.SelectedItems;
      foreach (ListViewItem item in itemCollection)
      {
        selectedExpenseId = Int32.Parse(item.SubItems[0].Text);
        txtExpTitle.Text = item.SubItems[1].Text;
        cmbExpType.Text = item.SubItems[2].Text;
        numExpAmount.Value = Int32.Parse(item.SubItems[3].Text);
      }
    }

    private void btnClearExpense_Click(object sender, EventArgs e)
    {
      btnAddExpense.Enabled = true;
      btnUpdateExpense.Enabled = false;
      btnDeleteExpense.Enabled = false;
      clearExpenseFields();
    }

    private void btnDeleteExpense_Click(object sender, EventArgs e)
    {
      DialogResult res = MessageBox.Show("Are you sure you want to Delete this Expense?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
      if (res == DialogResult.OK)
      {
        ve = new VehicleManagementEntities();
        var singleExp = ve.Expenses.Where(r => r.ExpenseId == selectedExpenseId).First();
        ve.Expenses.Remove(singleExp);
        ve.SaveChanges();
        MessageBox.Show("Expense successfully deleted!");
        fetchExpenses();
        clearExpenseFields();
      }
    }
  }
}
