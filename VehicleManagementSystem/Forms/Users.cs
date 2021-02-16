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
        userBindingSource.DataSource = ve.Users.ToList();
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
      ve = new VehicleManagementEntities();
      userBindingSource.DataSource = ve.Users.ToList();
    }


    private void btnClose_Click(object sender, EventArgs e)
    {
      this.Hide();
    }

    private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
    {
      if(dataGridView1.Rows[e.RowIndex].Cells[1].Value != null)
      {
        Id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
        txtUsername.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
      }
      else
      {
        MessageBox.Show("You've selected an invalid item.");
      }

      if (Id != 0)
      {
        
      }
    }

    //private void button2_Click(object sender, EventArgs e)
    //{
    //  txtUsername.Text = "";
    //  txtPassword.Text = "";
    //  Id = 0;
    //}

    private void btnClear_Click(object sender, EventArgs e)
    {
      txtUsername.Text = "";
      txtPassword.Text = "";
      Id = 0;
    }
  }
}
