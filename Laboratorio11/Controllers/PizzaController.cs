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

    [HttpPost]
    public ActionResult<Pizza> Create(Pizza pizza)
    {
        _logger.LogInformation("Create pizza {pizza}", pizza);
        PizzaService.Add(pizza);
        return CreatedAtAction(nameof(Get), new { id = pizza.Id }, pizza);
    }

    [HttpPut("{id:int:min(1)}")]
    public ActionResult Update(int id, Pizza pizza)
    {
        if (id != pizza.Id)
        {
            return BadRequest();
        }
        var pizzaToUpdate = PizzaService.Get(id);
        if (pizzaToUpdate is null)
        {
            return NotFound();
        }
        PizzaService.Update(pizza);
        return NoContent();
    }

    [HttpDelete("{id:int:min(1)}")]
    public ActionResult Delete(int id)
    {
        var pizza = PizzaService.Get(id);
        if (pizza is null)
        {
            return NotFound();
        }
        PizzaService.Delete(id);
        return NoContent();
    }
}
