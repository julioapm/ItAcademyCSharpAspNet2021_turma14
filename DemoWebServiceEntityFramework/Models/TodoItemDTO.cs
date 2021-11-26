using System.ComponentModel.DataAnnotations;

namespace DemoWebServiceEntityFramework.Models;

public class TodoItemDTO
{
    public long Id { get; set; }
    [Required]
    [MaxLength(200)]
    public string? Name { get; set; }
    public bool IsComplete { get; set; }
    public override string ToString()
    {
        return $"{Id} - {Name} - {IsComplete}";
    }
    public TodoItemDTO()
    {
    }
    public TodoItemDTO(TodoItem item)
    {
        Id = item.Id;
        Name = item.Name;
        IsComplete = item.IsComplete;
    }
}