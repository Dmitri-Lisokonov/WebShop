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
     interface IAccountContext
    {       
        List<Account> GetAll();
        Account GetCustomer(int customerID);
        Account searchByUserName(string username);
        bool Insert(Account account);
        bool Delete(Account account);
        bool Update(Account account);

    }
}
