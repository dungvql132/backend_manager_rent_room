namespace DataLayer.Models
{
    public class Address : BaseModel
    {
        public string Addresses { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
    }
}
