﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebShop.Models
{
    class Product
    {
        public int productId;
        public string productName;
        public string discription;
        public int serialNumber;
        public string sizing;
        public string colorway;
        public string categoryName;
        public string brandName;
        public int price;

        public Product()
        {

        }

        public Product(int productId, string productName, string discription, int serialNumber, string sizing, string colorway, string categoryName, string brandName, int price)
        {
            this.productId = productId;
            this.productName = productName;
            this.discription = discription;
            this.serialNumber = serialNumber;
            this.sizing = sizing;
            this.colorway = colorway;
            this.categoryName = categoryName;
            this.brandName = brandName;
            this.price = price;
        }

        public override string ToString()
        {
            return this.productName + " " + this.discription + " " + this.serialNumber + " " + this.sizing + " " + this.colorway + " " + this.categoryName + " " + this.brandName ;
        }
    }
}
