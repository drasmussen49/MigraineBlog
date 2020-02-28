using Microsoft.EntityFrameworkCore.Migrations;

namespace MigraineBlog.Migrations
{
    public partial class NewSeedDataPostTag : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PostTags",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PostId = table.Column<int>(nullable: false),
                    TagId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PostTags", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PostTags_Posts_PostId",
                        column: x => x.PostId,
                        principalTable: "Posts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PostTags_Tags_TagId",
                        column: x => x.TagId,
                        principalTable: "Tags",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Author", "Body", "CategoryId", "Title" },
                values: new object[,]
                {
                    { 1, "Dan", "I had a migraine over the weekend, and it totally ended my day. I had to close all the blinds in the house, sit in my bed with no sounds around and lie there. Nothing's worse than having a migraine on your day off and you can't even enjoy it...", 1, "Day Over" },
                    { 2, "Rhianna", "Hi. I have been suffering from what I THOUGHT were just regular old headaches, until I met someone who suffers from chronic migraines. Only then did I realize what I may be suffering from are actually migraines! Unfortunately, without having health insurance right now, I cannot afford the pricey trip to a doctor for an official diagnosis. I have been taking the advice of my migraine-having friends on how to identify my triggers and the best at-home solutions. It's not ideal, but it's the best I can do for now! Hang in there, everyone!  ", 1, "Unofficial Diagnosis" },
                    { 3, "Joan", "I have taken four ibuprofen which are all 400mg each. Can I take more? Please? My migraine will not cease. SOS.", 2, "Is This Okay?" },
                    { 4, "Rebecca", "I am a 30 year old female, and I received my official diagnosis for migraines 5 years ago. My husband and I would like to have children, but I am worried I will pass this cursed gene onto my kids. Should I be worried?", 2, "Are Migraines Genetic?" },
                    { 5, "Jefferson", "I find that the best way to kill a migraine (or at least avoid the suffering!) is by... simply taking a nice long nap in a dark quiet place. Works like a charm!", 3, "When In Doubt, Sleep It Out!" },
                    { 6, "Coral", "Make sure to always get enough sleep, at least 8 hours per night. Drink enough water! Avoid loud sounds. Stay off screens for extended periods of time. If you start to feel the ol' familiar ache behind your eyes, try a temperature sleeping-mask! You can heat them up in the microwave OR stick them in the freezer and rest them over your eyes. Hope these help!", 3, "Everyday Helpful Tips" }
                });

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "#BadDay" },
                    { 2, "#SOS" },
                    { 3, "#Relief" },
                    { 4, "#Triggers" },
                    { 5, "#Advice" }
                });

            migrationBuilder.InsertData(
                table: "PostTags",
                columns: new[] { "Id", "PostId", "TagId" },
                values: new object[,]
                {
                    { 7, 3, 1 },
                    { 1, 1, 2 },
                    { 4, 4, 2 },
                    { 6, 3, 2 },
                    { 11, 6, 2 },
                    { 12, 6, 3 },
                    { 2, 1, 4 },
                    { 8, 5, 4 },
                    { 3, 2, 5 },
                    { 5, 4, 5 },
                    { 9, 5, 5 },
                    { 10, 6, 5 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_PostTags_PostId",
                table: "PostTags",
                column: "PostId");

            migrationBuilder.CreateIndex(
                name: "IX_PostTags_TagId",
                table: "PostTags",
                column: "TagId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PostTags");

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
