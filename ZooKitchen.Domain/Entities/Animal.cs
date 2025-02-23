using ZooKitchen.Domain.Commons;


namespace ZooKitchen.Domain.Entities
{
    public class Animal : EntityBase

    {
        public string Name { get; set; }  // Hayvanın adı
        public ICollection<DeliveryDetail> DeliveryDetails { get; set; }  // Gönderim detaylarıyla ilişki

    }
}
