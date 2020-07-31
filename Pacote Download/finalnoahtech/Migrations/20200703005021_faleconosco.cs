using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Org.BouncyCastle.Math.EC.Rfc7748;

namespace Noahtech.Migrations
{
    public partial class faleconosco : Migration
    {
       
             protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FaleConosco",
                columns: table => new
                {
                    ContatoId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Mensagem = table.Column<string>(nullable: true)
              },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FaleConosco", x => x.ContatoId);
                });
        }
    


        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
               name: "FaleConoso");
        }
    }

}

