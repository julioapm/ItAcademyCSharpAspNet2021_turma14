using Microsoft.AspNetCore.Mvc;
using DemoWebServiceEntityFramework.Models;
using Microsoft.EntityFrameworkCore;

namespace DemoWebServiceEntityFramework.Controllers;

[ApiController]
[Route("api/[controller]")]
public class TodoItemsController : ControllerBase
{
    private readonly ILogger<TodoItemsController> _logger;
    private readonly TodoContext _context;
    public TodoItemsController(ILogger<TodoItemsController> logger, TodoContext context)
    {
        _logger = logger;
        _context = context;
    }

    [HttpGet] //GET api/TodoItems
    public async Task<IEnumerable<TodoItem>> GetTodoItems()
    {
        return await _context.TodoItems.ToListAsync();
    }

    [HttpGet("{id}")] //GET api/TodoItems/1
    public async Task<ActionResult<TodoItem>> GetTodoItem(long id)
    {
        var todoItem = await _context.TodoItems.FindAsync(id);
        if (todoItem == null)
        {
            return NotFound();
        }
        return todoItem;
    }

    [HttpGet] //GET api/TodoItems/notcomplete
    public async Task<IEnumerable<TodoItem>> GetTodoItemsNotComplete()
    {
        return await _context.TodoItems.Where(t => !t.IsComplete).ToListAsync();
    }
}
