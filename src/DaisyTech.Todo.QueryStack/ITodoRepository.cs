using System;
using System.Collections.Generic;
using DaisyTech.Todo.QueryStack.Models;

namespace DaisyTech.Todo.QueryStack
{
    public interface ITodoRepository
    {
        List<TodoItem> GetAll();
        TodoItem Find(long id);
        TodoItem Create(TodoItem todo);
        void Update(long id, TodoItem todo);
        void Delete(long id);
    }
}