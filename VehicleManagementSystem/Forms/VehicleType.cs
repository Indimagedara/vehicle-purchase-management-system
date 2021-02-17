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
      Cursor.Current = Cursors.WaitCursor;
      btnSave.Visible = true;
      btnUpdate.Visible = false;

      using(ve = new VehicleManagementEntities())
      {
        List<VehicleType> list = ve.VehicleTypes.ToList();
        foreach(VehicleType v in list)
        {
          ListViewItem item = new ListViewItem(v.VehicleTypeId.ToString());
          item.SubItems.Add(v.VehiType);
          listVehicleTypes.Items.Add(item);
        }
      }
      Cursor.Current = Cursors.Default;


    }

    private void btnSave_Click(object sender, EventArgs e)
    {
      if(txtVehicleType.Text != null)
      {
        ve = new VehicleManagementEntities();
        VehicleType vehicleType = new VehicleType()
        {
          VehiType = txtVehicleType.Text
        };
        ve.VehicleTypes.Add(vehicleType);
        ve.SaveChanges();
        txtVehicleType.Text = "";
        MessageBox.Show("Successfully saved!");
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
        MessageBox.Show("Successfully updated!");
        Id = 0;
      }
    }
  }
}
