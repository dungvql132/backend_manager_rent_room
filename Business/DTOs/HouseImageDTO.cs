using System.ComponentModel.DataAnnotations.Schema;

namespace BusinessLayer.DTOs
{
    public class HouseImageDTO : BaseModelUserDTO
    {
        public string? Link {get; set;}
        public Guid? HouseId { get; set; }
    }
}
