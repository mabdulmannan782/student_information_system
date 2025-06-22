using SIMS_Project.Models;
using System.ComponentModel.DataAnnotations;

namespace SIMS_Project.Models
{
    public class Subject
    {
        [Key]
        public int SubjectID { get; set; }

        [Required]
        [StringLength(100)]
        public string SubjectName { get; set; }

        public int ClassID { get; set; }
        public int TeacherID { get; set; }

        public Class Class { get; set; }
        public Teacher Teacher { get; set; }

        public ICollection<Student> Students { get; set; }
        public ICollection<Timetable> Timetables { get; set; }
        public ICollection<Assignment> Assignments { get; set; }
        public ICollection<Exam> Exams { get; set; }
        public ICollection<Grade> Grades { get; set; }
    }

}
