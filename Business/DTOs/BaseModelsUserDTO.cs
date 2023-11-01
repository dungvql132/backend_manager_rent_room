using System.ComponentModel.DataAnnotations.Schema;

namespace BusinessLayer.DTOs
{
    public class BaseModelUserDTO : BaseModelDTO
    {
        public Guid? CreatedBy { get; set; }
        public Guid? LastModifiedBy { get; set; }
    }
}
