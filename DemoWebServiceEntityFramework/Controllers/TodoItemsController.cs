using Microsoft.AspNetCore.Mvc;
using DemoWebServiceEntityFramework.Models;

namespace DemoWebServiceEntityFramework.Controllers;

[ApiController]
[Route("[controller]")]
public class TodoItemsController : ControllerBase
{
    private readonly ILogger<TodoItemsController> _logger;
    private readonly TodoContext _context;
    public TodoItemsController(ILogger<TodoItemsController> logger, TodoContext context)
    {
        _logger = logger;
        _context = context;
    }

}
