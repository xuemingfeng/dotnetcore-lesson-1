using System;
using Microsoft.EntityFrameworkCore;
using DaisyTech.Todo.QueryStack.Models;

namespace DaisyTech.Todo.QueryStack.SqlServer {
    public class TodoContext : DbContext {
        public DbSet<TodoItem> TodoItems { get; set; }

        protected override void OnConfiguring (DbContextOptionsBuilder optionsBuilder) {
            optionsBuilder.UseSqlServer (ConfigurationManager.ConnectionStrings["TodoDatabase"].ConnectionString);
        }
    }
}