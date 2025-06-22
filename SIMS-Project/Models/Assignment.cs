using SIMS_Project.Models;
using System.ComponentModel.DataAnnotations;

namespace SIMS_Project.Models
{
    public class Assignment
    {
        [Key]
        public int AssignmentID { get; set; }

        [Required]
        [StringLength(100)]
        public string Title { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public DateTime DueDate { get; set; }

        [Required]
        public int ClassID { get; set; }

        [Required]
        public int SubjectID { get; set; }

        [Required]
        public int TeacherID { get; set; }

        [Required]
        [Range(0, int.MaxValue)]
        public int TotalMarks { get; set; }

        public Class Class { get; set; }
        public Subject Subject { get; set; }
        public Teacher Teacher { get; set; }

        public ICollection<Grade> Grades { get; set; } // One-to-many
    }
}
