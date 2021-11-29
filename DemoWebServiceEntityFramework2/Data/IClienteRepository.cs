using DemoWebServiceEntityFramework2.Models;

namespace DemoWebServiceEntityFramework2.Data;

public interface IClienteRepository
{
    Task<Cliente?> GetAsync(int id);
}