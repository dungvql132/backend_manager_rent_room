using System;
using System.ComponentModel.DataAnnotations;

namespace BusinessLayer.DTOs
{
    public class BaseModelDTO
    {
        public Guid? Id { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? LastModifiedDate { get; set; }

        public BaseModelDTO()
        {
        }
    }
}
