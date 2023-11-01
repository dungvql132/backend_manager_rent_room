using System.ComponentModel.DataAnnotations.Schema;

namespace DataLayer.Models
{
    public class Campuses : BaseModel
    {
        public string CampusName { get; set; }
        public Guid AddressId { get; set; }

        [ForeignKey("AddressId")]
        public Address Address { get; set; }
    }
}
