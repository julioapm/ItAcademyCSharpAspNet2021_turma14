using Microsoft.EntityFrameworkCore;

namespace DemoWebServiceEntityFramework.Models;

public class TodoContext : DbContext
{
    public TodoContext(DbContextOptions<TodoContext> options)
        : base(options)
    {
    }
    
    public TodoContext()
    {
    }

    public DbSet<TodoItem> TodoItems { get; set; } = null!;
}