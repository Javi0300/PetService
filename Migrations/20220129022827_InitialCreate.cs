using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PetService.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Municipios",
                columns: table => new
                {
                    IdMunicipio = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreMunicipio = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Municipios", x => x.IdMunicipio);
                });

            migrationBuilder.CreateTable(
                name: "Productos",
                columns: table => new
                {
                    IdProductos = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descripcion = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: false),
                    Costo = table.Column<double>(type: "float", nullable: false),
                    Precio = table.Column<double>(type: "float", nullable: false),
                    Inventario = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Productos", x => x.IdProductos);
                });

            migrationBuilder.CreateTable(
                name: "Servicios",
                columns: table => new
                {
                    IdServicio = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreServicio = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Servicios", x => x.IdServicio);
                });

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    IdUsuario = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Correo = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Edad = table.Column<DateTime>(type: "datetime", nullable: true),
                    Sexo = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Usuario = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Contraseña = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.IdUsuario);
                });

            migrationBuilder.CreateTable(
                name: "Propietarios",
                columns: table => new
                {
                    IdPropietario = table.Column<int>(type: "int", nullable: false),
                    Nombres = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    Apellidos = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    Email = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: false),
                    FechaNacimiento = table.Column<DateTime>(type: "datetime", nullable: false),
                    Sexo = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: true),
                    IdUsuario = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    IdMunicipio = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Propietarios", x => x.IdPropietario);
                    table.ForeignKey(
                        name: "FK_Propietarios_Municipios",
                        column: x => x.IdPropietario,
                        principalTable: "Municipios",
                        principalColumn: "IdMunicipio");
                });

            migrationBuilder.CreateTable(
                name: "Direcciones",
                columns: table => new
                {
                    IdDireccion = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Calle = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    Numero = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    CodigoPostal = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    Ciudad = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    IdPropietario = table.Column<int>(type: "int", nullable: true),
                    IdUsuario = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Direcciones", x => x.IdDireccion);
                    table.ForeignKey(
                        name: "FK_Direcciones_Propietarios",
                        column: x => x.IdPropietario,
                        principalTable: "Propietarios",
                        principalColumn: "IdPropietario");
                });

            migrationBuilder.CreateTable(
                name: "Perros",
                columns: table => new
                {
                    IdPerro = table.Column<int>(type: "int", nullable: false),
                    Nombre = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    Sexo = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    FechaNacimiento = table.Column<DateTime>(type: "datetime", nullable: true),
                    IdPropietario = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Perros", x => x.IdPerro);
                    table.ForeignKey(
                        name: "FK_Perros_Propietarios",
                        column: x => x.IdPerro,
                        principalTable: "Propietarios",
                        principalColumn: "IdPropietario");
                });

            migrationBuilder.CreateTable(
                name: "Ventas",
                columns: table => new
                {
                    IdVenta = table.Column<int>(type: "int", nullable: false),
                    IdPropietario = table.Column<int>(type: "int", nullable: false),
                    Fecha = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ventas", x => x.IdVenta);
                    table.ForeignKey(
                        name: "FK_Ventas_Propietarios",
                        column: x => x.IdVenta,
                        principalTable: "Propietarios",
                        principalColumn: "IdPropietario");
                });

            migrationBuilder.CreateTable(
                name: "Citas",
                columns: table => new
                {
                    IdCitas = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdPropietario = table.Column<int>(type: "int", nullable: false),
                    IdPerro = table.Column<int>(type: "int", nullable: false),
                    Fecha = table.Column<DateTime>(type: "datetime", nullable: false),
                    Descripcion = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Citas", x => x.IdCitas);
                    table.ForeignKey(
                        name: "FK_Citas_Perros",
                        column: x => x.IdPerro,
                        principalTable: "Perros",
                        principalColumn: "IdPerro");
                    table.ForeignKey(
                        name: "FK_Citas_Propietarios",
                        column: x => x.IdPropietario,
                        principalTable: "Propietarios",
                        principalColumn: "IdPropietario");
                });

            migrationBuilder.CreateTable(
                name: "Venta_Detalle",
                columns: table => new
                {
                    IdVentaDetalle = table.Column<int>(type: "int", nullable: false),
                    IdVenta = table.Column<int>(type: "int", nullable: false),
                    IdProducto = table.Column<int>(type: "int", nullable: true),
                    IdServicio = table.Column<int>(type: "int", nullable: true),
                    Descripcion = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    Cantidad = table.Column<int>(type: "int", nullable: true),
                    Costo = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Venta_Detalle", x => x.IdVentaDetalle);
                    table.ForeignKey(
                        name: "FK_Venta_Detalle_Productos",
                        column: x => x.IdProducto,
                        principalTable: "Productos",
                        principalColumn: "IdProductos");
                    table.ForeignKey(
                        name: "FK_Venta_Detalle_Servicios",
                        column: x => x.IdServicio,
                        principalTable: "Servicios",
                        principalColumn: "IdServicio");
                    table.ForeignKey(
                        name: "FK_Venta_Detalle_Ventas",
                        column: x => x.IdVentaDetalle,
                        principalTable: "Ventas",
                        principalColumn: "IdVenta");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Citas_IdPerro",
                table: "Citas",
                column: "IdPerro");

            migrationBuilder.CreateIndex(
                name: "IX_Citas_IdPropietario",
                table: "Citas",
                column: "IdPropietario");

            migrationBuilder.CreateIndex(
                name: "IX_Direcciones_IdPropietario",
                table: "Direcciones",
                column: "IdPropietario");

            migrationBuilder.CreateIndex(
                name: "IX_Venta_Detalle_IdProducto",
                table: "Venta_Detalle",
                column: "IdProducto");

            migrationBuilder.CreateIndex(
                name: "IX_Venta_Detalle_IdServicio",
                table: "Venta_Detalle",
                column: "IdServicio");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Citas");

            migrationBuilder.DropTable(
                name: "Direcciones");

            migrationBuilder.DropTable(
                name: "Usuarios");

            migrationBuilder.DropTable(
                name: "Venta_Detalle");

            migrationBuilder.DropTable(
                name: "Perros");

            migrationBuilder.DropTable(
                name: "Productos");

            migrationBuilder.DropTable(
                name: "Servicios");

            migrationBuilder.DropTable(
                name: "Ventas");

            migrationBuilder.DropTable(
                name: "Propietarios");

            migrationBuilder.DropTable(
                name: "Municipios");
        }
    }
}
