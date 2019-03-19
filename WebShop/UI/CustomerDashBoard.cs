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

        Account account;

        public CustomerDashBoard()
        {
            InitializeComponent();
     
        }
        public CustomerDashBoard(Account account)
        {
            InitializeComponent();
            this.account = account;
        }


        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void CustomerDashBoard_Load(object sender, EventArgs e)
        {

            labelUsername.Text = account.username;
            labelPassword.Text = account.password;
            labelStreetName.Text = account.streetName;
            labelStreetNumber.Text = account.streetNumber.ToString();
            labelPostalCode.Text = account.postalCode;
            labelCity.Text = account.city;
            labelCountry.Text = account.country;
            labelPaymentMethod.Text = account.paymentMethod;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
               
        }
    }
}
