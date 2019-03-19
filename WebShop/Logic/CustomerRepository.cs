using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebShop.Data;
using WebShop.Models;

namespace WebShop.Logic
{
    class CustomerRepository
    {
        private ICustomerContext context;

        public CustomerRepository(ICustomerContext context)
        {
            this.context = context;
        }

        public Customer Login(string username)
        {
            return context.Login(username);
        }
        public List<Customer> GetAll()
        {
            return context.GetAll();
        }

        public Customer Get(int customerID)
        {
            return context.Get(customerID);
        }

        public bool Insert(Customer customer)
        {
            return context.Insert(customer);
        }

        public bool Delete(Customer customer)
        {
            return context.Insert(customer);
        }

        bool Update(Customer customer)
        {
            return context.Update(customer);
        }
    }
}
