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
  public partial class frmContractor : Form
  {
    VehicleManagementEntities ve;
    public int id = 0;
    public frmContractor()
    {
      InitializeComponent();
    }

    private void btnClear_Click(object sender, EventArgs e)
    {
      clearFields();
      btnSave.Enabled = true;
      btnUpdate.Enabled = false;
      btnDelete.Enabled = false;
    }

    private void clearFields()
    {
      txtName.Text = "";
      txtNic.Text = "";
      txtPhone.Text = "";
      cmbType.Text = "";
    }
    private void btnSave_Click(object sender, EventArgs e)
    {
      if(!string.IsNullOrEmpty(txtName.Text)&& !string.IsNullOrEmpty(txtNic.Text) && !string.IsNullOrEmpty(txtPhone.Text) && !string.IsNullOrEmpty(cmbType.Text))
      {
        bool isPhone = validatePhone();
        bool isNic = validateNic();
        if(isPhone == false)
        {
          MessageBox.Show("A Phone number should have 10 digits.");
        }
        else
        {
          
          if(isNic == false)
          {
            MessageBox.Show("A NIC should have 10 or 12 digits.");
          }
          else
          {
            ve = new VehicleManagementEntities();
            if(ve.Contractors.Any(c=> c.ContractorNic == txtNic.Text))
            {
              MessageBox.Show("This contractor is already exists!");
            }
            else
            {
              Contractor contractor = new Contractor()
              {
                ContractorName = txtName.Text,
                ContractorNic = txtNic.Text,
                ContractorPhone = txtPhone.Text,
                ContractorType = cmbType.Text
              };
              ve.Contractors.Add(contractor);
              ve.SaveChanges();
              MessageBox.Show("Contractor successfully added!");
              displayData();
              clearFields();
            }
          }
        }
      }
      else
      {
        MessageBox.Show("You must fill all fields!");
      }
    }

    private void frmContractor_Load(object sender, EventArgs e)
    {
      displayData();
    }

    private void displayData()
    {
      Cursor.Current = Cursors.WaitCursor;
      btnUpdate.Enabled = false;
      btnDelete.Enabled = false;
      btnSave.Enabled = true;
      listContractors.Items.Clear();
      using(ve = new VehicleManagementEntities())
      {
        List<Contractor> list = ve.Contractors.ToList();
        foreach (Contractor c in list)
        {
          ListViewItem item = new ListViewItem(c.ContractorId.ToString());
          item.SubItems.Add(c.ContractorName);
          item.SubItems.Add(c.ContractorNic);
          item.SubItems.Add(c.ContractorPhone);
          item.SubItems.Add(c.ContractorType);
          listContractors.Items.Add(item);
        }
      }
      Cursor.Current = Cursors.Default;
    }

    private void listContractors_SelectedIndexChanged(object sender, EventArgs e)
    {
      ListView.SelectedListViewItemCollection itemCollection = this.listContractors.SelectedItems;
      foreach (ListViewItem item in itemCollection)
      {
        id = Int32.Parse(item.SubItems[0].Text);
        txtName.Text = item.SubItems[1].Text;
        txtNic.Text = item.SubItems[2].Text;
        txtPhone.Text = item.SubItems[3].Text;
        cmbType.Text = item.SubItems[4].Text;
      }
      btnSave.Enabled = false;
      btnUpdate.Enabled = true;
      btnDelete.Enabled = true;
    }

    private void btnUpdate_Click(object sender, EventArgs e)
    {
      if (!string.IsNullOrEmpty(txtName.Text) && !string.IsNullOrEmpty(txtNic.Text) && !string.IsNullOrEmpty(txtPhone.Text) && !string.IsNullOrEmpty(cmbType.Text))
      {
        bool isPhone = validatePhone();
        bool isNic = validateNic();
        if(isPhone == false)
        {
          MessageBox.Show("A Phone number should have 10 digits.");
        }
        else
        {
          if(isNic == false)
          {
            MessageBox.Show("A NIC should have 10 or 12 digits.");
          }
          else
          {
            ve = new VehicleManagementEntities();
            var singleContractor = ve.Contractors.Where(r => r.ContractorId == id).First();
            singleContractor.ContractorName = txtName.Text;
            singleContractor.ContractorNic = txtNic.Text;
            singleContractor.ContractorPhone = txtPhone.Text;
            singleContractor.ContractorType = cmbType.Text;
            ve.SaveChanges();
            MessageBox.Show("Contractor successfully updated!");
            displayData();
            clearFields();
          }
        }
      }
      else
      {
        MessageBox.Show("You must fill all fields!");
      }

    }

    private Boolean validatePhone()
    {
      if(txtPhone.TextLength == 10)
      {
        return true;
      }
      else
      {
        return false;
      }
    }
    private Boolean validateNic()
    {
      if(txtNic.TextLength == 10 || txtNic.TextLength == 12)
      {
        return true;
      }
      else
      {
        return false;
      }
    }

    private void btnDelete_Click(object sender, EventArgs e)
    {
      DialogResult res = MessageBox.Show("Are you sure you want to Delete?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
      if (res == DialogResult.OK)
      {
        ve = new VehicleManagementEntities();
        var singleContractor = ve.Contractors.Where(r => r.ContractorId == id).First();
        ve.Contractors.Remove(singleContractor);
        ve.SaveChanges();
        displayData();         
      }
    }
  }
}
