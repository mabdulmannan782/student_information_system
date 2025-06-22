using SIMS_Project.Models;
using System.ComponentModel.DataAnnotations;


namespace SIMS_Project.Models
{
    public class Student
    {
        [Key]
        public int StudentID { get; set; }

        [Required]
        [StringLength(100)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(100)]
        public string LastName { get; set; }

        [Required] // Making ClassID required
        public int ClassID { get; set; }

        public int? SubjectID { get; set; } // Nullable if not every student has a subject

        public Class Class { get; set; }
        public Subject Subject { get; set; } // Navigation property

        public ICollection<Grade> Grades { get; set; }
        public ICollection<Attendance> Attendances { get; set; }
    }
}
