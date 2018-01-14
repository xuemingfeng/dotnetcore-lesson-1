using System;
using Microsoft.EntityFrameworkCore;
using System.Configuration;
using DaisyTech.Todo.QueryStack.Models;

namespace DaisyTech.Todo.QueryStack.SqlServer
{
    public class TodoContext : DbContext
    {
        public DbSet<TodoItem> TodoItems { get; set; }

        public TodoContext(DbContextOptions<TodoContext> options)
            : base(options)
        { }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // optionsBuilder.UseSqlServer (ConfigurationManager.ConnectionStrings["TodoDatabase"].ConnectionString);
            // optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS;Database=Todo;Trusted_Connection=True;");
        }
    }
}