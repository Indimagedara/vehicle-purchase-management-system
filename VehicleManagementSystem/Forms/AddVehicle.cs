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
  public partial class frmAddVehicle : Form
  {
    VehicleManagementEntities ve;
    int selectedId = 0;
    List<string> availableItems = new List<string>();
    string selectedItem;
    int removeItemIndex;
    public frmAddVehicle()
    {
      InitializeComponent();
    }

    private void btnUpdate_Click(object sender, EventArgs e)
    {

    }

    private void fetchInventoryData()
    {
      using (ve = new VehicleManagementEntities())
      {
        List<InventoryItem> inventoryItems = ve.InventoryItems.ToList();
        foreach(InventoryItem inv in inventoryItems)
        {
          ListViewItem item = new ListViewItem(inv.InventoryItemId.ToString());
          item.SubItems.Add(inv.ItemName.ToString());
          listPartInventory.Items.Add(item);
        }
      }
    }

    private void fetchData()
    {
      using(ve = new VehicleManagementEntities())
      {
        List<VehicleType> vehicleTypes = ve.VehicleTypes.ToList();
        cmbType.DisplayMember = "VehiType";
        cmbType.ValueMember = "VehicleTypeId";
        cmbType.DataSource = vehicleTypes;

        List<Category> vehiCategories = ve.Categories.ToList();
        cmbVehicleCategory.DisplayMember = "Category1";
        cmbVehicleCategory.ValueMember = "CategoryId";
        cmbVehicleCategory.DataSource = vehiCategories;

        List<Brand> brandsList = ve.Brands.ToList();
        //cmbSomething.DisplayMember = "Brand1";
        //cmbSomething.DataSource = brands;
        foreach (Brand b in brandsList)
        {
          cmbBrand.Items.Add(b.Brand1);
        }
      }
    }


    private void frmAddVehicle_Load(object sender, EventArgs e)
    {
      // TODO: This line of code loads data into the 'vehiclePurchaseManagementsDataSet.User' table. You can move, or remove it, as needed.
      fetchInventoryData();
      fetchData();
      btnRemovePart.Enabled = false;
    }

    private void btnClose_Click(object sender, EventArgs e)
    {
      this.Hide();
    }

    private void listPartInventory_SelectedIndexChanged(object sender, EventArgs e)
    {
      ListView.SelectedListViewItemCollection selectedInventoryItem = this.listPartInventory.SelectedItems;
      string partName = "";

      foreach(ListViewItem item in selectedInventoryItem)
      {
        selectedId = Int32.Parse(item.SubItems[0].Text);
        partName = item.SubItems[1].Text;
      }
      selectedItem = partName.ToString();
    }

    private void btnSelectItem_Click(object sender, EventArgs e)
    {
      if(selectedId != 0)
      {
        if((lbSelectedItems.Items.Contains(selectedItem) != true))
        {
          lbSelectedItems.Items.Add(selectedItem);
          availableItems.Add(selectedId.ToString());
          btnRemovePart.Enabled = true;
        }
        else
        {
          MessageBox.Show("Item already added to the list");
        }
      }
    }

    private void btnRemovePart_Click(object sender, EventArgs e)
    {
      lbSelectedItems.Items.RemoveAt(removeItemIndex);
      if(lbSelectedItems.Items.Count == 0)
      {
        btnRemovePart.Enabled = false;
      }
    }

    private void lbSelectedItems_SelectedIndexChanged(object sender, EventArgs e)
    {
      removeItemIndex = lbSelectedItems.SelectedIndex;
    }

    private void clearValues()
    {
      txtChassieNumber.Text = "";
      txtEngineCapacity.Text = "";
      txtEngineNumber.Text = "";
      cmbFuelType.Text = "";
      txtMilage.Text = "";
      txtModel.Text = "";
      txtModelYear.Text = "";
      txtNote.Text = "";
      txtRegNum.Text = "";
      txtRegYear.Text = "";
      cmbType.Text = "";
      cmbVehicleCategory.Text = "";
    }
    private void btnClear_Click(object sender, EventArgs e)
    {
      clearValues();
    }

    private void btnSave_Click(object sender, EventArgs e)
    {
        //MessageBox.Show(cmbType.SelectedValue.ToString());
      if(!string.IsNullOrEmpty(txtModel.Text) && !string.IsNullOrEmpty(txtModelYear.Text) 
        && !string.IsNullOrEmpty(cmbType.Text) && !string.IsNullOrEmpty(cmbVehicleCategory.Text) 
        && !string.IsNullOrEmpty(txtRegNum.Text) && !string.IsNullOrEmpty(txtRegYear.Text) 
        && !string.IsNullOrEmpty(txtEngineNumber.Text) && !string.IsNullOrEmpty(txtEngineCapacity.Text) 
        && !string.IsNullOrEmpty(txtMilage.Text) && !string.IsNullOrEmpty(cmbFuelType.Text) 
        && !string.IsNullOrEmpty(cmbBrand.Text) && !string.IsNullOrEmpty(cmbCondition.Text) 
        && !string.IsNullOrEmpty(cmbTransmission.Text))
      {
        System.Text.StringBuilder sb = new System.Text.StringBuilder();
        if (lbSelectedItems.Items.Count != 0)
        {
          foreach(object item in lbSelectedItems.Items)
          {
            sb.Append(item.ToString());
            sb.Append(",");
          }
          ve = new VehicleManagementEntities();
          if(ve.Vehicles.Any(o => o.RegNum == txtRegNum.Text) == true)
          {
            MessageBox.Show("This vehicle already exists on the system!");
          }
          else
          {
            Vehicle vehicle = new Vehicle()
            {
              Brand = cmbBrand.Text,
              Model = txtModel.Text,
              ModelYear = Int32.Parse(txtModelYear.Text),
              TypeId = long.Parse(cmbType.SelectedValue.ToString()),
              CategoryId = long.Parse(cmbVehicleCategory.SelectedValue.ToString()),
              RegNum = txtRegNum.Text,
              RegYear = Int32.Parse(txtRegYear.Text),
              EngineNumber = txtEngineNumber.Text,
              ChassieNumber = txtChassieNumber.Text,
              Milage = Int32.Parse(txtMilage.Text),
              Condition = cmbCondition.Text,
              Transmission = cmbTransmission.Text,
              EngineCapacity = float.Parse(txtEngineCapacity.Text),
              FuelType = cmbFuelType.Text,
              PartInventory = sb.ToString(),
              Note = txtNote.Text,
              DateCreated = DateTime.Now
            };
            ve.Vehicles.Add(vehicle);
            ve.SaveChanges();
            MessageBox.Show("Vehicle added successfully!");
            clearValues();
          }
        }
        else
        {
          MessageBox.Show("Please add available parts of the vehicle!");
        }
      }
      else
      {
        MessageBox.Show("Cannot add empty values");
      }
    }
  }
}
