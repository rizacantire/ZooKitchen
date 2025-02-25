using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooKitchen.Domain.Commons;

namespace ZooKitchen.Domain.Entities
{
    public class OrderDetail : EntityBase
    {
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public decimal Amount { get; set; }
        public Order Order { get; set; }
        public Product Product { get; set; }
        

    }
}
