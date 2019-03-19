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
       
        public Register()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Account registeringUser = new Account(tbUsername.Text, tbPassword.Text, Convert.ToInt32(tbStreetNumber.Text), tbStreetName.Text, tbCity.Text, tbPostalCode.Text, tbCountry.Text, "huh");
        }

        private void buttonExitRegister_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void Register_Load(object sender, EventArgs e)
        {

        }
    }
}
