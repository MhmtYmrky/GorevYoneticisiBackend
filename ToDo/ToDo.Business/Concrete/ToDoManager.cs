using System.Collections.Generic;
using ToDo.Business.Abstract;
using ToDo.DataAccess.Abstract;
using ToDo.DataAccess.Concrete;
using ToDo.Entities;

namespace ToDo.Business.Concrete
{
    public class ToDoManager : IToDoService
    {
        private IToDoRepository _todoRepository;
        public ToDoManager(IToDoRepository todoRepository)
        {
            _todoRepository = todoRepository;
        }
        public Todo CreateTodo(Todo todo)
        {
            return _todoRepository.CreateTodo(todo);
        }

        public void DeleteTodo(int id)
        {
            _todoRepository.DeleteTodo(id);
        }

        public List<Todo> GetAllTodos()
        {
            return _todoRepository.GetAllTodos();
        }

        public Todo GetTodoById(int id)
        {
            if(id>0)
            {
                return _todoRepository.GetTodoById(id);

            }
            throw new Exception("id cannot be less than 1");
        }

        public Todo UpdateTodo(Todo todo)
        {
            return _todoRepository.UpdateTodo(todo);
        }
    }
}
