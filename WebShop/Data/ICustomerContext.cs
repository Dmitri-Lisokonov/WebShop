using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebShop;
using WebShop.Models;
using WebShop.Data;

namespace WebShop.Data
{
    public interface ICustomerContext
    {
        
        List<Customer> GetAll();
        Customer Get(int customerID);
        Customer Login(string username);
        bool Insert(Customer customer);
        bool Delete(Customer customer);
        bool Update(Customer customer);

    }
}
