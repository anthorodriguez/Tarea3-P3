using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;
using TaskManager.Models;

namespace TaskManager.Services
{
    public class TaskService
    {
        private List<Models.Task> _tasks;
        private readonly string _filePath = "tasks.json";
        private int _nextId = 1;
        private readonly SemaphoreSlim _lock = new SemaphoreSlim(1, 1);
        private DateTime _lastSaveTime = DateTime.MinValue;
        private const int SaveIntervalMs = 5000; // Save every 5 seconds

        public TaskService()
        {
            _tasks = new List<Models.Task>();
            LoadTasks();
        }

        public void CreateTask(string title, string description, Priority priority = Priority.Media)
        {
            var task = new Models.Task(title, description, priority)
            {
                Id = _nextId++
            };
            
            _tasks.Add(task);
            SaveTasks();
        }

        public List<Models.Task> GetAllTasks()
        {
            return _tasks.AsReadOnly().ToList();
        }

        public Models.Task? GetTaskById(int id)
        {
            return _tasks.FirstOrDefault(t => t.Id == id);
        }

        public bool UpdateTask(int id, string? title = null, string? description = null, Priority? priority = null)
        {
            var task = GetTaskById(id);
            if (task == null) return false;

            if (!string.IsNullOrEmpty(title)) task.Title = title;
            if (!string.IsNullOrEmpty(description)) task.Description = description;
            if (priority.HasValue) task.Priority = priority.Value;

            SaveTasks();
            return true;
        }

        public bool CompleteTask(int id)
        {
            var task = GetTaskById(id);
            if (task == null) return false;

            task.IsCompleted = !task.IsCompleted;
            SaveTasks();
            return true;
        }

        public bool DeleteTask(int id)
        {
            var task = GetTaskById(id);
            if (task == null) return false;

            _tasks.Remove(task);
            SaveTasks();
            return true;
        }

        public List<Models.Task> SearchTasks(string searchTerm)
        {
            if (string.IsNullOrEmpty(searchTerm)) return GetAllTasks();
            
            return _tasks.Where(t => 
                t.Title.Contains(searchTerm, StringComparison.OrdinalIgnoreCase) ||
                t.Description.Contains(searchTerm, StringComparison.OrdinalIgnoreCase)
            ).ToList();
        }

        public List<Models.Task> GetTasksSorted(string sortBy)
        {
            return sortBy.ToLower() switch
            {
                "title" => _tasks.OrderBy(t => t.Title).ToList(),
                "date" => _tasks.OrderBy(t => t.CreatedDate).ToList(),
                "priority" => _tasks.OrderByDescending(t => t.Priority).ToList(),
                "status" => _tasks.OrderBy(t => t.IsCompleted).ToList(),
                _ => _tasks.ToList()
            };
        }

        public (int total, int completed, int pending, int highPriority) GetStatistics()
        {
            var total = _tasks.Count;
            var completed = _tasks.Count(t => t.IsCompleted);
            var pending = total - completed;
            var highPriority = _tasks.Count(t => t.Priority == Priority.Alta);

            return (total, completed, pending, highPriority);
        }

        private void SaveTasks()
        {
            try
            {
                var json = JsonConvert.SerializeObject(_tasks, Formatting.Indented);
                File.WriteAllText(_filePath, json);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al guardar: {ex.Message}");
            }
        }

        private void LoadTasks()
        {
            try
            {
                if (File.Exists(_filePath))
                {
                    var json = File.ReadAllText(_filePath);
                    _tasks = JsonConvert.DeserializeObject<List<Models.Task>>(json) ?? new List<Models.Task>();
                    
                    if (_tasks.Any())
                    {
                        _nextId = _tasks.Max(t => t.Id) + 1;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al cargar: {ex.Message}");
                _tasks = new List<Models.Task>();
            }
        }
    }
}