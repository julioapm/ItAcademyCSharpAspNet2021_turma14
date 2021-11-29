using DemoWebServiceEntityFramework2.Models;

namespace DemoWebServiceEntityFramework2.Data;

public interface IPedidoRepository
{
    Task<Pedido> AddAsync(Pedido pedido);
    Task<Pedido> GetAsync(int id);
}