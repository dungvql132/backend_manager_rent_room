using System.ComponentModel.DataAnnotations.Schema;

namespace BusinessLayer.DTOs
{
    public class RoomImageDTO : BaseModelUserDTO
    {
        public string? Link {get; set;}
        public Guid? RoomId { get; set; }
    }
}
