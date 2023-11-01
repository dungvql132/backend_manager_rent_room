using System.ComponentModel.DataAnnotations.Schema;

namespace DataLayer.Models
{
    public class RoomImage : BaseModelUser
    {
        public string Link {get; set;}
        public Guid RoomId { get; set; }

        [ForeignKey("RoomId")]
        public Room Room { get; set; }
    }
}
