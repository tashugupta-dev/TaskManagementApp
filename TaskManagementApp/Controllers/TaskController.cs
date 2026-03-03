using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using TaskManagementApp.Data;
using TaskManagementApp.Models;

namespace TaskManagementApp.Controllers
{
    public class TaskController : Controller
    {
        private readonly AppDbContext _context;

        public TaskController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index(string searchString)
        {
            var tasks = from t in _context.Tasks
                        select t;

            if (!string.IsNullOrEmpty(searchString))
            {
                tasks = tasks.Where(t => t.TaskTitle.Contains(searchString)
                          || t.TaskStatus.Contains(searchString));
            }

            return View(await tasks.ToListAsync());
        }

        public async Task<IActionResult> Create(int? id)
        {
            if (id == null)
                return View(new TaskItem());

            var task = await _context.Tasks.FindAsync(id);
            return View(task);
        }

        [HttpPost]
        public async Task<IActionResult> Create(TaskItem task)
        {
            if (ModelState.IsValid)
            {
                if (task.Id == 0)
                {
                    task.CreatedOn = DateTime.Now;
                    task.CreatedBy = "Admin";
                    _context.Tasks.Add(task);
                }
                else
                {
                    task.LastUpdatedOn = DateTime.Now;
                    task.LastUpdatedBy = "Admin";
                    _context.Update(task);
                }

                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            return View(task);
        }

        public async Task<IActionResult> Edit(int id)
        {
            var task = await _context.Tasks.FindAsync(id);
            return View(task);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(TaskItem task)
        {
            if (ModelState.IsValid)
            {
                task.LastUpdatedOn = DateTime.Now;
                _context.Update(task);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(task);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var task = await _context.Tasks.FindAsync(id);

            if (task != null)
            {
                _context.Tasks.Remove(task);
                await _context.SaveChangesAsync();
            }

            return RedirectToAction(nameof(Index));
        }
    }
}