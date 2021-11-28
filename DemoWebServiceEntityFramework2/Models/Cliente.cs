namespace DemoWebServiceEntityFramework2.Models;

public class Cliente
{
    public int ClienteId { get; set; }
    public string? Nome { get; set; }
    public string? Email { get; set; }
    //Relacionamento 1:N com Pedido
    public List<Pedido> Pedidos { get; set; } = null!;
}