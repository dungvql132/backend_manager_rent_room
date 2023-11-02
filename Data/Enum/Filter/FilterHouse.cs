namespace DataLayer.Filter
{
    public class FilterHouse : Filter
    {
        public int? Distant { get; set; }
        public Guid? CampusId { get; set; }
        public float? MaxPowerPrice { get; set; }
        public float? MaxWaterPrice { get; set; }
        public Guid? LandLordId { get; set; }
        public string? HouseName { get; set; }
    }
}
