using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebShop.Data;
using WebShop.Models;

namespace WebShop.Logic
{
    class AccountRepository
    {
        private IAccountContext context;

        public AccountRepository(IAccountContext context)
        {
            this.context = context;
        }

        public void getLoggedInUser(string succes)
        {
            if (succes == "succes")
            {
                
            }
        }

        public Account searchByUserName(string username)
        {
            return context.searchByUserName(username);
        }
        public List<Account> GetAll()
        {
            return context.GetAll();
        }

        public Account GetCustomer(int Id)
        {
            return context.GetCustomer(Id);
        }

        public bool Insert(Account account)
        {
            return context.Insert(account);
        }

        public bool Delete(Account account)
        {
            return context.Insert(account);
        }

        bool Update(Account account)
        {
            return context.Update(account);
        }
    }
}
