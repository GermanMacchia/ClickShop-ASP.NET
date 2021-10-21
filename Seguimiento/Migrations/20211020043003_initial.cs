using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Seguimiento.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Direcciones",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    provincia = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    calle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    numero = table.Column<int>(type: "int", nullable: false),
                    localidad = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Direcciones", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Empleados",
                columns: table => new
                {
                    legajo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    apellido = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Empleados", x => x.legajo);
                });

            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    dni = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    telefono = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    direccionid = table.Column<int>(type: "int", nullable: true),
                    mail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    apellido = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.dni);
                    table.ForeignKey(
                        name: "FK_Clientes_Direcciones_direccionid",
                        column: x => x.direccionid,
                        principalTable: "Direcciones",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Pedidos",
                columns: table => new
                {
                    nroTraking = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    clientedni = table.Column<int>(type: "int", nullable: true),
                    comentarios = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    fechaEnvio = table.Column<DateTime>(type: "datetime2", nullable: false),
                    fechaInicio = table.Column<DateTime>(type: "datetime2", nullable: false),
                    encargadolegajo = table.Column<int>(type: "int", nullable: true),
                    direccionid = table.Column<int>(type: "int", nullable: true),
                    estado = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pedidos", x => x.nroTraking);
                    table.ForeignKey(
                        name: "FK_Pedidos_Clientes_clientedni",
                        column: x => x.clientedni,
                        principalTable: "Clientes",
                        principalColumn: "dni",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Pedidos_Direcciones_direccionid",
                        column: x => x.direccionid,
                        principalTable: "Direcciones",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Pedidos_Empleados_encargadolegajo",
                        column: x => x.encargadolegajo,
                        principalTable: "Empleados",
                        principalColumn: "legajo",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Productos",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    precio = table.Column<double>(type: "float", nullable: false),
                    cantidad = table.Column<int>(type: "int", nullable: false),
                    talle = table.Column<int>(type: "int", nullable: false),
                    imagen = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PedidonroTraking = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Productos", x => x.id);
                    table.ForeignKey(
                        name: "FK_Productos_Pedidos_PedidonroTraking",
                        column: x => x.PedidonroTraking,
                        principalTable: "Pedidos",
                        principalColumn: "nroTraking",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Clientes_direccionid",
                table: "Clientes",
                column: "direccionid");

            migrationBuilder.CreateIndex(
                name: "IX_Pedidos_clientedni",
                table: "Pedidos",
                column: "clientedni");

            migrationBuilder.CreateIndex(
                name: "IX_Pedidos_direccionid",
                table: "Pedidos",
                column: "direccionid");

            migrationBuilder.CreateIndex(
                name: "IX_Pedidos_encargadolegajo",
                table: "Pedidos",
                column: "encargadolegajo");

            migrationBuilder.CreateIndex(
                name: "IX_Productos_PedidonroTraking",
                table: "Productos",
                column: "PedidonroTraking");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Productos");

            migrationBuilder.DropTable(
                name: "Pedidos");

            migrationBuilder.DropTable(
                name: "Clientes");

            migrationBuilder.DropTable(
                name: "Empleados");

            migrationBuilder.DropTable(
                name: "Direcciones");
        }
    }
}
