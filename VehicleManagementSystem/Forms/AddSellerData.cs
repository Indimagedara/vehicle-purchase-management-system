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
    int selectedId = frmSingleVehicle.selectedId;
    string regNum = frmSingleVehicle.vehicleNumber;
    VehicleManagementEntities ve;
    public frmAddSellerData()
    {
      InitializeComponent();
    }

    private void btnClose_Click(object sender, EventArgs e)
    {
      this.Hide();
    }

    private void fetchData()
    {
      using (ve = new VehicleManagementEntities())
      {
        List<VehicleSeller> vehicleSellers = ve.VehicleSellers.Where(v => v.VehicleNumber == regNum).ToList();
        if (vehicleSellers.Any())
        {
          btnSave.Visible = false;
          foreach (VehicleSeller seller in vehicleSellers)
          {
            txtName.Text = seller.SellerName;
            txtPhone.Text = seller.SellerContactNumber;
            txtAddress.Text = seller.SellerAddress;
            lblRegNum.Text = seller.SellerType;
          }
        }
        else
        {
          btnSave.Visible = true;
        }
      }
    }

    private void btnSave_Click(object sender, EventArgs e)
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

    private void frmAddSellerData_Load(object sender, EventArgs e)
    {
      lblRegNum.Text = regNum;
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
