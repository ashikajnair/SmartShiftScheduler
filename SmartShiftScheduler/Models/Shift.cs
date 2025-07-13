using System;
using System.ComponentModel.DataAnnotations;

namespace SmartShiftScheduler.Models
{
    public class Shift
    {
        public int ShiftID { get; set; }

        [Required]
        public DateTime Date { get; set; }

        [Required]
        public TimeSpan StartTime { get; set; }

        [Required]
        public TimeSpan EndTime { get; set; }

        // Foreign Key
        [Required]
        public int StaffID { get; set; }

        // Navigation Property
        public Staff Staff { get; set; }
    }
}
