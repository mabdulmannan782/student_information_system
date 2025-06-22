using SIMS_Project.Models;
using System.ComponentModel.DataAnnotations;

public class Guardian
{
    [Key]
    public int GuardianID { get; set; }

    [Required]
    [StringLength(100)]
    public string Name { get; set; }

    [Required]
    [Phone]
    public string Contact { get; set; }

    [Required]
    [EmailAddress]
    public string Email { get; set; }

    public int UserID { get; set; }
    public User User { get; set; }

    public ICollection<Student> Students { get; set; } // One-to-many
}
