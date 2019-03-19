using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebShop.Models;
using WebShop.Data;
using WebShop.Logic;


namespace WebShop.Data
{
    interface IProductContext
    {
        List<Product> GetAll();
        Product GetProduct(int productId);
        Product SearchByProductName(string productName);
        bool Insert(Product product);
        bool Delete(Product product);
        bool Update(Product product);

    }
}
