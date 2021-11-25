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

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<TodoItem>()
            .ToTable("Todos")
            .HasKey(t => t.Id)
            .HasName("PK_Todos");
        modelBuilder.Entity<TodoItem>()
            .Property(t => t.Name)
            .HasMaxLength(200)
            .IsRequired();
        /*
        modelBuilder.Entity<TodoItem>(eb => {
            eb.ToTable("Todos")
            .HasKey(t => t.Id)
            .HasName("PK_Todos");
            eb.Property(t => t.Name)
            .HasMaxLength(200)
            .IsRequired();
        });
        */
    }
}