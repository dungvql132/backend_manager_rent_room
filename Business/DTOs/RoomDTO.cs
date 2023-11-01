using System.ComponentModel.DataAnnotations.Schema;
using Data.Enum;

namespace BusinessLayer.DTOs
{
    public class RoomDTO : BaseModelUserDTO
    {
        public string? RoomName { get; set; }
        public float? Price { get; set; }
        public string? Information { get; set; }
        public string? Area { get; set; }
        public int? MaxAmountOfPeople { get; set; }
        public int? CurrentAmountOfPeople { get; set; }
        public int? FloorNumber { get; set; }

        [Column(TypeName = "int")]
        public RoomStatus? Status {get;set;}

        [Column(TypeName = "int")]
        public RoomType? Type {get;set;}
        public Guid HouseId { get; set; }
    }
}
