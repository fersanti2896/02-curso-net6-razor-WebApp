using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebAppRazor.Migrations {
    public partial class MInicial : Migration {
        protected override void Up(MigrationBuilder migrationBuilder) {
            migrationBuilder.CreateTable(
                name   : "Cursos",
                columns: table => new  {
                    Id           = table.Column<int>(type: "int", nullable: false)
                                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameCourse   = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CountClass   = table.Column<int>(type: "int", nullable: false),
                    Price        = table.Column<int>(type: "int", nullable: false),
                    DateCreation = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table => {
                    table.PrimaryKey("PK_Cursos", x => x.Id);
                }
            );
        }

        protected override void Down(MigrationBuilder migrationBuilder) {
            migrationBuilder.DropTable(
                name: "Cursos"
            );
        }
    }
}
