using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class UpdateUser1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Addresses_AddressId",
                table: "Users");

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

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Users",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<Guid>(
                name: "AddressId",
                table: "Users",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

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

            migrationBuilder.CreateIndex(
                name: "IX_Users_Email",
                table: "Users",
                column: "Email",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Addresses_AddressId",
                table: "Users",
                column: "AddressId",
                principalTable: "Addresses",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Addresses_AddressId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_Email",
                table: "Users");

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

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<Guid>(
                name: "AddressId",
                table: "Users",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("11111111-1111-1111-1111-111111111111"),
                columns: new[] { "CreateDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 30, 9, 28, 46, 33, DateTimeKind.Utc).AddTicks(3138), new DateTime(2023, 10, 30, 9, 28, 46, 33, DateTimeKind.Utc).AddTicks(3142) });

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-222222222222"),
                columns: new[] { "CreateDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 30, 9, 28, 46, 33, DateTimeKind.Utc).AddTicks(3173), new DateTime(2023, 10, 30, 9, 28, 46, 33, DateTimeKind.Utc).AddTicks(3173) });

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("33333333-3333-3333-3333-333333333333"),
                columns: new[] { "CreateDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 30, 9, 28, 46, 33, DateTimeKind.Utc).AddTicks(3178), new DateTime(2023, 10, 30, 9, 28, 46, 33, DateTimeKind.Utc).AddTicks(3178) });

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("44444444-4444-4444-4444-444444444444"),
                columns: new[] { "CreateDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 30, 9, 28, 46, 33, DateTimeKind.Utc).AddTicks(3182), new DateTime(2023, 10, 30, 9, 28, 46, 33, DateTimeKind.Utc).AddTicks(3182) });

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("55555555-5555-5555-5555-555555555555"),
                columns: new[] { "CreateDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 30, 9, 28, 46, 33, DateTimeKind.Utc).AddTicks(3185), new DateTime(2023, 10, 30, 9, 28, 46, 33, DateTimeKind.Utc).AddTicks(3186) });

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("66666666-6666-6666-6666-666666666666"),
                columns: new[] { "CreateDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 30, 9, 28, 46, 33, DateTimeKind.Utc).AddTicks(3189), new DateTime(2023, 10, 30, 9, 28, 46, 33, DateTimeKind.Utc).AddTicks(3189) });

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("77777777-7777-7777-7777-777777777777"),
                columns: new[] { "CreateDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 30, 9, 28, 46, 33, DateTimeKind.Utc).AddTicks(3192), new DateTime(2023, 10, 30, 9, 28, 46, 33, DateTimeKind.Utc).AddTicks(3193) });

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("88888888-8888-8888-8888-888888888888"),
                columns: new[] { "CreateDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 30, 9, 28, 46, 33, DateTimeKind.Utc).AddTicks(3196), new DateTime(2023, 10, 30, 9, 28, 46, 33, DateTimeKind.Utc).AddTicks(3196) });

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("99999999-9999-9999-9999-999999999999"),
                columns: new[] { "CreateDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 30, 9, 28, 46, 33, DateTimeKind.Utc).AddTicks(3204), new DateTime(2023, 10, 30, 9, 28, 46, 33, DateTimeKind.Utc).AddTicks(3205) });

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"),
                columns: new[] { "CreateDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 30, 9, 28, 46, 33, DateTimeKind.Utc).AddTicks(3208), new DateTime(2023, 10, 30, 9, 28, 46, 33, DateTimeKind.Utc).AddTicks(3208) });

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"),
                columns: new[] { "CreateDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 30, 9, 28, 46, 33, DateTimeKind.Utc).AddTicks(3212), new DateTime(2023, 10, 30, 9, 28, 46, 33, DateTimeKind.Utc).AddTicks(3212) });

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("cccccccc-cccc-cccc-cccc-cccccccccccc"),
                columns: new[] { "CreateDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 30, 9, 28, 46, 33, DateTimeKind.Utc).AddTicks(3215), new DateTime(2023, 10, 30, 9, 28, 46, 33, DateTimeKind.Utc).AddTicks(3216) });

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("dddddddd-dddd-dddd-dddd-dddddddddddd"),
                columns: new[] { "CreateDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 30, 9, 28, 46, 33, DateTimeKind.Utc).AddTicks(3219), new DateTime(2023, 10, 30, 9, 28, 46, 33, DateTimeKind.Utc).AddTicks(3220) });

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"),
                columns: new[] { "CreateDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 30, 9, 28, 46, 33, DateTimeKind.Utc).AddTicks(3223), new DateTime(2023, 10, 30, 9, 28, 46, 33, DateTimeKind.Utc).AddTicks(3224) });

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff"),
                columns: new[] { "CreateDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 30, 9, 28, 46, 33, DateTimeKind.Utc).AddTicks(3228), new DateTime(2023, 10, 30, 9, 28, 46, 33, DateTimeKind.Utc).AddTicks(3228) });

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

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Addresses_AddressId",
                table: "Users",
                column: "AddressId",
                principalTable: "Addresses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
