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
  public partial class frmVehicleCategory : Form
  {
    VehicleManagementEntities ve;
    int Id = 0;
    public frmVehicleCategory()
    {
      InitializeComponent();
    }

    private void VehicleCategory_Load(object sender, EventArgs e)
    {
      displayData();
    }

    private void displayData()
    {
      Cursor.Current = Cursors.WaitCursor;
      listVehicleCategory.Items.Clear();
      btnSave.Visible = true;
      btnUpdate.Visible = false;
      using(ve = new VehicleManagementEntities())
      {
        List<Category> list = ve.Categories.ToList();
        foreach(Category c in list)
        {
          ListViewItem item = new ListViewItem(c.CategoryId.ToString());
          item.SubItems.Add(c.Category1);
          listVehicleCategory.Items.Add(item);
        }

      }
      Cursor.Current = Cursors.Default;      
    }

    private void btnSave_Click(object sender, EventArgs e)
    {
      ve = new VehicleManagementEntities();
      if (txtCategory.Text != null)
      {
        Category category = new Category()
        {
          Category1 = txtCategory.Text,
        };
        ve.Categories.Add(category);
        ve.SaveChanges();
        txtCategory.Text = "";
        MessageBox.Show("Successfully added!");
        displayData();
        txtCategory.Text = "";
      }
      else
      {
        MessageBox.Show("All fields are required!");
      }
    }

    private void btnUpdate_Click(object sender, EventArgs e)
    {
      if (!string.IsNullOrEmpty(txtCategory.Text))
      {
        ve = new VehicleManagementEntities();
        var singleVehicleCategory = ve.Categories.Where(r => r.CategoryId == Id).First();
        singleVehicleCategory.Category1 = txtCategory.Text;
        ve.SaveChanges();
        displayData();
        MessageBox.Show("Successfully updated!");
        Id = 0;
        txtCategory.Text = "";
        displayData();
      }
    }

    private void btnClose_Click(object sender, EventArgs e)
    {
      this.Hide();
    }

    private void listVehicleCategory_SelectedIndexChanged(object sender, EventArgs e)
    {
      ListView.SelectedListViewItemCollection selectedVehicleCategory = this.listVehicleCategory.SelectedItems;
      string VehicleCategory = "";
      foreach(ListViewItem item in selectedVehicleCategory)
      {
        Id = Int32.Parse(item.SubItems[0].Text);
        VehicleCategory = item.SubItems[1].Text;
      }
      txtCategory.Text = VehicleCategory;
      btnSave.Visible = false;
      btnUpdate.Visible = true;
    }
  }
}
