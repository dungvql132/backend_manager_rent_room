using System.ComponentModel.DataAnnotations.Schema;

namespace DataLayer.Models
{
    public class RoomHistory : BaseModelUser
    {
        public Guid CustomerId { get; set; }

        [ForeignKey("CustomerId")]
        public User Customer { get; set; }
        public Guid RoomId { get; set; }

        [ForeignKey("RoomId")]
        public Room Room { get; set; }
    }
}
