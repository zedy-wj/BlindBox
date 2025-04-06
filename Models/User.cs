using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class User
{
    [Key]
    public int Id { get; set; }

    [Required]
    [StringLength(50, MinimumLength = 2, ErrorMessage = "The username length must be between 2 and 50 characters.")]
    public string Username { get; set; }

    [Required]
    [Column("password_hash")]
    [StringLength(255)]
    public string PasswordHash { get; set; }

    [Required]
    [StringLength(100)]
    public string Email { get; set; }

    [StringLength(20)]
    public string Phone { get; set; }

    [Column("created_at")]
    public DateTime CreatedAt { get; set; }

    [Column("updated_at")]
    public DateTime UpdatedAt { get; set; }

    [Column("is_active")]
    public byte IsActive { get; set; }

    [StringLength(50)]
    public string Nickname { get; set; }

    [Column("avatar_url")]
    [StringLength(255)]
    public string AvatarUrl { get; set; }

    [StringLength(1)]
    public byte Gender { get; set; }

    public DateTime Birthdate { get; set; }

    [Column("last_login_at")]
    public DateTime LastLoginAt { get; set; }

    public string Bio { get; set; } 
}

// DTO 定义
public class UserProfileDto
{
    [StringLength(50)]
    public string Nickname { get; set; }

    [StringLength(255)]
    public string AvatarUrl { get; set; }

    public string Bio { get; set; }
}

public class ChangePasswordDto
{
    [Required]
    public string OldPassword { get; set; }

    [Required]
    [StringLength(100, MinimumLength = 6)]
    public string NewPassword { get; set; }

    [Compare("NewPassword")]
    public string ConfirmNewPassword { get; set; }
}