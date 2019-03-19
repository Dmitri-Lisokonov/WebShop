using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebShop.Models
{
    public class Customer
    {
        public int customerId;
        public string paymentMethod { get; set; }
        public string password { get; set; }
        public int streetNumber { get; set; }
        public string streetName { get; set; }
        public string city { get; set; }
        public string postalCode { get; set; }
        public string country { get; set; }
        public string username { get; set; }
        
        public Customer()
        {

        }

        public Customer(int customerId, string username, string password, int streetNumber, string streetName, string city, string postalCode, string country, string paymentMethod)
        {
            this.customerId = customerId;
            this.username = username;
            this.password = password;
            this.streetNumber = streetNumber;
            this.streetName = streetName;
            this.city = city;
            this.postalCode = postalCode;
            this.country = country;
            this.paymentMethod = paymentMethod;
        }

        public override string ToString()
        {
            return  this.username + " " + this.streetNumber + " " + this.streetName + " " + this.city + " " + this.postalCode + " " + this.country;
        }
    }
}
