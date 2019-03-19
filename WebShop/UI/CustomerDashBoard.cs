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
using WebShop.Models;
using WebShop.Logic;

namespace WebShop
{
    public partial class CustomerDashBoard : Form
    {
        CustomerRepository customerRepo1 = new CustomerRepository(new MSSQLcontextCustomer());
        public int loggedUser;
        public CustomerDashBoard()
        {
            Customer customer = new Customer();
            InitializeComponent();
           // customer = customerRepo1.Get(loggedUser);
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();
            customer = customerRepo1.Login(textBox1.Text);
            labelUsername.Text = customer.username;
            labelPassword.Text = customer.password;
            labelStreetName.Text = customer.streetName;
            labelStreetNumber.Text = customer.streetNumber.ToString();
            labelPostalCode.Text = customer.postalCode;
            labelCity.Text = customer.city;
            labelCountry.Text = customer.country;
            labelPaymentMethod.Text = customer.paymentMethod;

        }

        private void CustomerDashBoard_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
               
        }
    }
}
