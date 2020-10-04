using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Practica1.Data.Migrations
{
    public partial class InitialMigrations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Productos",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    nombre = table.Column<string>(maxLength: 100, nullable: false),
                    descripcion = table.Column<string>(maxLength: 200, nullable: false),
                    costo = table.Column<decimal>(nullable: false),
                    precio = table.Column<decimal>(nullable: false),
                    existencia = table.Column<int>(nullable: false),
                    estado = table.Column<bool>(nullable: false),
                    fechaCreacion = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Productos", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Productos");
        }
    }
}
