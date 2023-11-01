using System.ComponentModel.DataAnnotations.Schema;

namespace BusinessLayer.DTOs
{
    public class HouseDTO : BaseModelUserDTO
    {
        public string? HouseName {get; set;}
        public string? Information {get; set;}
        public string? Village {get; set;}
        public float? PowerPrice {get; set;}
        public float? WaterPrice {get; set;}
        public Guid? AddressId { get; set; }
        public Guid? LandLordId { get; set; }
        public Guid? CampusId { get; set; }
    }

    public class HouseUpdateDTO : BaseModelUserDTO
    {
        public string? HouseName {get; set;}
        public string? Information {get; set;}
        public string? Village {get; set;}
        public float? PowerPrice {get; set;}
        public float? WaterPrice {get; set;}
        public Guid? AddressId { get; set; }
        public Guid? LandLordId { get; set; }
        public Guid? CampusId { get; set; }
    }
}
