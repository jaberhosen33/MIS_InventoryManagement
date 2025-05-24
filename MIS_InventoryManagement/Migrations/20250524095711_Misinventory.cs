using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MIS_InventoryManagement.Migrations
{
    public partial class Misinventory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "StafInformations",
                columns: table => new
                {
                    StafId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Dpt = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Designation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Mail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StafInformations", x => x.StafId);
                });

            migrationBuilder.CreateTable(
                name: "PcInformations",
                columns: table => new
                {
                    SlNo = table.Column<int>(type: "int", nullable: false),
                    BrandName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModelNo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Ram = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Ssd = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Hhd = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Processor = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Generation = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    VandorName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    StafId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PcInformations", x => x.SlNo);
                    table.ForeignKey(
                        name: "FK_PcInformations_StafInformations_StafId",
                        column: x => x.StafId,
                        principalTable: "StafInformations",
                        principalColumn: "StafId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Accessories",
                columns: table => new
                {
                    AccessoriesID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Device_type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Brand = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VandorName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Capasity = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    AddBY = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    StaffId = table.Column<int>(type: "int", nullable: false),
                    PC_SLNO = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Accessories", x => x.AccessoriesID);
                    table.ForeignKey(
                        name: "FK_Accessories_PcInformations_PC_SLNO",
                        column: x => x.PC_SLNO,
                        principalTable: "PcInformations",
                        principalColumn: "SlNo",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Accessories_StafInformations_StaffId",
                        column: x => x.StaffId,
                        principalTable: "StafInformations",
                        principalColumn: "StafId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Accessories_PC_SLNO",
                table: "Accessories",
                column: "PC_SLNO");

            migrationBuilder.CreateIndex(
                name: "IX_Accessories_StaffId",
                table: "Accessories",
                column: "StaffId");

            migrationBuilder.CreateIndex(
                name: "IX_PcInformations_StafId",
                table: "PcInformations",
                column: "StafId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Accessories");

            migrationBuilder.DropTable(
                name: "PcInformations");

            migrationBuilder.DropTable(
                name: "StafInformations");
        }
    }
}
