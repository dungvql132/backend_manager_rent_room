using System.ComponentModel.DataAnnotations;

namespace BusinessLayer.DTOs
{
    public class RegisterUserDTO
    {
        [Required]
        public string? Email { get; set; }
        [Required]
        [MinLength(8, ErrorMessage = "Password must be at least 8 characters long.")]
        [MaxLength(20, ErrorMessage = "Password cannot be more than 20 characters.")]
        public string? Password { get; set; }
        public string? DisplayName { get; set; }
        public string? ProfileImageLink { get; set; }
        public string? PhoneNumber { get; set; }
        public int Role { get; set; }
    }

    public class LoginUserDTO
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        public string? Password { get; set; }
    }

    public class LoginResponseUserDTO
    {
        public string? Email { get; set; }
        public string? Token { get; set; }
    }
}
