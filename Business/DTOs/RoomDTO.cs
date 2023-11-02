using System.ComponentModel.DataAnnotations.Schema;
using Data.Enum;
using DataLayer.Filter;

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
        public RoomStatus? Status { get; set; }
        public RoomType? Type { get; set; }
        public Guid HouseId { get; set; }
    }

    public class RoomUpdateDTO : BaseModelUserDTO
    {
        public string? RoomName { get; set; }
        public float? Price { get; set; }
        public string? Information { get; set; }
        public string? Area { get; set; }
        public int? MaxAmountOfPeople { get; set; }
        public int? CurrentAmountOfPeople { get; set; }
        public int? FloorNumber { get; set; }
        public RoomStatus? Status { get; set; }
        public RoomType? Type { get; set; }
    }

    public class FilterRoomDTO : FilterRoom
    {

    }
}
