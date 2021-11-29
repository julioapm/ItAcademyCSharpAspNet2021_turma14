using DemoWebServiceEntityFramework2.Models;
using Microsoft.EntityFrameworkCore;

namespace DemoWebServiceEntityFramework2.Data;

public class ClienteRepositoryEF : IClienteRepository
{
    private readonly BdContext _context;
    public ClienteRepositoryEF(BdContext context)
    {
        _context = context;
    }

    public async Task<Cliente?> GetAsync(int id)
    {
        return await _context.Clientes.FindAsync(id);
    }
}