using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDo.DataAccess.Abstract;
using ToDo.Entities;

namespace ToDo.DataAccess.Concrete
{
    public class ToDoRepository : IToDoRepository
    {
        public Todo CreateTodo(Todo todo)
        {
            using (var todoDbContext = new ToDoDbContext())
            { 
                todoDbContext.ToDoApp.Add(todo);
                todoDbContext.SaveChanges();
                return todo;
            }
        }

        public void DeleteTodo(int id)
        {
            using (var todoDbContext = new ToDoDbContext()) 
            { 
                var deletedTodo=GetTodoById(id);
                todoDbContext.ToDoApp.Remove(deletedTodo);
                todoDbContext.SaveChanges();
            }
        }

        public List<Todo> GetAllTodos()
        {
            using (var todoDbContext=new ToDoDbContext()) {return todoDbContext.ToDoApp.ToList<Todo>(); }
        }

        public Todo GetTodoById(int id)
        {
            using (var todoDbContext = new ToDoDbContext()) { return todoDbContext.ToDoApp.Find(id); }
        }

        public Todo UpdateTodo(Todo todo)
        {
            using (var todoDbContext = new ToDoDbContext())
            { 
                todoDbContext.ToDoApp.Update(todo);
                todoDbContext.SaveChanges();
                return todo;
            }
        }
    }
}
