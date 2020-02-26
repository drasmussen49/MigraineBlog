using Microsoft.EntityFrameworkCore.Migrations;

namespace MigraineBlog.Migrations
{
    public partial class NewDescriptionSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Categories",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "Description",
                value: "This is a place where you can share your own stories relating to your migraines. It would help users to keep content related to your migraines/headaches and how they impact your life.");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "Description",
                value: "If you have a medically sensitive question relating to your migraine/headache conditions or medication, write a post about it here! A vetted team of doctors will read them and give advice.");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "Description",
                value: "If you have any tips for other migraineurs concerning avoidance methods, triggers or over-the-counter relief techniques, post about it here!");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "Categories");
        }
    }
}
