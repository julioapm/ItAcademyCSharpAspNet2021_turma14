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
    public async Task<IEnumerable<TodoItemDTO>> GetTodoItems()
    {
        return await _context.TodoItems
            .AsNoTracking()
            .Select(t => new TodoItemDTO(t)).ToListAsync();
    }

    [HttpGet("notcomplete")] //GET api/TodoItems/notcomplete
    public async Task<IEnumerable<TodoItemDTO>> GetTodoItemsNotComplete()
    {
        return await _context.TodoItems
            .Where(t => !t.IsComplete)
            .Select(t => new TodoItemDTO(t))
            .ToListAsync();
    }

    [HttpGet("{id:long}")] //GET api/TodoItems/1
    public async Task<ActionResult<TodoItemDTO>> GetTodoItem(long id)
    {
        var todoItem = await _context.TodoItems.FindAsync(id);
        if (todoItem == null)
        {
            return NotFound();
        }
        return new TodoItemDTO(todoItem);
    }

    [HttpPost] //POST api/TodoItems
    public async Task<ActionResult<TodoItemDTO>> CreateTodoItem(TodoItemDTO todoDTO)
    {
        var todoItem = new TodoItem
        {
            IsComplete = todoDTO.IsComplete,
            Name = todoDTO.Name
        };
        _context.TodoItems.Add(todoItem);
        await _context.SaveChangesAsync();
        return CreatedAtAction(
            nameof(GetTodoItem),
            new { id = todoItem.Id },
            new TodoItemDTO(todoItem)
        );
    }

    [HttpDelete("{id:long}")] //DELETE api/TodoItems/1
    public async Task<IActionResult> DeleteTodoItem(long id)
    {
        var todoItem = await _context.TodoItems.FindAsync(id);
        if (todoItem == null)
        {
            return NotFound();
        }
        _context.TodoItems.Remove(todoItem);
        await _context.SaveChangesAsync();
        return NoContent();
    }

    [HttpPut("{id:long}")] //PUT api/TodoItems/1
    public async Task<ActionResult> UpdateTodoItem(long id, TodoItemDTO todoDTO)
    {
        _logger.LogInformation($"UpdateTodoItem:{todoDTO}");
        var todoItem = await _context.TodoItems.FindAsync(id);
        if (todoItem == null)
        {
            return NotFound();
        }
        if (id != todoDTO.Id)
        {
            return BadRequest();
        }
        todoItem.Name = todoDTO.Name;
        todoItem.IsComplete = todoDTO.IsComplete;
        await _context.SaveChangesAsync();
        return NoContent();
    }
}
