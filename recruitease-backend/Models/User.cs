using System.ComponentModel.DataAnnotations;

namespace recruitease_backend.Models;

public class User
{
    [Key]
    public int Id { get; set; }

    [Required]
    [MaxLength(100)]
    public string FullName { get; set; } = string.Empty;

    [Required]
    [EmailAddress]
    [MaxLength(150)]
    public string Email { get; set; } = string.Empty;

    [Required]
    [MinLength(8)]
    public string PasswordHash { get; set; } = string.Empty;

    // Role can be "Candidate" or "Recruiter"
    [Required]
    [MaxLength(20)]
    public string Role { get; set; } = "Candidate";

    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
}