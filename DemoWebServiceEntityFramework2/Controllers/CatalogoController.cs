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
public class CatalogoController : ControllerBase
{
    private readonly ILogger<CatalogoController> _logger;
    private readonly IProdutoRepository _produtoRepository;

    public CatalogoController(ILogger<CatalogoController> logger, IProdutoRepository produtoRepository)
    {
        _logger = logger;
        _produtoRepository = produtoRepository;
    }

    //GET /catalogo
    [HttpGet]
    public async Task<IEnumerable<ProdutoDTO>> GetAll()
    {
        var produtos = await _produtoRepository.GetAllAsync();
        return produtos.Select(ProdutoDTO.FromProduto);
    }

    //GET /catalogo/{id}
    [HttpGet("{id}")]
    public async Task<ActionResult<ProdutoDTO>> GetById(int id)
    {
        var produto = await _produtoRepository.GetAsync(id);
        return ProdutoDTO.FromProduto(produto);
    }
}