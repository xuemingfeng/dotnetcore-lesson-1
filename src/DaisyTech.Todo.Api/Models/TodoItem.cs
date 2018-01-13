using System;

namespace DaisyTech.Todo.Api.Models {
    public class TodoItem {
        public long Id { get; set; }
        public string Subject { get; set; }
        public string Details { get; set; }
        public bool IsComplete { get; set; }
    }
}