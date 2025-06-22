using SIMS_Project.Models;
using System.ComponentModel.DataAnnotations;

namespace SIMS_Project.Models
{
    public class Class
    {
        [Key]
        public int ClassID { get; set; }

        [Required]
        [StringLength(50)]
        public string ClassName { get; set; }

        public int? TeacherID { get; set; }

        public Teacher Teacher { get; set; }
        public ICollection<Student> Students { get; set; }
        public ICollection<Subject> Subjects { get; set; }
        public ICollection<Exam> Exams { get; set; }
        public ICollection<Timetable> Timetables { get; set; }
        public ICollection<Assignment> Assignments { get; set; }
    }
}
