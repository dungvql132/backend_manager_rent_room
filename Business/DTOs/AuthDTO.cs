using System.ComponentModel.DataAnnotations;

namespace BusinessLayer.DTOs
{
    public class RegisterUserDTO
    {
        [Required]
        public string? Email { get; set; }
        [Required]
        public string? Password { get; set; }
        public string? DisplayName { get; set; }
        public string? ProfileImageLink { get; set; }
        public string? PhoneNumber { get; set; }
        public int Role { get; set; }
    }

    public class LoginUserDTO
    {
        [Required]
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
