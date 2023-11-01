using System.ComponentModel.DataAnnotations.Schema;

namespace BusinessLayer.DTOs
{
    public class CampusesDTO : BaseModelDTO
    {
        public string? CampusName { get; set; }
        public Guid? AddressId { get; set; }
    }
}
