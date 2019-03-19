using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebShop.Data;
using WebShop.Logic;
using WebShop.Models;
using WebShop.UI;

namespace WebShop
{
    public partial class Login : Form
    {
        AccountController account = new AccountController();


        public Login()
        {
            InitializeComponent();
          
        }

        private void tbLogin_TextChanged(object sender, EventArgs e)
        {
            
            
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            
            CustomerDashBoard dashboard = new CustomerDashBoard(account.Login(tbLogin.Text, tbPassword.Text));
            dashboard.Show();
            this.Hide();
   
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            register.Show();
            this.Hide();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
