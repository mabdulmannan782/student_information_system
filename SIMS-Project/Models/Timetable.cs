using SIMS_Project.Models;
using System.ComponentModel.DataAnnotations;

namespace SIMS_Project.Models
{
    public class Timetable
    {
        [Key]
        public int TimetableID { get; set; }

        [Required]
        public int ClassID { get; set; }

        [Required]
        public int SubjectID { get; set; }

        [Required]
        public int TeacherID { get; set; }

        [Required]
        [StringLength(10)]
        public string DayOfWeek { get; set; } 

        [Required]
        public TimeSpan StartTime { get; set; }

        [Required]
        public TimeSpan EndTime { get; set; }

        public Class Class { get; set; }
        public Subject Subject { get; set; }
        public Teacher Teacher { get; set; }
    }
}
