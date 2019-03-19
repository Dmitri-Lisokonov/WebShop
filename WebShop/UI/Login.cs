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
        CustomerRepository customerRepo = new CustomerRepository(new MSSQLcontextCustomer());
        
        public Login()
        {
            InitializeComponent();
          
        }

        private void tbLogin_TextChanged(object sender, EventArgs e)
        {
            
            
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
           
            Customer loggingUser = customerRepo.Login(tbLogin.Text);
            if(loggingUser.password == tbPassword.Text)
            {
                CustomerDashBoard customerdashboard = new CustomerDashBoard();
                customerdashboard.loggedUser = loggingUser.customerId;
                this.Hide();
                customerdashboard.Show();
            }
            else
            {
                MessageBox.Show("Username and password do not match. Please register if you don't have an account yet.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            register.Show();
            this.Hide();
        }
    }
}
