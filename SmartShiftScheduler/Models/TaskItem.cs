using System;
using System.ComponentModel.DataAnnotations;

namespace SmartShiftScheduler.Models
{
    public class TaskItem
    {
        public int TaskItemID { get; set; }

        [Required]
        public string TaskName { get; set; }

        public string Description { get; set; }

        [Required]
        public DateTime Date { get; set; }

        public string Status { get; set; }

        // Foreign Key
        [Required]
        public int StaffID { get; set; }

        // Navigation Property
        public Staff Staff { get; set; }
    }
}
