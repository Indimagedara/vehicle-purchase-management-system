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
    public frmUsers()
    {
      InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      ve = new VehicleManagementEntities();
      if(txtUsername.Text != null && txtPassword.Text != null)
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
      }
      else
      {
        MessageBox.Show("All fields are required!");
      }
    }

    private void frmUsers_Load(object sender, EventArgs e)
    {
      // TODO: This line of code loads data into the 'vehiclePurchaseManagementsDataSet.User' table. You can move, or remove it, as needed.
      this.userTableAdapter.Fill(this.vehiclePurchaseManagementsDataSet.User);
      // TODO: This line of code loads data into the 'vehiclePurchaseManagementsDataSet.Users' table. You can move, or remove it, as needed.


    }

    private void btnClose_Click(object sender, EventArgs e)
    {
      this.Hide();
    }
  }
}
