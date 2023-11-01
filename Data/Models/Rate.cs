using System.ComponentModel.DataAnnotations.Schema;

namespace DataLayer.Models
{
    public class Rate : BaseModelUser
    {
        public float Star {get;set;}
        public string Comment {get;set;}
        public string? Reply {get;set;}

        public Guid HouseId { get; set; }

        [ForeignKey("HouseId")]
        public House House { get; set; }
    }
}
