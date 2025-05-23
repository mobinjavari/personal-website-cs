using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyWebApp.Models;

public enum UserRank
{
    Ghost,
    User,
    Admin,
    Owner
}

public class User
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    [Required]
    [RegularExpression(@"^[a-z]+$", ErrorMessage = "Username can only contain lowercase letters a-z")]
    [StringLength(50)]
    public string Username { get; set; } = null!;

    [Required]
    [StringLength(50)]
    public string Password { get; set; } = null!;

    [Required]
    [EmailAddress]
    [StringLength(30)]
    public string Email { get; set; } = null!;

    [StringLength(50)]
    public string? FirstName { get; set; }

    [StringLength(50)]
    public string? LastName { get; set; }

    public UserRank Rank { get; set; } = UserRank.Ghost;

    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    public DateTime LastLoginAt { get; set; } = DateTime.UtcNow;

    public DateTime LastProfileUpdatedAt { get; set; } = DateTime.UtcNow;

    public string DisplayName => GetDisplayName();

    public string AvatarName => GetAvatarName();

    private string GetDisplayName()
    {
        if (!string.IsNullOrEmpty(FirstName) || !string.IsNullOrEmpty(LastName))
        {
            return $"{FirstName} {LastName}".Trim();
        }

        return Username;
    }

    private string GetAvatarName()
    {
        if (!string.IsNullOrEmpty(FirstName) && !string.IsNullOrEmpty(LastName))
        {
            return (FirstName[0].ToString() + LastName[0].ToString()).ToUpper();
        }

        return !string.IsNullOrEmpty(Username) ? 
            Username[0].ToString().ToUpper() : "?";
    }
} 