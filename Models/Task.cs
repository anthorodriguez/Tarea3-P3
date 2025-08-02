using System;

namespace TaskManager.Models
{
    public class Task
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public DateTime CreatedDate { get; set; }
        public DateTime? DueDate { get; set; }
        public Priority Priority { get; set; }
        public bool IsCompleted { get; set; }

        public Task()
        {
            CreatedDate = DateTime.Now;
        }

        public Task(string title, string description, Priority priority = Priority.Media)
        {
            Title = title;
            Description = description;
            Priority = priority;
            CreatedDate = DateTime.Now;
            IsCompleted = false;
        }
    }

    public enum Priority
    {
        Baja = 1,
        Media = 2,
        Alta = 3
    }
}