using SIMS_Project.Models;
using System.ComponentModel.DataAnnotations;

public class Exam
{
    [Key]
    public int ExamID { get; set; }

    [Required]
    [StringLength(100)]
    public string ExamName { get; set; }

    [Required]
    public int ClassID { get; set; }

    [Required]
    public int SubjectID { get; set; }

    [Required]
    public DateTime Date { get; set; }

    [Required]
    [Range(0, int.MaxValue)]
    public int TotalMarks { get; set; }

    public Class Class { get; set; }
    public Subject Subject { get; set; }
    public ICollection<Grade> Grades { get; set; }
}
