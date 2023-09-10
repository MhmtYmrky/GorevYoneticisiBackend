using Microsoft.AspNetCore.Mvc;
using ToDo.Business.Abstract;
using ToDo.Entities;

namespace ToDo.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodoController : ControllerBase
    {
        private IToDoService _todoService;
        public TodoController(IToDoService todoService)
        {
            _todoService = todoService;
        }
        [HttpGet]
        public List<Todo> Get()
        {
            return _todoService.GetAllTodos();
        }
        [HttpGet("{id}")]
        public Todo Get(int id)
        {
            return _todoService.GetTodoById(id);
        }

        [HttpPost]
        public Todo Post([FromBody] Todo todo)
        {
            return _todoService.CreateTodo(todo);
        }
        [HttpPut]
        public Todo Put([FromBody] Todo todo)
        {
            return _todoService.UpdateTodo(todo);
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _todoService.DeleteTodo(id);
        }
    }
}
