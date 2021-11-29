using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Cors;
using DemoWebServiceEntityFramework2.Data;
using DemoWebServiceEntityFramework2.Models;
using DemoWebServiceEntityFramework2.Dtos;

namespace DemoWebServiceEntityFramework2.Controllers;

[ApiController]
[Route("[controller]")]
[EnableCors("AllowAll")]
public class PedidosController : ControllerBase
{
    private readonly ILogger<CatalogoController> _logger;
    private readonly IPedidoRepository _pedidoRepository;
    private readonly IClienteRepository _clienteRepository;
    private readonly IProdutoRepository _produtoRepository;
    public PedidosController(ILogger<CatalogoController> logger, IPedidoRepository pedidoRepository, IClienteRepository clienteRepository, IProdutoRepository produtoRepository)
    {
        _logger = logger;
        _pedidoRepository = pedidoRepository;
        _clienteRepository = clienteRepository;
        _produtoRepository = produtoRepository;
    }
    
    //POST /pedidos
    [HttpPost]
    public async Task<ActionResult<PedidoDTO>> ProcessCarrinho(CarrinhoDTO carrinho)
    {
        //Não convém implementar regras de negócio complexas no corpo do
        //método de ação do controlador!
        var pedido = new Pedido();
        pedido.DataEmissao = DateTime.Now;
        var cliente = await _clienteRepository.GetAsync(carrinho.IdCliente);
        if (cliente == null)
        {
            return BadRequest($"Cliente não encontrado: {carrinho.IdCliente}");
        }
        pedido.Cliente = cliente;
        if (carrinho.Itens.Count() == 0)
        {
            return BadRequest("Carrinho vazio");
        }
        pedido.PedidoProdutos = new List<PedidoProduto>();
        foreach (var item in carrinho.Itens)
        {
            var produto = await _produtoRepository.GetAsync(item.IdProduto);
            if (produto == null)
            {
                return BadRequest($"Produto não encontrado: {item.IdProduto}");
            }
            var itemDoPedido = new PedidoProduto();
            itemDoPedido.Produto = produto;
            itemDoPedido.Quantidade = item.Quantidade;
            itemDoPedido.ValorUnitario = produto.Preco;
            pedido.PedidoProdutos.Add(itemDoPedido);
        }
        var novoPedido = await _pedidoRepository.AddAsync(pedido);
        return PedidoDTO.FromPedido(novoPedido);
    }
}