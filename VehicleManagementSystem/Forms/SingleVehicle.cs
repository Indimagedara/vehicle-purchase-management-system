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
    int selectedId = frmDashboard.Id;
    public frmSingleVehicle()
    {
      InitializeComponent();
    }

    private void frmSingleVehicle_Load(object sender, EventArgs e)
    {
      fetchData();
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
          this.Text = vehi.RegNum;
          lblRegNum.Text = vehi.RegNum;
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
        }

      }
      Cursor.Current = Cursors.Default;
    }
  }
}
