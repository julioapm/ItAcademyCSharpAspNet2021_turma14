using DemoWebServiceEntityFramework2.Models;

namespace DemoWebServiceEntityFramework2.Dtos;

public class PedidoDTO
{
    public int Id { get; set; }
    public string DataEmissao { get; set; }
    public string NomeCliente { get; set; }
    public IEnumerable<PedidoItemDTO> Itens { get; set; }
    public decimal ValorTotal { get; set; }
    public PedidoDTO(int id, string dataEmissao, string nomeCliente, IEnumerable<PedidoItemDTO> itens)
    {
        Id = id;
        DataEmissao = dataEmissao;
        NomeCliente = nomeCliente;
        Itens = itens;
        ValorTotal = itens.Sum(i => i.Quantidade * i.ValorUnitario);
    }
    public static PedidoDTO FromPedido(Pedido pedido)
    {
        return new PedidoDTO(
            pedido.PedidoId,
            pedido.DataEmissao.ToString("dd/MM/yyyy"),
            pedido.Cliente!.Nome!,
            pedido.PedidoProdutos.Select(i => PedidoItemDTO.FromPedidoProduto(i))
        );
    }
}

public class PedidoItemDTO
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public int Quantidade { get; set; }
    public decimal ValorUnitario { get; set; }
    public PedidoItemDTO(int id, string nome, int quantidade, decimal valorUnitario)
    {
        Id = id;
        Nome = nome;
        Quantidade = quantidade;
        ValorUnitario = valorUnitario;
    }
    public static PedidoItemDTO FromPedidoProduto(PedidoProduto item)
    {
        return new PedidoItemDTO(item.ProdutoId, item.Produto!.Nome!, item.Quantidade, item.ValorUnitario/100m);
    }
}