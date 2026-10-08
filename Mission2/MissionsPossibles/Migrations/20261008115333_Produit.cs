using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Mission.Migrations
{
    /// <inheritdoc />
    public partial class Produit : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Produits_Categories_CategorieId",
                table: "Produits");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Produits",
                table: "Produits");

            migrationBuilder.RenameTable(
                name: "Produits",
                newName: "produits");

            migrationBuilder.RenameIndex(
                name: "IX_Produits_CategorieId",
                table: "produits",
                newName: "IX_produits_CategorieId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_produits",
                table: "produits",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "produits",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreation",
                value: new DateTime(2026, 10, 8, 7, 53, 32, 343, DateTimeKind.Local).AddTicks(2716));

            migrationBuilder.UpdateData(
                table: "produits",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreation",
                value: new DateTime(2026, 10, 8, 7, 53, 32, 343, DateTimeKind.Local).AddTicks(2742));

            migrationBuilder.UpdateData(
                table: "produits",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreation",
                value: new DateTime(2026, 10, 8, 7, 53, 32, 343, DateTimeKind.Local).AddTicks(2757));

            migrationBuilder.UpdateData(
                table: "produits",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreation",
                value: new DateTime(2026, 10, 8, 7, 53, 32, 343, DateTimeKind.Local).AddTicks(2771));

            migrationBuilder.UpdateData(
                table: "produits",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreation",
                value: new DateTime(2026, 10, 8, 7, 53, 32, 343, DateTimeKind.Local).AddTicks(2785));

            migrationBuilder.UpdateData(
                table: "produits",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreation",
                value: new DateTime(2026, 10, 8, 7, 53, 32, 343, DateTimeKind.Local).AddTicks(2803));

            migrationBuilder.UpdateData(
                table: "produits",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreation",
                value: new DateTime(2026, 10, 8, 7, 53, 32, 343, DateTimeKind.Local).AddTicks(2818));

            migrationBuilder.UpdateData(
                table: "produits",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreation",
                value: new DateTime(2026, 10, 8, 7, 53, 32, 343, DateTimeKind.Local).AddTicks(2833));

            migrationBuilder.UpdateData(
                table: "produits",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreation",
                value: new DateTime(2026, 10, 8, 7, 53, 32, 343, DateTimeKind.Local).AddTicks(2847));

            migrationBuilder.UpdateData(
                table: "produits",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreation",
                value: new DateTime(2026, 10, 8, 7, 53, 32, 343, DateTimeKind.Local).AddTicks(2864));

            migrationBuilder.UpdateData(
                table: "produits",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreation",
                value: new DateTime(2026, 10, 8, 7, 53, 32, 343, DateTimeKind.Local).AddTicks(2879));

            migrationBuilder.UpdateData(
                table: "produits",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreation",
                value: new DateTime(2026, 10, 8, 7, 53, 32, 343, DateTimeKind.Local).AddTicks(2893));

            migrationBuilder.UpdateData(
                table: "produits",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreation",
                value: new DateTime(2026, 10, 8, 7, 53, 32, 343, DateTimeKind.Local).AddTicks(2908));

            migrationBuilder.UpdateData(
                table: "produits",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreation",
                value: new DateTime(2026, 10, 8, 7, 53, 32, 343, DateTimeKind.Local).AddTicks(2961));

            migrationBuilder.UpdateData(
                table: "produits",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateCreation",
                value: new DateTime(2026, 10, 8, 7, 53, 32, 343, DateTimeKind.Local).AddTicks(2976));

            migrationBuilder.UpdateData(
                table: "produits",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateCreation",
                value: new DateTime(2026, 10, 8, 7, 53, 32, 343, DateTimeKind.Local).AddTicks(2990));

            migrationBuilder.UpdateData(
                table: "produits",
                keyColumn: "Id",
                keyValue: 17,
                column: "DateCreation",
                value: new DateTime(2026, 10, 8, 7, 53, 32, 343, DateTimeKind.Local).AddTicks(3005));

            migrationBuilder.UpdateData(
                table: "produits",
                keyColumn: "Id",
                keyValue: 18,
                column: "DateCreation",
                value: new DateTime(2026, 10, 8, 7, 53, 32, 343, DateTimeKind.Local).AddTicks(3020));

            migrationBuilder.UpdateData(
                table: "produits",
                keyColumn: "Id",
                keyValue: 19,
                column: "DateCreation",
                value: new DateTime(2026, 10, 8, 7, 53, 32, 343, DateTimeKind.Local).AddTicks(3034));

            migrationBuilder.UpdateData(
                table: "produits",
                keyColumn: "Id",
                keyValue: 20,
                column: "DateCreation",
                value: new DateTime(2026, 10, 8, 7, 53, 32, 343, DateTimeKind.Local).AddTicks(3048));

            migrationBuilder.AddForeignKey(
                name: "FK_produits_Categories_CategorieId",
                table: "produits",
                column: "CategorieId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_produits_Categories_CategorieId",
                table: "produits");

            migrationBuilder.DropPrimaryKey(
                name: "PK_produits",
                table: "produits");

            migrationBuilder.RenameTable(
                name: "produits",
                newName: "Produits");

            migrationBuilder.RenameIndex(
                name: "IX_produits_CategorieId",
                table: "Produits",
                newName: "IX_Produits_CategorieId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Produits",
                table: "Produits",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "Produits",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreation",
                value: new DateTime(2024, 10, 10, 17, 33, 54, 570, DateTimeKind.Local).AddTicks(4834));

            migrationBuilder.UpdateData(
                table: "Produits",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreation",
                value: new DateTime(2024, 10, 10, 17, 33, 54, 570, DateTimeKind.Local).AddTicks(4853));

            migrationBuilder.UpdateData(
                table: "Produits",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreation",
                value: new DateTime(2024, 10, 10, 17, 33, 54, 570, DateTimeKind.Local).AddTicks(4867));

            migrationBuilder.UpdateData(
                table: "Produits",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreation",
                value: new DateTime(2024, 10, 10, 17, 33, 54, 570, DateTimeKind.Local).AddTicks(4881));

            migrationBuilder.UpdateData(
                table: "Produits",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreation",
                value: new DateTime(2024, 10, 10, 17, 33, 54, 570, DateTimeKind.Local).AddTicks(4895));

            migrationBuilder.UpdateData(
                table: "Produits",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreation",
                value: new DateTime(2024, 10, 10, 17, 33, 54, 570, DateTimeKind.Local).AddTicks(4914));

            migrationBuilder.UpdateData(
                table: "Produits",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreation",
                value: new DateTime(2024, 10, 10, 17, 33, 54, 570, DateTimeKind.Local).AddTicks(4928));

            migrationBuilder.UpdateData(
                table: "Produits",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreation",
                value: new DateTime(2024, 10, 10, 17, 33, 54, 570, DateTimeKind.Local).AddTicks(4942));

            migrationBuilder.UpdateData(
                table: "Produits",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreation",
                value: new DateTime(2024, 10, 10, 17, 33, 54, 570, DateTimeKind.Local).AddTicks(4956));

            migrationBuilder.UpdateData(
                table: "Produits",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreation",
                value: new DateTime(2024, 10, 10, 17, 33, 54, 570, DateTimeKind.Local).AddTicks(4992));

            migrationBuilder.UpdateData(
                table: "Produits",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreation",
                value: new DateTime(2024, 10, 10, 17, 33, 54, 570, DateTimeKind.Local).AddTicks(5006));

            migrationBuilder.UpdateData(
                table: "Produits",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreation",
                value: new DateTime(2024, 10, 10, 17, 33, 54, 570, DateTimeKind.Local).AddTicks(5019));

            migrationBuilder.UpdateData(
                table: "Produits",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreation",
                value: new DateTime(2024, 10, 10, 17, 33, 54, 570, DateTimeKind.Local).AddTicks(5033));

            migrationBuilder.UpdateData(
                table: "Produits",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreation",
                value: new DateTime(2024, 10, 10, 17, 33, 54, 570, DateTimeKind.Local).AddTicks(5047));

            migrationBuilder.UpdateData(
                table: "Produits",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateCreation",
                value: new DateTime(2024, 10, 10, 17, 33, 54, 570, DateTimeKind.Local).AddTicks(5060));

            migrationBuilder.UpdateData(
                table: "Produits",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateCreation",
                value: new DateTime(2024, 10, 10, 17, 33, 54, 570, DateTimeKind.Local).AddTicks(5074));

            migrationBuilder.UpdateData(
                table: "Produits",
                keyColumn: "Id",
                keyValue: 17,
                column: "DateCreation",
                value: new DateTime(2024, 10, 10, 17, 33, 54, 570, DateTimeKind.Local).AddTicks(5087));

            migrationBuilder.UpdateData(
                table: "Produits",
                keyColumn: "Id",
                keyValue: 18,
                column: "DateCreation",
                value: new DateTime(2024, 10, 10, 17, 33, 54, 570, DateTimeKind.Local).AddTicks(5102));

            migrationBuilder.UpdateData(
                table: "Produits",
                keyColumn: "Id",
                keyValue: 19,
                column: "DateCreation",
                value: new DateTime(2024, 10, 10, 17, 33, 54, 570, DateTimeKind.Local).AddTicks(5116));

            migrationBuilder.UpdateData(
                table: "Produits",
                keyColumn: "Id",
                keyValue: 20,
                column: "DateCreation",
                value: new DateTime(2024, 10, 10, 17, 33, 54, 570, DateTimeKind.Local).AddTicks(5130));

            migrationBuilder.AddForeignKey(
                name: "FK_Produits_Categories_CategorieId",
                table: "Produits",
                column: "CategorieId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
