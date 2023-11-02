using System.ComponentModel.DataAnnotations.Schema;

namespace DataLayer.Models
{
    public class House : BaseModelUser
    {
        public string HouseName { get; set; }
        public string Information { get; set; }
        public string Village { get; set; }
        public float PowerPrice { get; set; }
        public float WaterPrice { get; set; }
        public Guid AddressId { get; set; }

        [ForeignKey("AddressId")]
        public Address Address { get; set; }

        public Guid LandLordId { get; set; }

        [ForeignKey("LandLordId")]
        public User LandLordUser { get; set; }

        public Guid? CampusId { get; set; }

        [ForeignKey("CampusId")]
        public Campuses? Campus { get; set; }

        public ICollection<HouseImage> HouseImages { get; set; }
        public ICollection<Room> Rooms { get; set; }
        public ICollection<Rate> Rates { get; set; }
    }
}
