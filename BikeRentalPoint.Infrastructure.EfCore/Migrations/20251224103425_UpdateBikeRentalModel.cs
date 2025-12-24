using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BikeRentalPoint.Infrastructure.EfCore.Migrations
{
    /// <inheritdoc />
    public partial class UpdateBikeRentalModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_rent_bike_bike_id",
                table: "rent");

            migrationBuilder.DropForeignKey(
                name: "FK_rent_renter_renter_id",
                table: "rent");

            migrationBuilder.DeleteData(
                table: "rent",
                keyColumn: "id",
                keyValue: new Guid("06ba3375-11d9-49b3-9db5-73703c4b24b0"));

            migrationBuilder.DeleteData(
                table: "rent",
                keyColumn: "id",
                keyValue: new Guid("13a97ac3-4746-43bc-b4b7-d4cba1edd39b"));

            migrationBuilder.DeleteData(
                table: "rent",
                keyColumn: "id",
                keyValue: new Guid("3693a260-f88c-4fea-8535-250979eda36f"));

            migrationBuilder.DeleteData(
                table: "rent",
                keyColumn: "id",
                keyValue: new Guid("447a3edb-7bd9-4467-bdd4-b713d189d934"));

            migrationBuilder.DeleteData(
                table: "rent",
                keyColumn: "id",
                keyValue: new Guid("45467e33-19f4-4465-8dee-8e55be3c6a19"));

            migrationBuilder.DeleteData(
                table: "rent",
                keyColumn: "id",
                keyValue: new Guid("46de07ab-24f5-497d-9d1f-78512c0ab9f6"));

            migrationBuilder.DeleteData(
                table: "rent",
                keyColumn: "id",
                keyValue: new Guid("62953104-b9e1-4021-88a2-63f7b78ed558"));

            migrationBuilder.DeleteData(
                table: "rent",
                keyColumn: "id",
                keyValue: new Guid("6957a893-bdee-4e3d-9c19-22bbd4b04710"));

            migrationBuilder.DeleteData(
                table: "rent",
                keyColumn: "id",
                keyValue: new Guid("7799b9fa-cc36-4ce8-ac54-be35ae864392"));

            migrationBuilder.DeleteData(
                table: "rent",
                keyColumn: "id",
                keyValue: new Guid("7d833f9a-1bf3-4191-950b-d724fc3af9a1"));

            migrationBuilder.DeleteData(
                table: "rent",
                keyColumn: "id",
                keyValue: new Guid("86dd46d2-d590-453c-ab9a-47a498917b81"));

            migrationBuilder.DeleteData(
                table: "rent",
                keyColumn: "id",
                keyValue: new Guid("8825d79f-eb62-4d72-bef2-366e86bd0ed7"));

            migrationBuilder.DeleteData(
                table: "rent",
                keyColumn: "id",
                keyValue: new Guid("afd870f1-6346-42fe-bc98-836f32e16849"));

            migrationBuilder.DeleteData(
                table: "rent",
                keyColumn: "id",
                keyValue: new Guid("b7cd534b-1b61-4e3c-b6a2-74e0c79a86c7"));

            migrationBuilder.DeleteData(
                table: "rent",
                keyColumn: "id",
                keyValue: new Guid("d389a5a6-d398-46f2-a5c3-730f75d41553"));

            migrationBuilder.DeleteData(
                table: "rent",
                keyColumn: "id",
                keyValue: new Guid("d44dc785-ed28-4259-8c64-0de1f1768277"));

            migrationBuilder.DeleteData(
                table: "rent",
                keyColumn: "id",
                keyValue: new Guid("d56a4c5a-3c15-4886-8fd4-73fec0a831b3"));

            migrationBuilder.DeleteData(
                table: "rent",
                keyColumn: "id",
                keyValue: new Guid("fa62f9da-bbc4-40dc-b24f-97d190aa20bc"));

            migrationBuilder.DeleteData(
                table: "renter",
                keyColumn: "id",
                keyValue: new Guid("b7491013-1f84-4866-a8e7-730c226c3659"));

            migrationBuilder.DeleteData(
                table: "bike",
                keyColumn: "id",
                keyValue: new Guid("279902b6-a996-4fe1-8de8-0f36cfcff3eb"));

            migrationBuilder.DeleteData(
                table: "bike",
                keyColumn: "id",
                keyValue: new Guid("2ff0d2de-a373-41ae-8018-f08f2590ec88"));

            migrationBuilder.DeleteData(
                table: "bike",
                keyColumn: "id",
                keyValue: new Guid("36358c4c-8620-4fb5-9502-e1ea23d0d3e1"));

            migrationBuilder.DeleteData(
                table: "bike",
                keyColumn: "id",
                keyValue: new Guid("3c43bc36-34e8-4fe3-ba3d-9b52777c6976"));

            migrationBuilder.DeleteData(
                table: "bike",
                keyColumn: "id",
                keyValue: new Guid("61865875-b804-4baa-8b2a-3260e62b84f3"));

            migrationBuilder.DeleteData(
                table: "bike",
                keyColumn: "id",
                keyValue: new Guid("745b41c8-ca80-427c-9e86-152b5a1ba5f4"));

            migrationBuilder.DeleteData(
                table: "bike",
                keyColumn: "id",
                keyValue: new Guid("80d70b89-4692-4eda-9492-cf898aac545d"));

            migrationBuilder.DeleteData(
                table: "bike",
                keyColumn: "id",
                keyValue: new Guid("9ca5637c-9c10-419e-9c35-db2d523f5b08"));

            migrationBuilder.DeleteData(
                table: "bike",
                keyColumn: "id",
                keyValue: new Guid("d76ea574-e417-4567-a4b3-fd59c314d391"));

            migrationBuilder.DeleteData(
                table: "bike",
                keyColumn: "id",
                keyValue: new Guid("e2330abb-386b-45fe-8c3b-52ec852dee1f"));

            migrationBuilder.DeleteData(
                table: "renter",
                keyColumn: "id",
                keyValue: new Guid("1c9e5593-74e4-4f32-bb1a-aa65013e9749"));

            migrationBuilder.DeleteData(
                table: "renter",
                keyColumn: "id",
                keyValue: new Guid("3ac86426-26df-46cb-b4f2-576f442d104e"));

            migrationBuilder.DeleteData(
                table: "renter",
                keyColumn: "id",
                keyValue: new Guid("590c9949-a9d3-4084-81b4-d2b5c59cc0e7"));

            migrationBuilder.DeleteData(
                table: "renter",
                keyColumn: "id",
                keyValue: new Guid("682bfc31-dc6f-42db-ac47-233ab1aba084"));

            migrationBuilder.DeleteData(
                table: "renter",
                keyColumn: "id",
                keyValue: new Guid("9bf4355d-d000-4822-9bd1-dea296610a3a"));

            migrationBuilder.DeleteData(
                table: "renter",
                keyColumn: "id",
                keyValue: new Guid("9cec14bf-3470-4394-9899-fdf3519f699f"));

            migrationBuilder.DeleteData(
                table: "renter",
                keyColumn: "id",
                keyValue: new Guid("9d22c91c-85c9-44ac-85d6-2d0cf9c0513c"));

            migrationBuilder.DeleteData(
                table: "renter",
                keyColumn: "id",
                keyValue: new Guid("cf7dcad8-2859-4f7e-95c1-c1471d134db0"));

            migrationBuilder.DeleteData(
                table: "renter",
                keyColumn: "id",
                keyValue: new Guid("d8abaf64-e960-486d-a064-7134dc4c0522"));

            migrationBuilder.DeleteData(
                table: "model",
                keyColumn: "id",
                keyValue: new Guid("1a96f120-7e4e-4e36-a536-07aa6df6112c"));

            migrationBuilder.DeleteData(
                table: "model",
                keyColumn: "id",
                keyValue: new Guid("49e4174e-b015-4340-a0fc-dfef5947961a"));

            migrationBuilder.DeleteData(
                table: "model",
                keyColumn: "id",
                keyValue: new Guid("81baa0bc-eef3-4797-ba5a-d8e4d862a37a"));

            migrationBuilder.DeleteData(
                table: "model",
                keyColumn: "id",
                keyValue: new Guid("a72e8761-ee46-4c3d-a7e0-0d6b17523f16"));

            migrationBuilder.DeleteData(
                table: "model",
                keyColumn: "id",
                keyValue: new Guid("aadbd9ee-2517-40f8-9db3-a1161a6c16a5"));

            migrationBuilder.DeleteData(
                table: "model",
                keyColumn: "id",
                keyValue: new Guid("c87a3abb-ff4d-45ed-a9d0-88055b9673cf"));

            migrationBuilder.DeleteData(
                table: "model",
                keyColumn: "id",
                keyValue: new Guid("e0350b2c-8f99-49d5-b4eb-4f1165b87abc"));

            migrationBuilder.DeleteData(
                table: "model",
                keyColumn: "id",
                keyValue: new Guid("ec369c47-c55e-4825-8a3d-438949233514"));

            migrationBuilder.DeleteData(
                table: "model",
                keyColumn: "id",
                keyValue: new Guid("ec4c0299-7e52-44cb-9fd9-9fd8f2990232"));

            migrationBuilder.DeleteData(
                table: "model",
                keyColumn: "id",
                keyValue: new Guid("fb93836e-474f-48f7-b8fd-2eb25b21f30d"));

            migrationBuilder.InsertData(
                table: "model",
                columns: new[] { "id", "bike_type", "bike_weight", "brake_type", "max_passenger_weight", "model_year", "price_per_hour", "wheel_size" },
                values: new object[,]
                {
                    { new Guid("2b22dd33-eccf-4f04-a52c-4ac4df78720b"), 0, 12.0, 1, 120.0, 2025, 17m, 28.0 },
                    { new Guid("4d46e705-4b64-40d3-8883-f12934993abc"), 2, 10.0, 0, 90.0, 2020, 9m, 27.5 },
                    { new Guid("671e5425-28a2-4d9f-bc07-5dd81f8f3c64"), 1, 11.0, 0, 110.0, 2021, 10m, 26.0 },
                    { new Guid("6a9c0efe-2bc0-4e64-9c4f-fdc9fff23108"), 0, 9.0, 1, 100.0, 2022, 12m, 28.0 },
                    { new Guid("8dea56e8-6982-4339-8a8b-5b08b43e36be"), 0, 12.0, 2, 100.0, 2024, 14m, 28.0 },
                    { new Guid("b5b6735d-45fa-4c62-b653-db81f7121d84"), 1, 13.0, 1, 120.0, 2023, 15m, 29.0 },
                    { new Guid("b8061bf4-0826-43e6-9cbc-41ee8452d755"), 2, 11.0, 0, 95.0, 2021, 11m, 27.0 },
                    { new Guid("e2ad9828-414d-409e-b3e1-344ff44b19c1"), 3, 14.0, 1, 100.0, 2024, 16m, 26.0 },
                    { new Guid("e45334d8-7bd4-4d04-ba7a-9a382185c4f9"), 4, 8.0, 3, 80.0, 2019, 8m, 24.0 },
                    { new Guid("e7c23725-116a-4e40-a1cc-660a5373d188"), 1, 15.0, 5, 130.0, 2023, 13m, 29.0 }
                });

            migrationBuilder.InsertData(
                table: "renter",
                columns: new[] { "id", "last_name", "middle_name", "name", "phone_number" },
                values: new object[,]
                {
                    { new Guid("4b45a861-d993-4f44-87c4-fac41fb6494b"), "Смирнов", "Валерьевич", "Семен", "999-999" },
                    { new Guid("4eec356c-e16c-4f83-b01a-acb228d09e35"), "Алексеев", "Николаевич", "Алексей", "444-444" },
                    { new Guid("81ecca56-1aef-481c-a15b-a64f43e22df0"), "Федоров", "Владимирович", "Федор", "888-888" },
                    { new Guid("8275540f-31af-4291-b809-373d9291c5e0"), "Сидоров", "Сидорович", "Сидор", "333-333" },
                    { new Guid("a4029112-136c-4689-bfca-f8b64afc9b87"), "Кузнецов", "Игоревич", "Сергей", "666-666" },
                    { new Guid("aea707e2-152c-44b3-b40b-e46a0a9d0047"), "Петров", "Петрович", "Петр", "222-222" },
                    { new Guid("c2c0b965-9a05-49cb-8051-5ce6d26761af"), "Попов", "Алексеевич", "Дмитрий", "000-000" },
                    { new Guid("e3803c2c-1d4f-4a94-b6e8-43418b11cf3d"), "Иванов", "Иванович", "Иван", "111-111" },
                    { new Guid("e5b43429-1e08-44e1-ade2-5307812fa40f"), "Васильев", "Павлович", "Василий", "555-555" },
                    { new Guid("ff8c419a-401a-46b9-a544-a3d9f81e96de"), "Никитин", "Андреевич", "Никита", "777-777" }
                });

            migrationBuilder.InsertData(
                table: "bike",
                columns: new[] { "id", "color", "model_id", "serial_number" },
                values: new object[,]
                {
                    { new Guid("160e4ff6-8a73-4df8-be70-a97a5428ee83"), "Black", new Guid("b5b6735d-45fa-4c62-b653-db81f7121d84"), "103" },
                    { new Guid("2cc7ef72-0a74-4cdd-83a9-c3e163f0dd70"), "Green", new Guid("4d46e705-4b64-40d3-8883-f12934993abc"), "104" },
                    { new Guid("4948faf4-935b-4d9a-800a-4e2816760d68"), "Silver", new Guid("e2ad9828-414d-409e-b3e1-344ff44b19c1"), "107" },
                    { new Guid("80cf1be0-4bd7-40b2-9e48-b86cb56fff12"), "Blue", new Guid("671e5425-28a2-4d9f-bc07-5dd81f8f3c64"), "102" },
                    { new Guid("8cdfc712-b2b0-451a-8196-358529d251ac"), "Purple", new Guid("2b22dd33-eccf-4f04-a52c-4ac4df78720b"), "110" },
                    { new Guid("aad23158-ce0b-41ac-836b-a66c0a57ce30"), "Yellow", new Guid("e45334d8-7bd4-4d04-ba7a-9a382185c4f9"), "106" },
                    { new Guid("b6ce7e19-cd47-4fd6-a531-c48e5809d555"), "White", new Guid("8dea56e8-6982-4339-8a8b-5b08b43e36be"), "105" },
                    { new Guid("d546a410-ebd2-49cc-a6cf-e9e0eb3c3daa"), "Gray", new Guid("e7c23725-116a-4e40-a1cc-660a5373d188"), "108" },
                    { new Guid("dfecdb38-11f8-4d75-ba9c-35787ff76810"), "Orange", new Guid("b8061bf4-0826-43e6-9cbc-41ee8452d755"), "109" },
                    { new Guid("f7ea642e-c7d8-4a66-9660-757e1d55e1f2"), "Red", new Guid("6a9c0efe-2bc0-4e64-9c4f-fdc9fff23108"), "101" }
                });

            migrationBuilder.InsertData(
                table: "rent",
                columns: new[] { "id", "bike_id", "duration", "renter_id", "start_time" },
                values: new object[,]
                {
                    { new Guid("080e7d48-2167-4bcd-9123-1dbbf2a8f1af"), new Guid("f7ea642e-c7d8-4a66-9660-757e1d55e1f2"), new TimeSpan(0, 2, 0, 0, 0), new Guid("e3803c2c-1d4f-4a94-b6e8-43418b11cf3d"), new DateTime(2025, 12, 22, 12, 34, 24, 298, DateTimeKind.Local).AddTicks(5363) },
                    { new Guid("2aeb83b7-11b7-45de-927d-fa53ae799ec6"), new Guid("8cdfc712-b2b0-451a-8196-358529d251ac"), new TimeSpan(0, 2, 0, 0, 0), new Guid("e3803c2c-1d4f-4a94-b6e8-43418b11cf3d"), new DateTime(2025, 12, 24, 13, 4, 24, 298, DateTimeKind.Local).AddTicks(6349) },
                    { new Guid("31777f35-0c75-4f73-b06e-282d822c1392"), new Guid("b6ce7e19-cd47-4fd6-a531-c48e5809d555"), new TimeSpan(0, 2, 30, 0, 0), new Guid("e5b43429-1e08-44e1-ade2-5307812fa40f"), new DateTime(2025, 12, 24, 4, 34, 24, 298, DateTimeKind.Local).AddTicks(6306) },
                    { new Guid("37a0baf3-cc36-4d2d-ac2c-209584154ccd"), new Guid("aad23158-ce0b-41ac-836b-a66c0a57ce30"), new TimeSpan(0, 2, 30, 0, 0), new Guid("81ecca56-1aef-481c-a15b-a64f43e22df0"), new DateTime(2025, 12, 24, 8, 34, 24, 298, DateTimeKind.Local).AddTicks(6344) },
                    { new Guid("4de3abf1-efc7-4a16-b34d-70375969fc3a"), new Guid("2cc7ef72-0a74-4cdd-83a9-c3e163f0dd70"), new TimeSpan(0, 1, 30, 0, 0), new Guid("4eec356c-e16c-4f83-b01a-acb228d09e35"), new DateTime(2025, 12, 23, 18, 34, 24, 298, DateTimeKind.Local).AddTicks(6300) },
                    { new Guid("5e7242b3-1798-4a69-b5c2-ce3ac97c132e"), new Guid("d546a410-ebd2-49cc-a6cf-e9e0eb3c3daa"), new TimeSpan(0, 3, 0, 0, 0), new Guid("8275540f-31af-4291-b809-373d9291c5e0"), new DateTime(2025, 12, 24, 14, 4, 24, 298, DateTimeKind.Local).AddTicks(6352) },
                    { new Guid("7c9937af-d8f8-4b61-8d95-40c8bd0f5488"), new Guid("4948faf4-935b-4d9a-800a-4e2816760d68"), new TimeSpan(0, 2, 0, 0, 0), new Guid("aea707e2-152c-44b3-b40b-e46a0a9d0047"), new DateTime(2025, 12, 23, 23, 34, 24, 298, DateTimeKind.Local).AddTicks(6334) },
                    { new Guid("86ea8960-4861-420f-a8b1-26fcff8ead54"), new Guid("aad23158-ce0b-41ac-836b-a66c0a57ce30"), new TimeSpan(0, 2, 0, 0, 0), new Guid("e5b43429-1e08-44e1-ade2-5307812fa40f"), new DateTime(2025, 12, 24, 14, 22, 24, 298, DateTimeKind.Local).AddTicks(6354) },
                    { new Guid("a037529b-b217-4f53-beea-172461c4ddc2"), new Guid("160e4ff6-8a73-4df8-be70-a97a5428ee83"), new TimeSpan(0, 3, 0, 0, 0), new Guid("e3803c2c-1d4f-4a94-b6e8-43418b11cf3d"), new DateTime(2025, 12, 23, 13, 34, 24, 298, DateTimeKind.Local).AddTicks(6332) },
                    { new Guid("a6e03ffb-f13c-452f-a818-83a411941a1b"), new Guid("4948faf4-935b-4d9a-800a-4e2816760d68"), new TimeSpan(0, 6, 0, 0, 0), new Guid("ff8c419a-401a-46b9-a544-a3d9f81e96de"), new DateTime(2025, 12, 24, 11, 34, 24, 298, DateTimeKind.Local).AddTicks(6311) },
                    { new Guid("c2f7bc0b-834d-4930-8b2b-57c9bd76e35a"), new Guid("b6ce7e19-cd47-4fd6-a531-c48e5809d555"), new TimeSpan(0, 4, 0, 0, 0), new Guid("a4029112-136c-4689-bfca-f8b64afc9b87"), new DateTime(2025, 12, 24, 6, 34, 24, 298, DateTimeKind.Local).AddTicks(6341) },
                    { new Guid("d0176ef7-5c84-4c72-b91b-b2591f9457ab"), new Guid("dfecdb38-11f8-4d75-ba9c-35787ff76810"), new TimeSpan(0, 3, 30, 0, 0), new Guid("4b45a861-d993-4f44-87c4-fac41fb6494b"), new DateTime(2025, 12, 24, 13, 34, 24, 298, DateTimeKind.Local).AddTicks(6329) },
                    { new Guid("d7ec7795-9c7a-4814-8029-f1fa336f291a"), new Guid("aad23158-ce0b-41ac-836b-a66c0a57ce30"), new TimeSpan(0, 5, 0, 0, 0), new Guid("a4029112-136c-4689-bfca-f8b64afc9b87"), new DateTime(2025, 12, 24, 9, 34, 24, 298, DateTimeKind.Local).AddTicks(6309) },
                    { new Guid("db62ab99-6af9-4620-a96f-31c9e9d99344"), new Guid("d546a410-ebd2-49cc-a6cf-e9e0eb3c3daa"), new TimeSpan(0, 2, 30, 0, 0), new Guid("81ecca56-1aef-481c-a15b-a64f43e22df0"), new DateTime(2025, 12, 24, 12, 34, 24, 298, DateTimeKind.Local).AddTicks(6326) },
                    { new Guid("f47719be-6652-488c-ac6a-b90c2da6f02a"), new Guid("80cf1be0-4bd7-40b2-9e48-b86cb56fff12"), new TimeSpan(0, 3, 0, 0, 0), new Guid("aea707e2-152c-44b3-b40b-e46a0a9d0047"), new DateTime(2025, 12, 22, 22, 34, 24, 298, DateTimeKind.Local).AddTicks(6288) },
                    { new Guid("fbc6af3c-701b-49cf-949f-41df984271cd"), new Guid("d546a410-ebd2-49cc-a6cf-e9e0eb3c3daa"), new TimeSpan(0, 5, 0, 0, 0), new Guid("4eec356c-e16c-4f83-b01a-acb228d09e35"), new DateTime(2025, 12, 24, 2, 34, 24, 298, DateTimeKind.Local).AddTicks(6337) },
                    { new Guid("fd52bef8-dbe2-43b5-b8e5-bb688c60903c"), new Guid("160e4ff6-8a73-4df8-be70-a97a5428ee83"), new TimeSpan(0, 4, 0, 0, 0), new Guid("8275540f-31af-4291-b809-373d9291c5e0"), new DateTime(2025, 12, 23, 8, 34, 24, 298, DateTimeKind.Local).AddTicks(6297) },
                    { new Guid("fe68990f-5ccf-4025-91bd-06958a0d5e83"), new Guid("2cc7ef72-0a74-4cdd-83a9-c3e163f0dd70"), new TimeSpan(0, 3, 30, 0, 0), new Guid("4b45a861-d993-4f44-87c4-fac41fb6494b"), new DateTime(2025, 12, 24, 10, 34, 24, 298, DateTimeKind.Local).AddTicks(6347) }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_rent_bike_bike_id",
                table: "rent",
                column: "bike_id",
                principalTable: "bike",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_rent_renter_renter_id",
                table: "rent",
                column: "renter_id",
                principalTable: "renter",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_rent_bike_bike_id",
                table: "rent");

            migrationBuilder.DropForeignKey(
                name: "FK_rent_renter_renter_id",
                table: "rent");

            migrationBuilder.DeleteData(
                table: "rent",
                keyColumn: "id",
                keyValue: new Guid("080e7d48-2167-4bcd-9123-1dbbf2a8f1af"));

            migrationBuilder.DeleteData(
                table: "rent",
                keyColumn: "id",
                keyValue: new Guid("2aeb83b7-11b7-45de-927d-fa53ae799ec6"));

            migrationBuilder.DeleteData(
                table: "rent",
                keyColumn: "id",
                keyValue: new Guid("31777f35-0c75-4f73-b06e-282d822c1392"));

            migrationBuilder.DeleteData(
                table: "rent",
                keyColumn: "id",
                keyValue: new Guid("37a0baf3-cc36-4d2d-ac2c-209584154ccd"));

            migrationBuilder.DeleteData(
                table: "rent",
                keyColumn: "id",
                keyValue: new Guid("4de3abf1-efc7-4a16-b34d-70375969fc3a"));

            migrationBuilder.DeleteData(
                table: "rent",
                keyColumn: "id",
                keyValue: new Guid("5e7242b3-1798-4a69-b5c2-ce3ac97c132e"));

            migrationBuilder.DeleteData(
                table: "rent",
                keyColumn: "id",
                keyValue: new Guid("7c9937af-d8f8-4b61-8d95-40c8bd0f5488"));

            migrationBuilder.DeleteData(
                table: "rent",
                keyColumn: "id",
                keyValue: new Guid("86ea8960-4861-420f-a8b1-26fcff8ead54"));

            migrationBuilder.DeleteData(
                table: "rent",
                keyColumn: "id",
                keyValue: new Guid("a037529b-b217-4f53-beea-172461c4ddc2"));

            migrationBuilder.DeleteData(
                table: "rent",
                keyColumn: "id",
                keyValue: new Guid("a6e03ffb-f13c-452f-a818-83a411941a1b"));

            migrationBuilder.DeleteData(
                table: "rent",
                keyColumn: "id",
                keyValue: new Guid("c2f7bc0b-834d-4930-8b2b-57c9bd76e35a"));

            migrationBuilder.DeleteData(
                table: "rent",
                keyColumn: "id",
                keyValue: new Guid("d0176ef7-5c84-4c72-b91b-b2591f9457ab"));

            migrationBuilder.DeleteData(
                table: "rent",
                keyColumn: "id",
                keyValue: new Guid("d7ec7795-9c7a-4814-8029-f1fa336f291a"));

            migrationBuilder.DeleteData(
                table: "rent",
                keyColumn: "id",
                keyValue: new Guid("db62ab99-6af9-4620-a96f-31c9e9d99344"));

            migrationBuilder.DeleteData(
                table: "rent",
                keyColumn: "id",
                keyValue: new Guid("f47719be-6652-488c-ac6a-b90c2da6f02a"));

            migrationBuilder.DeleteData(
                table: "rent",
                keyColumn: "id",
                keyValue: new Guid("fbc6af3c-701b-49cf-949f-41df984271cd"));

            migrationBuilder.DeleteData(
                table: "rent",
                keyColumn: "id",
                keyValue: new Guid("fd52bef8-dbe2-43b5-b8e5-bb688c60903c"));

            migrationBuilder.DeleteData(
                table: "rent",
                keyColumn: "id",
                keyValue: new Guid("fe68990f-5ccf-4025-91bd-06958a0d5e83"));

            migrationBuilder.DeleteData(
                table: "renter",
                keyColumn: "id",
                keyValue: new Guid("c2c0b965-9a05-49cb-8051-5ce6d26761af"));

            migrationBuilder.DeleteData(
                table: "bike",
                keyColumn: "id",
                keyValue: new Guid("160e4ff6-8a73-4df8-be70-a97a5428ee83"));

            migrationBuilder.DeleteData(
                table: "bike",
                keyColumn: "id",
                keyValue: new Guid("2cc7ef72-0a74-4cdd-83a9-c3e163f0dd70"));

            migrationBuilder.DeleteData(
                table: "bike",
                keyColumn: "id",
                keyValue: new Guid("4948faf4-935b-4d9a-800a-4e2816760d68"));

            migrationBuilder.DeleteData(
                table: "bike",
                keyColumn: "id",
                keyValue: new Guid("80cf1be0-4bd7-40b2-9e48-b86cb56fff12"));

            migrationBuilder.DeleteData(
                table: "bike",
                keyColumn: "id",
                keyValue: new Guid("8cdfc712-b2b0-451a-8196-358529d251ac"));

            migrationBuilder.DeleteData(
                table: "bike",
                keyColumn: "id",
                keyValue: new Guid("aad23158-ce0b-41ac-836b-a66c0a57ce30"));

            migrationBuilder.DeleteData(
                table: "bike",
                keyColumn: "id",
                keyValue: new Guid("b6ce7e19-cd47-4fd6-a531-c48e5809d555"));

            migrationBuilder.DeleteData(
                table: "bike",
                keyColumn: "id",
                keyValue: new Guid("d546a410-ebd2-49cc-a6cf-e9e0eb3c3daa"));

            migrationBuilder.DeleteData(
                table: "bike",
                keyColumn: "id",
                keyValue: new Guid("dfecdb38-11f8-4d75-ba9c-35787ff76810"));

            migrationBuilder.DeleteData(
                table: "bike",
                keyColumn: "id",
                keyValue: new Guid("f7ea642e-c7d8-4a66-9660-757e1d55e1f2"));

            migrationBuilder.DeleteData(
                table: "renter",
                keyColumn: "id",
                keyValue: new Guid("4b45a861-d993-4f44-87c4-fac41fb6494b"));

            migrationBuilder.DeleteData(
                table: "renter",
                keyColumn: "id",
                keyValue: new Guid("4eec356c-e16c-4f83-b01a-acb228d09e35"));

            migrationBuilder.DeleteData(
                table: "renter",
                keyColumn: "id",
                keyValue: new Guid("81ecca56-1aef-481c-a15b-a64f43e22df0"));

            migrationBuilder.DeleteData(
                table: "renter",
                keyColumn: "id",
                keyValue: new Guid("8275540f-31af-4291-b809-373d9291c5e0"));

            migrationBuilder.DeleteData(
                table: "renter",
                keyColumn: "id",
                keyValue: new Guid("a4029112-136c-4689-bfca-f8b64afc9b87"));

            migrationBuilder.DeleteData(
                table: "renter",
                keyColumn: "id",
                keyValue: new Guid("aea707e2-152c-44b3-b40b-e46a0a9d0047"));

            migrationBuilder.DeleteData(
                table: "renter",
                keyColumn: "id",
                keyValue: new Guid("e3803c2c-1d4f-4a94-b6e8-43418b11cf3d"));

            migrationBuilder.DeleteData(
                table: "renter",
                keyColumn: "id",
                keyValue: new Guid("e5b43429-1e08-44e1-ade2-5307812fa40f"));

            migrationBuilder.DeleteData(
                table: "renter",
                keyColumn: "id",
                keyValue: new Guid("ff8c419a-401a-46b9-a544-a3d9f81e96de"));

            migrationBuilder.DeleteData(
                table: "model",
                keyColumn: "id",
                keyValue: new Guid("2b22dd33-eccf-4f04-a52c-4ac4df78720b"));

            migrationBuilder.DeleteData(
                table: "model",
                keyColumn: "id",
                keyValue: new Guid("4d46e705-4b64-40d3-8883-f12934993abc"));

            migrationBuilder.DeleteData(
                table: "model",
                keyColumn: "id",
                keyValue: new Guid("671e5425-28a2-4d9f-bc07-5dd81f8f3c64"));

            migrationBuilder.DeleteData(
                table: "model",
                keyColumn: "id",
                keyValue: new Guid("6a9c0efe-2bc0-4e64-9c4f-fdc9fff23108"));

            migrationBuilder.DeleteData(
                table: "model",
                keyColumn: "id",
                keyValue: new Guid("8dea56e8-6982-4339-8a8b-5b08b43e36be"));

            migrationBuilder.DeleteData(
                table: "model",
                keyColumn: "id",
                keyValue: new Guid("b5b6735d-45fa-4c62-b653-db81f7121d84"));

            migrationBuilder.DeleteData(
                table: "model",
                keyColumn: "id",
                keyValue: new Guid("b8061bf4-0826-43e6-9cbc-41ee8452d755"));

            migrationBuilder.DeleteData(
                table: "model",
                keyColumn: "id",
                keyValue: new Guid("e2ad9828-414d-409e-b3e1-344ff44b19c1"));

            migrationBuilder.DeleteData(
                table: "model",
                keyColumn: "id",
                keyValue: new Guid("e45334d8-7bd4-4d04-ba7a-9a382185c4f9"));

            migrationBuilder.DeleteData(
                table: "model",
                keyColumn: "id",
                keyValue: new Guid("e7c23725-116a-4e40-a1cc-660a5373d188"));

            migrationBuilder.InsertData(
                table: "model",
                columns: new[] { "id", "bike_type", "bike_weight", "brake_type", "max_passenger_weight", "model_year", "price_per_hour", "wheel_size" },
                values: new object[,]
                {
                    { new Guid("1a96f120-7e4e-4e36-a536-07aa6df6112c"), 1, 11.0, 0, 110.0, 2021, 10m, 26.0 },
                    { new Guid("49e4174e-b015-4340-a0fc-dfef5947961a"), 0, 12.0, 1, 120.0, 2025, 17m, 28.0 },
                    { new Guid("81baa0bc-eef3-4797-ba5a-d8e4d862a37a"), 3, 14.0, 1, 100.0, 2024, 16m, 26.0 },
                    { new Guid("a72e8761-ee46-4c3d-a7e0-0d6b17523f16"), 2, 11.0, 0, 95.0, 2021, 11m, 27.0 },
                    { new Guid("aadbd9ee-2517-40f8-9db3-a1161a6c16a5"), 0, 9.0, 1, 100.0, 2022, 12m, 28.0 },
                    { new Guid("c87a3abb-ff4d-45ed-a9d0-88055b9673cf"), 4, 8.0, 3, 80.0, 2019, 8m, 24.0 },
                    { new Guid("e0350b2c-8f99-49d5-b4eb-4f1165b87abc"), 1, 13.0, 1, 120.0, 2023, 15m, 29.0 },
                    { new Guid("ec369c47-c55e-4825-8a3d-438949233514"), 0, 12.0, 2, 100.0, 2024, 14m, 28.0 },
                    { new Guid("ec4c0299-7e52-44cb-9fd9-9fd8f2990232"), 2, 10.0, 0, 90.0, 2020, 9m, 27.5 },
                    { new Guid("fb93836e-474f-48f7-b8fd-2eb25b21f30d"), 1, 15.0, 5, 130.0, 2023, 13m, 29.0 }
                });

            migrationBuilder.InsertData(
                table: "renter",
                columns: new[] { "id", "last_name", "middle_name", "name", "phone_number" },
                values: new object[,]
                {
                    { new Guid("1c9e5593-74e4-4f32-bb1a-aa65013e9749"), "Федоров", "Владимирович", "Федор", "888-888" },
                    { new Guid("3ac86426-26df-46cb-b4f2-576f442d104e"), "Никитин", "Андреевич", "Никита", "777-777" },
                    { new Guid("590c9949-a9d3-4084-81b4-d2b5c59cc0e7"), "Петров", "Петрович", "Петр", "222-222" },
                    { new Guid("682bfc31-dc6f-42db-ac47-233ab1aba084"), "Васильев", "Павлович", "Василий", "555-555" },
                    { new Guid("9bf4355d-d000-4822-9bd1-dea296610a3a"), "Сидоров", "Сидорович", "Сидор", "333-333" },
                    { new Guid("9cec14bf-3470-4394-9899-fdf3519f699f"), "Иванов", "Иванович", "Иван", "111-111" },
                    { new Guid("9d22c91c-85c9-44ac-85d6-2d0cf9c0513c"), "Смирнов", "Валерьевич", "Семен", "999-999" },
                    { new Guid("b7491013-1f84-4866-a8e7-730c226c3659"), "Попов", "Алексеевич", "Дмитрий", "000-000" },
                    { new Guid("cf7dcad8-2859-4f7e-95c1-c1471d134db0"), "Кузнецов", "Игоревич", "Сергей", "666-666" },
                    { new Guid("d8abaf64-e960-486d-a064-7134dc4c0522"), "Алексеев", "Николаевич", "Алексей", "444-444" }
                });

            migrationBuilder.InsertData(
                table: "bike",
                columns: new[] { "id", "color", "model_id", "serial_number" },
                values: new object[,]
                {
                    { new Guid("279902b6-a996-4fe1-8de8-0f36cfcff3eb"), "White", new Guid("ec369c47-c55e-4825-8a3d-438949233514"), "105" },
                    { new Guid("2ff0d2de-a373-41ae-8018-f08f2590ec88"), "Yellow", new Guid("c87a3abb-ff4d-45ed-a9d0-88055b9673cf"), "106" },
                    { new Guid("36358c4c-8620-4fb5-9502-e1ea23d0d3e1"), "Purple", new Guid("49e4174e-b015-4340-a0fc-dfef5947961a"), "110" },
                    { new Guid("3c43bc36-34e8-4fe3-ba3d-9b52777c6976"), "Silver", new Guid("81baa0bc-eef3-4797-ba5a-d8e4d862a37a"), "107" },
                    { new Guid("61865875-b804-4baa-8b2a-3260e62b84f3"), "Orange", new Guid("a72e8761-ee46-4c3d-a7e0-0d6b17523f16"), "109" },
                    { new Guid("745b41c8-ca80-427c-9e86-152b5a1ba5f4"), "Blue", new Guid("1a96f120-7e4e-4e36-a536-07aa6df6112c"), "102" },
                    { new Guid("80d70b89-4692-4eda-9492-cf898aac545d"), "Black", new Guid("e0350b2c-8f99-49d5-b4eb-4f1165b87abc"), "103" },
                    { new Guid("9ca5637c-9c10-419e-9c35-db2d523f5b08"), "Green", new Guid("ec4c0299-7e52-44cb-9fd9-9fd8f2990232"), "104" },
                    { new Guid("d76ea574-e417-4567-a4b3-fd59c314d391"), "Red", new Guid("aadbd9ee-2517-40f8-9db3-a1161a6c16a5"), "101" },
                    { new Guid("e2330abb-386b-45fe-8c3b-52ec852dee1f"), "Gray", new Guid("fb93836e-474f-48f7-b8fd-2eb25b21f30d"), "108" }
                });

            migrationBuilder.InsertData(
                table: "rent",
                columns: new[] { "id", "bike_id", "duration", "renter_id", "start_time" },
                values: new object[,]
                {
                    { new Guid("06ba3375-11d9-49b3-9db5-73703c4b24b0"), new Guid("e2330abb-386b-45fe-8c3b-52ec852dee1f"), new TimeSpan(0, 3, 0, 0, 0), new Guid("9bf4355d-d000-4822-9bd1-dea296610a3a"), new DateTime(2025, 11, 24, 22, 57, 17, 176, DateTimeKind.Local).AddTicks(7042) },
                    { new Guid("13a97ac3-4746-43bc-b4b7-d4cba1edd39b"), new Guid("3c43bc36-34e8-4fe3-ba3d-9b52777c6976"), new TimeSpan(0, 6, 0, 0, 0), new Guid("3ac86426-26df-46cb-b4f2-576f442d104e"), new DateTime(2025, 11, 24, 20, 27, 17, 176, DateTimeKind.Local).AddTicks(7025) },
                    { new Guid("3693a260-f88c-4fea-8535-250979eda36f"), new Guid("279902b6-a996-4fe1-8de8-0f36cfcff3eb"), new TimeSpan(0, 2, 30, 0, 0), new Guid("682bfc31-dc6f-42db-ac47-233ab1aba084"), new DateTime(2025, 11, 24, 13, 27, 17, 176, DateTimeKind.Local).AddTicks(7022) },
                    { new Guid("447a3edb-7bd9-4467-bdd4-b713d189d934"), new Guid("279902b6-a996-4fe1-8de8-0f36cfcff3eb"), new TimeSpan(0, 4, 0, 0, 0), new Guid("cf7dcad8-2859-4f7e-95c1-c1471d134db0"), new DateTime(2025, 11, 24, 15, 27, 17, 176, DateTimeKind.Local).AddTicks(7036) },
                    { new Guid("45467e33-19f4-4465-8dee-8e55be3c6a19"), new Guid("2ff0d2de-a373-41ae-8018-f08f2590ec88"), new TimeSpan(0, 2, 30, 0, 0), new Guid("1c9e5593-74e4-4f32-bb1a-aa65013e9749"), new DateTime(2025, 11, 24, 17, 27, 17, 176, DateTimeKind.Local).AddTicks(7037) },
                    { new Guid("46de07ab-24f5-497d-9d1f-78512c0ab9f6"), new Guid("36358c4c-8620-4fb5-9502-e1ea23d0d3e1"), new TimeSpan(0, 2, 0, 0, 0), new Guid("9cec14bf-3470-4394-9899-fdf3519f699f"), new DateTime(2025, 11, 24, 21, 57, 17, 176, DateTimeKind.Local).AddTicks(7040) },
                    { new Guid("62953104-b9e1-4021-88a2-63f7b78ed558"), new Guid("e2330abb-386b-45fe-8c3b-52ec852dee1f"), new TimeSpan(0, 5, 0, 0, 0), new Guid("d8abaf64-e960-486d-a064-7134dc4c0522"), new DateTime(2025, 11, 24, 11, 27, 17, 176, DateTimeKind.Local).AddTicks(7034) },
                    { new Guid("6957a893-bdee-4e3d-9c19-22bbd4b04710"), new Guid("80d70b89-4692-4eda-9492-cf898aac545d"), new TimeSpan(0, 3, 0, 0, 0), new Guid("9cec14bf-3470-4394-9899-fdf3519f699f"), new DateTime(2025, 11, 23, 22, 27, 17, 176, DateTimeKind.Local).AddTicks(7031) },
                    { new Guid("7799b9fa-cc36-4ce8-ac54-be35ae864392"), new Guid("2ff0d2de-a373-41ae-8018-f08f2590ec88"), new TimeSpan(0, 5, 0, 0, 0), new Guid("cf7dcad8-2859-4f7e-95c1-c1471d134db0"), new DateTime(2025, 11, 24, 18, 27, 17, 176, DateTimeKind.Local).AddTicks(7023) },
                    { new Guid("7d833f9a-1bf3-4191-950b-d724fc3af9a1"), new Guid("61865875-b804-4baa-8b2a-3260e62b84f3"), new TimeSpan(0, 3, 30, 0, 0), new Guid("9d22c91c-85c9-44ac-85d6-2d0cf9c0513c"), new DateTime(2025, 11, 24, 22, 27, 17, 176, DateTimeKind.Local).AddTicks(7028) },
                    { new Guid("86dd46d2-d590-453c-ab9a-47a498917b81"), new Guid("9ca5637c-9c10-419e-9c35-db2d523f5b08"), new TimeSpan(0, 1, 30, 0, 0), new Guid("d8abaf64-e960-486d-a064-7134dc4c0522"), new DateTime(2025, 11, 24, 3, 27, 17, 176, DateTimeKind.Local).AddTicks(7020) },
                    { new Guid("8825d79f-eb62-4d72-bef2-366e86bd0ed7"), new Guid("80d70b89-4692-4eda-9492-cf898aac545d"), new TimeSpan(0, 4, 0, 0, 0), new Guid("9bf4355d-d000-4822-9bd1-dea296610a3a"), new DateTime(2025, 11, 23, 17, 27, 17, 176, DateTimeKind.Local).AddTicks(7007) },
                    { new Guid("afd870f1-6346-42fe-bc98-836f32e16849"), new Guid("9ca5637c-9c10-419e-9c35-db2d523f5b08"), new TimeSpan(0, 3, 30, 0, 0), new Guid("9d22c91c-85c9-44ac-85d6-2d0cf9c0513c"), new DateTime(2025, 11, 24, 19, 27, 17, 176, DateTimeKind.Local).AddTicks(7039) },
                    { new Guid("b7cd534b-1b61-4e3c-b6a2-74e0c79a86c7"), new Guid("2ff0d2de-a373-41ae-8018-f08f2590ec88"), new TimeSpan(0, 2, 0, 0, 0), new Guid("682bfc31-dc6f-42db-ac47-233ab1aba084"), new DateTime(2025, 11, 24, 23, 15, 17, 176, DateTimeKind.Local).AddTicks(7044) },
                    { new Guid("d389a5a6-d398-46f2-a5c3-730f75d41553"), new Guid("e2330abb-386b-45fe-8c3b-52ec852dee1f"), new TimeSpan(0, 2, 30, 0, 0), new Guid("1c9e5593-74e4-4f32-bb1a-aa65013e9749"), new DateTime(2025, 11, 24, 21, 27, 17, 176, DateTimeKind.Local).AddTicks(7027) },
                    { new Guid("d44dc785-ed28-4259-8c64-0de1f1768277"), new Guid("3c43bc36-34e8-4fe3-ba3d-9b52777c6976"), new TimeSpan(0, 2, 0, 0, 0), new Guid("590c9949-a9d3-4084-81b4-d2b5c59cc0e7"), new DateTime(2025, 11, 24, 8, 27, 17, 176, DateTimeKind.Local).AddTicks(7033) },
                    { new Guid("d56a4c5a-3c15-4886-8fd4-73fec0a831b3"), new Guid("d76ea574-e417-4567-a4b3-fd59c314d391"), new TimeSpan(0, 2, 0, 0, 0), new Guid("9cec14bf-3470-4394-9899-fdf3519f699f"), new DateTime(2025, 11, 22, 21, 27, 17, 176, DateTimeKind.Local).AddTicks(6419) },
                    { new Guid("fa62f9da-bbc4-40dc-b24f-97d190aa20bc"), new Guid("745b41c8-ca80-427c-9e86-152b5a1ba5f4"), new TimeSpan(0, 3, 0, 0, 0), new Guid("590c9949-a9d3-4084-81b4-d2b5c59cc0e7"), new DateTime(2025, 11, 23, 7, 27, 17, 176, DateTimeKind.Local).AddTicks(7003) }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_rent_bike_bike_id",
                table: "rent",
                column: "bike_id",
                principalTable: "bike",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_rent_renter_renter_id",
                table: "rent",
                column: "renter_id",
                principalTable: "renter",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
