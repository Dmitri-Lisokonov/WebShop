using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebShop.Data;
using WebShop.Models;

namespace WebShop.Logic
{
    class AccountController
    {
        AccountRepository accountRepo = new AccountRepository(new MSSQLcontextAccount());
        public Account Login(string username, string password)
        {

            Account loggingUser = accountRepo.searchByUserName(username);
            if (loggingUser.password == password)
            {
                return loggingUser;
            
            }
            else
            {
                return null;
            }

        }

    }
}
