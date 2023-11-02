using Data.Enum;
using DataLayer.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Database
{
    public class MorkContext : IdentityDbContext
    {
        public MorkContext(DbContextOptions dbContextOptions)
            : base(dbContextOptions) { }

        public DbSet<Address> Addresses { get; set; }
        public DbSet<Campuses> Campuses { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<House> Houses { get; set; }
        public DbSet<HouseImage> HouseImages { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<RoomImage> RoomImages { get; set; }
        public DbSet<RoomHistory> RoomHistories { get; set; }
        public DbSet<Rate> Rates { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
                .Entity<House>()
                .HasOne(h => h.Campus)
                .WithMany()
                .HasForeignKey(h => h.CampusId)
                .OnDelete(DeleteBehavior.NoAction);
            modelBuilder
                .Entity<House>()
                .HasOne(h => h.LandLordUser)
                .WithMany()
                .HasForeignKey(h => h.LandLordId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder
                .Entity<RoomHistory>()
                .HasOne(h => h.Customer)
                .WithMany()
                .HasForeignKey(h => h.CustomerId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder
                .Entity<House>()
                .HasMany(a => a.HouseImages)
                .WithOne(b => b.House)
                .HasForeignKey(b => b.HouseId);

            modelBuilder
                .Entity<House>()
                .HasMany(a => a.Rooms)
                .WithOne(b => b.House)
                .HasForeignKey(b => b.HouseId);

            modelBuilder
                .Entity<House>()
                .HasMany(a => a.Rates)
                .WithOne(b => b.House)
                .HasForeignKey(b => b.HouseId);

            modelBuilder
                .Entity<Room>()
                .HasMany(a => a.RoomImages)
                .WithOne(b => b.Room)
                .HasForeignKey(b => b.RoomId);

            modelBuilder
                .Entity<Room>()
                .HasMany(a => a.RoomHistories)
                .WithOne(b => b.Room)
                .HasForeignKey(b => b.RoomId);

            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Address>().HasData(
            new Address { Id = Guid.Parse("11111111-1111-1111-1111-111111111111"), Addresses = "123 Main St", Latitude = 40.7128, Longitude = -74.0060 },
            new Address { Id = Guid.Parse("22222222-2222-2222-2222-222222222222"), Addresses = "456 Elm St", Latitude = 35.6895, Longitude = 139.6917 },
            new Address { Id = Guid.Parse("33333333-3333-3333-3333-333333333333"), Addresses = "789 Oak St", Latitude = 51.5074, Longitude = -0.1278 },
            new Address { Id = Guid.Parse("44444444-4444-4444-4444-444444444444"), Addresses = "101 Maple St", Latitude = 52.5200, Longitude = 13.4050 },
            new Address { Id = Guid.Parse("55555555-5555-5555-5555-555555555555"), Addresses = "202 Birch St", Latitude = 48.8566, Longitude = 2.3522 },
            new Address { Id = Guid.Parse("66666666-6666-6666-6666-666666666666"), Addresses = "303 Cedar St", Latitude = 37.7749, Longitude = -122.4194 },
            new Address { Id = Guid.Parse("77777777-7777-7777-7777-777777777777"), Addresses = "404 Pine St", Latitude = 34.0522, Longitude = -118.2437 },
            new Address { Id = Guid.Parse("88888888-8888-8888-8888-888888888888"), Addresses = "505 Spruce St", Latitude = 41.8781, Longitude = -87.6298 },
            new Address { Id = Guid.Parse("99999999-9999-9999-9999-999999999999"), Addresses = "606 Redwood St", Latitude = 51.1657, Longitude = 10.4515 },
            new Address { Id = Guid.Parse("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), Addresses = "707 Sequoia St", Latitude = 35.682839, Longitude = 139.759455 },
            new Address { Id = Guid.Parse("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), Addresses = "808 Cedar St", Latitude = 40.7128, Longitude = -74.0060 },
            new Address { Id = Guid.Parse("cccccccc-cccc-cccc-cccc-cccccccccccc"), Addresses = "909 Pine St", Latitude = 35.6895, Longitude = 139.6917 },
            new Address { Id = Guid.Parse("dddddddd-dddd-dddd-dddd-dddddddddddd"), Addresses = "1010 Oak St", Latitude = 51.5074, Longitude = -0.1278 },
            new Address { Id = Guid.Parse("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"), Addresses = "1111 Elm St", Latitude = 52.5200, Longitude = 13.4050 },
            new Address { Id = Guid.Parse("ffffffff-ffff-ffff-ffff-ffffffffffff"), Addresses = "1212 Birch St", Latitude = 48.8566, Longitude = 2.3522 }
            );

            modelBuilder.Entity<Campuses>().HasData(
            new Campuses { Id = Guid.Parse("11111111-1111-1111-1111-111111111111"), CampusName = "Campus 1", AddressId = Guid.Parse("11111111-1111-1111-1111-111111111111") },
            new Campuses { Id = Guid.Parse("22222222-2222-2222-2222-222222222222"), CampusName = "Campus 2", AddressId = Guid.Parse("22222222-2222-2222-2222-222222222222") },
            new Campuses { Id = Guid.Parse("33333333-3333-3333-3333-333333333333"), CampusName = "Campus 3", AddressId = Guid.Parse("33333333-3333-3333-3333-333333333333") },
            new Campuses { Id = Guid.Parse("44444444-4444-4444-4444-444444444444"), CampusName = "Campus 4", AddressId = Guid.Parse("44444444-4444-4444-4444-444444444444") },
            new Campuses { Id = Guid.Parse("55555555-5555-5555-5555-555555555555"), CampusName = "Campus 5", AddressId = Guid.Parse("55555555-5555-5555-5555-555555555555") },
            new Campuses { Id = Guid.Parse("66666666-6666-6666-6666-666666666666"), CampusName = "Campus 6", AddressId = Guid.Parse("66666666-6666-6666-6666-666666666666") },
            new Campuses { Id = Guid.Parse("77777777-7777-7777-7777-777777777777"), CampusName = "Campus 7", AddressId = Guid.Parse("77777777-7777-7777-7777-777777777777") },
            new Campuses { Id = Guid.Parse("88888888-8888-8888-8888-888888888888"), CampusName = "Campus 8", AddressId = Guid.Parse("88888888-8888-8888-8888-888888888888") },
            new Campuses { Id = Guid.Parse("99999999-9999-9999-9999-999999999999"), CampusName = "Campus 9", AddressId = Guid.Parse("99999999-9999-9999-9999-999999999999") },
            new Campuses { Id = Guid.Parse("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), CampusName = "Campus 10", AddressId = Guid.Parse("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa") }
            );

            modelBuilder.Entity<User>().HasData(
            new User
            {
                Id = Guid.Parse("11111111-1111-1111-1111-111111111111"),
                Email = "staff@gmail.com",
                Password = "123456",
                DisplayName = "staff",
                ProfileImageLink = "user1.jpg",
                PhoneNumber = "1234567890",
                Active = true,
                Role = Role.Staff, // You can set the appropriate Role enum value
                AddressId = null // You can set the address if needed
            },
            new User
            {
                Id = Guid.Parse("22222222-2222-2222-2222-222222222222"),
                Email = "landlord1@gmail.com",
                Password = "123456",
                DisplayName = "landlord1",
                ProfileImageLink = "user2.jpg",
                PhoneNumber = "9876543210",
                Active = true,
                Role = Role.Landlord, // You can set the appropriate Role enum value
                AddressId = null // You can set the address if needed
            },
            new User
            {
                Id = Guid.Parse("33333333-3333-3333-3333-333333333333"),
                Email = "landlord2@gmail.com",
                Password = "123456",
                DisplayName = "landlord2",
                ProfileImageLink = "user2.jpg",
                PhoneNumber = "9876543210",
                Active = true,
                Role = Role.Landlord, // You can set the appropriate Role enum value
                AddressId = null // You can set the address if needed
            },
            new User
            {
                Id = Guid.Parse("44444444-4444-4444-4444-444444444444"),
                Email = "admin@admin.com",
                Password = "123456",
                DisplayName = "User 3",
                ProfileImageLink = "user3.jpg",
                PhoneNumber = "5555555555",
                Active = true,
                Role = Role.Admin, // You can set the appropriate Role enum value
                AddressId = null // You can set the address if needed
            });

            modelBuilder.Entity<House>().HasData(
    new House
    {
        Id = Guid.Parse("11111111-1111-1111-1111-111111111111"),
        HouseName = "House 1",
        Information = "Information for House 1",
        Village = "Village 1",
        PowerPrice = 100.00f,
        WaterPrice = 50.00f,
        AddressId = Guid.Parse("11111111-1111-1111-1111-111111111111"), // Use a valid Address Id
        LandLordId = Guid.Parse("33333333-3333-3333-3333-333333333333"), // Use a valid LandLord User Id
        CampusId = Guid.Parse("33333333-3333-3333-3333-333333333333"), // Use a valid Campus Id
    },
    new House
    {
        Id = Guid.Parse("22222222-2222-2222-2222-222222222222"),
        HouseName = "House 2",
        Information = "Information for House 2",
        Village = "Village 2",
        PowerPrice = 120.00f,
        WaterPrice = 55.00f,
        AddressId = Guid.Parse("22222222-2222-2222-2222-222222222222"), // Use a valid Address Id
        LandLordId = Guid.Parse("33333333-3333-3333-3333-333333333333"), // Use a valid LandLord User Id
        CampusId = Guid.Parse("22222222-2222-2222-2222-222222222222"), // Use a valid Campus Id
    },
    new House
    {
        Id = Guid.Parse("33333333-3333-3333-3333-333333333333"),
        HouseName = "House 3",
        Information = "Information for House 3",
        Village = "Village 3",
        PowerPrice = 90.00f,
        WaterPrice = 40.00f,
        AddressId = Guid.Parse("33333333-3333-3333-3333-333333333333"), // Use a valid Address Id
        LandLordId = Guid.Parse("33333333-3333-3333-3333-333333333333"), // Use a valid LandLord User Id
        CampusId = Guid.Parse("44444444-4444-4444-4444-444444444444"), // Use a valid Campus Id
    },
    new House
    {
        Id = Guid.Parse("44444444-4444-4444-4444-444444444444"),
        HouseName = "House 4",
        Information = "Information for House 4",
        Village = "Village 4",
        PowerPrice = 110.00f,
        WaterPrice = 52.00f,
        AddressId = Guid.Parse("44444444-4444-4444-4444-444444444444"), // Use a valid Address Id
        LandLordId = Guid.Parse("33333333-3333-3333-3333-333333333333"), // Use a valid LandLord User Id
        CampusId = Guid.Parse("66666666-6666-6666-6666-666666666666"), // Use a valid Campus Id
    },
    new House
    {
        Id = Guid.Parse("55555555-5555-5555-5555-555555555555"),
        HouseName = "House 5",
        Information = "Information for House 5",
        Village = "Village 5",
        PowerPrice = 105.00f,
        WaterPrice = 48.00f,
        AddressId = Guid.Parse("55555555-5555-5555-5555-555555555555"), // Use a valid Address Id
        LandLordId = Guid.Parse("33333333-3333-3333-3333-333333333333"), // Use a valid LandLord User Id
        CampusId = Guid.Parse("22222222-2222-2222-2222-222222222222"), // Use a valid Campus Id
    },
    new House
    {
        Id = Guid.Parse("66666666-6666-6666-6666-666666666666"),
        HouseName = "House 6",
        Information = "Information for House 6",
        Village = "Village 6",
        PowerPrice = 95.00f,
        WaterPrice = 45.00f,
        AddressId = Guid.Parse("66666666-6666-6666-6666-666666666666"), // Use a valid Address Id
        LandLordId = Guid.Parse("33333333-3333-3333-3333-333333333333"), // Use a valid LandLord User Id
        CampusId = Guid.Parse("66666666-6666-6666-6666-666666666666"), // Use a valid Campus Id
    },
    new House
    {
        Id = Guid.Parse("77777777-7777-7777-7777-777777777777"),
        HouseName = "House 7",
        Information = "Information for House 7",
        Village = "Village 7",
        PowerPrice = 98.00f,
        WaterPrice = 47.00f,
        AddressId = Guid.Parse("77777777-7777-7777-7777-777777777777"), // Use a valid Address Id
        LandLordId = Guid.Parse("33333333-3333-3333-3333-333333333333"), // Use a valid LandLord User Id
        CampusId = Guid.Parse("66666666-6666-6666-6666-666666666666"), // Use a valid Campus Id
    },
    new House
    {
        Id = Guid.Parse("88888888-8888-8888-8888-888888888888"),
        HouseName = "House 8",
        Information = "Information for House 8",
        Village = "Village 8",
        PowerPrice = 103.00f,
        WaterPrice = 51.00f,
        AddressId = Guid.Parse("88888888-8888-8888-8888-888888888888"), // Use a valid Address Id
        LandLordId = Guid.Parse("33333333-3333-3333-3333-333333333333"), // Use a valid LandLord User Id
        CampusId = Guid.Parse("66666666-6666-6666-6666-666666666666"), // Use a valid Campus Id
    },
    new House
    {
        Id = Guid.Parse("99999999-9999-9999-9999-999999999999"),
        HouseName = "House 9",
        Information = "Information for House 9",
        Village = "Village 9",
        PowerPrice = 97.00f,
        WaterPrice = 49.00f,
        AddressId = Guid.Parse("99999999-9999-9999-9999-999999999999"), // Use a valid Address Id
        LandLordId = Guid.Parse("22222222-2222-2222-2222-222222222222"), // Use a valid LandLord User Id
        CampusId = Guid.Parse("44444444-4444-4444-4444-444444444444"), // Use a valid Campus Id
    },
    new House
    {
        Id = Guid.Parse("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"),
        HouseName = "House 10",
        Information = "Information for House 10",
        Village = "Village 10",
        PowerPrice = 105.00f,
        WaterPrice = 55.00f,
        AddressId = Guid.Parse("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), // Use a valid Address Id
        LandLordId = Guid.Parse("22222222-2222-2222-2222-222222222222"), // Use a valid LandLord User Id
        CampusId = Guid.Parse("66666666-6666-6666-6666-666666666666"), // Use a valid Campus Id
    },
    new House
    {
        Id = Guid.Parse("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"),
        HouseName = "House 11",
        Information = "Information for House 11",
        Village = "Village 11",
        PowerPrice = 103.00f,
        WaterPrice = 53.00f,
        AddressId = Guid.Parse("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), // Use a valid Address Id
        LandLordId = Guid.Parse("22222222-2222-2222-2222-222222222222"), // Use a valid LandLord User Id
        CampusId = Guid.Parse("66666666-6666-6666-6666-666666666666"), // Use a valid Campus Id
    },
    new House
    {
        Id = Guid.Parse("cccccccc-cccc-cccc-cccc-cccccccccccc"),
        HouseName = "House 12",
        Information = "Information for House 12",
        Village = "Village 12",
        PowerPrice = 98.00f,
        WaterPrice = 48.00f,
        AddressId = Guid.Parse("cccccccc-cccc-cccc-cccc-cccccccccccc"), // Use a valid Address Id
        LandLordId = Guid.Parse("22222222-2222-2222-2222-222222222222"), // Use a valid LandLord User Id
        CampusId = Guid.Parse("66666666-6666-6666-6666-666666666666"), // Use a valid Campus Id
    },
    new House
    {
        Id = Guid.Parse("dddddddd-dddd-dddd-dddd-dddddddddddd"),
        HouseName = "House 13",
        Information = "Information for House 13",
        Village = "Village 13",
        PowerPrice = 96.00f,
        WaterPrice = 46.00f,
        AddressId = Guid.Parse("dddddddd-dddd-dddd-dddd-dddddddddddd"), // Use a valid Address Id
        LandLordId = Guid.Parse("22222222-2222-2222-2222-222222222222"), // Use a valid LandLord User Id
        CampusId = Guid.Parse("66666666-6666-6666-6666-666666666666"), // Use a valid Campus Id
    },
    new House
    {
        Id = Guid.Parse("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"),
        HouseName = "House 14",
        Information = "Information for House 14",
        Village = "Village 14",
        PowerPrice = 99.00f,
        WaterPrice = 49.00f,
        AddressId = Guid.Parse("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"), // Use a valid Address Id
        LandLordId = Guid.Parse("22222222-2222-2222-2222-222222222222"), // Use a valid LandLord User Id
        CampusId = Guid.Parse("66666666-6666-6666-6666-666666666666"), // Use a valid Campus Id
    },
    new House
    {
        Id = Guid.Parse("ffffffff-ffff-ffff-ffff-ffffffffffff"),
        HouseName = "House 15",
        Information = "Information for House 15",
        Village = "Village 15",
        PowerPrice = 101.00f,
        WaterPrice = 51.00f,
        AddressId = Guid.Parse("ffffffff-ffff-ffff-ffff-ffffffffffff"), // Use a valid Address Id
        LandLordId = Guid.Parse("22222222-2222-2222-2222-222222222222"), // Use a valid LandLord User Id
        CampusId = Guid.Parse("22222222-2222-2222-2222-222222222222"), // Use a valid Campus Id
    }
);

modelBuilder.Entity<Room>().HasData(
    new Room
    {
        Id = Guid.Parse("11111111-1111-1111-1111-111111111111"),
        RoomName = "Room 1",
        Price = 100.00f,
        Information = "Information for Room 1",
        Area = "100 sq. ft.",
        MaxAmountOfPeople = 2,
        CurrentAmountOfPeople = 1,
        FloorNumber = 1,
        Status = RoomStatus.Available,
        Type = RoomType.Single,
        HouseId = Guid.Parse("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), // Use a valid House Id
    },
    new Room
    {
        Id = Guid.Parse("22222222-2222-2222-2222-222222222222"),
        RoomName = "Room 2",
        Price = 120.00f,
        Information = "Information for Room 2",
        Area = "110 sq. ft.",
        MaxAmountOfPeople = 3,
        CurrentAmountOfPeople = 1,
        FloorNumber = 2,
        Status = RoomStatus.Available,
        Type = RoomType.Double,
        HouseId = Guid.Parse("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), // Use a valid House Id
    },
    new Room
    {
        Id = Guid.Parse("33333333-3333-3333-3333-333333333333"),
        RoomName = "Room 3",
        Price = 90.00f,
        Information = "Information for Room 3",
        Area = "95 sq. ft.",
        MaxAmountOfPeople = 1,
        CurrentAmountOfPeople = 1,
        FloorNumber = 1,
        Status = RoomStatus.Available,
        Type = RoomType.Single,
        HouseId = Guid.Parse("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), // Use a valid House Id
    },
    new Room
    {
        Id = Guid.Parse("44444444-4444-4444-4444-444444444444"),
        RoomName = "Room 4",
        Price = 110.00f,
        Information = "Information for Room 4",
        Area = "105 sq. ft.",
        MaxAmountOfPeople = 2,
        CurrentAmountOfPeople = 1,
        FloorNumber = 2,
        Status = RoomStatus.Available,
        Type = RoomType.Double,
        HouseId = Guid.Parse("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), // Use a valid House Id
    },
    new Room
    {
        Id = Guid.Parse("55555555-5555-5555-5555-555555555555"),
        RoomName = "Room 5",
        Price = 105.00f,
        Information = "Information for Room 5",
        Area = "100 sq. ft.",
        MaxAmountOfPeople = 2,
        CurrentAmountOfPeople = 2,
        FloorNumber = 3,
        Status = RoomStatus.Available,
        Type = RoomType.Single,
        HouseId = Guid.Parse("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), // Use a valid House Id
    },
    new Room
    {
        Id = Guid.Parse("66666666-6666-6666-6666-666666666666"),
        RoomName = "Room 6",
        Price = 95.00f,
        Information = "Information for Room 6",
        Area = "90 sq. ft.",
        MaxAmountOfPeople = 1,
        CurrentAmountOfPeople = 1,
        FloorNumber = 3,
        Status = RoomStatus.Available,
        Type = RoomType.Single,
        HouseId = Guid.Parse("88888888-8888-8888-8888-888888888888"), // Use a valid House Id
    },
    new Room
    {
        Id = Guid.Parse("77777777-7777-7777-7777-777777777777"),
        RoomName = "Room 7",
        Price = 98.00f,
        Information = "Information for Room 7",
        Area = "95 sq. ft.",
        MaxAmountOfPeople = 2,
        CurrentAmountOfPeople = 2,
        FloorNumber = 4,
        Status = RoomStatus.Available,
        Type = RoomType.Double,
        HouseId = Guid.Parse("88888888-8888-8888-8888-888888888888"), // Use a valid House Id
    },
    new Room
    {
        Id = Guid.Parse("88888888-8888-8888-8888-888888888888"),
        RoomName = "Room 8",
        Price = 103.00f,
        Information = "Information for Room 8",
        Area = "100 sq. ft.",
        MaxAmountOfPeople = 2,
        CurrentAmountOfPeople = 2,
        FloorNumber = 4,
        Status = RoomStatus.Available,
        Type = RoomType.Single,
        HouseId = Guid.Parse("88888888-8888-8888-8888-888888888888"), // Use a valid House Id
    },
    new Room
    {
        Id = Guid.Parse("99999999-9999-9999-9999-999999999999"),
        RoomName = "Room 9",
        Price = 97.00f,
        Information = "Information for Room 9",
        Area = "95 sq. ft.",
        MaxAmountOfPeople = 1,
        CurrentAmountOfPeople = 1,
        FloorNumber = 5,
        Status = RoomStatus.Available,
        Type = RoomType.Single,
        HouseId = Guid.Parse("88888888-8888-8888-8888-888888888888"), // Use a valid House Id
    },
    new Room
    {
        Id = Guid.Parse("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"),
        RoomName = "Room 10",
        Price = 105.00f,
        Information = "Information for Room 10",
        Area = "100 sq. ft.",
        MaxAmountOfPeople = 2,
        CurrentAmountOfPeople = 2,
        FloorNumber = 5,
        Status = RoomStatus.Available,
        Type = RoomType.Double,
        HouseId = Guid.Parse("88888888-8888-8888-8888-888888888888"), // Use a valid House Id
    });


        }
    }
}
