using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebShop.Models
{
    class Branch
    {
        private int branchId;
        private string branchName;
        private string productName;
        private string street;
        private int streetNumber;
        private string postalCode;
        private string country;
        private string city;

        public Branch(int branchId, string branchName, string productName, string street, int streetNumber, string postalCode, string country, string city)
        {
            this.branchId = branchId;
            this.productName = productName;
            this.branchName = branchName;
            this.street = street;
            this.streetNumber = streetNumber;
            this.postalCode = postalCode;
            this.country = country;
            this.city = city;
        }

        public override string ToString()
        {
            return this.branchName + " " + this.productName + " " + this.street + " " + this.streetNumber + " " + this.postalCode + " " + this.country + " " + this.city;
        }
    }
}
