using SIMS_Project.Models;
using System.ComponentModel.DataAnnotations;

public class Grade
{
    [Key]
    public int GradeID { get; set; }

    public int? ExamID { get; set; }
    public int? StudentID { get; set; }
    public int? AssignmentID { get; set; }

    [Required]
    [Range(0, int.MaxValue)]
    public int MarksObtained { get; set; }

    [StringLength(2)]
    public string GradeValue { get; set; }

    [StringLength(255)]
    public string Remarks { get; set; }


    public int SubjectID { get; set; }

    public Exam Exam { get; set; }
    public Student Student { get; set; }
    public Assignment Assignment { get; set; }
    public Subject Subject { get; set; }
}
