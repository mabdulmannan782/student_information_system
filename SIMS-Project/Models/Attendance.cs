using SIMS_Project.Models;
using System.ComponentModel.DataAnnotations;

public class Attendance
{
    public enum AttendanceStatus
    {
        Present,
        Absent,
        Late
    }
    [Key]
    public int AttendanceID { get; set; }

    [Required]
    public int StudentID { get; set; }

    [Required]
    public DateTime Date { get; set; }

    [Required]
    public AttendanceStatus Status { get; set; }

    [StringLength(255)]
    public string Remarks { get; set; }

    public Student Student { get; set; }
}
