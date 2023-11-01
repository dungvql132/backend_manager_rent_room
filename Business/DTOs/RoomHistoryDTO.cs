using System.ComponentModel.DataAnnotations.Schema;

namespace BusinessLayer.DTOs
{
    public class RoomHistoryDTO : BaseModelUserDTO
    {
        public Guid? CustomerId { get; set; }
        public Guid? RoomId { get; set; }
    }
}
