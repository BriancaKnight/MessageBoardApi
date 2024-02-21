using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MessageBoardApi.Migrations
{
    public partial class AddDataValidation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Text",
                keyValue: null,
                column: "Text",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "Text",
                table: "Messages",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Topic",
                keyValue: null,
                column: "Topic",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "Topic",
                table: "Groups",
                type: "varchar(20)",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "ApplicationUser",
                keyColumn: "Id",
                keyValue: "abc",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f32f0c29-8455-4199-a0f2-495ed1318a4a", "AQAAAAEAACcQAAAAECTt9A+AH54zc/erlrP/382jwI4kuPVxQ9LzBJY2dkB1XFICmqInCr7fYhk6yafvAg==", "7a6c20f3-9abf-47b9-960a-6086356efefe" });

            migrationBuilder.UpdateData(
                table: "ApplicationUser",
                keyColumn: "Id",
                keyValue: "def",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "97aa0e12-567f-4ba0-8e34-aff2e89a6f8f", "AQAAAAEAACcQAAAAEIVCn0yqIeytajSqTHNUJ9OOsdHaA7mC4BPDsC8d75KFt17oJNd2Uc+PTUIjIQiEUQ==", "6399598e-9e95-453d-9485-b678181dadb3" });

            migrationBuilder.UpdateData(
                table: "ApplicationUser",
                keyColumn: "Id",
                keyValue: "ghi",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8ef2ffac-599f-4afd-9e04-72470c39d2cc", "AQAAAAEAACcQAAAAELpQhiR60Lw9DBS9ieVCOuq3I9oWKzdoN3D+iV70bHZTUFdTZ6vdnLIlI0NSHj85SQ==", "44730422-ce7d-4ed6-9b82-600048c15914" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Text",
                table: "Messages",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Topic",
                table: "Groups",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(20)",
                oldMaxLength: 20)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "ApplicationUser",
                keyColumn: "Id",
                keyValue: "abc",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7c1467aa-152c-403b-9503-85ed98a398fa", "AQAAAAEAACcQAAAAECXMEbZl2oip2CeMQ3yxw0AyYLYDJZRsm4jUTLbyDOS//4nEjc6cl8T/NP9vfYqnCg==", "f596f2f7-c883-4b16-b33c-6558510cae6e" });

            migrationBuilder.UpdateData(
                table: "ApplicationUser",
                keyColumn: "Id",
                keyValue: "def",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6a23dd3f-4c52-46a7-89c1-f2aca174fedc", "AQAAAAEAACcQAAAAEHX3g4TczGxwrzDiZR64prHVBpF93BrWWNMS2VgeMXR5lcm4yUFoDhR2N+pIp5Xeug==", "32bed3ce-85be-4b38-a489-2bef2483e4f0" });

            migrationBuilder.UpdateData(
                table: "ApplicationUser",
                keyColumn: "Id",
                keyValue: "ghi",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c1f4e42f-075e-4bbb-89df-b6813224eaed", "AQAAAAEAACcQAAAAEF/zArBHQ3gS1bn/Bba9s/3dkEvTgZC6y0K6eCUlGEQiTX6tw9Mfeip6IJS2nU2RcQ==", "6c3e0c69-0a51-40e9-85e4-d0603917717d" });
        }
    }
}
