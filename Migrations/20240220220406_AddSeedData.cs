using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MessageBoardApi.Migrations
{
    public partial class AddSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "ApplicationUser",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "abc", 0, "7c1467aa-152c-403b-9503-85ed98a398fa", "jimothy@proton.me", false, false, null, null, null, "AQAAAAEAACcQAAAAECXMEbZl2oip2CeMQ3yxw0AyYLYDJZRsm4jUTLbyDOS//4nEjc6cl8T/NP9vfYqnCg==", null, false, "f596f2f7-c883-4b16-b33c-6558510cae6e", false, "Jimothy" },
                    { "def", 0, "6a23dd3f-4c52-46a7-89c1-f2aca174fedc", "Timmet@tutanota.com", false, false, null, null, null, "AQAAAAEAACcQAAAAEHX3g4TczGxwrzDiZR64prHVBpF93BrWWNMS2VgeMXR5lcm4yUFoDhR2N+pIp5Xeug==", null, false, "32bed3ce-85be-4b38-a489-2bef2483e4f0", false, "Timmet" },
                    { "ghi", 0, "c1f4e42f-075e-4bbb-89df-b6813224eaed", "Woxanda@soverin.net", false, false, null, null, null, "AQAAAAEAACcQAAAAEF/zArBHQ3gS1bn/Bba9s/3dkEvTgZC6y0K6eCUlGEQiTX6tw9Mfeip6IJS2nU2RcQ==", null, false, "6c3e0c69-0a51-40e9-85e4-d0603917717d", false, "Woxanda" }
                });

            migrationBuilder.InsertData(
                table: "Groups",
                columns: new[] { "GroupId", "Topic" },
                values: new object[,]
                {
                    { 1, "Hellos" },
                    { 2, "Goodbyes" },
                    { 3, "Nonsense" }
                });

            migrationBuilder.InsertData(
                table: "Messages",
                columns: new[] { "MessageId", "Date", "GroupId", "Text", "UserId" },
                values: new object[] { 1, new DateTime(2024, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Hi I need more discount hogs!", "abc" });

            migrationBuilder.InsertData(
                table: "Messages",
                columns: new[] { "MessageId", "Date", "GroupId", "Text", "UserId" },
                values: new object[] { 2, new DateTime(2023, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Goodbye, thank you for teaching me how to shave my cat ", "def" });

            migrationBuilder.InsertData(
                table: "Messages",
                columns: new[] { "MessageId", "Date", "GroupId", "Text", "UserId" },
                values: new object[] { 3, new DateTime(1924, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Kim Jong Un is so dreamy!!", "ghi" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ApplicationUser",
                keyColumn: "Id",
                keyValue: "abc");

            migrationBuilder.DeleteData(
                table: "ApplicationUser",
                keyColumn: "Id",
                keyValue: "def");

            migrationBuilder.DeleteData(
                table: "ApplicationUser",
                keyColumn: "Id",
                keyValue: "ghi");

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 3);
        }
    }
}
