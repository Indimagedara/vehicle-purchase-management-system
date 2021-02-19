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
  public partial class frmUsers : Form
  {
    VehicleManagementEntities ve;
    int Id = 0;
    public frmUsers()
    {
      InitializeComponent();
    }

    private void BtnSave(object sender, EventArgs e)
    {
      if(txtUsername.Text != null && txtPassword.Text != null)
      {
        ve = new VehicleManagementEntities();
        if (ve.Users.Any(o => o.Username == txtUsername.Text))
        {
          MessageBox.Show("User already exists");
        }
        else
        {
          User users = new User()
          {
            Username = txtUsername.Text,
            Password = BCrypt.Net.BCrypt.HashString(txtPassword.Text),
          };
          ve.Users.Add(users);
          ve.SaveChanges();
          txtUsername.Text = "";
          txtPassword.Text = "";
          MessageBox.Show("Successfully added!");
          displayData();
          txtUsername.Text = "";
          txtPassword.Text = "";        
        }
      }
      else
      {
        MessageBox.Show("All fields are required!");
      }
    }

    private void frmUsers_Load(object sender, EventArgs e)
    {
      displayData();
    }


    private void btnClose_Click(object sender, EventArgs e)
    {
      this.Hide();
    }

    private void btnClear_Click(object sender, EventArgs e)
    {
      txtUsername.Text = "";
      txtPassword.Text = "";
      Id = 0;
      btnUpdate.Visible = false;
      btnSave.Visible = true;
    }

    private void listUsers_SelectedIndexChanged(object sender, EventArgs e)
    {
      ListView.SelectedListViewItemCollection selectedUser = this.listUsers.SelectedItems;
      string username = "";
      foreach(ListViewItem item in selectedUser)
      {
        Id = Int32.Parse(item.SubItems[0].Text);
        username = item.SubItems[1].Text;
      }
      txtUsername.Text = username;
      btnSave.Visible = false;
      btnUpdate.Visible = true;
    }

    private void displayData() {
      Cursor.Current = Cursors.WaitCursor;
      btnUpdate.Visible = false;
      btnSave.Visible = true;
      btnUpdate.Visible = false;
      listUsers.Items.Clear();
      using (ve = new VehicleManagementEntities())
      {
        List<User> list = ve.Users.ToList();
        foreach (User u in list)
        {
          ListViewItem item = new ListViewItem(u.UserId.ToString());
          item.SubItems.Add(u.Username);
          listUsers.Items.Add(item);
        }
      }
      Cursor.Current = Cursors.Default;
    }

    private void btnUpdate_Click(object sender, EventArgs e)
    {
      if (!string.IsNullOrEmpty(txtUsername.Text) && !string.IsNullOrEmpty(txtPassword.Text))
      {
        ve = new VehicleManagementEntities();
        var singleUser = ve.Users.Where(r => r.UserId == Id).First();
        singleUser.Username = txtUsername.Text;
        singleUser.Password = BCrypt.Net.BCrypt.HashString(txtPassword.Text);
        ve.SaveChanges();
        MessageBox.Show("Successfully updated!");
        Id = 0;
        displayData();
        txtPassword.Text = "";
        txtUsername.Text = "";
      }
      else
      {
        MessageBox.Show("Cannot update empty fields!");
      }
    }
  }
}
