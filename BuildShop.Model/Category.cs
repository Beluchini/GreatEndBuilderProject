using System.ComponentModel.DataAnnotations;

namespace BuildShop.Model;

public class Category
{
    [Key] public int Id { get; set; }
    
    public string Type { get; set; }
}