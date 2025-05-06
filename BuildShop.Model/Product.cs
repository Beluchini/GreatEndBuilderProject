using System.ComponentModel.DataAnnotations;

namespace BuildShop.Model;

public class Product
{
    [Key] public int Id { get; set; }
    public string Title { get; set; }
    public int Count { get; set; }
    public decimal Price { get; set; }
}