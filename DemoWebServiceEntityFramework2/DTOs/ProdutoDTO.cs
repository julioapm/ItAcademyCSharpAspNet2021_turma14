using DemoWebServiceEntityFramework2.Models;

namespace DemoWebServiceEntityFramework2.Dtos;

public class ProdutoDTO
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public decimal Preco { get; set; }

    public ProdutoDTO(int id, string nome, int preco)
    {
        Id = id;
        Nome = nome;
        Preco = preco/100.0m;
    }

    public static ProdutoDTO FromProduto(Produto produto)
    {
        return new ProdutoDTO(produto.ProdutoId, produto.Nome!, produto.Preco);
    }
}