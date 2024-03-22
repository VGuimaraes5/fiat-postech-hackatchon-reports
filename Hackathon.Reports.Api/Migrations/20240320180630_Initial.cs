using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Hackathon.Reports.Api.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "tb_point_record_report",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    Date = table.Column<DateOnly>(type: "date", nullable: false),
                    UserIdentification = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Registers = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_point_record_report", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "tb_point_record_report",
                columns: new[] { "Id", "CreatedAt", "Date", "IsDeleted", "Registers", "UpdatedAt", "UserIdentification" },
                values: new object[,]
                {
                    { new Guid("019eaeac-88e2-47b7-a916-4d3d0fc0f60e"), null, new DateOnly(2024, 3, 21), false, "[{\"StartTime\":\"08:00:00\",\"EndTime\":\"12:00:00\"}, {\"StartTime\":\"13:00:00\",\"EndTime\":\"17:00:00\"}]", null, "seed" },
                    { new Guid("0e8f6443-6ffc-434f-bbe2-601094710d0d"), null, new DateOnly(2024, 3, 5), false, "[{\"StartTime\":\"08:00:00\",\"EndTime\":\"12:00:00\"}, {\"StartTime\":\"13:00:00\",\"EndTime\":\"17:00:00\"}]", null, "seed" },
                    { new Guid("101ca83b-2020-404d-9fd7-d24beb8e2d0a"), null, new DateOnly(2024, 3, 11), false, "[{\"StartTime\":\"08:00:00\",\"EndTime\":\"12:00:00\"}, {\"StartTime\":\"13:00:00\",\"EndTime\":\"17:00:00\"}]", null, "seed" },
                    { new Guid("31fc841a-6588-4987-bbde-dd475ba529cb"), null, new DateOnly(2024, 3, 15), false, "[{\"StartTime\":\"08:00:00\",\"EndTime\":\"12:00:00\"}, {\"StartTime\":\"13:00:00\",\"EndTime\":\"17:00:00\"}]", null, "seed" },
                    { new Guid("33f5eb34-b594-4853-a8c2-ca04f144718e"), null, new DateOnly(2024, 3, 1), false, "[{\"StartTime\":\"08:00:00\",\"EndTime\":\"12:00:00\"}, {\"StartTime\":\"13:00:00\",\"EndTime\":\"18:00:00\"}]", null, "seed" },
                    { new Guid("3beb51d8-ab93-4838-aca8-023f7ab9368c"), null, new DateOnly(2024, 3, 20), false, "[{\"StartTime\":\"08:00:00\",\"EndTime\":\"12:00:00\"}, {\"StartTime\":\"13:00:00\",\"EndTime\":\"17:40:00\"}]", null, "seed" },
                    { new Guid("4254f432-714e-4ba3-9fb8-a55cf9634828"), null, new DateOnly(2024, 3, 4), false, "[{\"StartTime\":\"08:00:00\",\"EndTime\":\"12:00:00\"}, {\"StartTime\":\"13:00:00\",\"EndTime\":\"17:00:00\"}]", null, "seed" },
                    { new Guid("50900374-d272-4560-91a4-7c865e6b60c4"), null, new DateOnly(2024, 3, 6), false, "[{\"StartTime\":\"08:00:00\",\"EndTime\":\"12:00:00\"}, {\"StartTime\":\"13:00:00\",\"EndTime\":\"17:30:00\"}]", null, "seed" },
                    { new Guid("51c70c16-cd5b-468b-adec-029e40b4faa5"), null, new DateOnly(2024, 3, 18), false, "[{\"StartTime\":\"08:00:00\",\"EndTime\":\"12:00:00\"}, {\"StartTime\":\"13:00:00\",\"EndTime\":\"17:00:00\"}]", null, "seed" },
                    { new Guid("546ac3f3-9176-464f-97b2-ef509987105a"), null, new DateOnly(2024, 3, 22), false, "[{\"StartTime\":\"08:00:00\",\"EndTime\":\"12:00:00\"}, {\"StartTime\":\"13:00:00\",\"EndTime\":\"17:00:00\"}]", null, "seed" },
                    { new Guid("6885ebf9-6dd0-4544-8a52-1deba7feae64"), null, new DateOnly(2024, 3, 12), false, "[{\"StartTime\":\"08:00:00\",\"EndTime\":\"12:10:00\"}, {\"StartTime\":\"13:10:00\",\"EndTime\":\"17:20:00\"}]", null, "seed" },
                    { new Guid("7064b744-6494-448c-8b52-fc2445b92269"), null, new DateOnly(2024, 3, 25), false, "[{\"StartTime\":\"08:00:00\",\"EndTime\":\"12:00:00\"}, {\"StartTime\":\"13:00:00\",\"EndTime\":\"17:00:00\"}]", null, "seed" },
                    { new Guid("7217b499-2e31-42c0-98a5-45341ddab1b0"), null, new DateOnly(2024, 3, 8), false, "[{\"StartTime\":\"08:00:00\",\"EndTime\":\"12:00:00\"}, {\"StartTime\":\"13:00:00\",\"EndTime\":\"17:00:00\"}]", null, "seed" },
                    { new Guid("72e24965-2465-4dd9-9ec5-3335ae1fe253"), null, new DateOnly(2024, 3, 26), false, "[{\"StartTime\":\"08:00:00\",\"EndTime\":\"12:10:00\"}, {\"StartTime\":\"13:10:00\",\"EndTime\":\"17:20:00\"}]", null, "seed" },
                    { new Guid("77ed8db7-a1e3-4f36-b6c6-20996f53d2f8"), null, new DateOnly(2024, 3, 27), false, "[{\"StartTime\":\"08:00:00\",\"EndTime\":\"12:00:00\"}, {\"StartTime\":\"13:00:00\",\"EndTime\":\"17:40:00\"}]", null, "seed" },
                    { new Guid("8e5d30bf-9d9b-49f4-ac09-8f612acc312c"), null, new DateOnly(2024, 3, 13), false, "[{\"StartTime\":\"08:00:00\",\"EndTime\":\"12:00:00\"}, {\"StartTime\":\"13:00:00\",\"EndTime\":\"17:40:00\"}]", null, "seed" },
                    { new Guid("be8e5ace-d07b-4c4f-bb11-47eb40741392"), null, new DateOnly(2024, 3, 7), false, "[{\"StartTime\":\"08:00:00\",\"EndTime\":\"12:00:00\"}, {\"StartTime\":\"13:00:00\",\"EndTime\":\"17:00:00\"}]", null, "seed" },
                    { new Guid("bed63fc9-acdd-41fe-bdbe-3abb5e79946c"), null, new DateOnly(2024, 3, 29), false, "[{\"StartTime\":\"08:00:00\",\"EndTime\":\"12:00:00\"}, {\"StartTime\":\"13:00:00\",\"EndTime\":\"17:00:00\"}]", null, "seed" },
                    { new Guid("c4bc3010-ab68-46a5-a589-e47a98f7a17d"), null, new DateOnly(2024, 3, 28), false, "[{\"StartTime\":\"08:00:00\",\"EndTime\":\"12:00:00\"}, {\"StartTime\":\"13:00:00\",\"EndTime\":\"17:00:00\"}]", null, "seed" },
                    { new Guid("db858396-7aec-4027-aa42-af78475eb37b"), null, new DateOnly(2024, 3, 19), false, "[{\"StartTime\":\"08:00:00\",\"EndTime\":\"12:10:00\"}, {\"StartTime\":\"13:10:00\",\"EndTime\":\"17:20:00\"}]", null, "seed" },
                    { new Guid("eb5fd3d9-2d6a-437f-97e4-50460fe17093"), null, new DateOnly(2024, 3, 14), false, "[{\"StartTime\":\"08:00:00\",\"EndTime\":\"12:00:00\"}, {\"StartTime\":\"13:00:00\",\"EndTime\":\"17:00:00\"}]", null, "seed" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_tb_point_record_report_UserIdentification",
                table: "tb_point_record_report",
                column: "UserIdentification");

            migrationBuilder.CreateIndex(
                name: "IX_tb_point_record_report_UserIdentification_Date",
                table: "tb_point_record_report",
                columns: new[] { "UserIdentification", "Date" },
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tb_point_record_report");
        }
    }
}
