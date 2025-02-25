using ZooKitchen.Domain.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooKitchen.Domain.Entities
{
    public class Product : EntityBase
    {
        public string Name { get; set; }
        public ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
