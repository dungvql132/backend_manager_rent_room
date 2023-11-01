using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class UpdateCampus : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CampusName",
                table: "Campuses",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "Addresses",
                table: "Addresses",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.InsertData(
                table: "Addresses",
                columns: new[] { "Id", "Addresses", "CreateDate", "LastModifiedDate", "Latitude", "Longitude" },
                values: new object[,]
                {
                    { new Guid("11111111-1111-1111-1111-111111111111"), "123 Main St", new DateTime(2023, 10, 30, 9, 28, 46, 33, DateTimeKind.Utc).AddTicks(3138), new DateTime(2023, 10, 30, 9, 28, 46, 33, DateTimeKind.Utc).AddTicks(3142), 40.712800000000001, -74.006 },
                    { new Guid("22222222-2222-2222-2222-222222222222"), "456 Elm St", new DateTime(2023, 10, 30, 9, 28, 46, 33, DateTimeKind.Utc).AddTicks(3173), new DateTime(2023, 10, 30, 9, 28, 46, 33, DateTimeKind.Utc).AddTicks(3173), 35.689500000000002, 139.6917 },
                    { new Guid("33333333-3333-3333-3333-333333333333"), "789 Oak St", new DateTime(2023, 10, 30, 9, 28, 46, 33, DateTimeKind.Utc).AddTicks(3178), new DateTime(2023, 10, 30, 9, 28, 46, 33, DateTimeKind.Utc).AddTicks(3178), 51.507399999999997, -0.1278 },
                    { new Guid("44444444-4444-4444-4444-444444444444"), "101 Maple St", new DateTime(2023, 10, 30, 9, 28, 46, 33, DateTimeKind.Utc).AddTicks(3182), new DateTime(2023, 10, 30, 9, 28, 46, 33, DateTimeKind.Utc).AddTicks(3182), 52.520000000000003, 13.404999999999999 },
                    { new Guid("55555555-5555-5555-5555-555555555555"), "202 Birch St", new DateTime(2023, 10, 30, 9, 28, 46, 33, DateTimeKind.Utc).AddTicks(3185), new DateTime(2023, 10, 30, 9, 28, 46, 33, DateTimeKind.Utc).AddTicks(3186), 48.8566, 2.3521999999999998 },
                    { new Guid("66666666-6666-6666-6666-666666666666"), "303 Cedar St", new DateTime(2023, 10, 30, 9, 28, 46, 33, DateTimeKind.Utc).AddTicks(3189), new DateTime(2023, 10, 30, 9, 28, 46, 33, DateTimeKind.Utc).AddTicks(3189), 37.774900000000002, -122.4194 },
                    { new Guid("77777777-7777-7777-7777-777777777777"), "404 Pine St", new DateTime(2023, 10, 30, 9, 28, 46, 33, DateTimeKind.Utc).AddTicks(3192), new DateTime(2023, 10, 30, 9, 28, 46, 33, DateTimeKind.Utc).AddTicks(3193), 34.052199999999999, -118.2437 },
                    { new Guid("88888888-8888-8888-8888-888888888888"), "505 Spruce St", new DateTime(2023, 10, 30, 9, 28, 46, 33, DateTimeKind.Utc).AddTicks(3196), new DateTime(2023, 10, 30, 9, 28, 46, 33, DateTimeKind.Utc).AddTicks(3196), 41.878100000000003, -87.629800000000003 },
                    { new Guid("99999999-9999-9999-9999-999999999999"), "606 Redwood St", new DateTime(2023, 10, 30, 9, 28, 46, 33, DateTimeKind.Utc).AddTicks(3204), new DateTime(2023, 10, 30, 9, 28, 46, 33, DateTimeKind.Utc).AddTicks(3205), 51.165700000000001, 10.451499999999999 },
                    { new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), "707 Sequoia St", new DateTime(2023, 10, 30, 9, 28, 46, 33, DateTimeKind.Utc).AddTicks(3208), new DateTime(2023, 10, 30, 9, 28, 46, 33, DateTimeKind.Utc).AddTicks(3208), 35.682839000000001, 139.759455 },
                    { new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), "808 Cedar St", new DateTime(2023, 10, 30, 9, 28, 46, 33, DateTimeKind.Utc).AddTicks(3212), new DateTime(2023, 10, 30, 9, 28, 46, 33, DateTimeKind.Utc).AddTicks(3212), 40.712800000000001, -74.006 },
                    { new Guid("cccccccc-cccc-cccc-cccc-cccccccccccc"), "909 Pine St", new DateTime(2023, 10, 30, 9, 28, 46, 33, DateTimeKind.Utc).AddTicks(3215), new DateTime(2023, 10, 30, 9, 28, 46, 33, DateTimeKind.Utc).AddTicks(3216), 35.689500000000002, 139.6917 },
                    { new Guid("dddddddd-dddd-dddd-dddd-dddddddddddd"), "1010 Oak St", new DateTime(2023, 10, 30, 9, 28, 46, 33, DateTimeKind.Utc).AddTicks(3219), new DateTime(2023, 10, 30, 9, 28, 46, 33, DateTimeKind.Utc).AddTicks(3220), 51.507399999999997, -0.1278 },
                    { new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"), "1111 Elm St", new DateTime(2023, 10, 30, 9, 28, 46, 33, DateTimeKind.Utc).AddTicks(3223), new DateTime(2023, 10, 30, 9, 28, 46, 33, DateTimeKind.Utc).AddTicks(3224), 52.520000000000003, 13.404999999999999 },
                    { new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff"), "1212 Birch St", new DateTime(2023, 10, 30, 9, 28, 46, 33, DateTimeKind.Utc).AddTicks(3228), new DateTime(2023, 10, 30, 9, 28, 46, 33, DateTimeKind.Utc).AddTicks(3228), 48.8566, 2.3521999999999998 }
                });

            migrationBuilder.InsertData(
                table: "Campuses",
                columns: new[] { "Id", "AddressId", "CampusName", "CreateDate", "LastModifiedDate" },
                values: new object[,]
                {
                    { new Guid("1bb10cd9-f9a6-49cb-afcc-a7af3fb4fc54"), new Guid("11111111-1111-1111-1111-111111111111"), "Campus 1", new DateTime(2023, 10, 30, 9, 28, 46, 33, DateTimeKind.Utc).AddTicks(3721), new DateTime(2023, 10, 30, 9, 28, 46, 33, DateTimeKind.Utc).AddTicks(3722) },
                    { new Guid("2376feec-1f26-477e-8227-9b34579310a7"), new Guid("22222222-2222-2222-2222-222222222222"), "Campus 2", new DateTime(2023, 10, 30, 9, 28, 46, 33, DateTimeKind.Utc).AddTicks(3735), new DateTime(2023, 10, 30, 9, 28, 46, 33, DateTimeKind.Utc).AddTicks(3735) },
                    { new Guid("48481d59-51a2-47dc-a59f-166f5a6d38ad"), new Guid("88888888-8888-8888-8888-888888888888"), "Campus 8", new DateTime(2023, 10, 30, 9, 28, 46, 33, DateTimeKind.Utc).AddTicks(3756), new DateTime(2023, 10, 30, 9, 28, 46, 33, DateTimeKind.Utc).AddTicks(3756) },
                    { new Guid("4c30dcaa-79eb-4bea-bb20-7bf745860c49"), new Guid("33333333-3333-3333-3333-333333333333"), "Campus 3", new DateTime(2023, 10, 30, 9, 28, 46, 33, DateTimeKind.Utc).AddTicks(3739), new DateTime(2023, 10, 30, 9, 28, 46, 33, DateTimeKind.Utc).AddTicks(3739) },
                    { new Guid("5139636b-0bd3-42d5-a6f1-a440ff440063"), new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), "Campus 10", new DateTime(2023, 10, 30, 9, 28, 46, 33, DateTimeKind.Utc).AddTicks(3767), new DateTime(2023, 10, 30, 9, 28, 46, 33, DateTimeKind.Utc).AddTicks(3768) },
                    { new Guid("5f9e67af-2f75-4272-a793-5c264be24242"), new Guid("77777777-7777-7777-7777-777777777777"), "Campus 7", new DateTime(2023, 10, 30, 9, 28, 46, 33, DateTimeKind.Utc).AddTicks(3752), new DateTime(2023, 10, 30, 9, 28, 46, 33, DateTimeKind.Utc).AddTicks(3753) },
                    { new Guid("8d38dd49-2211-4e70-abb1-696b6146139c"), new Guid("66666666-6666-6666-6666-666666666666"), "Campus 6", new DateTime(2023, 10, 30, 9, 28, 46, 33, DateTimeKind.Utc).AddTicks(3749), new DateTime(2023, 10, 30, 9, 28, 46, 33, DateTimeKind.Utc).AddTicks(3749) },
                    { new Guid("a7f53ce5-421a-4cb2-bf3e-fe88d8f0d459"), new Guid("55555555-5555-5555-5555-555555555555"), "Campus 5", new DateTime(2023, 10, 30, 9, 28, 46, 33, DateTimeKind.Utc).AddTicks(3745), new DateTime(2023, 10, 30, 9, 28, 46, 33, DateTimeKind.Utc).AddTicks(3746) },
                    { new Guid("c838c546-a918-4b6b-be3a-2a67f6ae5d49"), new Guid("99999999-9999-9999-9999-999999999999"), "Campus 9", new DateTime(2023, 10, 30, 9, 28, 46, 33, DateTimeKind.Utc).AddTicks(3759), new DateTime(2023, 10, 30, 9, 28, 46, 33, DateTimeKind.Utc).AddTicks(3760) },
                    { new Guid("ccfb32e1-b2e0-4780-bed1-56d5851feb22"), new Guid("44444444-4444-4444-4444-444444444444"), "Campus 4", new DateTime(2023, 10, 30, 9, 28, 46, 33, DateTimeKind.Utc).AddTicks(3742), new DateTime(2023, 10, 30, 9, 28, 46, 33, DateTimeKind.Utc).AddTicks(3742) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("cccccccc-cccc-cccc-cccc-cccccccccccc"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("dddddddd-dddd-dddd-dddd-dddddddddddd"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff"));

            migrationBuilder.DeleteData(
                table: "Campuses",
                keyColumn: "Id",
                keyValue: new Guid("1bb10cd9-f9a6-49cb-afcc-a7af3fb4fc54"));

            migrationBuilder.DeleteData(
                table: "Campuses",
                keyColumn: "Id",
                keyValue: new Guid("2376feec-1f26-477e-8227-9b34579310a7"));

            migrationBuilder.DeleteData(
                table: "Campuses",
                keyColumn: "Id",
                keyValue: new Guid("48481d59-51a2-47dc-a59f-166f5a6d38ad"));

            migrationBuilder.DeleteData(
                table: "Campuses",
                keyColumn: "Id",
                keyValue: new Guid("4c30dcaa-79eb-4bea-bb20-7bf745860c49"));

            migrationBuilder.DeleteData(
                table: "Campuses",
                keyColumn: "Id",
                keyValue: new Guid("5139636b-0bd3-42d5-a6f1-a440ff440063"));

            migrationBuilder.DeleteData(
                table: "Campuses",
                keyColumn: "Id",
                keyValue: new Guid("5f9e67af-2f75-4272-a793-5c264be24242"));

            migrationBuilder.DeleteData(
                table: "Campuses",
                keyColumn: "Id",
                keyValue: new Guid("8d38dd49-2211-4e70-abb1-696b6146139c"));

            migrationBuilder.DeleteData(
                table: "Campuses",
                keyColumn: "Id",
                keyValue: new Guid("a7f53ce5-421a-4cb2-bf3e-fe88d8f0d459"));

            migrationBuilder.DeleteData(
                table: "Campuses",
                keyColumn: "Id",
                keyValue: new Guid("c838c546-a918-4b6b-be3a-2a67f6ae5d49"));

            migrationBuilder.DeleteData(
                table: "Campuses",
                keyColumn: "Id",
                keyValue: new Guid("ccfb32e1-b2e0-4780-bed1-56d5851feb22"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("11111111-1111-1111-1111-111111111111"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-222222222222"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("33333333-3333-3333-3333-333333333333"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("44444444-4444-4444-4444-444444444444"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("55555555-5555-5555-5555-555555555555"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("66666666-6666-6666-6666-666666666666"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("77777777-7777-7777-7777-777777777777"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("88888888-8888-8888-8888-888888888888"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("99999999-9999-9999-9999-999999999999"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"));

            migrationBuilder.DropColumn(
                name: "CampusName",
                table: "Campuses");

            migrationBuilder.AlterColumn<long>(
                name: "Addresses",
                table: "Addresses",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }
    }
}
