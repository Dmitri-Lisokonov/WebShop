using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebShop
{
    class Customer
    {
        private String customerId;
        private String username;
        private String password;
        private String streetName;
        private int streetNumber;
        private String city;
        private String postalCode;
        private String country;

        public override string ToString()
        {
            return this.username;
        }
    }
}
