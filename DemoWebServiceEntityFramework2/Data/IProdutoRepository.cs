using DemoWebServiceEntityFramework2.Models;

namespace DemoWebServiceEntityFramework2.Data;

public interface IProdutoRepository
{
    Task<Produto> GetAsync(int id);
    Task<IEnumerable<Produto>> GetAllAsync();
}