using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BuildShop.Model;

public class RecordOfProduct
{
    [Key] public int Id { get; set; }
    
    public int ClientId { get; set; }
    [ForeignKey("ClientId")] public Client Clients { get; set; }
    
    public int ProductId { get; set; }
    [ForeignKey("ProductId")] public Product Products { get; set; }
    
    public int OrderId { get; set; }
    [ForeignKey("OrderId")] public Order Orders { get; set; }
    
    public int DeliveryId { get; set; }
    [ForeignKey("DeliveryId")] public Delivery Delivery { get; set; }
    
    public int CategoryId { get; set; }
    [ForeignKey("CategoryId")] public Category Category { get; set; }
    
    public int BasketId { get; set; }
    [ForeignKey("BasketId")] public Basket Baskets { get; set; }
}