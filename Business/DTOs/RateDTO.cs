using System.ComponentModel.DataAnnotations.Schema;

namespace BusinessLayer.DTOs
{
    public class RateDTO : BaseModelUserDTO
    {
        public float? Star {get;set;}
        public string? Comment {get;set;}
        public string? Reply {get;set;}

        public Guid? HouseId { get; set; }
    }
}
