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
  public partial class frmInventory : Form
  {
    VehicleManagementEntities ve;
    int Id = 0;
    public frmInventory()
    {
      InitializeComponent();
    }

    private void btnClose_Click(object sender, EventArgs e)
    {
      this.Hide();
    }

    private void clearValues()
    {
      txtItem.Text = "";
      btnUpdate.Visible = false;
      btnSave.Visible = true;
      Id = 0;
    }

    private void displayData()
    {
      Cursor.Current = Cursors.WaitCursor;
      listInventoryItem.Items.Clear();
      using(ve = new VehicleManagementEntities())
      {
        List<InventoryItem> list = ve.InventoryItems.ToList();
        foreach(InventoryItem u in list)
        {
          ListViewItem item = new ListViewItem(u.InventoryItemId.ToString());
          item.SubItems.Add(u.ItemName);
          listInventoryItem.Items.Add(item);
        }
      }
      Cursor.Current = Cursors.Default;
    }

    private void frmInventory_Load(object sender, EventArgs e)
    {
      displayData();
    }

    private void btnSave_Click(object sender, EventArgs e)
    {
      if(txtItem.Text != null)
      {
        ve = new VehicleManagementEntities();
        InventoryItem inventoryItem = new InventoryItem()
        {
          ItemName = txtItem.Text
        };
        ve.InventoryItems.Add(inventoryItem);
        ve.SaveChanges();
        MessageBox.Show("Successfully saved");
        clearValues();
        displayData();
      }
      else
      {
        MessageBox.Show("Cannot submit empty fields");
      }
    }

    private void btnUpdate_Click(object sender, EventArgs e)
    {
      if (!string.IsNullOrEmpty(txtItem.Text))
      {
        ve = new VehicleManagementEntities();
        var singleItem = ve.InventoryItems.Where(r => r.InventoryItemId == Id).First();
        singleItem.ItemName = txtItem.Text;
        ve.SaveChanges();
        clearValues();
        displayData();
        MessageBox.Show("Succesfully updated!");
      }
      else
      {
        MessageBox.Show("Cannot submit empty fields");
      }
    }

    private void listInventoryItem_SelectedIndexChanged(object sender, EventArgs e)
    {
      ListView.SelectedListViewItemCollection selectedInvItem = this.listInventoryItem.SelectedItems;
      string itemName = "";
      foreach(ListViewItem item in selectedInvItem)
      {
        Id = Int32.Parse(item.SubItems[0].Text);
        itemName = item.SubItems[1].Text;
      }
      txtItem.Text = itemName;
      btnUpdate.Visible = true;
      btnSave.Visible = false;
    }

    private void btnClear_Click(object sender, EventArgs e)
    {
      clearValues();
    }
  }
}
