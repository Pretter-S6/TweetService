using Microsoft.EntityFrameworkCore.Migrations;

namespace TweetService.Migrations
{
    public partial class MyFirstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_tweet",
                table: "tweet");

            migrationBuilder.RenameTable(
                name: "tweet",
                newName: "tweets");

            migrationBuilder.AddPrimaryKey(
                name: "PK_tweets",
                table: "tweets",
                column: "ID");

            migrationBuilder.CreateTable(
                name: "likes",
                columns: table => new
                {
                    LikeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TweetID = table.Column<int>(type: "int", nullable: false),
                    UserID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_likes", x => x.LikeID);
                });

            migrationBuilder.CreateTable(
                name: "reactions",
                columns: table => new
                {
                    ReactionID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TweetID = table.Column<int>(type: "int", nullable: false),
                    UserID = table.Column<int>(type: "int", nullable: false),
                    Reaction = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_reactions", x => x.ReactionID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "likes");

            migrationBuilder.DropTable(
                name: "reactions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_tweets",
                table: "tweets");

            migrationBuilder.RenameTable(
                name: "tweets",
                newName: "tweet");

            migrationBuilder.AddPrimaryKey(
                name: "PK_tweet",
                table: "tweet",
                column: "ID");
        }
    }
}
