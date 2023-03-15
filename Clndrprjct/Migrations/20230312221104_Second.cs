using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Clndrprjct.Migrations
{
    /// <inheritdoc />
    public partial class Second : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CalendarEvent_User_UserId",
                table: "CalendarEvent");

            migrationBuilder.DropForeignKey(
                name: "FK_Reminders_CalendarEvent_CalendarEventId",
                table: "Reminders");

            migrationBuilder.DropForeignKey(
                name: "FK_Reminders_User_UserId",
                table: "Reminders");

            migrationBuilder.DropPrimaryKey(
                name: "PK_User",
                table: "User");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CalendarEvent",
                table: "CalendarEvent");

            migrationBuilder.RenameTable(
                name: "User",
                newName: "Users");

            migrationBuilder.RenameTable(
                name: "CalendarEvent",
                newName: "CalendarEvents");

            migrationBuilder.RenameIndex(
                name: "IX_CalendarEvent_UserId",
                table: "CalendarEvents",
                newName: "IX_CalendarEvents_UserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Users",
                table: "Users",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CalendarEvents",
                table: "CalendarEvents",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CalendarEvents_Users_UserId",
                table: "CalendarEvents",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Reminders_CalendarEvents_CalendarEventId",
                table: "Reminders",
                column: "CalendarEventId",
                principalTable: "CalendarEvents",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Reminders_Users_UserId",
                table: "Reminders",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CalendarEvents_Users_UserId",
                table: "CalendarEvents");

            migrationBuilder.DropForeignKey(
                name: "FK_Reminders_CalendarEvents_CalendarEventId",
                table: "Reminders");

            migrationBuilder.DropForeignKey(
                name: "FK_Reminders_Users_UserId",
                table: "Reminders");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Users",
                table: "Users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CalendarEvents",
                table: "CalendarEvents");

            migrationBuilder.RenameTable(
                name: "Users",
                newName: "User");

            migrationBuilder.RenameTable(
                name: "CalendarEvents",
                newName: "CalendarEvent");

            migrationBuilder.RenameIndex(
                name: "IX_CalendarEvents_UserId",
                table: "CalendarEvent",
                newName: "IX_CalendarEvent_UserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_User",
                table: "User",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CalendarEvent",
                table: "CalendarEvent",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CalendarEvent_User_UserId",
                table: "CalendarEvent",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Reminders_CalendarEvent_CalendarEventId",
                table: "Reminders",
                column: "CalendarEventId",
                principalTable: "CalendarEvent",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Reminders_User_UserId",
                table: "Reminders",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
