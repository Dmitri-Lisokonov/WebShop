using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebShop.Data;
using WebShop.Logic;
using WebShop.Models;

namespace WebShop.Logic
{
    class RegisterController
    {
        AccountRepository customerRepo = new AccountRepository(new MSSQLcontextAccount());

        public Account Register(Account account)
        {
            
            Console.WriteLine("register succes.");
            customerRepo.Insert(account);
            return account;
            
        }
        
    }
}
