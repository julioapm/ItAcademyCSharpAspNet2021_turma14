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

    [HttpGet("notcomplete")] //GET api/TodoItems/notcomplete
    public async Task<IEnumerable<TodoItem>> GetTodoItemsNotComplete()
    {
        return await _context.TodoItems.Where(t => !t.IsComplete).ToListAsync();
    }

    [HttpGet("{id:long}")] //GET api/TodoItems/1
    public async Task<ActionResult<TodoItem>> GetTodoItem(long id)
    {
        var todoItem = await _context.TodoItems.FindAsync(id);
        if (todoItem == null)
        {
            return NotFound();
        }
        return todoItem;
    }

    [HttpPost] //POST api/TodoItems
    public async Task<ActionResult<TodoItem>> CreateTodoItem(TodoItem todo)
    {
        _context.TodoItems.Add(todo);
        await _context.SaveChangesAsync();
        return CreatedAtAction(nameof(GetTodoItem), new { id = todo.Id }, todo);
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
    public async Task<ActionResult> UpdateTodoItem(long id, TodoItem todo)
    {
        var todoItem = await _context.TodoItems.FindAsync(id);
        if (todoItem == null)
        {
            return NotFound();
        }
        if (id != todo.Id)
        {
            return BadRequest();
        }
        todoItem.Name = todo.Name;
        todoItem.IsComplete = todo.IsComplete;
        await _context.SaveChangesAsync();
        return NoContent();
    }
}
