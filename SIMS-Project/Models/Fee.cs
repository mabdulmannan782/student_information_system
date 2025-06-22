using SIMS_Project.Models;
using System.ComponentModel.DataAnnotations;

public class Fee
{
    [Key]
    public int FeeID { get; set; }

    [Required]
    public int StudentID { get; set; }

    [Required]
    [Range(0, double.MaxValue)]
    public decimal Amount { get; set; }

    [Required]
    public DateTime DueDate { get; set; }

    public DateTime? PaidDate { get; set; }

    [Required]
    [StringLength(50)]
    public string Status { get; set; }

    public Student Student { get; set; }
}
