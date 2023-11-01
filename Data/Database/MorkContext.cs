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
            new Campuses {  CampusName = "Campus 1", AddressId = Guid.Parse("11111111-1111-1111-1111-111111111111") },
            new Campuses {  CampusName = "Campus 2", AddressId = Guid.Parse("22222222-2222-2222-2222-222222222222") },
            new Campuses {  CampusName = "Campus 3", AddressId = Guid.Parse("33333333-3333-3333-3333-333333333333") },
            new Campuses {  CampusName = "Campus 4", AddressId = Guid.Parse("44444444-4444-4444-4444-444444444444") },
            new Campuses {  CampusName = "Campus 5", AddressId = Guid.Parse("55555555-5555-5555-5555-555555555555") },
            new Campuses {  CampusName = "Campus 6", AddressId = Guid.Parse("66666666-6666-6666-6666-666666666666") },
            new Campuses {  CampusName = "Campus 7", AddressId = Guid.Parse("77777777-7777-7777-7777-777777777777") },
            new Campuses {  CampusName = "Campus 8", AddressId = Guid.Parse("88888888-8888-8888-8888-888888888888") },
            new Campuses {  CampusName = "Campus 9", AddressId = Guid.Parse("99999999-9999-9999-9999-999999999999") },
            new Campuses {  CampusName = "Campus 10", AddressId = Guid.Parse("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa") }
            );
        }
    }
}
