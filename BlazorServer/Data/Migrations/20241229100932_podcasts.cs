using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BlazorServer.Migrations
{
    /// <inheritdoc />
    public partial class podcasts : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Podcasts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Podcasts", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Podcasts",
                columns: new[] { "Id", "Title" },
                values: new object[,]
                {
                    { 1, "Podcast 1" },
                    { 2, "Podcast 2" },
                    { 3, "Podcast 3" },
                    { 4, "Podcast 4" },
                    { 5, "Podcast 5" },
                    { 6, "Podcast 6" },
                    { 7, "Podcast 7" },
                    { 8, "Podcast 8" },
                    { 9, "Podcast 9" },
                    { 10, "Podcast 10" },
                    { 11, "Podcast 11" },
                    { 12, "Podcast 12" },
                    { 13, "Podcast 13" },
                    { 14, "Podcast 14" },
                    { 15, "Podcast 15" },
                    { 16, "Podcast 16" },
                    { 17, "Podcast 17" },
                    { 18, "Podcast 18" },
                    { 19, "Podcast 19" },
                    { 20, "Podcast 20" },
                    { 21, "Podcast 21" },
                    { 22, "Podcast 22" },
                    { 23, "Podcast 23" },
                    { 24, "Podcast 24" },
                    { 25, "Podcast 25" },
                    { 26, "Podcast 26" },
                    { 27, "Podcast 27" },
                    { 28, "Podcast 28" },
                    { 29, "Podcast 29" },
                    { 30, "Podcast 30" },
                    { 31, "Podcast 31" },
                    { 32, "Podcast 32" },
                    { 33, "Podcast 33" },
                    { 34, "Podcast 34" },
                    { 35, "Podcast 35" },
                    { 36, "Podcast 36" },
                    { 37, "Podcast 37" },
                    { 38, "Podcast 38" },
                    { 39, "Podcast 39" },
                    { 40, "Podcast 40" },
                    { 41, "Podcast 41" },
                    { 42, "Podcast 42" },
                    { 43, "Podcast 43" },
                    { 44, "Podcast 44" },
                    { 45, "Podcast 45" },
                    { 46, "Podcast 46" },
                    { 47, "Podcast 47" },
                    { 48, "Podcast 48" },
                    { 49, "Podcast 49" },
                    { 50, "Podcast 50" },
                    { 51, "Podcast 51" },
                    { 52, "Podcast 52" },
                    { 53, "Podcast 53" },
                    { 54, "Podcast 54" },
                    { 55, "Podcast 55" },
                    { 56, "Podcast 56" },
                    { 57, "Podcast 57" },
                    { 58, "Podcast 58" },
                    { 59, "Podcast 59" },
                    { 60, "Podcast 60" },
                    { 61, "Podcast 61" },
                    { 62, "Podcast 62" },
                    { 63, "Podcast 63" },
                    { 64, "Podcast 64" },
                    { 65, "Podcast 65" },
                    { 66, "Podcast 66" },
                    { 67, "Podcast 67" },
                    { 68, "Podcast 68" },
                    { 69, "Podcast 69" },
                    { 70, "Podcast 70" },
                    { 71, "Podcast 71" },
                    { 72, "Podcast 72" },
                    { 73, "Podcast 73" },
                    { 74, "Podcast 74" },
                    { 75, "Podcast 75" },
                    { 76, "Podcast 76" },
                    { 77, "Podcast 77" },
                    { 78, "Podcast 78" },
                    { 79, "Podcast 79" },
                    { 80, "Podcast 80" },
                    { 81, "Podcast 81" },
                    { 82, "Podcast 82" },
                    { 83, "Podcast 83" },
                    { 84, "Podcast 84" },
                    { 85, "Podcast 85" },
                    { 86, "Podcast 86" },
                    { 87, "Podcast 87" },
                    { 88, "Podcast 88" },
                    { 89, "Podcast 89" },
                    { 90, "Podcast 90" },
                    { 91, "Podcast 91" },
                    { 92, "Podcast 92" },
                    { 93, "Podcast 93" },
                    { 94, "Podcast 94" },
                    { 95, "Podcast 95" },
                    { 96, "Podcast 96" },
                    { 97, "Podcast 97" },
                    { 98, "Podcast 98" },
                    { 99, "Podcast 99" },
                    { 100, "Podcast 100" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Podcasts");
        }
    }
}
