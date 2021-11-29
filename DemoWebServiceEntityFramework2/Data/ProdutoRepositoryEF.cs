using DemoWebServiceEntityFramework2.Models;
using Microsoft.EntityFrameworkCore;

namespace DemoWebServiceEntityFramework2.Data;

public class ProdutoRepositoryEF : IProdutoRepository
{
    private readonly BdContext _context;

    public ProdutoRepositoryEF(BdContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<Produto>> GetAllAsync()
    {
        return await _context.Produtos.ToListAsync();
    }

    public async Task<Produto> GetAsync(int id)
    {
        var produto = await _context.Produtos.FindAsync(id);
        if (produto == null)
        {
            throw new ProdutoNotFoundException(id);
        }
        return produto;
    }
}