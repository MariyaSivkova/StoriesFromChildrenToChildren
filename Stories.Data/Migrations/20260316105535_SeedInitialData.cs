using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Stories.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedInitialData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "seed-user-id", 0, "0e3fe523-be7d-4355-995e-f3a5a4f0d8b0", "admin@site.com", true, false, null, "ADMIN@SITE.COM", "ADMIN@SITE.COM", "AQAAAAIAAYagAAAAEBQzPxyTzhJH0n8lIzXGhCwGGg179WRr+AXCTt+uPxrjGerPI7aCK74aM1xQhl5asw==", null, false, "2a8a37c5-b7bb-4799-a8a7-b6b4bb3705ac", false, "admin@site.com" });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "Biography", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 1, "Charles Perrault was a French author best known for laying the foundations of the fairy tale genre with stories such as Cinderella and Sleeping Beauty.", "Charles", "Perrault" },
                    { 2, "Hans Christian Andersen was a Danish author famous for his timeless fairy tales including The Little Mermaid, The Ugly Duckling, and The Snow Queen.", "Hans Christian", "Andersen" },
                    { 3, "Lewis Carroll was an English writer and mathematician best known for the children's fantasy novel Alice's Adventures in Wonderland.", "Lewis", "Carroll" },
                    { 4, "J. M. Barrie was a Scottish novelist and playwright best remembered as the creator of Peter Pan, the boy who never grows up.", "J. M.", "Barrie" },
                    { 5, "J. R. R. Tolkien was an English writer and professor famous for his fantasy works including The Hobbit and The Lord of the Rings.", "J. R. R.", "Tolkien" },
                    { 6, "Joanna Cole was an American author best known for the educational children's series The Magic School Bus.", "Joanna", "Cole" },
                    { 7, "Steve Parker is a British science writer known for creating engaging science books for children and young readers.", "Steve", "Parker" },
                    { 8, "Robert Louis Stevenson was a Scottish novelist and poet, well known for works such as Treasure Island and the poetry collection A Child's Garden of Verses.", "Robert Louis", "Stevenson" },
                    { 9, "Shel Silverstein was an American writer, poet, and illustrator famous for beloved children's poetry collections such as Where the Sidewalk Ends.", "Shel", "Silverstein" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CategoryName" },
                values: new object[,]
                {
                    { 1, "Fairy Tales" },
                    { 2, "Novels for Children" },
                    { 3, "Science" },
                    { 4, "Poems" }
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Annotation", "AuthorId", "CategoryId", "Date", "Description", "PathToAudiobook", "PathToCover", "Title", "UserId" },
                values: new object[,]
                {
                    { 1, "A magical fairy tale about kindness and hope.", 1, 1, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cinderella overcomes hardship with the help of magic and kindness.", "/audio/cinderella.mp3", "/Images/covers/cinderella.jpg", "Cinderella", "seed-user-id" },
                    { 2, "A princess escapes the evil queen and finds new friends.", 1, 1, new DateTime(2024, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "A classic story about friendship, courage, and kindness.", "/audio/snowwhite.mp3", "/Images/covers/snezhanka.jpg", "Snow White and the Seven Dwarfs", "seed-user-id" },
                    { 3, "A mermaid dreams of becoming human.", 2, 1, new DateTime(2024, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "A touching fairy tale about dreams, sacrifice, and love.", "/audio/littlemermaid.mp3", "/Images/covers/blankCover.jpg", "The Little Mermaid", "seed-user-id" },
                    { 4, "A curious girl enters a strange magical world.", 3, 2, new DateTime(2024, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Alice explores a fantasy world filled with unusual characters.", "/audio/alice.mp3", "/Images/covers/blankCover.jpg", "Alice in Wonderland", "seed-user-id" },
                    { 5, "The boy who never grows up.", 4, 2, new DateTime(2024, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Peter Pan takes children on adventures in Neverland.", "/audio/peterpan.mp3", "/Images/covers/blankCover.jpg", "Peter Pan", "seed-user-id" },
                    { 6, "A hobbit goes on a great adventure.", 5, 2, new DateTime(2024, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bilbo Baggins joins a quest to reclaim treasure from a dragon.", "/audio/hobbit.mp3", "/Images/covers/hobbit.jpg", "The Hobbit", "seed-user-id" },
                    { 7, "A fun journey through the human body.", 6, 3, new DateTime(2024, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Children learn science through an exciting adventure.", "/audio/magicschoolbus.mp3", "/Images/covers/magicschoolbus.jpg", "The Magic School Bus: Inside the Human Body", "seed-user-id" },
                    { 8, "Discover planets, stars, and galaxies.", 7, 3, new DateTime(2024, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "A child-friendly introduction to space science.", "/audio/spacekids.mp3", "/Images/covers/spacekids.jpg", "Space for Young Explorers", "seed-user-id" },
                    { 9, "100 things you should know about World Wonders.", 7, 3, new DateTime(2024, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "It takes you on a thrilling tour of mighty monuments and awesome natural features. Exactly 100 facts, accompanied by detailed artwork, bring to life ancient stone giants, undersea cities, and mighty migrations made by living things. ", "/audio/experiments.mp3", "/Images/covers/blankCover.jpg", "World Wonders (100 Things You Should Know About Series)", "seed-user-id" },
                    { 10, "Funny and imaginative children's poems.", 9, 4, new DateTime(2024, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "A beloved collection of humorous and creative poetry.", "/audio/sidewalkends.mp3", "/Images/covers/blankCover.jpg", "Where the Sidewalk Ends", "seed-user-id" },
                    { 11, "Classic poems about childhood.", 8, 4, new DateTime(2024, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "A timeless collection of poems loved by generations.", "/audio/gardenofverses.mp3", "/Images/covers/blankCover.jpg", "A Child's Garden of Verses", "seed-user-id" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "seed-user-id");

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
