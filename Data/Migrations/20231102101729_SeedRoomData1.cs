using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedRoomData1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("31da3e04-3b5d-42b7-a9d1-69e25c51e0b4"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("3b2120f9-8f7f-466e-a438-bfe5914c61a1"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("5eef4755-28fb-42f5-9764-f86977a114cb"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("7fcc4c79-5d14-408d-ae8a-56ca29f15623"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("89a1b5cb-3c8e-417b-83b7-a77402719d55"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("8d7c777b-fec6-4291-b190-91931acb067c"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("944a5878-9c87-40a0-a9e0-b42e2513876f"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("c5271025-9e8f-4545-bc8e-3109cf158a33"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("e806192e-9f16-42a6-b0d5-947efa378ac8"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("eb0ba795-c855-444d-a2f1-d49fe4eb9bbd"));

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("11111111-1111-1111-1111-111111111111"),
                columns: new[] { "CreateDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 11, 2, 10, 17, 29, 121, DateTimeKind.Utc).AddTicks(1930), new DateTime(2023, 11, 2, 10, 17, 29, 121, DateTimeKind.Utc).AddTicks(1933) });

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-222222222222"),
                columns: new[] { "CreateDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 11, 2, 10, 17, 29, 121, DateTimeKind.Utc).AddTicks(1952), new DateTime(2023, 11, 2, 10, 17, 29, 121, DateTimeKind.Utc).AddTicks(1952) });

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("33333333-3333-3333-3333-333333333333"),
                columns: new[] { "CreateDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 11, 2, 10, 17, 29, 121, DateTimeKind.Utc).AddTicks(1954), new DateTime(2023, 11, 2, 10, 17, 29, 121, DateTimeKind.Utc).AddTicks(1955) });

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("44444444-4444-4444-4444-444444444444"),
                columns: new[] { "CreateDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 11, 2, 10, 17, 29, 121, DateTimeKind.Utc).AddTicks(1957), new DateTime(2023, 11, 2, 10, 17, 29, 121, DateTimeKind.Utc).AddTicks(1957) });

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("55555555-5555-5555-5555-555555555555"),
                columns: new[] { "CreateDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 11, 2, 10, 17, 29, 121, DateTimeKind.Utc).AddTicks(1959), new DateTime(2023, 11, 2, 10, 17, 29, 121, DateTimeKind.Utc).AddTicks(1960) });

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("66666666-6666-6666-6666-666666666666"),
                columns: new[] { "CreateDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 11, 2, 10, 17, 29, 121, DateTimeKind.Utc).AddTicks(1961), new DateTime(2023, 11, 2, 10, 17, 29, 121, DateTimeKind.Utc).AddTicks(1961) });

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("77777777-7777-7777-7777-777777777777"),
                columns: new[] { "CreateDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 11, 2, 10, 17, 29, 121, DateTimeKind.Utc).AddTicks(1964), new DateTime(2023, 11, 2, 10, 17, 29, 121, DateTimeKind.Utc).AddTicks(1964) });

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("88888888-8888-8888-8888-888888888888"),
                columns: new[] { "CreateDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 11, 2, 10, 17, 29, 121, DateTimeKind.Utc).AddTicks(1978), new DateTime(2023, 11, 2, 10, 17, 29, 121, DateTimeKind.Utc).AddTicks(1978) });

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("99999999-9999-9999-9999-999999999999"),
                columns: new[] { "CreateDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 11, 2, 10, 17, 29, 121, DateTimeKind.Utc).AddTicks(1980), new DateTime(2023, 11, 2, 10, 17, 29, 121, DateTimeKind.Utc).AddTicks(1980) });

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"),
                columns: new[] { "CreateDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 11, 2, 10, 17, 29, 121, DateTimeKind.Utc).AddTicks(1982), new DateTime(2023, 11, 2, 10, 17, 29, 121, DateTimeKind.Utc).AddTicks(1982) });

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"),
                columns: new[] { "CreateDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 11, 2, 10, 17, 29, 121, DateTimeKind.Utc).AddTicks(1983), new DateTime(2023, 11, 2, 10, 17, 29, 121, DateTimeKind.Utc).AddTicks(1984) });

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("cccccccc-cccc-cccc-cccc-cccccccccccc"),
                columns: new[] { "CreateDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 11, 2, 10, 17, 29, 121, DateTimeKind.Utc).AddTicks(1985), new DateTime(2023, 11, 2, 10, 17, 29, 121, DateTimeKind.Utc).AddTicks(1985) });

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("dddddddd-dddd-dddd-dddd-dddddddddddd"),
                columns: new[] { "CreateDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 11, 2, 10, 17, 29, 121, DateTimeKind.Utc).AddTicks(1987), new DateTime(2023, 11, 2, 10, 17, 29, 121, DateTimeKind.Utc).AddTicks(1987) });

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"),
                columns: new[] { "CreateDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 11, 2, 10, 17, 29, 121, DateTimeKind.Utc).AddTicks(1989), new DateTime(2023, 11, 2, 10, 17, 29, 121, DateTimeKind.Utc).AddTicks(1989) });

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff"),
                columns: new[] { "CreateDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 11, 2, 10, 17, 29, 121, DateTimeKind.Utc).AddTicks(1990), new DateTime(2023, 11, 2, 10, 17, 29, 121, DateTimeKind.Utc).AddTicks(1991) });

            migrationBuilder.UpdateData(
                table: "Campuses",
                keyColumn: "Id",
                keyValue: new Guid("11111111-1111-1111-1111-111111111111"),
                columns: new[] { "CreateDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 11, 2, 10, 17, 29, 121, DateTimeKind.Utc).AddTicks(2136), new DateTime(2023, 11, 2, 10, 17, 29, 121, DateTimeKind.Utc).AddTicks(2136) });

            migrationBuilder.UpdateData(
                table: "Campuses",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-222222222222"),
                columns: new[] { "CreateDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 11, 2, 10, 17, 29, 121, DateTimeKind.Utc).AddTicks(2139), new DateTime(2023, 11, 2, 10, 17, 29, 121, DateTimeKind.Utc).AddTicks(2140) });

            migrationBuilder.UpdateData(
                table: "Campuses",
                keyColumn: "Id",
                keyValue: new Guid("33333333-3333-3333-3333-333333333333"),
                columns: new[] { "CreateDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 11, 2, 10, 17, 29, 121, DateTimeKind.Utc).AddTicks(2141), new DateTime(2023, 11, 2, 10, 17, 29, 121, DateTimeKind.Utc).AddTicks(2142) });

            migrationBuilder.UpdateData(
                table: "Campuses",
                keyColumn: "Id",
                keyValue: new Guid("44444444-4444-4444-4444-444444444444"),
                columns: new[] { "CreateDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 11, 2, 10, 17, 29, 121, DateTimeKind.Utc).AddTicks(2144), new DateTime(2023, 11, 2, 10, 17, 29, 121, DateTimeKind.Utc).AddTicks(2144) });

            migrationBuilder.UpdateData(
                table: "Campuses",
                keyColumn: "Id",
                keyValue: new Guid("55555555-5555-5555-5555-555555555555"),
                columns: new[] { "CreateDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 11, 2, 10, 17, 29, 121, DateTimeKind.Utc).AddTicks(2146), new DateTime(2023, 11, 2, 10, 17, 29, 121, DateTimeKind.Utc).AddTicks(2146) });

            migrationBuilder.UpdateData(
                table: "Campuses",
                keyColumn: "Id",
                keyValue: new Guid("66666666-6666-6666-6666-666666666666"),
                columns: new[] { "CreateDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 11, 2, 10, 17, 29, 121, DateTimeKind.Utc).AddTicks(2148), new DateTime(2023, 11, 2, 10, 17, 29, 121, DateTimeKind.Utc).AddTicks(2148) });

            migrationBuilder.UpdateData(
                table: "Campuses",
                keyColumn: "Id",
                keyValue: new Guid("77777777-7777-7777-7777-777777777777"),
                columns: new[] { "CreateDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 11, 2, 10, 17, 29, 121, DateTimeKind.Utc).AddTicks(2150), new DateTime(2023, 11, 2, 10, 17, 29, 121, DateTimeKind.Utc).AddTicks(2150) });

            migrationBuilder.UpdateData(
                table: "Campuses",
                keyColumn: "Id",
                keyValue: new Guid("88888888-8888-8888-8888-888888888888"),
                columns: new[] { "CreateDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 11, 2, 10, 17, 29, 121, DateTimeKind.Utc).AddTicks(2152), new DateTime(2023, 11, 2, 10, 17, 29, 121, DateTimeKind.Utc).AddTicks(2152) });

            migrationBuilder.UpdateData(
                table: "Campuses",
                keyColumn: "Id",
                keyValue: new Guid("99999999-9999-9999-9999-999999999999"),
                columns: new[] { "CreateDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 11, 2, 10, 17, 29, 121, DateTimeKind.Utc).AddTicks(2155), new DateTime(2023, 11, 2, 10, 17, 29, 121, DateTimeKind.Utc).AddTicks(2155) });

            migrationBuilder.UpdateData(
                table: "Campuses",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"),
                columns: new[] { "CreateDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 11, 2, 10, 17, 29, 121, DateTimeKind.Utc).AddTicks(2157), new DateTime(2023, 11, 2, 10, 17, 29, 121, DateTimeKind.Utc).AddTicks(2157) });

            migrationBuilder.UpdateData(
                table: "Houses",
                keyColumn: "Id",
                keyValue: new Guid("11111111-1111-1111-1111-111111111111"),
                columns: new[] { "CreateDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 11, 2, 10, 17, 29, 121, DateTimeKind.Utc).AddTicks(2212), new DateTime(2023, 11, 2, 10, 17, 29, 121, DateTimeKind.Utc).AddTicks(2212) });

            migrationBuilder.UpdateData(
                table: "Houses",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-222222222222"),
                columns: new[] { "CreateDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 11, 2, 10, 17, 29, 121, DateTimeKind.Utc).AddTicks(2218), new DateTime(2023, 11, 2, 10, 17, 29, 121, DateTimeKind.Utc).AddTicks(2219) });

            migrationBuilder.UpdateData(
                table: "Houses",
                keyColumn: "Id",
                keyValue: new Guid("33333333-3333-3333-3333-333333333333"),
                columns: new[] { "CreateDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 11, 2, 10, 17, 29, 121, DateTimeKind.Utc).AddTicks(2223), new DateTime(2023, 11, 2, 10, 17, 29, 121, DateTimeKind.Utc).AddTicks(2224) });

            migrationBuilder.UpdateData(
                table: "Houses",
                keyColumn: "Id",
                keyValue: new Guid("44444444-4444-4444-4444-444444444444"),
                columns: new[] { "CreateDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 11, 2, 10, 17, 29, 121, DateTimeKind.Utc).AddTicks(2227), new DateTime(2023, 11, 2, 10, 17, 29, 121, DateTimeKind.Utc).AddTicks(2227) });

            migrationBuilder.UpdateData(
                table: "Houses",
                keyColumn: "Id",
                keyValue: new Guid("55555555-5555-5555-5555-555555555555"),
                columns: new[] { "CreateDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 11, 2, 10, 17, 29, 121, DateTimeKind.Utc).AddTicks(2231), new DateTime(2023, 11, 2, 10, 17, 29, 121, DateTimeKind.Utc).AddTicks(2231) });

            migrationBuilder.UpdateData(
                table: "Houses",
                keyColumn: "Id",
                keyValue: new Guid("66666666-6666-6666-6666-666666666666"),
                columns: new[] { "CreateDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 11, 2, 10, 17, 29, 121, DateTimeKind.Utc).AddTicks(2234), new DateTime(2023, 11, 2, 10, 17, 29, 121, DateTimeKind.Utc).AddTicks(2234) });

            migrationBuilder.UpdateData(
                table: "Houses",
                keyColumn: "Id",
                keyValue: new Guid("77777777-7777-7777-7777-777777777777"),
                columns: new[] { "CreateDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 11, 2, 10, 17, 29, 121, DateTimeKind.Utc).AddTicks(2238), new DateTime(2023, 11, 2, 10, 17, 29, 121, DateTimeKind.Utc).AddTicks(2239) });

            migrationBuilder.UpdateData(
                table: "Houses",
                keyColumn: "Id",
                keyValue: new Guid("88888888-8888-8888-8888-888888888888"),
                columns: new[] { "CreateDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 11, 2, 10, 17, 29, 121, DateTimeKind.Utc).AddTicks(2242), new DateTime(2023, 11, 2, 10, 17, 29, 121, DateTimeKind.Utc).AddTicks(2242) });

            migrationBuilder.UpdateData(
                table: "Houses",
                keyColumn: "Id",
                keyValue: new Guid("99999999-9999-9999-9999-999999999999"),
                columns: new[] { "CreateDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 11, 2, 10, 17, 29, 121, DateTimeKind.Utc).AddTicks(2245), new DateTime(2023, 11, 2, 10, 17, 29, 121, DateTimeKind.Utc).AddTicks(2246) });

            migrationBuilder.UpdateData(
                table: "Houses",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"),
                columns: new[] { "CreateDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 11, 2, 10, 17, 29, 121, DateTimeKind.Utc).AddTicks(2249), new DateTime(2023, 11, 2, 10, 17, 29, 121, DateTimeKind.Utc).AddTicks(2249) });

            migrationBuilder.UpdateData(
                table: "Houses",
                keyColumn: "Id",
                keyValue: new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"),
                columns: new[] { "CreateDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 11, 2, 10, 17, 29, 121, DateTimeKind.Utc).AddTicks(2278), new DateTime(2023, 11, 2, 10, 17, 29, 121, DateTimeKind.Utc).AddTicks(2278) });

            migrationBuilder.UpdateData(
                table: "Houses",
                keyColumn: "Id",
                keyValue: new Guid("cccccccc-cccc-cccc-cccc-cccccccccccc"),
                columns: new[] { "CreateDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 11, 2, 10, 17, 29, 121, DateTimeKind.Utc).AddTicks(2281), new DateTime(2023, 11, 2, 10, 17, 29, 121, DateTimeKind.Utc).AddTicks(2282) });

            migrationBuilder.UpdateData(
                table: "Houses",
                keyColumn: "Id",
                keyValue: new Guid("dddddddd-dddd-dddd-dddd-dddddddddddd"),
                columns: new[] { "CreateDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 11, 2, 10, 17, 29, 121, DateTimeKind.Utc).AddTicks(2285), new DateTime(2023, 11, 2, 10, 17, 29, 121, DateTimeKind.Utc).AddTicks(2285) });

            migrationBuilder.UpdateData(
                table: "Houses",
                keyColumn: "Id",
                keyValue: new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"),
                columns: new[] { "CreateDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 11, 2, 10, 17, 29, 121, DateTimeKind.Utc).AddTicks(2288), new DateTime(2023, 11, 2, 10, 17, 29, 121, DateTimeKind.Utc).AddTicks(2289) });

            migrationBuilder.UpdateData(
                table: "Houses",
                keyColumn: "Id",
                keyValue: new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff"),
                columns: new[] { "CreateDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 11, 2, 10, 17, 29, 121, DateTimeKind.Utc).AddTicks(2292), new DateTime(2023, 11, 2, 10, 17, 29, 121, DateTimeKind.Utc).AddTicks(2292) });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Area", "CreateDate", "CreatedBy", "CurrentAmountOfPeople", "FloorNumber", "HouseId", "Information", "LastModifiedBy", "LastModifiedDate", "MaxAmountOfPeople", "Price", "RoomName", "Status", "Type" },
                values: new object[,]
                {
                    { new Guid("11111111-1111-1111-1111-111111111111"), "100 sq. ft.", new DateTime(2023, 11, 2, 10, 17, 29, 121, DateTimeKind.Utc).AddTicks(2314), null, 1, 1, new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), "Information for Room 1", null, new DateTime(2023, 11, 2, 10, 17, 29, 121, DateTimeKind.Utc).AddTicks(2314), 2, 100f, "Room 1", 0, 0 },
                    { new Guid("22222222-2222-2222-2222-222222222222"), "110 sq. ft.", new DateTime(2023, 11, 2, 10, 17, 29, 121, DateTimeKind.Utc).AddTicks(2318), null, 1, 2, new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), "Information for Room 2", null, new DateTime(2023, 11, 2, 10, 17, 29, 121, DateTimeKind.Utc).AddTicks(2318), 3, 120f, "Room 2", 0, 1 },
                    { new Guid("33333333-3333-3333-3333-333333333333"), "95 sq. ft.", new DateTime(2023, 11, 2, 10, 17, 29, 121, DateTimeKind.Utc).AddTicks(2321), null, 1, 1, new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), "Information for Room 3", null, new DateTime(2023, 11, 2, 10, 17, 29, 121, DateTimeKind.Utc).AddTicks(2321), 1, 90f, "Room 3", 0, 0 },
                    { new Guid("44444444-4444-4444-4444-444444444444"), "105 sq. ft.", new DateTime(2023, 11, 2, 10, 17, 29, 121, DateTimeKind.Utc).AddTicks(2325), null, 1, 2, new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), "Information for Room 4", null, new DateTime(2023, 11, 2, 10, 17, 29, 121, DateTimeKind.Utc).AddTicks(2326), 2, 110f, "Room 4", 0, 1 },
                    { new Guid("55555555-5555-5555-5555-555555555555"), "100 sq. ft.", new DateTime(2023, 11, 2, 10, 17, 29, 121, DateTimeKind.Utc).AddTicks(2328), null, 2, 3, new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), "Information for Room 5", null, new DateTime(2023, 11, 2, 10, 17, 29, 121, DateTimeKind.Utc).AddTicks(2328), 2, 105f, "Room 5", 0, 0 },
                    { new Guid("66666666-6666-6666-6666-666666666666"), "90 sq. ft.", new DateTime(2023, 11, 2, 10, 17, 29, 121, DateTimeKind.Utc).AddTicks(2331), null, 1, 3, new Guid("88888888-8888-8888-8888-888888888888"), "Information for Room 6", null, new DateTime(2023, 11, 2, 10, 17, 29, 121, DateTimeKind.Utc).AddTicks(2331), 1, 95f, "Room 6", 0, 0 },
                    { new Guid("77777777-7777-7777-7777-777777777777"), "95 sq. ft.", new DateTime(2023, 11, 2, 10, 17, 29, 121, DateTimeKind.Utc).AddTicks(2334), null, 2, 4, new Guid("88888888-8888-8888-8888-888888888888"), "Information for Room 7", null, new DateTime(2023, 11, 2, 10, 17, 29, 121, DateTimeKind.Utc).AddTicks(2334), 2, 98f, "Room 7", 0, 1 },
                    { new Guid("88888888-8888-8888-8888-888888888888"), "100 sq. ft.", new DateTime(2023, 11, 2, 10, 17, 29, 121, DateTimeKind.Utc).AddTicks(2337), null, 2, 4, new Guid("88888888-8888-8888-8888-888888888888"), "Information for Room 8", null, new DateTime(2023, 11, 2, 10, 17, 29, 121, DateTimeKind.Utc).AddTicks(2337), 2, 103f, "Room 8", 0, 0 },
                    { new Guid("99999999-9999-9999-9999-999999999999"), "95 sq. ft.", new DateTime(2023, 11, 2, 10, 17, 29, 121, DateTimeKind.Utc).AddTicks(2340), null, 1, 5, new Guid("88888888-8888-8888-8888-888888888888"), "Information for Room 9", null, new DateTime(2023, 11, 2, 10, 17, 29, 121, DateTimeKind.Utc).AddTicks(2340), 1, 97f, "Room 9", 0, 0 },
                    { new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), "100 sq. ft.", new DateTime(2023, 11, 2, 10, 17, 29, 121, DateTimeKind.Utc).AddTicks(2342), null, 2, 5, new Guid("88888888-8888-8888-8888-888888888888"), "Information for Room 10", null, new DateTime(2023, 11, 2, 10, 17, 29, 121, DateTimeKind.Utc).AddTicks(2343), 2, 105f, "Room 10", 0, 1 }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("11111111-1111-1111-1111-111111111111"),
                columns: new[] { "CreateDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 11, 2, 10, 17, 29, 121, DateTimeKind.Utc).AddTicks(2182), new DateTime(2023, 11, 2, 10, 17, 29, 121, DateTimeKind.Utc).AddTicks(2182) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-222222222222"),
                columns: new[] { "CreateDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 11, 2, 10, 17, 29, 121, DateTimeKind.Utc).AddTicks(2187), new DateTime(2023, 11, 2, 10, 17, 29, 121, DateTimeKind.Utc).AddTicks(2187) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("33333333-3333-3333-3333-333333333333"),
                columns: new[] { "CreateDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 11, 2, 10, 17, 29, 121, DateTimeKind.Utc).AddTicks(2190), new DateTime(2023, 11, 2, 10, 17, 29, 121, DateTimeKind.Utc).AddTicks(2190) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("44444444-4444-4444-4444-444444444444"),
                columns: new[] { "CreateDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 11, 2, 10, 17, 29, 121, DateTimeKind.Utc).AddTicks(2192), new DateTime(2023, 11, 2, 10, 17, 29, 121, DateTimeKind.Utc).AddTicks(2193) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("11111111-1111-1111-1111-111111111111"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-222222222222"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("33333333-3333-3333-3333-333333333333"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("44444444-4444-4444-4444-444444444444"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("55555555-5555-5555-5555-555555555555"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("66666666-6666-6666-6666-666666666666"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("77777777-7777-7777-7777-777777777777"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("88888888-8888-8888-8888-888888888888"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("99999999-9999-9999-9999-999999999999"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"));

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("11111111-1111-1111-1111-111111111111"),
                columns: new[] { "CreateDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 11, 2, 10, 2, 6, 622, DateTimeKind.Utc).AddTicks(8911), new DateTime(2023, 11, 2, 10, 2, 6, 622, DateTimeKind.Utc).AddTicks(8914) });

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-222222222222"),
                columns: new[] { "CreateDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 11, 2, 10, 2, 6, 622, DateTimeKind.Utc).AddTicks(8938), new DateTime(2023, 11, 2, 10, 2, 6, 622, DateTimeKind.Utc).AddTicks(8939) });

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("33333333-3333-3333-3333-333333333333"),
                columns: new[] { "CreateDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 11, 2, 10, 2, 6, 622, DateTimeKind.Utc).AddTicks(8941), new DateTime(2023, 11, 2, 10, 2, 6, 622, DateTimeKind.Utc).AddTicks(8942) });

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("44444444-4444-4444-4444-444444444444"),
                columns: new[] { "CreateDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 11, 2, 10, 2, 6, 622, DateTimeKind.Utc).AddTicks(8943), new DateTime(2023, 11, 2, 10, 2, 6, 622, DateTimeKind.Utc).AddTicks(8944) });

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("55555555-5555-5555-5555-555555555555"),
                columns: new[] { "CreateDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 11, 2, 10, 2, 6, 622, DateTimeKind.Utc).AddTicks(8945), new DateTime(2023, 11, 2, 10, 2, 6, 622, DateTimeKind.Utc).AddTicks(8945) });

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("66666666-6666-6666-6666-666666666666"),
                columns: new[] { "CreateDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 11, 2, 10, 2, 6, 622, DateTimeKind.Utc).AddTicks(8948), new DateTime(2023, 11, 2, 10, 2, 6, 622, DateTimeKind.Utc).AddTicks(8948) });

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("77777777-7777-7777-7777-777777777777"),
                columns: new[] { "CreateDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 11, 2, 10, 2, 6, 622, DateTimeKind.Utc).AddTicks(8963), new DateTime(2023, 11, 2, 10, 2, 6, 622, DateTimeKind.Utc).AddTicks(8963) });

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("88888888-8888-8888-8888-888888888888"),
                columns: new[] { "CreateDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 11, 2, 10, 2, 6, 622, DateTimeKind.Utc).AddTicks(8964), new DateTime(2023, 11, 2, 10, 2, 6, 622, DateTimeKind.Utc).AddTicks(8965) });

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("99999999-9999-9999-9999-999999999999"),
                columns: new[] { "CreateDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 11, 2, 10, 2, 6, 622, DateTimeKind.Utc).AddTicks(8966), new DateTime(2023, 11, 2, 10, 2, 6, 622, DateTimeKind.Utc).AddTicks(8967) });

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"),
                columns: new[] { "CreateDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 11, 2, 10, 2, 6, 622, DateTimeKind.Utc).AddTicks(8968), new DateTime(2023, 11, 2, 10, 2, 6, 622, DateTimeKind.Utc).AddTicks(8968) });

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"),
                columns: new[] { "CreateDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 11, 2, 10, 2, 6, 622, DateTimeKind.Utc).AddTicks(8974), new DateTime(2023, 11, 2, 10, 2, 6, 622, DateTimeKind.Utc).AddTicks(8974) });

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("cccccccc-cccc-cccc-cccc-cccccccccccc"),
                columns: new[] { "CreateDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 11, 2, 10, 2, 6, 622, DateTimeKind.Utc).AddTicks(8975), new DateTime(2023, 11, 2, 10, 2, 6, 622, DateTimeKind.Utc).AddTicks(8976) });

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("dddddddd-dddd-dddd-dddd-dddddddddddd"),
                columns: new[] { "CreateDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 11, 2, 10, 2, 6, 622, DateTimeKind.Utc).AddTicks(8977), new DateTime(2023, 11, 2, 10, 2, 6, 622, DateTimeKind.Utc).AddTicks(8978) });

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"),
                columns: new[] { "CreateDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 11, 2, 10, 2, 6, 622, DateTimeKind.Utc).AddTicks(8979), new DateTime(2023, 11, 2, 10, 2, 6, 622, DateTimeKind.Utc).AddTicks(8979) });

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff"),
                columns: new[] { "CreateDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 11, 2, 10, 2, 6, 622, DateTimeKind.Utc).AddTicks(8983), new DateTime(2023, 11, 2, 10, 2, 6, 622, DateTimeKind.Utc).AddTicks(8983) });

            migrationBuilder.UpdateData(
                table: "Campuses",
                keyColumn: "Id",
                keyValue: new Guid("11111111-1111-1111-1111-111111111111"),
                columns: new[] { "CreateDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 11, 2, 10, 2, 6, 622, DateTimeKind.Utc).AddTicks(9313), new DateTime(2023, 11, 2, 10, 2, 6, 622, DateTimeKind.Utc).AddTicks(9313) });

            migrationBuilder.UpdateData(
                table: "Campuses",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-222222222222"),
                columns: new[] { "CreateDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 11, 2, 10, 2, 6, 622, DateTimeKind.Utc).AddTicks(9317), new DateTime(2023, 11, 2, 10, 2, 6, 622, DateTimeKind.Utc).AddTicks(9318) });

            migrationBuilder.UpdateData(
                table: "Campuses",
                keyColumn: "Id",
                keyValue: new Guid("33333333-3333-3333-3333-333333333333"),
                columns: new[] { "CreateDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 11, 2, 10, 2, 6, 622, DateTimeKind.Utc).AddTicks(9320), new DateTime(2023, 11, 2, 10, 2, 6, 622, DateTimeKind.Utc).AddTicks(9320) });

            migrationBuilder.UpdateData(
                table: "Campuses",
                keyColumn: "Id",
                keyValue: new Guid("44444444-4444-4444-4444-444444444444"),
                columns: new[] { "CreateDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 11, 2, 10, 2, 6, 622, DateTimeKind.Utc).AddTicks(9322), new DateTime(2023, 11, 2, 10, 2, 6, 622, DateTimeKind.Utc).AddTicks(9322) });

            migrationBuilder.UpdateData(
                table: "Campuses",
                keyColumn: "Id",
                keyValue: new Guid("55555555-5555-5555-5555-555555555555"),
                columns: new[] { "CreateDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 11, 2, 10, 2, 6, 622, DateTimeKind.Utc).AddTicks(9324), new DateTime(2023, 11, 2, 10, 2, 6, 622, DateTimeKind.Utc).AddTicks(9324) });

            migrationBuilder.UpdateData(
                table: "Campuses",
                keyColumn: "Id",
                keyValue: new Guid("66666666-6666-6666-6666-666666666666"),
                columns: new[] { "CreateDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 11, 2, 10, 2, 6, 622, DateTimeKind.Utc).AddTicks(9326), new DateTime(2023, 11, 2, 10, 2, 6, 622, DateTimeKind.Utc).AddTicks(9326) });

            migrationBuilder.UpdateData(
                table: "Campuses",
                keyColumn: "Id",
                keyValue: new Guid("77777777-7777-7777-7777-777777777777"),
                columns: new[] { "CreateDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 11, 2, 10, 2, 6, 622, DateTimeKind.Utc).AddTicks(9328), new DateTime(2023, 11, 2, 10, 2, 6, 622, DateTimeKind.Utc).AddTicks(9328) });

            migrationBuilder.UpdateData(
                table: "Campuses",
                keyColumn: "Id",
                keyValue: new Guid("88888888-8888-8888-8888-888888888888"),
                columns: new[] { "CreateDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 11, 2, 10, 2, 6, 622, DateTimeKind.Utc).AddTicks(9332), new DateTime(2023, 11, 2, 10, 2, 6, 622, DateTimeKind.Utc).AddTicks(9332) });

            migrationBuilder.UpdateData(
                table: "Campuses",
                keyColumn: "Id",
                keyValue: new Guid("99999999-9999-9999-9999-999999999999"),
                columns: new[] { "CreateDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 11, 2, 10, 2, 6, 622, DateTimeKind.Utc).AddTicks(9334), new DateTime(2023, 11, 2, 10, 2, 6, 622, DateTimeKind.Utc).AddTicks(9334) });

            migrationBuilder.UpdateData(
                table: "Campuses",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"),
                columns: new[] { "CreateDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 11, 2, 10, 2, 6, 622, DateTimeKind.Utc).AddTicks(9336), new DateTime(2023, 11, 2, 10, 2, 6, 622, DateTimeKind.Utc).AddTicks(9336) });

            migrationBuilder.UpdateData(
                table: "Houses",
                keyColumn: "Id",
                keyValue: new Guid("11111111-1111-1111-1111-111111111111"),
                columns: new[] { "CreateDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 11, 2, 10, 2, 6, 622, DateTimeKind.Utc).AddTicks(9392), new DateTime(2023, 11, 2, 10, 2, 6, 622, DateTimeKind.Utc).AddTicks(9392) });

            migrationBuilder.UpdateData(
                table: "Houses",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-222222222222"),
                columns: new[] { "CreateDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 11, 2, 10, 2, 6, 622, DateTimeKind.Utc).AddTicks(9404), new DateTime(2023, 11, 2, 10, 2, 6, 622, DateTimeKind.Utc).AddTicks(9404) });

            migrationBuilder.UpdateData(
                table: "Houses",
                keyColumn: "Id",
                keyValue: new Guid("33333333-3333-3333-3333-333333333333"),
                columns: new[] { "CreateDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 11, 2, 10, 2, 6, 622, DateTimeKind.Utc).AddTicks(9408), new DateTime(2023, 11, 2, 10, 2, 6, 622, DateTimeKind.Utc).AddTicks(9408) });

            migrationBuilder.UpdateData(
                table: "Houses",
                keyColumn: "Id",
                keyValue: new Guid("44444444-4444-4444-4444-444444444444"),
                columns: new[] { "CreateDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 11, 2, 10, 2, 6, 622, DateTimeKind.Utc).AddTicks(9411), new DateTime(2023, 11, 2, 10, 2, 6, 622, DateTimeKind.Utc).AddTicks(9412) });

            migrationBuilder.UpdateData(
                table: "Houses",
                keyColumn: "Id",
                keyValue: new Guid("55555555-5555-5555-5555-555555555555"),
                columns: new[] { "CreateDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 11, 2, 10, 2, 6, 622, DateTimeKind.Utc).AddTicks(9415), new DateTime(2023, 11, 2, 10, 2, 6, 622, DateTimeKind.Utc).AddTicks(9416) });

            migrationBuilder.UpdateData(
                table: "Houses",
                keyColumn: "Id",
                keyValue: new Guid("66666666-6666-6666-6666-666666666666"),
                columns: new[] { "CreateDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 11, 2, 10, 2, 6, 622, DateTimeKind.Utc).AddTicks(9419), new DateTime(2023, 11, 2, 10, 2, 6, 622, DateTimeKind.Utc).AddTicks(9419) });

            migrationBuilder.UpdateData(
                table: "Houses",
                keyColumn: "Id",
                keyValue: new Guid("77777777-7777-7777-7777-777777777777"),
                columns: new[] { "CreateDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 11, 2, 10, 2, 6, 622, DateTimeKind.Utc).AddTicks(9423), new DateTime(2023, 11, 2, 10, 2, 6, 622, DateTimeKind.Utc).AddTicks(9423) });

            migrationBuilder.UpdateData(
                table: "Houses",
                keyColumn: "Id",
                keyValue: new Guid("88888888-8888-8888-8888-888888888888"),
                columns: new[] { "CreateDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 11, 2, 10, 2, 6, 622, DateTimeKind.Utc).AddTicks(9426), new DateTime(2023, 11, 2, 10, 2, 6, 622, DateTimeKind.Utc).AddTicks(9427) });

            migrationBuilder.UpdateData(
                table: "Houses",
                keyColumn: "Id",
                keyValue: new Guid("99999999-9999-9999-9999-999999999999"),
                columns: new[] { "CreateDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 11, 2, 10, 2, 6, 622, DateTimeKind.Utc).AddTicks(9430), new DateTime(2023, 11, 2, 10, 2, 6, 622, DateTimeKind.Utc).AddTicks(9430) });

            migrationBuilder.UpdateData(
                table: "Houses",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"),
                columns: new[] { "CreateDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 11, 2, 10, 2, 6, 622, DateTimeKind.Utc).AddTicks(9435), new DateTime(2023, 11, 2, 10, 2, 6, 622, DateTimeKind.Utc).AddTicks(9435) });

            migrationBuilder.UpdateData(
                table: "Houses",
                keyColumn: "Id",
                keyValue: new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"),
                columns: new[] { "CreateDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 11, 2, 10, 2, 6, 622, DateTimeKind.Utc).AddTicks(9442), new DateTime(2023, 11, 2, 10, 2, 6, 622, DateTimeKind.Utc).AddTicks(9442) });

            migrationBuilder.UpdateData(
                table: "Houses",
                keyColumn: "Id",
                keyValue: new Guid("cccccccc-cccc-cccc-cccc-cccccccccccc"),
                columns: new[] { "CreateDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 11, 2, 10, 2, 6, 622, DateTimeKind.Utc).AddTicks(9445), new DateTime(2023, 11, 2, 10, 2, 6, 622, DateTimeKind.Utc).AddTicks(9445) });

            migrationBuilder.UpdateData(
                table: "Houses",
                keyColumn: "Id",
                keyValue: new Guid("dddddddd-dddd-dddd-dddd-dddddddddddd"),
                columns: new[] { "CreateDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 11, 2, 10, 2, 6, 622, DateTimeKind.Utc).AddTicks(9448), new DateTime(2023, 11, 2, 10, 2, 6, 622, DateTimeKind.Utc).AddTicks(9449) });

            migrationBuilder.UpdateData(
                table: "Houses",
                keyColumn: "Id",
                keyValue: new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"),
                columns: new[] { "CreateDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 11, 2, 10, 2, 6, 622, DateTimeKind.Utc).AddTicks(9452), new DateTime(2023, 11, 2, 10, 2, 6, 622, DateTimeKind.Utc).AddTicks(9453) });

            migrationBuilder.UpdateData(
                table: "Houses",
                keyColumn: "Id",
                keyValue: new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff"),
                columns: new[] { "CreateDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 11, 2, 10, 2, 6, 622, DateTimeKind.Utc).AddTicks(9456), new DateTime(2023, 11, 2, 10, 2, 6, 622, DateTimeKind.Utc).AddTicks(9456) });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Area", "CreateDate", "CreatedBy", "CurrentAmountOfPeople", "FloorNumber", "HouseId", "Information", "LastModifiedBy", "LastModifiedDate", "MaxAmountOfPeople", "Price", "RoomName", "Status", "Type" },
                values: new object[,]
                {
                    { new Guid("31da3e04-3b5d-42b7-a9d1-69e25c51e0b4"), "105 sq. ft.", new DateTime(2023, 11, 2, 10, 2, 6, 622, DateTimeKind.Utc).AddTicks(9491), null, 1, 2, new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), "Information for Room 4", null, new DateTime(2023, 11, 2, 10, 2, 6, 622, DateTimeKind.Utc).AddTicks(9491), 2, 110f, "Room 4", 0, 1 },
                    { new Guid("3b2120f9-8f7f-466e-a438-bfe5914c61a1"), "100 sq. ft.", new DateTime(2023, 11, 2, 10, 2, 6, 622, DateTimeKind.Utc).AddTicks(9493), null, 2, 3, new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), "Information for Room 5", null, new DateTime(2023, 11, 2, 10, 2, 6, 622, DateTimeKind.Utc).AddTicks(9494), 2, 105f, "Room 5", 0, 0 },
                    { new Guid("5eef4755-28fb-42f5-9764-f86977a114cb"), "95 sq. ft.", new DateTime(2023, 11, 2, 10, 2, 6, 622, DateTimeKind.Utc).AddTicks(9488), null, 1, 1, new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), "Information for Room 3", null, new DateTime(2023, 11, 2, 10, 2, 6, 622, DateTimeKind.Utc).AddTicks(9488), 1, 90f, "Room 3", 0, 0 },
                    { new Guid("7fcc4c79-5d14-408d-ae8a-56ca29f15623"), "110 sq. ft.", new DateTime(2023, 11, 2, 10, 2, 6, 622, DateTimeKind.Utc).AddTicks(9485), null, 1, 2, new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), "Information for Room 2", null, new DateTime(2023, 11, 2, 10, 2, 6, 622, DateTimeKind.Utc).AddTicks(9485), 3, 120f, "Room 2", 0, 1 },
                    { new Guid("89a1b5cb-3c8e-417b-83b7-a77402719d55"), "90 sq. ft.", new DateTime(2023, 11, 2, 10, 2, 6, 622, DateTimeKind.Utc).AddTicks(9498), null, 1, 3, new Guid("88888888-8888-8888-8888-888888888888"), "Information for Room 6", null, new DateTime(2023, 11, 2, 10, 2, 6, 622, DateTimeKind.Utc).AddTicks(9498), 1, 95f, "Room 6", 0, 0 },
                    { new Guid("8d7c777b-fec6-4291-b190-91931acb067c"), "95 sq. ft.", new DateTime(2023, 11, 2, 10, 2, 6, 622, DateTimeKind.Utc).AddTicks(9527), null, 1, 5, new Guid("88888888-8888-8888-8888-888888888888"), "Information for Room 9", null, new DateTime(2023, 11, 2, 10, 2, 6, 622, DateTimeKind.Utc).AddTicks(9527), 1, 97f, "Room 9", 0, 0 },
                    { new Guid("944a5878-9c87-40a0-a9e0-b42e2513876f"), "95 sq. ft.", new DateTime(2023, 11, 2, 10, 2, 6, 622, DateTimeKind.Utc).AddTicks(9500), null, 2, 4, new Guid("88888888-8888-8888-8888-888888888888"), "Information for Room 7", null, new DateTime(2023, 11, 2, 10, 2, 6, 622, DateTimeKind.Utc).AddTicks(9501), 2, 98f, "Room 7", 0, 1 },
                    { new Guid("c5271025-9e8f-4545-bc8e-3109cf158a33"), "100 sq. ft.", new DateTime(2023, 11, 2, 10, 2, 6, 622, DateTimeKind.Utc).AddTicks(9503), null, 2, 4, new Guid("88888888-8888-8888-8888-888888888888"), "Information for Room 8", null, new DateTime(2023, 11, 2, 10, 2, 6, 622, DateTimeKind.Utc).AddTicks(9503), 2, 103f, "Room 8", 0, 0 },
                    { new Guid("e806192e-9f16-42a6-b0d5-947efa378ac8"), "100 sq. ft.", new DateTime(2023, 11, 2, 10, 2, 6, 622, DateTimeKind.Utc).AddTicks(9479), null, 1, 1, new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), "Information for Room 1", null, new DateTime(2023, 11, 2, 10, 2, 6, 622, DateTimeKind.Utc).AddTicks(9479), 2, 100f, "Room 1", 0, 0 },
                    { new Guid("eb0ba795-c855-444d-a2f1-d49fe4eb9bbd"), "100 sq. ft.", new DateTime(2023, 11, 2, 10, 2, 6, 622, DateTimeKind.Utc).AddTicks(9531), null, 2, 5, new Guid("88888888-8888-8888-8888-888888888888"), "Information for Room 10", null, new DateTime(2023, 11, 2, 10, 2, 6, 622, DateTimeKind.Utc).AddTicks(9532), 2, 105f, "Room 10", 0, 1 }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("11111111-1111-1111-1111-111111111111"),
                columns: new[] { "CreateDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 11, 2, 10, 2, 6, 622, DateTimeKind.Utc).AddTicks(9360), new DateTime(2023, 11, 2, 10, 2, 6, 622, DateTimeKind.Utc).AddTicks(9361) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-222222222222"),
                columns: new[] { "CreateDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 11, 2, 10, 2, 6, 622, DateTimeKind.Utc).AddTicks(9368), new DateTime(2023, 11, 2, 10, 2, 6, 622, DateTimeKind.Utc).AddTicks(9369) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("33333333-3333-3333-3333-333333333333"),
                columns: new[] { "CreateDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 11, 2, 10, 2, 6, 622, DateTimeKind.Utc).AddTicks(9371), new DateTime(2023, 11, 2, 10, 2, 6, 622, DateTimeKind.Utc).AddTicks(9371) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("44444444-4444-4444-4444-444444444444"),
                columns: new[] { "CreateDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 11, 2, 10, 2, 6, 622, DateTimeKind.Utc).AddTicks(9373), new DateTime(2023, 11, 2, 10, 2, 6, 622, DateTimeKind.Utc).AddTicks(9373) });
        }
    }
}
