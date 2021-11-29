using System.ComponentModel.DataAnnotations;

namespace DemoWebServiceEntityFramework2.Dtos;

public class CarrinhoDTO
{
    [Required]
    public int IdCliente { get; set; }
    public IEnumerable<ItemCarrinhoDTO> Itens { get; set; } = null!;
}

public class ItemCarrinhoDTO
{
    [Required]
    public int IdProduto { get; set; }
    [Required]
    [Range(1, int.MaxValue)]
    public int Quantidade { get; set; }
}