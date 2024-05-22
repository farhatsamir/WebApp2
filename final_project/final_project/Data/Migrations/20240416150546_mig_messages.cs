using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace final_project.Data.Migrations
{
    /// <inheritdoc />
    public partial class mig_messages : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Message",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    client_email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    client_message = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    message_data = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Message", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Message");
        }
    }
}
