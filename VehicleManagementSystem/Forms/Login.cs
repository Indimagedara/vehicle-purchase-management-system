using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace VehicleManagementSystem
{
  public partial class frmLogin : Form
  {
    public frmLogin()
    {
      InitializeComponent();
    }

    private void btnExit_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void btnLogin_Click(object sender, EventArgs e)
    {
      frmDashboard dashboard = new frmDashboard();
      dashboard.Show();
      this.Hide();

      //var account = login(txtUsername.Text, txtPassword.Text);
      //if(account == null)
      //{
      //  MessageBox.Show("Login failed!");
      //}
      //else
      //{
      //  frmDashboard dashboard = new frmDashboard();
      //  dashboard.Show();
      //  this.Hide();
      //}
    }

    private User login(string username, string password)
    {
      VehicleManagementEntities ve = new VehicleManagementEntities();
      var account = ve.Users.SingleOrDefault(a => a.Username.Equals(username));
      if(account != null)
      {
        if(BCrypt.Net.BCrypt.Verify(password, account.Password))
        {
          return account;
        }
      }
      return null;
    }
    //private string DecryptPassword(string encryptedPassword)
    //{

    //  return 'test';
    //}
  }
}
