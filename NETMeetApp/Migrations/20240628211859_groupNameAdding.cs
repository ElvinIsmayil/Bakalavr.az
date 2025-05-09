﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NETMeetApp.Migrations
{
    /// <inheritdoc />
    public partial class groupNameAdding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "GroupName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "GroupName",
                table: "AspNetUsers");
        }
    }
}
