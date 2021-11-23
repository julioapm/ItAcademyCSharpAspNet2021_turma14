using System.ComponentModel.DataAnnotations;

namespace Laboratorio11.Models;

public class Pizza
{
    public int Id { get; set;}
    [Required]
    [StringLength(20)]
    public string? Name {get; set;}
    public bool IsGlutenFree {get; set;}
    override public string ToString()
    {
        return $"{Id} - {Name} - {IsGlutenFree}";
    }
}