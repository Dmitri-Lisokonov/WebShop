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
    class ProductRepository
    {
        private IProductContext context;

        public ProductRepository(IProductContext context)
        {
            this.context = context;
        }

        public void getLoggedInUser(string succes)
        {
            if (succes == "succes")
            {

            }
        }

        public Product searchByProductName(string name)
        {
            return context.SearchByProductName(name);
        }
        public List<Product> GetAll()
        {
            return context.GetAll();
        }

        public Product GetProduct(int Id)
        {
            return context.GetProduct(Id);
        }

        public bool Insert(Product product)
        {
            return context.Insert(product);
        }

        public bool Delete(Product product)
        {
            return context.Insert(product);
        }

        bool Update(Product product)
        {
            return context.Update(product);
        }
    }
}
