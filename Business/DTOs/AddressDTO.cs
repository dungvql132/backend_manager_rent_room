namespace BusinessLayer.DTOs
{
    public class AddressDTO : BaseModelDTO
    {
        public string? Addresses { get; set; }
        public double? Latitude { get; set; }
        public double? Longitude { get; set; }
    }
}
