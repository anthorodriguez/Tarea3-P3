using Microsoft.AspNetCore.Mvc;
using TaskManager.Models;
using TaskManager.Services;

namespace TaskManager.Controllers
{
    public class HomeController : Controller
    {
        private readonly TaskService _taskService;

        public HomeController(TaskService taskService)
        {
            _taskService = taskService;
        }

        public IActionResult Index(string search = "", string sort = "")
        {
            var tasks = string.IsNullOrEmpty(search) 
                ? _taskService.GetAllTasks() 
                : _taskService.SearchTasks(search);

            if (!string.IsNullOrEmpty(sort))
            {
                tasks = _taskService.GetTasksSorted(sort);
            }

            var stats = _taskService.GetStatistics();
            
            ViewBag.Search = search;
            ViewBag.Sort = sort;
            ViewBag.Stats = stats;
            
            return View(tasks);
        }

        [HttpPost]
        [HttpPost]
        public IActionResult Create(string title, string description, string priority)
        {
            try
            {
                if (string.IsNullOrEmpty(title))
                {
                    return Json(new { success = false, message = "El título es requerido" });
                }

                Priority priorityEnum;
                if (!Enum.TryParse(priority, out priorityEnum))
                {
                    priorityEnum = Priority.Media;
                }

                _taskService.CreateTask(title, description, priorityEnum);
                return Json(new { success = true });
            }
            catch (Exception ex)
            {
                return Json(new { success = false, message = ex.Message });
            }
        }

        [HttpPost]
        public IActionResult Complete(int id)
        {
            _taskService.CompleteTask(id);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Delete(int id)
        {
            _taskService.DeleteTask(id);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Update(int id, string title, string description, Priority priority)
        {
            _taskService.UpdateTask(id, title, description, priority);
            return RedirectToAction("Index");
        }
    }
}