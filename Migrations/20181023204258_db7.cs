using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace demomvc.Migrations
{
    public partial class db7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Usuario",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    Apellidos = table.Column<string>(nullable: true),
                    Celular = table.Column<string>(nullable: true),
<<<<<<< HEAD:Migrations/20181022045714_db7.cs
=======
                    ConfirmarContraseña = table.Column<string>(nullable: true),
>>>>>>> d7a7f2ef9b0bb16fd346f899115cf858c3038eb8:Migrations/20181023204258_db7.cs
                    Contraseña = table.Column<string>(nullable: true),
                    Correo = table.Column<string>(nullable: true),
                    Nacimiento = table.Column<string>(nullable: true),
                    Nombre = table.Column<string>(maxLength: 40, nullable: false),
                    Usu = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Usuario");
        }
    }
}
