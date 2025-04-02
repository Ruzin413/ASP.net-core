using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace mystore.Migrations
{
    /// <inheritdoc />
    public partial class Dbmigration1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "employees1",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FormName = table.Column<string>(type: "varchar(100)", maxLength: 15, nullable: false),
                    Email = table.Column<string>(type: "varchar(100)", nullable: false),
                    FormAge = table.Column<int>(type: "int", nullable: false),
                    FormGender = table.Column<string>(type: "varchar(10)", nullable: false),
                    MarriedStatus = table.Column<string>(type: "varchar(10)", nullable: false),
                    FormTextArea = table.Column<string>(type: "varchar(500)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_employees1", x => x.ID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "employees1");
        }
    }
}
