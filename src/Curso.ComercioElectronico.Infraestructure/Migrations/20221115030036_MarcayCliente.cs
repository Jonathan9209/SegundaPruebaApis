using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Curso.ComercioElectronico.Infraestructure.Migrations
{
    public partial class MarcayCliente : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Productos_Marcas_MarcaId",
                table: "Productos");

            migrationBuilder.DropIndex(
                name: "IX_Productos_MarcaId",
                table: "Productos");

            migrationBuilder.AddColumn<string>(
                name: "MarcaId1",
                table: "Productos",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Marcas",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER")
                .OldAnnotation("Sqlite:Autoincrement", true);

            migrationBuilder.AddColumn<string>(
                name: "Apellidos",
                table: "Clientes",
                type: "TEXT",
                maxLength: 80,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Cedula",
                table: "Clientes",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Direccion",
                table: "Clientes",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Telefono",
                table: "Clientes",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Productos_MarcaId1",
                table: "Productos",
                column: "MarcaId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Productos_Marcas_MarcaId1",
                table: "Productos",
                column: "MarcaId1",
                principalTable: "Marcas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Productos_Marcas_MarcaId1",
                table: "Productos");

            migrationBuilder.DropIndex(
                name: "IX_Productos_MarcaId1",
                table: "Productos");

            migrationBuilder.DropColumn(
                name: "MarcaId1",
                table: "Productos");

            migrationBuilder.DropColumn(
                name: "Apellidos",
                table: "Clientes");

            migrationBuilder.DropColumn(
                name: "Cedula",
                table: "Clientes");

            migrationBuilder.DropColumn(
                name: "Direccion",
                table: "Clientes");

            migrationBuilder.DropColumn(
                name: "Telefono",
                table: "Clientes");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Marcas",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "TEXT")
                .Annotation("Sqlite:Autoincrement", true);

            migrationBuilder.CreateIndex(
                name: "IX_Productos_MarcaId",
                table: "Productos",
                column: "MarcaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Productos_Marcas_MarcaId",
                table: "Productos",
                column: "MarcaId",
                principalTable: "Marcas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
