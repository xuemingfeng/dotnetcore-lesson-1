using System;

namespace DaisyTech.Todo.QueryStack.Models {
    public class TodoItem {
        public long Id { get; set; }
        public string Subject { get; set; }
        public string Details { get; set; }
        public bool IsComplete { get; set; }
        public DateTime CreatedAtUtc { get; set; }
    }
}