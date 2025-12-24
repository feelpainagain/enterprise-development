using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BikeRentalPoint.Infrastructure.EfCore.Migrations
{
    /// <inheritdoc />
    public partial class SyncModelSnapshot : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                    { new Guid("001e6fcd-5a65-4592-8475-598bae3421bc"), 0, 12.0, 2, 100.0, 2024, 14m, 28.0 },
                    { new Guid("01c16a54-51b0-4e1d-baa0-cbd9edfb1e68"), 1, 11.0, 0, 110.0, 2021, 10m, 26.0 },
                    { new Guid("223d4e89-84d2-4606-88db-5cbb6649dbfc"), 1, 15.0, 5, 130.0, 2023, 13m, 29.0 },
                    { new Guid("26af4f3e-a8ce-4780-ba61-11c1b02e8c8f"), 0, 9.0, 1, 100.0, 2022, 12m, 28.0 },
                    { new Guid("29a4a967-f786-460b-aa3a-09fe77ebc4cd"), 2, 10.0, 0, 90.0, 2020, 9m, 27.5 },
                    { new Guid("57454149-3d5f-46f7-ad67-59c9c20e4b8a"), 0, 12.0, 1, 120.0, 2025, 17m, 28.0 },
                    { new Guid("86571f83-df76-49d4-8066-3d778049c98d"), 4, 8.0, 3, 80.0, 2019, 8m, 24.0 },
                    { new Guid("950a5ff4-beb7-42ae-9fe2-bc6a351fe380"), 3, 14.0, 1, 100.0, 2024, 16m, 26.0 },
                    { new Guid("ab60dde3-c3b4-4424-98a5-523596d84e49"), 1, 13.0, 1, 120.0, 2023, 15m, 29.0 },
                    { new Guid("ed8f35b4-7af5-4681-a8a7-b18d0227f3aa"), 2, 11.0, 0, 95.0, 2021, 11m, 27.0 }
                });

            migrationBuilder.InsertData(
                table: "renter",
                columns: new[] { "id", "last_name", "middle_name", "name", "phone_number" },
                values: new object[,]
                {
                    { new Guid("027ed055-e56d-489d-9c3f-7f842632c3f7"), "Алексеев", "Николаевич", "Алексей", "444-444" },
                    { new Guid("0841a662-5040-447a-8691-bc4e7f3368a4"), "Сидоров", "Сидорович", "Сидор", "333-333" },
                    { new Guid("714ac5c6-ba03-4139-9800-10fb23d2c067"), "Кузнецов", "Игоревич", "Сергей", "666-666" },
                    { new Guid("72da748d-2127-42ce-8171-9343bb8e2658"), "Никитин", "Андреевич", "Никита", "777-777" },
                    { new Guid("743960e3-0371-47c8-80f5-c62f461decaf"), "Петров", "Петрович", "Петр", "222-222" },
                    { new Guid("a46b03d5-195b-4dfd-9958-a89d1c4094d2"), "Васильев", "Павлович", "Василий", "555-555" },
                    { new Guid("ba0fade0-8861-4f6f-b308-238883bb2909"), "Смирнов", "Валерьевич", "Семен", "999-999" },
                    { new Guid("bbc8ef69-6b1a-4d19-bf96-72dbf6a3b86d"), "Иванов", "Иванович", "Иван", "111-111" },
                    { new Guid("c3ace681-d7cc-4f78-8986-17177396f976"), "Попов", "Алексеевич", "Дмитрий", "000-000" },
                    { new Guid("c6d08001-9232-471e-a82e-f5da8f461ce6"), "Федоров", "Владимирович", "Федор", "888-888" }
                });

            migrationBuilder.InsertData(
                table: "bike",
                columns: new[] { "id", "color", "model_id", "serial_number" },
                values: new object[,]
                {
                    { new Guid("1d12d97a-593b-4a03-b151-d65bf8aa3a84"), "Yellow", new Guid("86571f83-df76-49d4-8066-3d778049c98d"), "106" },
                    { new Guid("3d57e48d-c20b-4beb-bf0f-0050a490fa4c"), "Silver", new Guid("950a5ff4-beb7-42ae-9fe2-bc6a351fe380"), "107" },
                    { new Guid("610365e0-c878-4296-a66f-e901fb12bbaa"), "Blue", new Guid("01c16a54-51b0-4e1d-baa0-cbd9edfb1e68"), "102" },
                    { new Guid("623f5102-30c6-4b97-a492-f6ad9bc6cd20"), "Black", new Guid("ab60dde3-c3b4-4424-98a5-523596d84e49"), "103" },
                    { new Guid("6e872a9a-bacb-4d0d-baa0-b72af61a56a7"), "Orange", new Guid("ed8f35b4-7af5-4681-a8a7-b18d0227f3aa"), "109" },
                    { new Guid("7cbe88b3-efd6-43d3-abf3-ac8e8d9ea158"), "Red", new Guid("26af4f3e-a8ce-4780-ba61-11c1b02e8c8f"), "101" },
                    { new Guid("9a49bfd3-fe3b-43f5-a884-fb2136488f54"), "Purple", new Guid("57454149-3d5f-46f7-ad67-59c9c20e4b8a"), "110" },
                    { new Guid("ad3afcbe-6b97-4b96-8ba2-deaf5d2c53b5"), "Green", new Guid("29a4a967-f786-460b-aa3a-09fe77ebc4cd"), "104" },
                    { new Guid("b60d7365-728c-4801-984b-45f47a23876d"), "White", new Guid("001e6fcd-5a65-4592-8475-598bae3421bc"), "105" },
                    { new Guid("c39de33e-b0fe-4ec8-bb97-02dcd929528c"), "Gray", new Guid("223d4e89-84d2-4606-88db-5cbb6649dbfc"), "108" }
                });

            migrationBuilder.InsertData(
                table: "rent",
                columns: new[] { "id", "bike_id", "duration", "renter_id", "start_time" },
                values: new object[,]
                {
                    { new Guid("03dad402-2417-4efc-976c-59e0150beae2"), new Guid("9a49bfd3-fe3b-43f5-a884-fb2136488f54"), new TimeSpan(0, 2, 0, 0, 0), new Guid("bbc8ef69-6b1a-4d19-bf96-72dbf6a3b86d"), new DateTime(2025, 12, 24, 13, 8, 21, 354, DateTimeKind.Local).AddTicks(1699) },
                    { new Guid("0989bc71-2c42-4cfd-bcaa-b95ab9c1c195"), new Guid("1d12d97a-593b-4a03-b151-d65bf8aa3a84"), new TimeSpan(0, 2, 0, 0, 0), new Guid("a46b03d5-195b-4dfd-9958-a89d1c4094d2"), new DateTime(2025, 12, 24, 14, 26, 21, 354, DateTimeKind.Local).AddTicks(1706) },
                    { new Guid("12a23d94-4b4f-4bec-9d7c-86093a2eec78"), new Guid("c39de33e-b0fe-4ec8-bb97-02dcd929528c"), new TimeSpan(0, 5, 0, 0, 0), new Guid("027ed055-e56d-489d-9c3f-7f842632c3f7"), new DateTime(2025, 12, 24, 2, 38, 21, 354, DateTimeKind.Local).AddTicks(1688) },
                    { new Guid("2414c2de-fd19-4d38-a4ca-45d664cf71ce"), new Guid("ad3afcbe-6b97-4b96-8ba2-deaf5d2c53b5"), new TimeSpan(0, 1, 30, 0, 0), new Guid("027ed055-e56d-489d-9c3f-7f842632c3f7"), new DateTime(2025, 12, 23, 18, 38, 21, 354, DateTimeKind.Local).AddTicks(1664) },
                    { new Guid("4990a0d6-9b8c-431f-814b-c7da104fd90e"), new Guid("1d12d97a-593b-4a03-b151-d65bf8aa3a84"), new TimeSpan(0, 2, 30, 0, 0), new Guid("c6d08001-9232-471e-a82e-f5da8f461ce6"), new DateTime(2025, 12, 24, 8, 38, 21, 354, DateTimeKind.Local).AddTicks(1694) },
                    { new Guid("56951888-d020-41bb-929a-88020ac64842"), new Guid("6e872a9a-bacb-4d0d-baa0-b72af61a56a7"), new TimeSpan(0, 3, 30, 0, 0), new Guid("ba0fade0-8861-4f6f-b308-238883bb2909"), new DateTime(2025, 12, 24, 13, 38, 21, 354, DateTimeKind.Local).AddTicks(1678) },
                    { new Guid("7e0cfe15-d60c-4eb2-94b8-2234266d6331"), new Guid("623f5102-30c6-4b97-a492-f6ad9bc6cd20"), new TimeSpan(0, 3, 0, 0, 0), new Guid("bbc8ef69-6b1a-4d19-bf96-72dbf6a3b86d"), new DateTime(2025, 12, 23, 13, 38, 21, 354, DateTimeKind.Local).AddTicks(1683) },
                    { new Guid("a23dfdd1-45c2-4191-b768-9f5d5f869929"), new Guid("c39de33e-b0fe-4ec8-bb97-02dcd929528c"), new TimeSpan(0, 2, 30, 0, 0), new Guid("c6d08001-9232-471e-a82e-f5da8f461ce6"), new DateTime(2025, 12, 24, 12, 38, 21, 354, DateTimeKind.Local).AddTicks(1675) },
                    { new Guid("a3ce076e-bec2-4329-95d3-5b6b8fb3fe92"), new Guid("610365e0-c878-4296-a66f-e901fb12bbaa"), new TimeSpan(0, 3, 0, 0, 0), new Guid("743960e3-0371-47c8-80f5-c62f461decaf"), new DateTime(2025, 12, 22, 22, 38, 21, 354, DateTimeKind.Local).AddTicks(1652) },
                    { new Guid("addd5449-33e9-4e1b-80b6-47e1457e6164"), new Guid("c39de33e-b0fe-4ec8-bb97-02dcd929528c"), new TimeSpan(0, 3, 0, 0, 0), new Guid("0841a662-5040-447a-8691-bc4e7f3368a4"), new DateTime(2025, 12, 24, 14, 8, 21, 354, DateTimeKind.Local).AddTicks(1702) },
                    { new Guid("b9771db7-09ce-426b-8b10-ab23548f46b8"), new Guid("3d57e48d-c20b-4beb-bf0f-0050a490fa4c"), new TimeSpan(0, 2, 0, 0, 0), new Guid("743960e3-0371-47c8-80f5-c62f461decaf"), new DateTime(2025, 12, 23, 23, 38, 21, 354, DateTimeKind.Local).AddTicks(1685) },
                    { new Guid("c380d0db-8558-4f2f-83a6-ae01b2425f15"), new Guid("623f5102-30c6-4b97-a492-f6ad9bc6cd20"), new TimeSpan(0, 4, 0, 0, 0), new Guid("0841a662-5040-447a-8691-bc4e7f3368a4"), new DateTime(2025, 12, 23, 8, 38, 21, 354, DateTimeKind.Local).AddTicks(1659) },
                    { new Guid("cea82580-1108-4416-bcf9-8dc19b749cf5"), new Guid("3d57e48d-c20b-4beb-bf0f-0050a490fa4c"), new TimeSpan(0, 6, 0, 0, 0), new Guid("72da748d-2127-42ce-8171-9343bb8e2658"), new DateTime(2025, 12, 24, 11, 38, 21, 354, DateTimeKind.Local).AddTicks(1673) },
                    { new Guid("d0e5f183-638a-45a0-8c9f-05761b6d7558"), new Guid("1d12d97a-593b-4a03-b151-d65bf8aa3a84"), new TimeSpan(0, 5, 0, 0, 0), new Guid("714ac5c6-ba03-4139-9800-10fb23d2c067"), new DateTime(2025, 12, 24, 9, 38, 21, 354, DateTimeKind.Local).AddTicks(1670) },
                    { new Guid("db9a469b-7715-4d1d-9381-69c23a954c5f"), new Guid("7cbe88b3-efd6-43d3-abf3-ac8e8d9ea158"), new TimeSpan(0, 2, 0, 0, 0), new Guid("bbc8ef69-6b1a-4d19-bf96-72dbf6a3b86d"), new DateTime(2025, 12, 22, 12, 38, 21, 354, DateTimeKind.Local).AddTicks(763) },
                    { new Guid("dfae4011-d364-419b-991d-5c39facfd611"), new Guid("b60d7365-728c-4801-984b-45f47a23876d"), new TimeSpan(0, 4, 0, 0, 0), new Guid("714ac5c6-ba03-4139-9800-10fb23d2c067"), new DateTime(2025, 12, 24, 6, 38, 21, 354, DateTimeKind.Local).AddTicks(1691) },
                    { new Guid("eb21a9f9-14cd-41b4-b668-4682ca1dba75"), new Guid("ad3afcbe-6b97-4b96-8ba2-deaf5d2c53b5"), new TimeSpan(0, 3, 30, 0, 0), new Guid("ba0fade0-8861-4f6f-b308-238883bb2909"), new DateTime(2025, 12, 24, 10, 38, 21, 354, DateTimeKind.Local).AddTicks(1697) },
                    { new Guid("fc380d30-e92d-4178-8f32-b9f3466529a5"), new Guid("b60d7365-728c-4801-984b-45f47a23876d"), new TimeSpan(0, 2, 30, 0, 0), new Guid("a46b03d5-195b-4dfd-9958-a89d1c4094d2"), new DateTime(2025, 12, 24, 4, 38, 21, 354, DateTimeKind.Local).AddTicks(1667) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "rent",
                keyColumn: "id",
                keyValue: new Guid("03dad402-2417-4efc-976c-59e0150beae2"));

            migrationBuilder.DeleteData(
                table: "rent",
                keyColumn: "id",
                keyValue: new Guid("0989bc71-2c42-4cfd-bcaa-b95ab9c1c195"));

            migrationBuilder.DeleteData(
                table: "rent",
                keyColumn: "id",
                keyValue: new Guid("12a23d94-4b4f-4bec-9d7c-86093a2eec78"));

            migrationBuilder.DeleteData(
                table: "rent",
                keyColumn: "id",
                keyValue: new Guid("2414c2de-fd19-4d38-a4ca-45d664cf71ce"));

            migrationBuilder.DeleteData(
                table: "rent",
                keyColumn: "id",
                keyValue: new Guid("4990a0d6-9b8c-431f-814b-c7da104fd90e"));

            migrationBuilder.DeleteData(
                table: "rent",
                keyColumn: "id",
                keyValue: new Guid("56951888-d020-41bb-929a-88020ac64842"));

            migrationBuilder.DeleteData(
                table: "rent",
                keyColumn: "id",
                keyValue: new Guid("7e0cfe15-d60c-4eb2-94b8-2234266d6331"));

            migrationBuilder.DeleteData(
                table: "rent",
                keyColumn: "id",
                keyValue: new Guid("a23dfdd1-45c2-4191-b768-9f5d5f869929"));

            migrationBuilder.DeleteData(
                table: "rent",
                keyColumn: "id",
                keyValue: new Guid("a3ce076e-bec2-4329-95d3-5b6b8fb3fe92"));

            migrationBuilder.DeleteData(
                table: "rent",
                keyColumn: "id",
                keyValue: new Guid("addd5449-33e9-4e1b-80b6-47e1457e6164"));

            migrationBuilder.DeleteData(
                table: "rent",
                keyColumn: "id",
                keyValue: new Guid("b9771db7-09ce-426b-8b10-ab23548f46b8"));

            migrationBuilder.DeleteData(
                table: "rent",
                keyColumn: "id",
                keyValue: new Guid("c380d0db-8558-4f2f-83a6-ae01b2425f15"));

            migrationBuilder.DeleteData(
                table: "rent",
                keyColumn: "id",
                keyValue: new Guid("cea82580-1108-4416-bcf9-8dc19b749cf5"));

            migrationBuilder.DeleteData(
                table: "rent",
                keyColumn: "id",
                keyValue: new Guid("d0e5f183-638a-45a0-8c9f-05761b6d7558"));

            migrationBuilder.DeleteData(
                table: "rent",
                keyColumn: "id",
                keyValue: new Guid("db9a469b-7715-4d1d-9381-69c23a954c5f"));

            migrationBuilder.DeleteData(
                table: "rent",
                keyColumn: "id",
                keyValue: new Guid("dfae4011-d364-419b-991d-5c39facfd611"));

            migrationBuilder.DeleteData(
                table: "rent",
                keyColumn: "id",
                keyValue: new Guid("eb21a9f9-14cd-41b4-b668-4682ca1dba75"));

            migrationBuilder.DeleteData(
                table: "rent",
                keyColumn: "id",
                keyValue: new Guid("fc380d30-e92d-4178-8f32-b9f3466529a5"));

            migrationBuilder.DeleteData(
                table: "renter",
                keyColumn: "id",
                keyValue: new Guid("c3ace681-d7cc-4f78-8986-17177396f976"));

            migrationBuilder.DeleteData(
                table: "bike",
                keyColumn: "id",
                keyValue: new Guid("1d12d97a-593b-4a03-b151-d65bf8aa3a84"));

            migrationBuilder.DeleteData(
                table: "bike",
                keyColumn: "id",
                keyValue: new Guid("3d57e48d-c20b-4beb-bf0f-0050a490fa4c"));

            migrationBuilder.DeleteData(
                table: "bike",
                keyColumn: "id",
                keyValue: new Guid("610365e0-c878-4296-a66f-e901fb12bbaa"));

            migrationBuilder.DeleteData(
                table: "bike",
                keyColumn: "id",
                keyValue: new Guid("623f5102-30c6-4b97-a492-f6ad9bc6cd20"));

            migrationBuilder.DeleteData(
                table: "bike",
                keyColumn: "id",
                keyValue: new Guid("6e872a9a-bacb-4d0d-baa0-b72af61a56a7"));

            migrationBuilder.DeleteData(
                table: "bike",
                keyColumn: "id",
                keyValue: new Guid("7cbe88b3-efd6-43d3-abf3-ac8e8d9ea158"));

            migrationBuilder.DeleteData(
                table: "bike",
                keyColumn: "id",
                keyValue: new Guid("9a49bfd3-fe3b-43f5-a884-fb2136488f54"));

            migrationBuilder.DeleteData(
                table: "bike",
                keyColumn: "id",
                keyValue: new Guid("ad3afcbe-6b97-4b96-8ba2-deaf5d2c53b5"));

            migrationBuilder.DeleteData(
                table: "bike",
                keyColumn: "id",
                keyValue: new Guid("b60d7365-728c-4801-984b-45f47a23876d"));

            migrationBuilder.DeleteData(
                table: "bike",
                keyColumn: "id",
                keyValue: new Guid("c39de33e-b0fe-4ec8-bb97-02dcd929528c"));

            migrationBuilder.DeleteData(
                table: "renter",
                keyColumn: "id",
                keyValue: new Guid("027ed055-e56d-489d-9c3f-7f842632c3f7"));

            migrationBuilder.DeleteData(
                table: "renter",
                keyColumn: "id",
                keyValue: new Guid("0841a662-5040-447a-8691-bc4e7f3368a4"));

            migrationBuilder.DeleteData(
                table: "renter",
                keyColumn: "id",
                keyValue: new Guid("714ac5c6-ba03-4139-9800-10fb23d2c067"));

            migrationBuilder.DeleteData(
                table: "renter",
                keyColumn: "id",
                keyValue: new Guid("72da748d-2127-42ce-8171-9343bb8e2658"));

            migrationBuilder.DeleteData(
                table: "renter",
                keyColumn: "id",
                keyValue: new Guid("743960e3-0371-47c8-80f5-c62f461decaf"));

            migrationBuilder.DeleteData(
                table: "renter",
                keyColumn: "id",
                keyValue: new Guid("a46b03d5-195b-4dfd-9958-a89d1c4094d2"));

            migrationBuilder.DeleteData(
                table: "renter",
                keyColumn: "id",
                keyValue: new Guid("ba0fade0-8861-4f6f-b308-238883bb2909"));

            migrationBuilder.DeleteData(
                table: "renter",
                keyColumn: "id",
                keyValue: new Guid("bbc8ef69-6b1a-4d19-bf96-72dbf6a3b86d"));

            migrationBuilder.DeleteData(
                table: "renter",
                keyColumn: "id",
                keyValue: new Guid("c6d08001-9232-471e-a82e-f5da8f461ce6"));

            migrationBuilder.DeleteData(
                table: "model",
                keyColumn: "id",
                keyValue: new Guid("001e6fcd-5a65-4592-8475-598bae3421bc"));

            migrationBuilder.DeleteData(
                table: "model",
                keyColumn: "id",
                keyValue: new Guid("01c16a54-51b0-4e1d-baa0-cbd9edfb1e68"));

            migrationBuilder.DeleteData(
                table: "model",
                keyColumn: "id",
                keyValue: new Guid("223d4e89-84d2-4606-88db-5cbb6649dbfc"));

            migrationBuilder.DeleteData(
                table: "model",
                keyColumn: "id",
                keyValue: new Guid("26af4f3e-a8ce-4780-ba61-11c1b02e8c8f"));

            migrationBuilder.DeleteData(
                table: "model",
                keyColumn: "id",
                keyValue: new Guid("29a4a967-f786-460b-aa3a-09fe77ebc4cd"));

            migrationBuilder.DeleteData(
                table: "model",
                keyColumn: "id",
                keyValue: new Guid("57454149-3d5f-46f7-ad67-59c9c20e4b8a"));

            migrationBuilder.DeleteData(
                table: "model",
                keyColumn: "id",
                keyValue: new Guid("86571f83-df76-49d4-8066-3d778049c98d"));

            migrationBuilder.DeleteData(
                table: "model",
                keyColumn: "id",
                keyValue: new Guid("950a5ff4-beb7-42ae-9fe2-bc6a351fe380"));

            migrationBuilder.DeleteData(
                table: "model",
                keyColumn: "id",
                keyValue: new Guid("ab60dde3-c3b4-4424-98a5-523596d84e49"));

            migrationBuilder.DeleteData(
                table: "model",
                keyColumn: "id",
                keyValue: new Guid("ed8f35b4-7af5-4681-a8a7-b18d0227f3aa"));

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
        }
    }
}
