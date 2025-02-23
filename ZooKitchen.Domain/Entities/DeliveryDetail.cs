using ZooKitchen.Domain.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooKitchen.Domain.Entities
{
    public class DeliveryDetail : EntityBase
    {
        public int AnimalId { get; set; }  // Hangi hayvana gönderildi
        public int ProductId { get; set; }    // Hangi yiyecek gönderildi
        public decimal Amount { get; set; } // Gönderilen yiyecek miktarı (kilogram, adet vb.)
        public DateTime DeliveryDate { get; set; } // Gönderim tarihi
        public Animal Animal { get; set; }  // Hayvanla ilişki
        public Product Product { get; set; }      // Yiyecek ile ilişki
        public string Description { get; set; } // Açıklama bilgileri

    }
}
