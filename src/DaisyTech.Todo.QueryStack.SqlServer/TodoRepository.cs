using System;
using System.Collections.Generic;
using System.Linq;
using DaisyTech.Todo.QueryStack;
using DaisyTech.Todo.QueryStack.Models;

namespace DaisyTech.Todo.QueryStack.SqlServer
{
    public class TodoRepository : ITodoRepository
    {
        private readonly TodoContext _context;

        public TodoRepository(TodoContext context)
        {
            _context = context;
        }

        public List<TodoItem> GetAll()
        {
            return _context.TodoItems.ToList();
        }

        public TodoItem Find(long id)
        {
            return _context.TodoItems.Find(id);
        }

        public TodoItem Create(TodoItem todo)
        {
            _context.TodoItems.Add(todo);
            _context.SaveChanges();

            return todo;
        }

        public void Update(long id, TodoItem todo)
        {
            var entity = _context.TodoItems.Find(id);
            entity.Subject = todo.Subject;
            entity.Details = todo.Details;

            _context.SaveChanges();
        }

        public void Delete(long id)
        {
            var entity = _context.TodoItems.Find(id);
            _context.Remove(entity);
            _context.SaveChanges();
        }
    }
}