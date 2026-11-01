using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace G_ASP_NET_83_EFCore02.Migrations
{
    /// <inheritdoc />
    public partial class ExamHubDbMTM : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Attendees_Events_EventId",
                table: "Attendees");

            migrationBuilder.DropIndex(
                name: "IX_Attendees_EventId",
                table: "Attendees");

            migrationBuilder.RenameColumn(
                name: "EventId",
                table: "Attendees",
                newName: "EventAttendeeEventId");

            migrationBuilder.AddColumn<int>(
                name: "EventAttendeeAttendeeId",
                table: "Events",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EventAttendeeEventId",
                table: "Events",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EventAttendeeAttendeeId",
                table: "Attendees",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "EventAttendee",
                columns: table => new
                {
                    EventId = table.Column<int>(type: "int", nullable: false),
                    AttendeeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EventAttendee", x => new { x.EventId, x.AttendeeId });
                });

            migrationBuilder.CreateIndex(
                name: "IX_Events_EventAttendeeEventId_EventAttendeeAttendeeId",
                table: "Events",
                columns: new[] { "EventAttendeeEventId", "EventAttendeeAttendeeId" });

            migrationBuilder.CreateIndex(
                name: "IX_Attendees_EventAttendeeEventId_EventAttendeeAttendeeId",
                table: "Attendees",
                columns: new[] { "EventAttendeeEventId", "EventAttendeeAttendeeId" });

            migrationBuilder.AddForeignKey(
                name: "FK_Attendees_EventAttendee_EventAttendeeEventId_EventAttendeeAttendeeId",
                table: "Attendees",
                columns: new[] { "EventAttendeeEventId", "EventAttendeeAttendeeId" },
                principalTable: "EventAttendee",
                principalColumns: new[] { "EventId", "AttendeeId" });

            migrationBuilder.AddForeignKey(
                name: "FK_Events_EventAttendee_EventAttendeeEventId_EventAttendeeAttendeeId",
                table: "Events",
                columns: new[] { "EventAttendeeEventId", "EventAttendeeAttendeeId" },
                principalTable: "EventAttendee",
                principalColumns: new[] { "EventId", "AttendeeId" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Attendees_EventAttendee_EventAttendeeEventId_EventAttendeeAttendeeId",
                table: "Attendees");

            migrationBuilder.DropForeignKey(
                name: "FK_Events_EventAttendee_EventAttendeeEventId_EventAttendeeAttendeeId",
                table: "Events");

            migrationBuilder.DropTable(
                name: "EventAttendee");

            migrationBuilder.DropIndex(
                name: "IX_Events_EventAttendeeEventId_EventAttendeeAttendeeId",
                table: "Events");

            migrationBuilder.DropIndex(
                name: "IX_Attendees_EventAttendeeEventId_EventAttendeeAttendeeId",
                table: "Attendees");

            migrationBuilder.DropColumn(
                name: "EventAttendeeAttendeeId",
                table: "Events");

            migrationBuilder.DropColumn(
                name: "EventAttendeeEventId",
                table: "Events");

            migrationBuilder.DropColumn(
                name: "EventAttendeeAttendeeId",
                table: "Attendees");

            migrationBuilder.RenameColumn(
                name: "EventAttendeeEventId",
                table: "Attendees",
                newName: "EventId");

            migrationBuilder.CreateIndex(
                name: "IX_Attendees_EventId",
                table: "Attendees",
                column: "EventId");

            migrationBuilder.AddForeignKey(
                name: "FK_Attendees_Events_EventId",
                table: "Attendees",
                column: "EventId",
                principalTable: "Events",
                principalColumn: "Id");
        }
    }
}
