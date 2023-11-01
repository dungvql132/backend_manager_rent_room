using System.ComponentModel.DataAnnotations.Schema;

namespace DataLayer.Models
{
    public class BaseModelUser : BaseModel
    {
        public Guid? CreatedBy { get; set; }

        [ForeignKey("CreatedBy")]
        public User? CreatedByUser { get; set; }

        public Guid? LastModifiedBy { get; set; }

        [ForeignKey("LastModifiedBy")]
        public User? LastModifiedByUser { get; set; }
    }
}
