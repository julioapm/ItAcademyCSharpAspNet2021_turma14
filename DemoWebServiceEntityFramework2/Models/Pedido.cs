namespace DemoWebServiceEntityFramework2.Models;

public class Pedido
{
    public int PedidoId { get; set; }
    public DateTime DataEmissao { get; set; }
    //Relacionamento N:1 com Cliente
    public Cliente? Cliente { get; set; }
    public int ClienteId { get; set; }
    //Relacionamento N:N com Produto via PedidoProduto
    public ICollection<Produto> Produtos { get; set; } = null!;
    public List<PedidoProduto> PedidoProdutos { get; set; } = null!;
}