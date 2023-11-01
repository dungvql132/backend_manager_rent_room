using System;
using System.ComponentModel.DataAnnotations;

namespace DataLayer.Models
{
    public class BaseModel
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public DateTime CreateDate { get; set; }

        [Required]
        public DateTime LastModifiedDate { get; set; }

        public BaseModel()
        {
            Id = Guid.NewGuid();
            CreateDate = DateTime.UtcNow;
            LastModifiedDate = DateTime.UtcNow;
        }
    }
}
