using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace SmartShiftScheduler.Models
{
    public class Staff
    {
        public int StaffID { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Role { get; set; }

        // Relationships
        [JsonIgnore]
        public ICollection<TaskItem> Tasks { get; set; }

        [JsonIgnore]
        public ICollection<Shift> Shifts { get; set; }
    }
}
