using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebShop.Models
{
    class Order
    {
        private int orderId;            
        private int productId;
        private int customerId;

        public Order(int orderId, int productId, int customerId)
        {
            this.orderId = orderId;
            this.productId = productId;
            this.customerId = customerId;
        }

        //Is public override method needed in this class?
    }
}
