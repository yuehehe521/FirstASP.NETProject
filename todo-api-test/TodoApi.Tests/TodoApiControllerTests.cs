
using Xunit;
using Todo.Api;
using Todo.Api.Models;
using Todo.Api.Controllers;

namespace Todo.UnitTest.Api;

public class TodoItemControllerTests
{
    private readonly TodoContext _context;

    [Fact]
    public async void should_return_200_when_get_all()
    {
        
        // var todoContext = {};
        var todoController = new TodoItemsController(_context);
        var result = await todoController.GetTodoItems();

        
    }

    [Fact]
    public async void should_return_201_when_post()
    {
        var todoItem = new TodoItem(){  Id = 2, Name = "todo", IsComplete = true};

    }
}