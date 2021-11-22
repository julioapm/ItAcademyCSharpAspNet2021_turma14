using Microsoft.AspNetCore.Mvc;

namespace DemoWebServiceAloMundo.Controllers;

[ApiController]
[Route("api/[controller]")]
public class AloMundoController : ControllerBase
{
    private readonly ILogger<AloMundoController> _logger;

    public AloMundoController(ILogger<AloMundoController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    public string Get()
    {
        _logger.LogInformation("AloMundoController.Get()");
        return "Alô Mundo!";
    }

    [HttpGet("{nome}")]
    public string Get(string nome)
    {
        _logger.LogInformation($"AloMundoController.Get({nome})");
        return $"Alô Mundo, {nome}!";
    }

    [HttpGet("query")]
    public string GetQuery(string nome)
    {
        _logger.LogInformation($"AloMundoController.GetQuery({nome})");
        return $"Alô Mundo, {nome}!";
    }

    [HttpPost]
    public string Post([FromBody] string nome)
    {
        _logger.LogInformation($"AloMundoController.Post({nome})");
        return $"Alô Mundo, {nome}!";
    }

    [HttpPost("pessoa")]
    public string Post([FromBody] Pessoa pessoa)
    {
        _logger.LogInformation($"AloMundoController.Post({pessoa.Nome})");
        return $"Alô Mundo, {pessoa.Nome}!";
    }
}
