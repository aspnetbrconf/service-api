using System;
using System.Collections.Generic;
using Microsoft.Data.Entity.Migrations;

namespace AspnetBr.Api.Migrations
{
    public partial class CreateModelMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Local",
                columns: table => new
                {
                    Id = table.Column<int>(isNullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Address = table.Column<string>(isNullable: true),
                    MapsUrl = table.Column<string>(isNullable: true),
                    Name = table.Column<string>(isNullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Local", x => x.Id);
                });
            migrationBuilder.CreateTable(
                name: "Schedule",
                columns: table => new
                {
                    Id = table.Column<int>(isNullable: false)
                        .Annotation("Sqlite:Autoincrement", true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Schedule", x => x.Id);
                });
            migrationBuilder.CreateTable(
                name: "Talk",
                columns: table => new
                {
                    Id = table.Column<int>(isNullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Description = table.Column<string>(isNullable: true),
                    Title = table.Column<string>(isNullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Talk", x => x.Id);
                });
            migrationBuilder.CreateTable(
                name: "Event",
                columns: table => new
                {
                    Id = table.Column<int>(isNullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    DueDate = table.Column<DateTime>(isNullable: false),
                    Edition = table.Column<string>(isNullable: true),
                    LocalId = table.Column<int>(isNullable: true),
                    Title = table.Column<string>(isNullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Event", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Event_Local_LocalId",
                        column: x => x.LocalId,
                        principalTable: "Local",
                        principalColumn: "Id");
                });
            migrationBuilder.CreateTable(
                name: "ScheduleItem",
                columns: table => new
                {
                    Id = table.Column<int>(isNullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Finish = table.Column<DateTime>(isNullable: false),
                    Order = table.Column<int>(isNullable: false),
                    ScheduleId = table.Column<int>(isNullable: true),
                    Start = table.Column<DateTime>(isNullable: false),
                    TalkId = table.Column<int>(isNullable: true),
                    TimeInfo = table.Column<string>(isNullable: true),
                    Title = table.Column<string>(isNullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ScheduleItem", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ScheduleItem_Schedule_ScheduleId",
                        column: x => x.ScheduleId,
                        principalTable: "Schedule",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ScheduleItem_Talk_TalkId",
                        column: x => x.TalkId,
                        principalTable: "Talk",
                        principalColumn: "Id");
                });
            migrationBuilder.CreateTable(
                name: "Speaker",
                columns: table => new
                {
                    Id = table.Column<int>(isNullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Bio = table.Column<string>(isNullable: true),
                    Fullname = table.Column<string>(isNullable: true),
                    PhotoUrl = table.Column<string>(isNullable: true),
                    TalkId = table.Column<int>(isNullable: true),
                    Title = table.Column<string>(isNullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Speaker", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Speaker_Talk_TalkId",
                        column: x => x.TalkId,
                        principalTable: "Talk",
                        principalColumn: "Id");
                });
            migrationBuilder.CreateTable(
                name: "Contact",
                columns: table => new
                {
                    Id = table.Column<int>(isNullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    EventId = table.Column<int>(isNullable: true),
                    Text = table.Column<string>(isNullable: true),
                    Type = table.Column<string>(isNullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contact", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Contact_Event_EventId",
                        column: x => x.EventId,
                        principalTable: "Event",
                        principalColumn: "Id");
                });
            migrationBuilder.CreateTable(
                name: "Sponsor",
                columns: table => new
                {
                    Id = table.Column<int>(isNullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    EventId = table.Column<int>(isNullable: true),
                    Level = table.Column<string>(isNullable: true),
                    Name = table.Column<string>(isNullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sponsor", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Sponsor_Event_EventId",
                        column: x => x.EventId,
                        principalTable: "Event",
                        principalColumn: "Id");
                });
            migrationBuilder.CreateTable(
                name: "Track",
                columns: table => new
                {
                    Id = table.Column<int>(isNullable: false),
                    Day = table.Column<DateTime>(isNullable: false),
                    Description = table.Column<string>(isNullable: true),
                    EventId = table.Column<int>(isNullable: true),
                    Room = table.Column<string>(isNullable: true),
                    Title = table.Column<string>(isNullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Track", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Track_Event_EventId",
                        column: x => x.EventId,
                        principalTable: "Event",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Track_Schedule_Id",
                        column: x => x.Id,
                        principalTable: "Schedule",
                        principalColumn: "Id");
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable("Contact");
            migrationBuilder.DropTable("ScheduleItem");
            migrationBuilder.DropTable("Speaker");
            migrationBuilder.DropTable("Sponsor");
            migrationBuilder.DropTable("Track");
            migrationBuilder.DropTable("Talk");
            migrationBuilder.DropTable("Event");
            migrationBuilder.DropTable("Schedule");
            migrationBuilder.DropTable("Local");
        }
    }
}
