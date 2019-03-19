using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebShop.Data;
using WebShop.Logic;
using WebShop.Models;

namespace WebShop.UI
{
    public partial class Register : Form
    {
        CustomerRepository customerRepo = new CustomerRepository(new MSSQLcontextCustomer());
        public Register()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Customer registeringUser = new Customer();
            registeringUser.username = tbUsername.Text;
            registeringUser.password = tbPassword.Text;
            registeringUser.streetName = tbStreetName.Text;
            registeringUser.streetNumber = Convert.ToInt32(tbStreetNumber.Text);
            registeringUser.city = tbCity.Text;
            registeringUser.postalCode = tbPostalCode.Text;
            registeringUser.country = tbCountry.Text;
            registeringUser.paymentMethod = "test";

            customerRepo.Insert(registeringUser);
        }

        private void buttonExitRegister_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }
    }
}
