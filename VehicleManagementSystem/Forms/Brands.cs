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
  public partial class frmBrands : Form
  {
    VehicleManagementEntities ve;
    int Id = 0;
    public frmBrands()
    {
      InitializeComponent();
    }

    private void btnClose_Click(object sender, EventArgs e)
    {
      this.Hide();
    }

    private void Brands_Load(object sender, EventArgs e)
    {
      fetchData();
    }

    private void fetchData()
    {
      Cursor.Current = Cursors.WaitCursor;
      listBrands.Items.Clear();
      using (ve = new VehicleManagementEntities())
      {
        List<Brand> brands = ve.Brands.ToList();
        foreach(Brand b in brands)
        {
          ListViewItem item = new ListViewItem(b.BrandId.ToString());
          item.SubItems.Add(b.Brand1.ToString());
          listBrands.Items.Add(item);
        }
      }
      btnSave.Visible = true;
      btnUpdate.Visible = false;
      Cursor.Current = Cursors.Default;
    }

    private void btnSave_Click(object sender, EventArgs e)
    {
      if (!string.IsNullOrEmpty(txtBrand.Text))
      {
        ve = new VehicleManagementEntities();
        if(ve.Brands.Any(o => o.Brand1 == txtBrand.Text) == false)
        {
          Brand brand = new Brand()
          {
            Brand1 = txtBrand.Text
          };
          ve.Brands.Add(brand);
          ve.SaveChanges();
          MessageBox.Show("Brand added successfully!");
          clearValues();
          fetchData();
        }
        else
        {
          MessageBox.Show("this brand already exists in the system");
        }
      }
      else
      {
        MessageBox.Show("Ypu cannot submit empty values");
      }
    }
    private void clearValues()
    {
      txtBrand.Text = "";
    }

    private void btnUpdate_Click(object sender, EventArgs e)
    {
      if (!string.IsNullOrEmpty(txtBrand.Text))
      {
        ve = new VehicleManagementEntities();
        var singleBrand = ve.Brands.Where(r => r.BrandId == Id).First();
        singleBrand.Brand1 = txtBrand.Text;
        ve.SaveChanges();
        MessageBox.Show("Brand updated successfully!");
        clearValues();
        fetchData();
        Id = 0;
      }
    }

    private void listBrands_SelectedIndexChanged(object sender, EventArgs e)
    {
      ListView.SelectedListViewItemCollection selectedBrand = this.listBrands.SelectedItems;
      string selectedBrandTemp = "";
      foreach(ListViewItem item in selectedBrand)
      {
        Id = Int32.Parse(item.SubItems[0].Text);
        selectedBrandTemp = item.SubItems[1].Text;
      }
      txtBrand.Text = selectedBrandTemp;
      btnSave.Visible = false;
      btnUpdate.Visible = true;
    }
  }
}
