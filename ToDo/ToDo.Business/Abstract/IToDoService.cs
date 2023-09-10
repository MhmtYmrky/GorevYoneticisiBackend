using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDo.Entities;

namespace ToDo.Business.Abstract
{
    public interface IToDoService
    {
        List<Todo> GetAllTodos();
        Todo GetTodoById(int id);
        Todo CreateTodo(Todo todo);
        Todo UpdateTodo(Todo todo);
        void DeleteTodo(int id);

    }
}
