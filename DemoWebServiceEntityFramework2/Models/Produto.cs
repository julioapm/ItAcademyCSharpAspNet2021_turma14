namespace DemoWebServiceEntityFramework2.Models;

public class Produto
{
    public int ProdutoId { get; set; }
    public string? Nome { get; set; }
    public int Preco { get; set; }
    //Relacionamento N:N com Pedido via PedidoProduto
    public ICollection<Pedido> Pedidos { get; set; } = null!;
    public List<PedidoProduto> PedidoProdutos { get; set; } = null!;
}