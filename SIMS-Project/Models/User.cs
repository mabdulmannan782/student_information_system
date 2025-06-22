using SIMS_Project.Models;
using System.ComponentModel.DataAnnotations;


public class User
{
    [Key]
    public int UserID { get; set; }

    [Required]
    [StringLength(100)]
    public string Username { get; set; }

    [Required]
    [StringLength(255)]
    public string PasswordHash { get; set; }

    [Required]
    [EmailAddress]
    public string Email { get; set; }

    public int RoleID { get; set; }
    public UserRole Role { get; set; }

    public ICollection<Teacher> Teachers { get; set; }
    public ICollection<Guardian> Guardians { get; set; }
}
