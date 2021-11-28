using Microsoft.EntityFrameworkCore;

namespace DemoWebServiceEntityFramework2.Models;

public class BdContext : DbContext
{
    public BdContext()
    {   
    }
    public BdContext (DbContextOptions<BdContext> options)
        : base(options)
    {
    }
    public DbSet<Cliente> Clientes { get; set; } = null!;
    public DbSet<Pedido> Pedidos { get; set; } = null!;
    public DbSet<Produto> Produtos { get; set; } = null!;

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Cliente>()
            .Property(c => c.Nome)
            .IsRequired()
            .HasMaxLength(45);
        modelBuilder.Entity<Produto>()
            .Property(c => c.Nome)
            .IsRequired()
            .HasMaxLength(30);
        modelBuilder.Entity<Pedido>()
            .HasMany(e => e.Produtos)
            .WithMany(e => e.Pedidos)
            .UsingEntity<PedidoProduto>();
    }
}