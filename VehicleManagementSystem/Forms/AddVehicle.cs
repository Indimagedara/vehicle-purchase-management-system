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
    int left = 19;
    int top = 10;
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
    private void frmAddVehicle_Load(object sender, EventArgs e)
    {
      fetchInventoryData();
    }
  }
}
