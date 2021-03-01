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
  public partial class frmAddSellerData : Form
  {
    int selectedId = 0;
    string regNum = frmSingleVehicle.vehicleNumber;
    VehicleManagementEntities ve;
    public frmAddSellerData()
    {
      InitializeComponent();
    }

    private void btnClose_Click(object sender, EventArgs e)
    {
      frmSingleVehicle singleVehicle = new frmSingleVehicle();
      singleVehicle.fetchSellerData();
      this.Hide();
    }

    private void fetchData()
    {
      using (ve = new VehicleManagementEntities())
      {
        List<VehicleSeller> vehicleSellers = ve.VehicleSellers.Where(v => v.VehicleNumber == regNum).ToList();
        if (vehicleSellers.Any())
        {
          btnSave.Text = "Update";
          foreach (VehicleSeller seller in vehicleSellers)
          {
            selectedId = Int32.Parse(seller.VehicleSellerId.ToString());
            txtName.Text = seller.SellerName;
            txtPhone.Text = seller.SellerContactNumber;
            txtAddress.Text = seller.SellerAddress;
            cmbType.Text = seller.SellerType;
          }
        }
        else
        {
          btnSave.Text = "Add";
        }
      }
    }

    private void btnSave_Click(object sender, EventArgs e)
    {
      if(selectedId == 0)
      {
        if(!string.IsNullOrEmpty(txtName.Text) && !string.IsNullOrEmpty(txtAddress.Text) 
          && !string.IsNullOrEmpty(txtPhone.Text) && !string.IsNullOrEmpty(cmbType.Text))
        {
          ve = new VehicleManagementEntities();
          if(ve.VehicleSellers.Any(r=>r.SellerName == txtName.Text && r.VehicleNumber == regNum) == false)
          {
            VehicleSeller vehicleSeller = new VehicleSeller()
            {
              SellerName = txtName.Text,
              SellerAddress = txtAddress.Text,
              SellerContactNumber = txtPhone.Text,
              SellerType = cmbType.Text,
              VehicleNumber = regNum
            };
            ve.VehicleSellers.Add(vehicleSeller);
            ve.SaveChanges();
            MessageBox.Show("Seller data saved successfully!");
            clearValues();
            frmSingleVehicle singleVehicle = new frmSingleVehicle();
            singleVehicle.fetchSellerData();
            btnSave.Text = "Update";
            btnSave.Enabled = false;
          
          }
          else
          {
            MessageBox.Show("This seller already exists");
          }
        }
        else
        {
          MessageBox.Show("All fields are required");
        }
      }
      else
      {
        if(!string.IsNullOrEmpty(txtName.Text) && !string.IsNullOrEmpty(txtAddress.Text) 
          && !string.IsNullOrEmpty(txtPhone.Text) && !string.IsNullOrEmpty(cmbType.Text))
        {
          ve = new VehicleManagementEntities();
          var singleSeller = ve.VehicleSellers.Where(r => r.VehicleSellerId == selectedId).First();
          singleSeller.SellerName = txtName.Text;
          singleSeller.SellerAddress = txtAddress.Text;
          singleSeller.SellerContactNumber = txtPhone.Text;
          singleSeller.SellerType = cmbType.Text;
          ve.SaveChanges();
          MessageBox.Show("Successfully updated!");
          btnSave.Text = "Update";
          btnSave.Enabled = false;
        }
      }
    }

    private void frmAddSellerData_Load(object sender, EventArgs e)
    {
      lblRegNum.Text = regNum;
      fetchData();
    }
    private void clearValues()
    {
      txtAddress.Text = "";
      txtName.Text = "";
      txtPhone.Text = "";
      cmbType.Text = "";
      txtName.Enabled = false;
      txtAddress.Enabled = false;
      txtPhone.Enabled = false;
      cmbType.Enabled = false;
    }
  }
}
