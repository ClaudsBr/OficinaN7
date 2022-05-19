using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OficinaN7.Migrations
{
    public partial class MelhorandoAsEntidades : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Clients_Addresses_EnderecoId",
                table: "Clients");

            migrationBuilder.DropForeignKey(
                name: "FK_Clients_Schedules_AgendaId",
                table: "Clients");

            migrationBuilder.RenameColumn(
                name: "DataHora",
                table: "Schedules",
                newName: "DateTime");

            migrationBuilder.RenameColumn(
                name: "Telefone",
                table: "Clients",
                newName: "RG");

            migrationBuilder.RenameColumn(
                name: "Nome",
                table: "Clients",
                newName: "Phone");

            migrationBuilder.RenameColumn(
                name: "EnderecoId",
                table: "Clients",
                newName: "ScheduleId");

            migrationBuilder.RenameColumn(
                name: "AgendaId",
                table: "Clients",
                newName: "AddressId");

            migrationBuilder.RenameIndex(
                name: "IX_Clients_EnderecoId",
                table: "Clients",
                newName: "IX_Clients_ScheduleId");

            migrationBuilder.RenameIndex(
                name: "IX_Clients_AgendaId",
                table: "Clients",
                newName: "IX_Clients_AddressId");

            migrationBuilder.AddColumn<DateTime>(
                name: "BirthDate",
                table: "Clients",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "CPF",
                table: "Clients",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Clients",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "Complemento",
                table: "Addresses",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddForeignKey(
                name: "FK_Clients_Addresses_AddressId",
                table: "Clients",
                column: "AddressId",
                principalTable: "Addresses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Clients_Schedules_ScheduleId",
                table: "Clients",
                column: "ScheduleId",
                principalTable: "Schedules",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Clients_Addresses_AddressId",
                table: "Clients");

            migrationBuilder.DropForeignKey(
                name: "FK_Clients_Schedules_ScheduleId",
                table: "Clients");

            migrationBuilder.DropColumn(
                name: "BirthDate",
                table: "Clients");

            migrationBuilder.DropColumn(
                name: "CPF",
                table: "Clients");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Clients");

            migrationBuilder.DropColumn(
                name: "Complemento",
                table: "Addresses");

            migrationBuilder.RenameColumn(
                name: "DateTime",
                table: "Schedules",
                newName: "DataHora");

            migrationBuilder.RenameColumn(
                name: "ScheduleId",
                table: "Clients",
                newName: "EnderecoId");

            migrationBuilder.RenameColumn(
                name: "RG",
                table: "Clients",
                newName: "Telefone");

            migrationBuilder.RenameColumn(
                name: "Phone",
                table: "Clients",
                newName: "Nome");

            migrationBuilder.RenameColumn(
                name: "AddressId",
                table: "Clients",
                newName: "AgendaId");

            migrationBuilder.RenameIndex(
                name: "IX_Clients_ScheduleId",
                table: "Clients",
                newName: "IX_Clients_EnderecoId");

            migrationBuilder.RenameIndex(
                name: "IX_Clients_AddressId",
                table: "Clients",
                newName: "IX_Clients_AgendaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Clients_Addresses_EnderecoId",
                table: "Clients",
                column: "EnderecoId",
                principalTable: "Addresses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Clients_Schedules_AgendaId",
                table: "Clients",
                column: "AgendaId",
                principalTable: "Schedules",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
