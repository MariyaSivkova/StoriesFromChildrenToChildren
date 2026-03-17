using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Stories.Data.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedPathsInSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "seed-user-id",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b3a55c00-0fd6-4bd3-ab65-f1fb2de34130", "AQAAAAIAAYagAAAAEKlBZZ1fBE9xTMzWSWizZ1wDCp76NU18J5I/bcfc0etlt17kYQFYDhNdUGdRK1lRBw==", "982146a2-b461-4f2f-84df-3bbcbfaee681" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                column: "PathToAudiobook",
                value: "/audio/cinderella.m4a");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                column: "PathToAudiobook",
                value: "/audio/snowwhite.m4a");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                column: "PathToAudiobook",
                value: "/audio/littlemermaid.m4a");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4,
                column: "PathToAudiobook",
                value: "/audio/alice.m4a");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5,
                column: "PathToAudiobook",
                value: "/audio/peterpan.m4a");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 6,
                column: "PathToAudiobook",
                value: "/audio/hobbit.m4a");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 7,
                column: "PathToAudiobook",
                value: "/audio/magicschoolbus.m4a");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 8,
                column: "PathToAudiobook",
                value: "/audio/spacekids.m4a");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 9,
                column: "PathToAudiobook",
                value: "/audio/experiments.m4a");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 10,
                column: "PathToAudiobook",
                value: "/audio/sidewalkends.m4a");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 11,
                column: "PathToAudiobook",
                value: "/audio/gardenofverses.m4a");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "seed-user-id",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0e3fe523-be7d-4355-995e-f3a5a4f0d8b0", "AQAAAAIAAYagAAAAEBQzPxyTzhJH0n8lIzXGhCwGGg179WRr+AXCTt+uPxrjGerPI7aCK74aM1xQhl5asw==", "2a8a37c5-b7bb-4799-a8a7-b6b4bb3705ac" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                column: "PathToAudiobook",
                value: "/audio/cinderella.mp3");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                column: "PathToAudiobook",
                value: "/audio/snowwhite.mp3");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                column: "PathToAudiobook",
                value: "/audio/littlemermaid.mp3");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4,
                column: "PathToAudiobook",
                value: "/audio/alice.mp3");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5,
                column: "PathToAudiobook",
                value: "/audio/peterpan.mp3");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 6,
                column: "PathToAudiobook",
                value: "/audio/hobbit.mp3");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 7,
                column: "PathToAudiobook",
                value: "/audio/magicschoolbus.mp3");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 8,
                column: "PathToAudiobook",
                value: "/audio/spacekids.mp3");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 9,
                column: "PathToAudiobook",
                value: "/audio/experiments.mp3");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 10,
                column: "PathToAudiobook",
                value: "/audio/sidewalkends.mp3");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 11,
                column: "PathToAudiobook",
                value: "/audio/gardenofverses.mp3");
        }
    }
}
