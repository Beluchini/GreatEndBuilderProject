using System.ComponentModel.DataAnnotations;

namespace BuildShop.Model;

public class Basket
{
    [Key] public int Id { get; set; }
    public string BasketTittle { get; set; }
    public int BasketCount { get; set; }
    public decimal BasketPrice { get; set; }
    public string BasketStyle { get; set; }
    public string BasketKind { get; set; }
}