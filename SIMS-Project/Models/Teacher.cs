using SIMS_Project.Models;
using System.ComponentModel.DataAnnotations;

public class Teacher
{
    [Key]
    public int TeacherID { get; set; }

    [Required]
    [StringLength(100)]
    public string Name { get; set; }

    [Phone]
    public string Contact { get; set; }

    [Required]
    [EmailAddress]
    public string Email { get; set; }

    [StringLength(200)]
    public string Qualification { get; set; }

    [Required]
    [Range(0, double.MaxValue)]
    public decimal Salary { get; set; }

    public int UserID { get; set; }
    public User User { get; set; }

    public ICollection<Subject> Subjects { get; set; }
    public ICollection<Class> Classes { get; set; }
    public ICollection<Assignment> Assignments { get; set; }
}
