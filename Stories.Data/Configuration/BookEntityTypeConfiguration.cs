
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Stories.DataModels;

namespace Stories.Data.Configuration
{
    public class BookEntityTypeConfiguration : IEntityTypeConfiguration<Book>
    {

        private readonly Book[] Book =
        {
            new Book
            {
                Id = 1,
                Title = "Cinderella",
                PathToAudiobook = "/audio/cinderella.m4a",
                PathToCover = "/Images/covers/cinderella.jpg",
                Annotation = "A magical fairy tale about kindness and hope.",
                Description = "Cinderella overcomes hardship with the help of magic and kindness.",
                Date = new DateTime(2024, 1, 1),
                UserId = "seed-user-id",
                AuthorId = 1,
                CategoryId = 1
            },
            new Book
            {
                Id = 2,
                Title = "Snow White and the Seven Dwarfs",
                PathToAudiobook = "/audio/snowwhite.m4a",
                PathToCover = "/Images/covers/snezhanka.jpg",
                Annotation = "A princess escapes the evil queen and finds new friends.",
                Description = "A classic story about friendship, courage, and kindness.",
                Date = new DateTime(2024, 1, 2),
                UserId = "seed-user-id",
                AuthorId = 1,
                CategoryId = 1
            },
            new Book
            {
                Id = 3,
                Title = "The Little Mermaid",
                PathToAudiobook = "/audio/littlemermaid.m4a",
                PathToCover = "/Images/covers/blankCover.jpg",
                Annotation = "A mermaid dreams of becoming human.",
                Description = "A touching fairy tale about dreams, sacrifice, and love.",
                Date = new DateTime(2024, 1, 3),
                UserId = "seed-user-id",
                AuthorId = 2,
                CategoryId = 1
            },
            new Book
            {
                Id = 4,
                Title = "Alice in Wonderland",
                PathToAudiobook = "/audio/alice.m4a",
                PathToCover = "/Images/covers/blankCover.jpg",
                Annotation = "A curious girl enters a strange magical world.",
                Description = "Alice explores a fantasy world filled with unusual characters.",
                Date = new DateTime(2024, 1, 4),
                UserId = "seed-user-id",
                AuthorId = 3,
                CategoryId = 2
            },
            new Book
            {
                Id = 5,
                Title = "Peter Pan",
                PathToAudiobook = "/audio/peterpan.m4a",
                PathToCover = "/Images/covers/blankCover.jpg",
                Annotation = "The boy who never grows up.",
                Description = "Peter Pan takes children on adventures in Neverland.",
                Date = new DateTime(2024, 1, 5),
                UserId = "seed-user-id",
                AuthorId = 4,
                CategoryId = 2
            },
            new Book
            {
                Id = 6,
                Title = "The Hobbit",
                PathToAudiobook = "/audio/hobbit.m4a",
                PathToCover = "/Images/covers/hobbit.jpg",
                Annotation = "A hobbit goes on a great adventure.",
                Description = "Bilbo Baggins joins a quest to reclaim treasure from a dragon.",
                Date = new DateTime(2024, 1, 6),
                UserId = "seed-user-id",
                AuthorId = 5,
                CategoryId = 2
            },
            new Book
            {
                Id = 7,
                Title = "The Magic School Bus: Inside the Human Body",
                PathToAudiobook = "/audio/magicschoolbus.m4a",
                PathToCover = "/Images/covers/magicschoolbus.jpg",
                Annotation = "A fun journey through the human body.",
                Description = "Children learn science through an exciting adventure.",
                Date = new DateTime(2024, 1, 7),
                UserId = "seed-user-id",
                AuthorId = 6,
                CategoryId = 3
            },
            new Book
            {
                Id = 8,
                Title = "Space for Young Explorers",
                PathToAudiobook = "/audio/spacekids.m4a",
                PathToCover = "/Images/covers/spacekids.jpg",
                Annotation = "Discover planets, stars, and galaxies.",
                Description = "A child-friendly introduction to space science.",
                Date = new DateTime(2024, 1, 8),
                UserId = "seed-user-id",
                AuthorId = 7,
                CategoryId = 3
            },
            new Book
            {
                Id = 9,
                Title = "World Wonders (100 Things You Should Know About Series)",
                PathToAudiobook = "/audio/experiments.m4a",
                PathToCover = "/Images/covers/blankCover.jpg",
                Annotation = "100 things you should know about World Wonders.",
                Description = "It takes you on a thrilling tour of mighty monuments and awesome natural features. Exactly 100 facts, accompanied by detailed artwork, bring to life ancient stone giants, undersea cities, and mighty migrations made by living things. ",
                Date = new DateTime(2024, 1, 9),
                UserId = "seed-user-id",
                AuthorId = 7,
                CategoryId = 3
            },
            new Book
            {
                Id = 10,
                Title = "Where the Sidewalk Ends",
                PathToAudiobook = "/audio/sidewalkends.m4a",
                PathToCover = "/Images/covers/blankCover.jpg",
                Annotation = "Funny and imaginative children's poems.",
                Description = "A beloved collection of humorous and creative poetry.",
                Date = new DateTime(2024, 1, 10),
                UserId = "seed-user-id",
                AuthorId = 9,
                CategoryId = 4
            },
            new Book
            {
                Id = 11,
                Title = "A Child's Garden of Verses",
                PathToAudiobook = "/audio/gardenofverses.m4a",
                PathToCover = "/Images/covers/blankCover.jpg",
                Annotation = "Classic poems about childhood.",
                Description = "A timeless collection of poems loved by generations.",
                Date = new DateTime(2024, 1, 11),
                UserId = "seed-user-id",
                AuthorId = 8,
                CategoryId = 4
            }
        };

public void Configure(EntityTypeBuilder<Book> entity)
        {
            entity.HasData(this.Book);

        }
    }
}
