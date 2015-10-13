using System;
using System.Collections.Generic;
using Microsoft.Data.Entity.Migrations;

namespace AspnetBr.Api.Migrations
{
    public partial class iqeurqie343 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsPrincipal",
                table: "Event",
                isNullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(name: "IsPrincipal", table: "Event");
        }
    }
}
