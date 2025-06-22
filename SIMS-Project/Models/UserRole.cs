using SIMS_Project.Models;
using System.ComponentModel.DataAnnotations;
public class UserRole
{
    [Key]
    public int RoleID { get; set; }

    [Required]
    [StringLength(50)]
    public string RoleName { get; set; } // E.g., "Admin", "Teacher", "Student", etc.

    public ICollection<User> Users { get; set; } // One-to-many
}