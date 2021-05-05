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
  }
}
