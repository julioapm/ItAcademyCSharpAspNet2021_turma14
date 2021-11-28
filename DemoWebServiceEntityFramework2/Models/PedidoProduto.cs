namespace DemoWebServiceEntityFramework2.Models;

public class PedidoProduto
{
    public int Quantidade { get; set; }
    public int ValorUnitario { get; set; }
    //Relacionamento N:1 com Pedido
    public Pedido? Pedido { get; set; }
    public int PedidoId { get; set; }
    //Relacionamento N:1 com Produto
    public Produto? Produto { get; set; }
    public int ProdutoId { get; set; }
}