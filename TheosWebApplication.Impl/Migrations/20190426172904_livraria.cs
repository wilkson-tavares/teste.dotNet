using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TheosWebApplication.Impl.Migrations
{
    public partial class livraria : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "LIVRARIA");

            migrationBuilder.CreateTable(
                name: "Autor",
                schema: "LIVRARIA",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Autor", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Genero",
                schema: "LIVRARIA",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genero", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TB_LIVROS",
                schema: "LIVRARIA",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    NOME = table.Column<string>(maxLength: 100, nullable: false),
                    AUTOR_ID = table.Column<int>(nullable: false),
                    GENERO_ID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("ID", x => x.ID);
                    table.ForeignKey(
                        name: "FK_TB_LIVROS_Autor_AUTOR_ID",
                        column: x => x.AUTOR_ID,
                        principalSchema: "LIVRARIA",
                        principalTable: "Autor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TB_LIVROS_Genero_GENERO_ID",
                        column: x => x.GENERO_ID,
                        principalSchema: "LIVRARIA",
                        principalTable: "Genero",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TB_LIVROS_AUTOR_ID",
                schema: "LIVRARIA",
                table: "TB_LIVROS",
                column: "AUTOR_ID");

            migrationBuilder.CreateIndex(
                name: "IX_TB_LIVROS_GENERO_ID",
                schema: "LIVRARIA",
                table: "TB_LIVROS",
                column: "GENERO_ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TB_LIVROS",
                schema: "LIVRARIA");

            migrationBuilder.DropTable(
                name: "Autor",
                schema: "LIVRARIA");

            migrationBuilder.DropTable(
                name: "Genero",
                schema: "LIVRARIA");
        }
    }
}
