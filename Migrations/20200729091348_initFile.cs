using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ODataDemo.Migrations
{
    public partial class initFile : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.CreateTable(
                name: "Files",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    ContentType = table.Column<string>(nullable: true),
                    Filename = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Files", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FileStatus",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Status = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FileStatus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FileFileStatus",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    FileId = table.Column<Guid>(nullable: false),
                    FileStatusId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FileFileStatus", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FileFileStatus_Files_FileId",
                        column: x => x.FileId,
                        principalTable: "Files",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FileFileStatus_FileStatus_FileStatusId",
                        column: x => x.FileStatusId,
                        principalTable: "FileStatus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_FileFileStatus_FileId",
                table: "FileFileStatus",
                column: "FileId");

            migrationBuilder.CreateIndex(
                name: "IX_FileFileStatus_FileStatusId",
                table: "FileFileStatus",
                column: "FileStatusId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FileFileStatus");

            migrationBuilder.DropTable(
                name: "Files");

            migrationBuilder.DropTable(
                name: "FileStatus");

          
        }
    }
}
