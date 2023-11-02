using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedHouse : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Campuses",
                keyColumn: "Id",
                keyValue: new Guid("0977aee7-57aa-4705-9133-aae7a6175efa"));

            migrationBuilder.DeleteData(
                table: "Campuses",
                keyColumn: "Id",
                keyValue: new Guid("0af0d8a6-8913-4ae8-9331-7f9d201f1fdc"));

            migrationBuilder.DeleteData(
                table: "Campuses",
                keyColumn: "Id",
                keyValue: new Guid("36041dfa-f87d-4889-8e75-b5a6228069bb"));

            migrationBuilder.DeleteData(
                table: "Campuses",
                keyColumn: "Id",
                keyValue: new Guid("41706a7b-f221-4d7b-ba76-d533635a6ba5"));

            migrationBuilder.DeleteData(
                table: "Campuses",
                keyColumn: "Id",
                keyValue: new Guid("85c87b65-990b-4306-9dd2-34febb76bd88"));

            migrationBuilder.DeleteData(
                table: "Campuses",
                keyColumn: "Id",
                keyValue: new Guid("9aacf079-0c17-47ba-97e2-2c987ed31ccb"));

            migrationBuilder.DeleteData(
                table: "Campuses",
                keyColumn: "Id",
                keyValue: new Guid("b8df88cb-b8f1-4262-b9eb-e37a73ab10c3"));

            migrationBuilder.DeleteData(
                table: "Campuses",
                keyColumn: "Id",
                keyValue: new Guid("c27c531e-bff9-4ce0-8eed-093d6155567f"));

            migrationBuilder.DeleteData(
                table: "Campuses",
                keyColumn: "Id",
                keyValue: new Guid("e9705cb7-36ca-42c3-bcc2-199094c52cde"));

            migrationBuilder.DeleteData(
                table: "Campuses",
                keyColumn: "Id",
                keyValue: new Guid("ec90ca30-339c-4220-b994-be8ac9847846"));

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("11111111-1111-1111-1111-111111111111"),
                columns: new[] { "CreateDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 11, 2, 2, 16, 38, 155, DateTimeKind.Utc).AddTicks(1046), new DateTime(2023, 11, 2, 2, 16, 38, 155, DateTimeKind.Utc).AddTicks(1050) });

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-222222222222"),
                columns: new[] { "CreateDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 11, 2, 2, 16, 38, 155, DateTimeKind.Utc).AddTicks(1077), new DateTime(2023, 11, 2, 2, 16, 38, 155, DateTimeKind.Utc).AddTicks(1077) });

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("33333333-3333-3333-3333-333333333333"),
                columns: new[] { "CreateDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 11, 2, 2, 16, 38, 155, DateTimeKind.Utc).AddTicks(1080), new DateTime(2023, 11, 2, 2, 16, 38, 155, DateTimeKind.Utc).AddTicks(1080) });

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("44444444-4444-4444-4444-444444444444"),
                columns: new[] { "CreateDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 11, 2, 2, 16, 38, 155, DateTimeKind.Utc).AddTicks(1094), new DateTime(2023, 11, 2, 2, 16, 38, 155, DateTimeKind.Utc).AddTicks(1095) });

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("55555555-5555-5555-5555-555555555555"),
                columns: new[] { "CreateDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 11, 2, 2, 16, 38, 155, DateTimeKind.Utc).AddTicks(1098), new DateTime(2023, 11, 2, 2, 16, 38, 155, DateTimeKind.Utc).AddTicks(1098) });

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("66666666-6666-6666-6666-666666666666"),
                columns: new[] { "CreateDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 11, 2, 2, 16, 38, 155, DateTimeKind.Utc).AddTicks(1100), new DateTime(2023, 11, 2, 2, 16, 38, 155, DateTimeKind.Utc).AddTicks(1100) });

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("77777777-7777-7777-7777-777777777777"),
                columns: new[] { "CreateDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 11, 2, 2, 16, 38, 155, DateTimeKind.Utc).AddTicks(1103), new DateTime(2023, 11, 2, 2, 16, 38, 155, DateTimeKind.Utc).AddTicks(1103) });

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("88888888-8888-8888-8888-888888888888"),
                columns: new[] { "CreateDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 11, 2, 2, 16, 38, 155, DateTimeKind.Utc).AddTicks(1105), new DateTime(2023, 11, 2, 2, 16, 38, 155, DateTimeKind.Utc).AddTicks(1105) });

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("99999999-9999-9999-9999-999999999999"),
                columns: new[] { "CreateDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 11, 2, 2, 16, 38, 155, DateTimeKind.Utc).AddTicks(1106), new DateTime(2023, 11, 2, 2, 16, 38, 155, DateTimeKind.Utc).AddTicks(1107) });

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"),
                columns: new[] { "CreateDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 11, 2, 2, 16, 38, 155, DateTimeKind.Utc).AddTicks(1108), new DateTime(2023, 11, 2, 2, 16, 38, 155, DateTimeKind.Utc).AddTicks(1108) });

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"),
                columns: new[] { "CreateDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 11, 2, 2, 16, 38, 155, DateTimeKind.Utc).AddTicks(1110), new DateTime(2023, 11, 2, 2, 16, 38, 155, DateTimeKind.Utc).AddTicks(1110) });

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("cccccccc-cccc-cccc-cccc-cccccccccccc"),
                columns: new[] { "CreateDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 11, 2, 2, 16, 38, 155, DateTimeKind.Utc).AddTicks(1114), new DateTime(2023, 11, 2, 2, 16, 38, 155, DateTimeKind.Utc).AddTicks(1114) });

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("dddddddd-dddd-dddd-dddd-dddddddddddd"),
                columns: new[] { "CreateDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 11, 2, 2, 16, 38, 155, DateTimeKind.Utc).AddTicks(1116), new DateTime(2023, 11, 2, 2, 16, 38, 155, DateTimeKind.Utc).AddTicks(1117) });

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"),
                columns: new[] { "CreateDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 11, 2, 2, 16, 38, 155, DateTimeKind.Utc).AddTicks(1118), new DateTime(2023, 11, 2, 2, 16, 38, 155, DateTimeKind.Utc).AddTicks(1119) });

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff"),
                columns: new[] { "CreateDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 11, 2, 2, 16, 38, 155, DateTimeKind.Utc).AddTicks(1120), new DateTime(2023, 11, 2, 2, 16, 38, 155, DateTimeKind.Utc).AddTicks(1120) });

            migrationBuilder.InsertData(
                table: "Campuses",
                columns: new[] { "Id", "AddressId", "CampusName", "CreateDate", "LastModifiedDate" },
                values: new object[,]
                {
                    { new Guid("11111111-1111-1111-1111-111111111111"), new Guid("11111111-1111-1111-1111-111111111111"), "Campus 1", new DateTime(2023, 11, 2, 2, 16, 38, 155, DateTimeKind.Utc).AddTicks(1447), new DateTime(2023, 11, 2, 2, 16, 38, 155, DateTimeKind.Utc).AddTicks(1447) },
                    { new Guid("22222222-2222-2222-2222-222222222222"), new Guid("22222222-2222-2222-2222-222222222222"), "Campus 2", new DateTime(2023, 11, 2, 2, 16, 38, 155, DateTimeKind.Utc).AddTicks(1450), new DateTime(2023, 11, 2, 2, 16, 38, 155, DateTimeKind.Utc).AddTicks(1450) },
                    { new Guid("33333333-3333-3333-3333-333333333333"), new Guid("33333333-3333-3333-3333-333333333333"), "Campus 3", new DateTime(2023, 11, 2, 2, 16, 38, 155, DateTimeKind.Utc).AddTicks(1452), new DateTime(2023, 11, 2, 2, 16, 38, 155, DateTimeKind.Utc).AddTicks(1453) },
                    { new Guid("44444444-4444-4444-4444-444444444444"), new Guid("44444444-4444-4444-4444-444444444444"), "Campus 4", new DateTime(2023, 11, 2, 2, 16, 38, 155, DateTimeKind.Utc).AddTicks(1454), new DateTime(2023, 11, 2, 2, 16, 38, 155, DateTimeKind.Utc).AddTicks(1455) },
                    { new Guid("55555555-5555-5555-5555-555555555555"), new Guid("55555555-5555-5555-5555-555555555555"), "Campus 5", new DateTime(2023, 11, 2, 2, 16, 38, 155, DateTimeKind.Utc).AddTicks(1458), new DateTime(2023, 11, 2, 2, 16, 38, 155, DateTimeKind.Utc).AddTicks(1458) },
                    { new Guid("66666666-6666-6666-6666-666666666666"), new Guid("66666666-6666-6666-6666-666666666666"), "Campus 6", new DateTime(2023, 11, 2, 2, 16, 38, 155, DateTimeKind.Utc).AddTicks(1460), new DateTime(2023, 11, 2, 2, 16, 38, 155, DateTimeKind.Utc).AddTicks(1460) },
                    { new Guid("77777777-7777-7777-7777-777777777777"), new Guid("77777777-7777-7777-7777-777777777777"), "Campus 7", new DateTime(2023, 11, 2, 2, 16, 38, 155, DateTimeKind.Utc).AddTicks(1462), new DateTime(2023, 11, 2, 2, 16, 38, 155, DateTimeKind.Utc).AddTicks(1462) },
                    { new Guid("88888888-8888-8888-8888-888888888888"), new Guid("88888888-8888-8888-8888-888888888888"), "Campus 8", new DateTime(2023, 11, 2, 2, 16, 38, 155, DateTimeKind.Utc).AddTicks(1464), new DateTime(2023, 11, 2, 2, 16, 38, 155, DateTimeKind.Utc).AddTicks(1465) },
                    { new Guid("99999999-9999-9999-9999-999999999999"), new Guid("99999999-9999-9999-9999-999999999999"), "Campus 9", new DateTime(2023, 11, 2, 2, 16, 38, 155, DateTimeKind.Utc).AddTicks(1466), new DateTime(2023, 11, 2, 2, 16, 38, 155, DateTimeKind.Utc).AddTicks(1467) },
                    { new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), "Campus 10", new DateTime(2023, 11, 2, 2, 16, 38, 155, DateTimeKind.Utc).AddTicks(1468), new DateTime(2023, 11, 2, 2, 16, 38, 155, DateTimeKind.Utc).AddTicks(1469) }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Active", "AddressId", "CreateDate", "DisplayName", "Email", "LastModifiedDate", "Password", "PhoneNumber", "ProfileImageLink", "Role" },
                values: new object[,]
                {
                    { new Guid("11111111-1111-1111-1111-111111111111"), true, null, new DateTime(2023, 11, 2, 2, 16, 38, 155, DateTimeKind.Utc).AddTicks(1501), "staff", "staff@gmail.com", new DateTime(2023, 11, 2, 2, 16, 38, 155, DateTimeKind.Utc).AddTicks(1501), "123456", "1234567890", "user1.jpg", 1 },
                    { new Guid("22222222-2222-2222-2222-222222222222"), true, null, new DateTime(2023, 11, 2, 2, 16, 38, 155, DateTimeKind.Utc).AddTicks(1509), "landlord1", "landlord1@gmail.com", new DateTime(2023, 11, 2, 2, 16, 38, 155, DateTimeKind.Utc).AddTicks(1509), "123456", "9876543210", "user2.jpg", 0 },
                    { new Guid("33333333-3333-3333-3333-333333333333"), true, null, new DateTime(2023, 11, 2, 2, 16, 38, 155, DateTimeKind.Utc).AddTicks(1513), "landlord2", "landlord2@gmail.com", new DateTime(2023, 11, 2, 2, 16, 38, 155, DateTimeKind.Utc).AddTicks(1513), "123456", "9876543210", "user2.jpg", 0 },
                    { new Guid("44444444-4444-4444-4444-444444444444"), true, null, new DateTime(2023, 11, 2, 2, 16, 38, 155, DateTimeKind.Utc).AddTicks(1516), "User 3", "admin@admin.com", new DateTime(2023, 11, 2, 2, 16, 38, 155, DateTimeKind.Utc).AddTicks(1516), "123456", "5555555555", "user3.jpg", 2 }
                });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "AddressId", "CampusId", "CreateDate", "CreatedBy", "HouseName", "Information", "LandLordId", "LastModifiedBy", "LastModifiedDate", "PowerPrice", "Village", "WaterPrice" },
                values: new object[,]
                {
                    { new Guid("11111111-1111-1111-1111-111111111111"), new Guid("11111111-1111-1111-1111-111111111111"), new Guid("33333333-3333-3333-3333-333333333333"), new DateTime(2023, 11, 2, 2, 16, 38, 155, DateTimeKind.Utc).AddTicks(1538), null, "House 1", "Information for House 1", new Guid("33333333-3333-3333-3333-333333333333"), null, new DateTime(2023, 11, 2, 2, 16, 38, 155, DateTimeKind.Utc).AddTicks(1539), 100f, "Village 1", 50f },
                    { new Guid("22222222-2222-2222-2222-222222222222"), new Guid("22222222-2222-2222-2222-222222222222"), new Guid("22222222-2222-2222-2222-222222222222"), new DateTime(2023, 11, 2, 2, 16, 38, 155, DateTimeKind.Utc).AddTicks(1546), null, "House 2", "Information for House 2", new Guid("33333333-3333-3333-3333-333333333333"), null, new DateTime(2023, 11, 2, 2, 16, 38, 155, DateTimeKind.Utc).AddTicks(1546), 120f, "Village 2", 55f },
                    { new Guid("33333333-3333-3333-3333-333333333333"), new Guid("33333333-3333-3333-3333-333333333333"), new Guid("44444444-4444-4444-4444-444444444444"), new DateTime(2023, 11, 2, 2, 16, 38, 155, DateTimeKind.Utc).AddTicks(1550), null, "House 3", "Information for House 3", new Guid("33333333-3333-3333-3333-333333333333"), null, new DateTime(2023, 11, 2, 2, 16, 38, 155, DateTimeKind.Utc).AddTicks(1550), 90f, "Village 3", 40f },
                    { new Guid("44444444-4444-4444-4444-444444444444"), new Guid("44444444-4444-4444-4444-444444444444"), new Guid("66666666-6666-6666-6666-666666666666"), new DateTime(2023, 11, 2, 2, 16, 38, 155, DateTimeKind.Utc).AddTicks(1553), null, "House 4", "Information for House 4", new Guid("33333333-3333-3333-3333-333333333333"), null, new DateTime(2023, 11, 2, 2, 16, 38, 155, DateTimeKind.Utc).AddTicks(1554), 110f, "Village 4", 52f },
                    { new Guid("55555555-5555-5555-5555-555555555555"), new Guid("55555555-5555-5555-5555-555555555555"), new Guid("22222222-2222-2222-2222-222222222222"), new DateTime(2023, 11, 2, 2, 16, 38, 155, DateTimeKind.Utc).AddTicks(1557), null, "House 5", "Information for House 5", new Guid("33333333-3333-3333-3333-333333333333"), null, new DateTime(2023, 11, 2, 2, 16, 38, 155, DateTimeKind.Utc).AddTicks(1557), 105f, "Village 5", 48f },
                    { new Guid("66666666-6666-6666-6666-666666666666"), new Guid("66666666-6666-6666-6666-666666666666"), new Guid("66666666-6666-6666-6666-666666666666"), new DateTime(2023, 11, 2, 2, 16, 38, 155, DateTimeKind.Utc).AddTicks(1560), null, "House 6", "Information for House 6", new Guid("33333333-3333-3333-3333-333333333333"), null, new DateTime(2023, 11, 2, 2, 16, 38, 155, DateTimeKind.Utc).AddTicks(1561), 95f, "Village 6", 45f },
                    { new Guid("77777777-7777-7777-7777-777777777777"), new Guid("77777777-7777-7777-7777-777777777777"), new Guid("66666666-6666-6666-6666-666666666666"), new DateTime(2023, 11, 2, 2, 16, 38, 155, DateTimeKind.Utc).AddTicks(1566), null, "House 7", "Information for House 7", new Guid("33333333-3333-3333-3333-333333333333"), null, new DateTime(2023, 11, 2, 2, 16, 38, 155, DateTimeKind.Utc).AddTicks(1566), 98f, "Village 7", 47f },
                    { new Guid("88888888-8888-8888-8888-888888888888"), new Guid("88888888-8888-8888-8888-888888888888"), new Guid("66666666-6666-6666-6666-666666666666"), new DateTime(2023, 11, 2, 2, 16, 38, 155, DateTimeKind.Utc).AddTicks(1570), null, "House 8", "Information for House 8", new Guid("33333333-3333-3333-3333-333333333333"), null, new DateTime(2023, 11, 2, 2, 16, 38, 155, DateTimeKind.Utc).AddTicks(1570), 103f, "Village 8", 51f },
                    { new Guid("99999999-9999-9999-9999-999999999999"), new Guid("99999999-9999-9999-9999-999999999999"), new Guid("44444444-4444-4444-4444-444444444444"), new DateTime(2023, 11, 2, 2, 16, 38, 155, DateTimeKind.Utc).AddTicks(1573), null, "House 9", "Information for House 9", new Guid("22222222-2222-2222-2222-222222222222"), null, new DateTime(2023, 11, 2, 2, 16, 38, 155, DateTimeKind.Utc).AddTicks(1574), 97f, "Village 9", 49f },
                    { new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), new Guid("66666666-6666-6666-6666-666666666666"), new DateTime(2023, 11, 2, 2, 16, 38, 155, DateTimeKind.Utc).AddTicks(1577), null, "House 10", "Information for House 10", new Guid("22222222-2222-2222-2222-222222222222"), null, new DateTime(2023, 11, 2, 2, 16, 38, 155, DateTimeKind.Utc).AddTicks(1577), 105f, "Village 10", 55f },
                    { new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), new Guid("66666666-6666-6666-6666-666666666666"), new DateTime(2023, 11, 2, 2, 16, 38, 155, DateTimeKind.Utc).AddTicks(1580), null, "House 11", "Information for House 11", new Guid("22222222-2222-2222-2222-222222222222"), null, new DateTime(2023, 11, 2, 2, 16, 38, 155, DateTimeKind.Utc).AddTicks(1581), 103f, "Village 11", 53f },
                    { new Guid("cccccccc-cccc-cccc-cccc-cccccccccccc"), new Guid("cccccccc-cccc-cccc-cccc-cccccccccccc"), new Guid("66666666-6666-6666-6666-666666666666"), new DateTime(2023, 11, 2, 2, 16, 38, 155, DateTimeKind.Utc).AddTicks(1584), null, "House 12", "Information for House 12", new Guid("22222222-2222-2222-2222-222222222222"), null, new DateTime(2023, 11, 2, 2, 16, 38, 155, DateTimeKind.Utc).AddTicks(1584), 98f, "Village 12", 48f },
                    { new Guid("dddddddd-dddd-dddd-dddd-dddddddddddd"), new Guid("dddddddd-dddd-dddd-dddd-dddddddddddd"), new Guid("66666666-6666-6666-6666-666666666666"), new DateTime(2023, 11, 2, 2, 16, 38, 155, DateTimeKind.Utc).AddTicks(1588), null, "House 13", "Information for House 13", new Guid("22222222-2222-2222-2222-222222222222"), null, new DateTime(2023, 11, 2, 2, 16, 38, 155, DateTimeKind.Utc).AddTicks(1588), 96f, "Village 13", 46f },
                    { new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"), new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"), new Guid("66666666-6666-6666-6666-666666666666"), new DateTime(2023, 11, 2, 2, 16, 38, 155, DateTimeKind.Utc).AddTicks(1591), null, "House 14", "Information for House 14", new Guid("22222222-2222-2222-2222-222222222222"), null, new DateTime(2023, 11, 2, 2, 16, 38, 155, DateTimeKind.Utc).AddTicks(1592), 99f, "Village 14", 49f },
                    { new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff"), new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff"), new Guid("22222222-2222-2222-2222-222222222222"), new DateTime(2023, 11, 2, 2, 16, 38, 155, DateTimeKind.Utc).AddTicks(1597), null, "House 15", "Information for House 15", new Guid("22222222-2222-2222-2222-222222222222"), null, new DateTime(2023, 11, 2, 2, 16, 38, 155, DateTimeKind.Utc).AddTicks(1597), 101f, "Village 15", 51f }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Campuses",
                keyColumn: "Id",
                keyValue: new Guid("11111111-1111-1111-1111-111111111111"));

            migrationBuilder.DeleteData(
                table: "Campuses",
                keyColumn: "Id",
                keyValue: new Guid("55555555-5555-5555-5555-555555555555"));

            migrationBuilder.DeleteData(
                table: "Campuses",
                keyColumn: "Id",
                keyValue: new Guid("77777777-7777-7777-7777-777777777777"));

            migrationBuilder.DeleteData(
                table: "Campuses",
                keyColumn: "Id",
                keyValue: new Guid("88888888-8888-8888-8888-888888888888"));

            migrationBuilder.DeleteData(
                table: "Campuses",
                keyColumn: "Id",
                keyValue: new Guid("99999999-9999-9999-9999-999999999999"));

            migrationBuilder.DeleteData(
                table: "Campuses",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"));

            migrationBuilder.DeleteData(
                table: "Houses",
                keyColumn: "Id",
                keyValue: new Guid("11111111-1111-1111-1111-111111111111"));

            migrationBuilder.DeleteData(
                table: "Houses",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-222222222222"));

            migrationBuilder.DeleteData(
                table: "Houses",
                keyColumn: "Id",
                keyValue: new Guid("33333333-3333-3333-3333-333333333333"));

            migrationBuilder.DeleteData(
                table: "Houses",
                keyColumn: "Id",
                keyValue: new Guid("44444444-4444-4444-4444-444444444444"));

            migrationBuilder.DeleteData(
                table: "Houses",
                keyColumn: "Id",
                keyValue: new Guid("55555555-5555-5555-5555-555555555555"));

            migrationBuilder.DeleteData(
                table: "Houses",
                keyColumn: "Id",
                keyValue: new Guid("66666666-6666-6666-6666-666666666666"));

            migrationBuilder.DeleteData(
                table: "Houses",
                keyColumn: "Id",
                keyValue: new Guid("77777777-7777-7777-7777-777777777777"));

            migrationBuilder.DeleteData(
                table: "Houses",
                keyColumn: "Id",
                keyValue: new Guid("88888888-8888-8888-8888-888888888888"));

            migrationBuilder.DeleteData(
                table: "Houses",
                keyColumn: "Id",
                keyValue: new Guid("99999999-9999-9999-9999-999999999999"));

            migrationBuilder.DeleteData(
                table: "Houses",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"));

            migrationBuilder.DeleteData(
                table: "Houses",
                keyColumn: "Id",
                keyValue: new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"));

            migrationBuilder.DeleteData(
                table: "Houses",
                keyColumn: "Id",
                keyValue: new Guid("cccccccc-cccc-cccc-cccc-cccccccccccc"));

            migrationBuilder.DeleteData(
                table: "Houses",
                keyColumn: "Id",
                keyValue: new Guid("dddddddd-dddd-dddd-dddd-dddddddddddd"));

            migrationBuilder.DeleteData(
                table: "Houses",
                keyColumn: "Id",
                keyValue: new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"));

            migrationBuilder.DeleteData(
                table: "Houses",
                keyColumn: "Id",
                keyValue: new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("11111111-1111-1111-1111-111111111111"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("44444444-4444-4444-4444-444444444444"));

            migrationBuilder.DeleteData(
                table: "Campuses",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-222222222222"));

            migrationBuilder.DeleteData(
                table: "Campuses",
                keyColumn: "Id",
                keyValue: new Guid("33333333-3333-3333-3333-333333333333"));

            migrationBuilder.DeleteData(
                table: "Campuses",
                keyColumn: "Id",
                keyValue: new Guid("44444444-4444-4444-4444-444444444444"));

            migrationBuilder.DeleteData(
                table: "Campuses",
                keyColumn: "Id",
                keyValue: new Guid("66666666-6666-6666-6666-666666666666"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-222222222222"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("33333333-3333-3333-3333-333333333333"));

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("11111111-1111-1111-1111-111111111111"),
                columns: new[] { "CreateDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 30, 10, 24, 53, 9, DateTimeKind.Utc).AddTicks(157), new DateTime(2023, 10, 30, 10, 24, 53, 9, DateTimeKind.Utc).AddTicks(161) });

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-222222222222"),
                columns: new[] { "CreateDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 30, 10, 24, 53, 9, DateTimeKind.Utc).AddTicks(184), new DateTime(2023, 10, 30, 10, 24, 53, 9, DateTimeKind.Utc).AddTicks(184) });

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("33333333-3333-3333-3333-333333333333"),
                columns: new[] { "CreateDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 30, 10, 24, 53, 9, DateTimeKind.Utc).AddTicks(188), new DateTime(2023, 10, 30, 10, 24, 53, 9, DateTimeKind.Utc).AddTicks(188) });

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("44444444-4444-4444-4444-444444444444"),
                columns: new[] { "CreateDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 30, 10, 24, 53, 9, DateTimeKind.Utc).AddTicks(191), new DateTime(2023, 10, 30, 10, 24, 53, 9, DateTimeKind.Utc).AddTicks(191) });

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("55555555-5555-5555-5555-555555555555"),
                columns: new[] { "CreateDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 30, 10, 24, 53, 9, DateTimeKind.Utc).AddTicks(194), new DateTime(2023, 10, 30, 10, 24, 53, 9, DateTimeKind.Utc).AddTicks(194) });

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("66666666-6666-6666-6666-666666666666"),
                columns: new[] { "CreateDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 30, 10, 24, 53, 9, DateTimeKind.Utc).AddTicks(196), new DateTime(2023, 10, 30, 10, 24, 53, 9, DateTimeKind.Utc).AddTicks(197) });

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("77777777-7777-7777-7777-777777777777"),
                columns: new[] { "CreateDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 30, 10, 24, 53, 9, DateTimeKind.Utc).AddTicks(199), new DateTime(2023, 10, 30, 10, 24, 53, 9, DateTimeKind.Utc).AddTicks(200) });

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("88888888-8888-8888-8888-888888888888"),
                columns: new[] { "CreateDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 30, 10, 24, 53, 9, DateTimeKind.Utc).AddTicks(214), new DateTime(2023, 10, 30, 10, 24, 53, 9, DateTimeKind.Utc).AddTicks(214) });

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("99999999-9999-9999-9999-999999999999"),
                columns: new[] { "CreateDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 30, 10, 24, 53, 9, DateTimeKind.Utc).AddTicks(217), new DateTime(2023, 10, 30, 10, 24, 53, 9, DateTimeKind.Utc).AddTicks(217) });

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"),
                columns: new[] { "CreateDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 30, 10, 24, 53, 9, DateTimeKind.Utc).AddTicks(220), new DateTime(2023, 10, 30, 10, 24, 53, 9, DateTimeKind.Utc).AddTicks(220) });

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"),
                columns: new[] { "CreateDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 30, 10, 24, 53, 9, DateTimeKind.Utc).AddTicks(223), new DateTime(2023, 10, 30, 10, 24, 53, 9, DateTimeKind.Utc).AddTicks(224) });

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("cccccccc-cccc-cccc-cccc-cccccccccccc"),
                columns: new[] { "CreateDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 30, 10, 24, 53, 9, DateTimeKind.Utc).AddTicks(226), new DateTime(2023, 10, 30, 10, 24, 53, 9, DateTimeKind.Utc).AddTicks(227) });

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("dddddddd-dddd-dddd-dddd-dddddddddddd"),
                columns: new[] { "CreateDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 30, 10, 24, 53, 9, DateTimeKind.Utc).AddTicks(229), new DateTime(2023, 10, 30, 10, 24, 53, 9, DateTimeKind.Utc).AddTicks(230) });

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"),
                columns: new[] { "CreateDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 30, 10, 24, 53, 9, DateTimeKind.Utc).AddTicks(232), new DateTime(2023, 10, 30, 10, 24, 53, 9, DateTimeKind.Utc).AddTicks(232) });

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff"),
                columns: new[] { "CreateDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 30, 10, 24, 53, 9, DateTimeKind.Utc).AddTicks(234), new DateTime(2023, 10, 30, 10, 24, 53, 9, DateTimeKind.Utc).AddTicks(235) });

            migrationBuilder.InsertData(
                table: "Campuses",
                columns: new[] { "Id", "AddressId", "CampusName", "CreateDate", "LastModifiedDate" },
                values: new object[,]
                {
                    { new Guid("0977aee7-57aa-4705-9133-aae7a6175efa"), new Guid("44444444-4444-4444-4444-444444444444"), "Campus 4", new DateTime(2023, 10, 30, 10, 24, 53, 9, DateTimeKind.Utc).AddTicks(451), new DateTime(2023, 10, 30, 10, 24, 53, 9, DateTimeKind.Utc).AddTicks(452) },
                    { new Guid("0af0d8a6-8913-4ae8-9331-7f9d201f1fdc"), new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), "Campus 10", new DateTime(2023, 10, 30, 10, 24, 53, 9, DateTimeKind.Utc).AddTicks(469), new DateTime(2023, 10, 30, 10, 24, 53, 9, DateTimeKind.Utc).AddTicks(470) },
                    { new Guid("36041dfa-f87d-4889-8e75-b5a6228069bb"), new Guid("11111111-1111-1111-1111-111111111111"), "Campus 1", new DateTime(2023, 10, 30, 10, 24, 53, 9, DateTimeKind.Utc).AddTicks(440), new DateTime(2023, 10, 30, 10, 24, 53, 9, DateTimeKind.Utc).AddTicks(441) },
                    { new Guid("41706a7b-f221-4d7b-ba76-d533635a6ba5"), new Guid("33333333-3333-3333-3333-333333333333"), "Campus 3", new DateTime(2023, 10, 30, 10, 24, 53, 9, DateTimeKind.Utc).AddTicks(448), new DateTime(2023, 10, 30, 10, 24, 53, 9, DateTimeKind.Utc).AddTicks(449) },
                    { new Guid("85c87b65-990b-4306-9dd2-34febb76bd88"), new Guid("77777777-7777-7777-7777-777777777777"), "Campus 7", new DateTime(2023, 10, 30, 10, 24, 53, 9, DateTimeKind.Utc).AddTicks(459), new DateTime(2023, 10, 30, 10, 24, 53, 9, DateTimeKind.Utc).AddTicks(459) },
                    { new Guid("9aacf079-0c17-47ba-97e2-2c987ed31ccb"), new Guid("22222222-2222-2222-2222-222222222222"), "Campus 2", new DateTime(2023, 10, 30, 10, 24, 53, 9, DateTimeKind.Utc).AddTicks(446), new DateTime(2023, 10, 30, 10, 24, 53, 9, DateTimeKind.Utc).AddTicks(446) },
                    { new Guid("b8df88cb-b8f1-4262-b9eb-e37a73ab10c3"), new Guid("66666666-6666-6666-6666-666666666666"), "Campus 6", new DateTime(2023, 10, 30, 10, 24, 53, 9, DateTimeKind.Utc).AddTicks(456), new DateTime(2023, 10, 30, 10, 24, 53, 9, DateTimeKind.Utc).AddTicks(457) },
                    { new Guid("c27c531e-bff9-4ce0-8eed-093d6155567f"), new Guid("99999999-9999-9999-9999-999999999999"), "Campus 9", new DateTime(2023, 10, 30, 10, 24, 53, 9, DateTimeKind.Utc).AddTicks(467), new DateTime(2023, 10, 30, 10, 24, 53, 9, DateTimeKind.Utc).AddTicks(467) },
                    { new Guid("e9705cb7-36ca-42c3-bcc2-199094c52cde"), new Guid("55555555-5555-5555-5555-555555555555"), "Campus 5", new DateTime(2023, 10, 30, 10, 24, 53, 9, DateTimeKind.Utc).AddTicks(454), new DateTime(2023, 10, 30, 10, 24, 53, 9, DateTimeKind.Utc).AddTicks(454) },
                    { new Guid("ec90ca30-339c-4220-b994-be8ac9847846"), new Guid("88888888-8888-8888-8888-888888888888"), "Campus 8", new DateTime(2023, 10, 30, 10, 24, 53, 9, DateTimeKind.Utc).AddTicks(462), new DateTime(2023, 10, 30, 10, 24, 53, 9, DateTimeKind.Utc).AddTicks(462) }
                });
        }
    }
}
