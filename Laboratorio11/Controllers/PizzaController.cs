using Microsoft.AspNetCore.Mvc;
using Laboratorio11.Models;
using Laboratorio11.Services;

namespace Laboratorio11.Controllers;

[ApiController]
[Route("[controller]")]
public class PizzaController : ControllerBase
{
    private readonly ILogger<PizzaController> _logger;

    public PizzaController(ILogger<PizzaController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    public List<Pizza> Get()
    {
        return PizzaService.GetAll();
    }

    [HttpGet("{id:int:min(1)}")]
    [ProducesResponseType(200)]
    [ProducesResponseType(404)]
    public ActionResult<Pizza> Get(int id)
    {
        _logger.LogInformation("Get pizza with id {id}", id);
        var pizza = PizzaService.Get(id);
        if (pizza is null)
        {
            return NotFound();
        }
        return pizza;
    }
}
