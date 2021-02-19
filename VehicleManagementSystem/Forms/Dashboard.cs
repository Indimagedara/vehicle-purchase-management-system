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
    public frmDashboard()
    {
      InitializeComponent();
    }

    private void usersToolStripMenuItem_Click(object sender, EventArgs e)
    {
      frmUsers users = new frmUsers();
      users.Show();
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

    private void employeesToolStripMenuItem_Click(object sender, EventArgs e)
    {
      frmEmployees employees = new frmEmployees();
      employees.Show();
    }

    private void inventoryToolStripMenuItem_Click(object sender, EventArgs e)
    {
      frmInventory inventory = new frmInventory();
      inventory.Show();
    }
  }
}
