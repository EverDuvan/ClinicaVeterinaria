using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ClinicaVet.App.Persistencia.Migrations
{
    public partial class Entidades1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Consultas_Mascota_mascotaId",
                table: "Consultas");

            migrationBuilder.DropForeignKey(
                name: "FK_Consultas_medicamentos_medicamentesId",
                table: "Consultas");

            migrationBuilder.DropTable(
                name: "medicamentos");

            migrationBuilder.DropIndex(
                name: "IX_Usuarios_Cedula",
                table: "Usuarios");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Mascota",
                table: "Mascota");

            migrationBuilder.DropColumn(
                name: "HorarioDia",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "Turno",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "Consultas");

            migrationBuilder.DropColumn(
                name: "ListaConsulta",
                table: "Consultas");

            migrationBuilder.DropColumn(
                name: "Dueño",
                table: "Mascota");

            migrationBuilder.DropColumn(
                name: "raza",
                table: "Mascota");

            migrationBuilder.RenameTable(
                name: "Mascota",
                newName: "Mascotas");

            migrationBuilder.RenameColumn(
                name: "Nombre",
                table: "Usuarios",
                newName: "nombre");

            migrationBuilder.RenameColumn(
                name: "Direccion",
                table: "Usuarios",
                newName: "direccion");

            migrationBuilder.RenameColumn(
                name: "Ciudad",
                table: "Usuarios",
                newName: "ciudad");

            migrationBuilder.RenameColumn(
                name: "Celular",
                table: "Usuarios",
                newName: "celular");

            migrationBuilder.RenameColumn(
                name: "Cedula",
                table: "Usuarios",
                newName: "cedula");

            migrationBuilder.RenameColumn(
                name: "Apellido",
                table: "Usuarios",
                newName: "apellido");

            migrationBuilder.RenameColumn(
                name: "Anotacion",
                table: "Consultas",
                newName: "anotacion");

            migrationBuilder.RenameColumn(
                name: "medicamentesId",
                table: "Consultas",
                newName: "recetaId");

            migrationBuilder.RenameColumn(
                name: "Fecha",
                table: "Consultas",
                newName: "FechaConsulta");

            migrationBuilder.RenameIndex(
                name: "IX_Consultas_medicamentesId",
                table: "Consultas",
                newName: "IX_Consultas_recetaId");

            migrationBuilder.RenameColumn(
                name: "Nombre",
                table: "Mascotas",
                newName: "nombre");

            migrationBuilder.RenameColumn(
                name: "FechaNacimiento",
                table: "Mascotas",
                newName: "fechaNacimiento");

            migrationBuilder.RenameColumn(
                name: "Descripcion",
                table: "Mascotas",
                newName: "descripcion");

            migrationBuilder.AlterColumn<string>(
                name: "password",
                table: "Usuarios",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "cedula",
                table: "Usuarios",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "email",
                table: "Usuarios",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "username",
                table: "Usuarios",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "dueñoId",
                table: "Mascotas",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "tipoMascota",
                table: "Mascotas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Mascotas",
                table: "Mascotas",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Agendas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    dueñoId = table.Column<int>(type: "int", nullable: true),
                    veterinarioId = table.Column<int>(type: "int", nullable: true),
                    dia = table.Column<DateTime>(type: "datetime2", nullable: false),
                    horaInicio = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Agendas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Agendas_Usuarios_dueñoId",
                        column: x => x.dueñoId,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Agendas_Usuarios_veterinarioId",
                        column: x => x.veterinarioId,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "HistoriaClinicas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    consultaId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HistoriaClinicas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HistoriaClinicas_Consultas_consultaId",
                        column: x => x.consultaId,
                        principalTable: "Consultas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Recetas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    medicamentos = table.Column<int>(type: "int", nullable: false),
                    dosis = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recetas", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_cedula",
                table: "Usuarios",
                column: "cedula",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Mascotas_dueñoId",
                table: "Mascotas",
                column: "dueñoId");

            migrationBuilder.CreateIndex(
                name: "IX_Agendas_dueñoId",
                table: "Agendas",
                column: "dueñoId");

            migrationBuilder.CreateIndex(
                name: "IX_Agendas_veterinarioId",
                table: "Agendas",
                column: "veterinarioId");

            migrationBuilder.CreateIndex(
                name: "IX_HistoriaClinicas_consultaId",
                table: "HistoriaClinicas",
                column: "consultaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Consultas_Mascotas_mascotaId",
                table: "Consultas",
                column: "mascotaId",
                principalTable: "Mascotas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Consultas_Recetas_recetaId",
                table: "Consultas",
                column: "recetaId",
                principalTable: "Recetas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Mascotas_Usuarios_dueñoId",
                table: "Mascotas",
                column: "dueñoId",
                principalTable: "Usuarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Consultas_Mascotas_mascotaId",
                table: "Consultas");

            migrationBuilder.DropForeignKey(
                name: "FK_Consultas_Recetas_recetaId",
                table: "Consultas");

            migrationBuilder.DropForeignKey(
                name: "FK_Mascotas_Usuarios_dueñoId",
                table: "Mascotas");

            migrationBuilder.DropTable(
                name: "Agendas");

            migrationBuilder.DropTable(
                name: "HistoriaClinicas");

            migrationBuilder.DropTable(
                name: "Recetas");

            migrationBuilder.DropIndex(
                name: "IX_Usuarios_cedula",
                table: "Usuarios");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Mascotas",
                table: "Mascotas");

            migrationBuilder.DropIndex(
                name: "IX_Mascotas_dueñoId",
                table: "Mascotas");

            migrationBuilder.DropColumn(
                name: "email",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "username",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "dueñoId",
                table: "Mascotas");

            migrationBuilder.DropColumn(
                name: "tipoMascota",
                table: "Mascotas");

            migrationBuilder.RenameTable(
                name: "Mascotas",
                newName: "Mascota");

            migrationBuilder.RenameColumn(
                name: "nombre",
                table: "Usuarios",
                newName: "Nombre");

            migrationBuilder.RenameColumn(
                name: "direccion",
                table: "Usuarios",
                newName: "Direccion");

            migrationBuilder.RenameColumn(
                name: "ciudad",
                table: "Usuarios",
                newName: "Ciudad");

            migrationBuilder.RenameColumn(
                name: "celular",
                table: "Usuarios",
                newName: "Celular");

            migrationBuilder.RenameColumn(
                name: "cedula",
                table: "Usuarios",
                newName: "Cedula");

            migrationBuilder.RenameColumn(
                name: "apellido",
                table: "Usuarios",
                newName: "Apellido");

            migrationBuilder.RenameColumn(
                name: "anotacion",
                table: "Consultas",
                newName: "Anotacion");

            migrationBuilder.RenameColumn(
                name: "recetaId",
                table: "Consultas",
                newName: "medicamentesId");

            migrationBuilder.RenameColumn(
                name: "FechaConsulta",
                table: "Consultas",
                newName: "Fecha");

            migrationBuilder.RenameIndex(
                name: "IX_Consultas_recetaId",
                table: "Consultas",
                newName: "IX_Consultas_medicamentesId");

            migrationBuilder.RenameColumn(
                name: "nombre",
                table: "Mascota",
                newName: "Nombre");

            migrationBuilder.RenameColumn(
                name: "fechaNacimiento",
                table: "Mascota",
                newName: "FechaNacimiento");

            migrationBuilder.RenameColumn(
                name: "descripcion",
                table: "Mascota",
                newName: "Descripcion");

            migrationBuilder.AlterColumn<string>(
                name: "password",
                table: "Usuarios",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Cedula",
                table: "Usuarios",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "HorarioDia",
                table: "Usuarios",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Turno",
                table: "Usuarios",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "Consultas",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ListaConsulta",
                table: "Consultas",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Dueño",
                table: "Mascota",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "raza",
                table: "Mascota",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Mascota",
                table: "Mascota",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "medicamentos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Medicinas = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_medicamentos", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_Cedula",
                table: "Usuarios",
                column: "Cedula",
                unique: true,
                filter: "[Cedula] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Consultas_Mascota_mascotaId",
                table: "Consultas",
                column: "mascotaId",
                principalTable: "Mascota",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Consultas_medicamentos_medicamentesId",
                table: "Consultas",
                column: "medicamentesId",
                principalTable: "medicamentos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
