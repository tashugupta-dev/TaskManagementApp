using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using TaskManagementApp.Models;

namespace TaskManagementApp.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<TaskItem> Tasks { get; set; }
    }
}