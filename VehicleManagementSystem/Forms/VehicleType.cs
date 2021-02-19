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
  public partial class frmVehicleType : Form
  {
    VehicleManagementEntities ve;
    int Id = 0;
    int index = 0;
    public frmVehicleType()
    {
      InitializeComponent();
    }

    private void btnClear_Click(object sender, EventArgs e)
    {
      txtVehicleType.Text = "";
      btnUpdate.Visible = false;
      btnSave.Visible = true;
    }

    private void btnClose_Click(object sender, EventArgs e)
    {
      this.Hide();
    }

    private void frmVehicleType_Load(object sender, EventArgs e)
    {
      displayData();
    }

    private void btnSave_Click(object sender, EventArgs e)
    {
      if(txtVehicleType.Text != null)
      {
        ve = new VehicleManagementEntities();
        if (ve.VehicleTypes.Any(o => o.VehiType == txtVehicleType.Text))
        {
          MessageBox.Show("Vehicle Type already exists");
        }
        else
        {
          VehicleType vehicleType = new VehicleType()
          {
            VehiType = txtVehicleType.Text
          };
          ve.VehicleTypes.Add(vehicleType);
          ve.SaveChanges();
          txtVehicleType.Text = "";
          MessageBox.Show("Successfully saved!");
          displayData();
          txtVehicleType.Text = "";
        }
      }

    }

    private void btnUpdate_Click(object sender, EventArgs e)
    {
      if (!string.IsNullOrEmpty(txtVehicleType.Text))
      {
        ve = new VehicleManagementEntities();
        var singleVehiType = ve.VehicleTypes.Where(r => r.VehicleTypeId == Id).First();
        singleVehiType.VehiType = txtVehicleType.Text;
        ve.SaveChanges();
        displayData();
        MessageBox.Show("Successfully updated!");
        Id = 0;
        txtVehicleType.Text = "";
      }
    }
    private void displayData()
    {
      Cursor.Current = Cursors.WaitCursor;
      btnSave.Visible = true;
      btnUpdate.Visible = false;
      listVehicleTypes.Items.Clear();
      using (ve = new VehicleManagementEntities())
      {
        List<VehicleType> list = ve.VehicleTypes.ToList();
        foreach (VehicleType v in list)
        {
          ListViewItem item = new ListViewItem(v.VehicleTypeId.ToString());
          item.SubItems.Add(v.VehiType);
          listVehicleTypes.Items.Add(item);
        }
      }
      Cursor.Current = Cursors.Default;
    }
    private void listVehicleTypes_SelectedIndexChanged(object sender, EventArgs e)
    {
      ListView.SelectedListViewItemCollection selectedVehicleType = this.listVehicleTypes.SelectedItems;
      string vehicleType = "";
      foreach (ListViewItem item in selectedVehicleType)
      {
        Id = Int32.Parse(item.SubItems[0].Text);
        vehicleType = item.SubItems[1].Text;
      }
      txtVehicleType.Text = vehicleType;
      btnSave.Visible = false;
      btnUpdate.Visible = true;
    }
  }
}
