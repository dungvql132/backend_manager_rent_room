using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Data.Enum;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models
{
    [Index(nameof(User.Email), IsUnique = true)]
    public class User : BaseModel
    {
        [Required]
        public string Email { get; set; }
        public string Password { get; set; }
        public string DisplayName { get; set; }
        public string ProfileImageLink { get; set; }
        public string PhoneNumber { get; set; }
        public bool Active { get; set; } = true;

        [Column(TypeName = "int")]
        public Role Role { get; set; }
        public Guid? AddressId { get; set; }

        [ForeignKey("AddressId")]
        public Address? Address { get; set; }
    }
}
