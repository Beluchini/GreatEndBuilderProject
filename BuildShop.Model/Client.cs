using System.ComponentModel.DataAnnotations;

namespace BuildShop.Model;

public class Client
{
    [Key] public int Id { get; set; }
    public string NickName { get; set; }
    public string Email { get; set; }
    public string Name { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Card { get; set; }
    public string Code { get; set; }
    public string DateCard { get; set; }
}