using Data.Enum;

namespace DataLayer.Filter
{
    public class FilterRoom : Filter
    {
        public RoomType? Type { get; set; }

        public string? RoomName { get; set; }
    }
}
