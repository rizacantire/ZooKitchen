using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooKitchen.Domain.Commons;

namespace ZooKitchen.Domain.Entities
{
    public class Order : EntityBase
    {
        public int AnimalId { get; set; }  // Hangi hayvana gönderildi
        public DateTime OrderDate { get; set; } // Gönderim tarihi
        public Animal Animal { get; set; }  // Hayvanla ilişki
        public string Description { get; set; }

    }
}
