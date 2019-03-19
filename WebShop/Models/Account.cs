using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebShop.Models
{
     public class Account
    {
        public int customerId { private set; get; }
        public string paymentMethod { private set;  get; }
        public string password { private set;  get; }
        public int streetNumber { private set;  get; }
        public string streetName { private set;  get; }
        public string city { private set;  get; }
        public string postalCode { private set;  get; }
        public string country { private set;  get; }
        public string username { private set;  get; }

        public int CustomerId
        {
            get { return customerId;  }
            private set { }
        }
        
        public Account()
        {

        }

        public Account(int customerId, string username, string password, int streetNumber, string streetName, string city, string postalCode, string country, string paymentMethod)
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

        public Account(string username, string password, int streetNumber, string streetName, string city, string postalCode, string country, string paymentMethod)
        {
            //this.customerId = customerId;
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
