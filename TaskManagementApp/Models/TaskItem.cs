using System;
using System.ComponentModel.DataAnnotations;

namespace TaskManagementApp.Models
{
    public class TaskItem
    {
        public int Id { get; set; }

        [Required]
        [StringLength(200)]
        public string TaskTitle { get; set; }

        [Required]
        public DateTime TaskDueDate { get; set; }

        [Required]
        public string TaskStatus { get; set; }

        public DateTime CreatedOn { get; set; } = DateTime.Now;

        public DateTime? LastUpdatedOn { get; set; }

        public string? CreatedBy { get; set; }
        public string? LastUpdatedBy { get; set; }
        public string? TaskDescription { get; set; }
        public string? TaskRemarks { get; set; }
    }
}