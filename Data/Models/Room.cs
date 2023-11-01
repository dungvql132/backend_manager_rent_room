using System.ComponentModel.DataAnnotations.Schema;
using Data.Enum;

namespace DataLayer.Models
{
    public class Room : BaseModelUser
    {
        public string RoomName { get; set; }
        public float Price { get; set; }
        public string Information { get; set; }
        public string Area { get; set; }
        public int MaxAmountOfPeople { get; set; }
        public int CurrentAmountOfPeople { get; set; }
        public int FloorNumber { get; set; }

        [Column(TypeName = "int")]
        public RoomStatus Status {get;set;}

        [Column(TypeName = "int")]
        public RoomType Type {get;set;}


        public Guid HouseId { get; set; }

        [ForeignKey("HouseId")]
        public House House { get; set; }

        public ICollection<RoomImage> RoomImages { get; set; }
        public ICollection<RoomHistory> RoomHistories { get; set; }
    }
}
