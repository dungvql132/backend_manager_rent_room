using System.ComponentModel.DataAnnotations.Schema;

namespace DataLayer.Models
{
    public class HouseImage : BaseModelUser
    {
        public string Link {get; set;}
        public Guid HouseId { get; set; }

        [ForeignKey("HouseId")]
        public House House { get; set; }
    }
}
