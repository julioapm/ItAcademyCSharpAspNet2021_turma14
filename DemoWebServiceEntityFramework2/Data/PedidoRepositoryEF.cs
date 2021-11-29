using DemoWebServiceEntityFramework2.Models;
using Microsoft.EntityFrameworkCore;

namespace DemoWebServiceEntityFramework2.Data;

public class PedidoRepositoryEF : IPedidoRepository
{
    private readonly BdContext _context;

    public PedidoRepositoryEF(BdContext context)
    {
        _context = context;
    }

    public async Task<Pedido> AddAsync(Pedido pedido)
    {
        await _context.Pedidos.AddAsync(pedido);
        await _context.SaveChangesAsync();
        return pedido;
    }

    public Task<Pedido> GetAsync(int id)
    {
        throw new NotImplementedException();
    }
}