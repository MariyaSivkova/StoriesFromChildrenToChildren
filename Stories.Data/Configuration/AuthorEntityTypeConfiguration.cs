using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Stories.DataModels;

namespace Stories.Data.Configuration
{
    public class AuthorEntityTypeConfiguration : IEntityTypeConfiguration<Author>
    {

        private readonly Author[] Author =
        {
        new Author
        {
            Id = 1,
            FirstName = "Charles",
            LastName = "Perrault",
            Biography = "Charles Perrault was a French author best known for laying the foundations of the fairy tale genre with stories such as Cinderella and Sleeping Beauty."
        },
        new Author
        {
            Id = 2,
            FirstName = "Hans Christian",
            LastName = "Andersen",
            Biography = "Hans Christian Andersen was a Danish author famous for his timeless fairy tales including The Little Mermaid, The Ugly Duckling, and The Snow Queen."
        },
        new Author
        {
            Id = 3,
            FirstName = "Lewis",
            LastName = "Carroll",
            Biography = "Lewis Carroll was an English writer and mathematician best known for the children's fantasy novel Alice's Adventures in Wonderland."
        },
        new Author
        {
            Id = 4,
            FirstName = "J. M.",
            LastName = "Barrie",
            Biography = "J. M. Barrie was a Scottish novelist and playwright best remembered as the creator of Peter Pan, the boy who never grows up."
        },
        new Author
        {
            Id = 5,
            FirstName = "J. R. R.",
            LastName = "Tolkien",
            Biography = "J. R. R. Tolkien was an English writer and professor famous for his fantasy works including The Hobbit and The Lord of the Rings."
        },
        new Author
        {
            Id = 6,
            FirstName = "Joanna",
            LastName = "Cole",
            Biography = "Joanna Cole was an American author best known for the educational children's series The Magic School Bus."
        },
        new Author
        {
            Id = 7,
            FirstName = "Steve",
            LastName = "Parker",
            Biography = "Steve Parker is a British science writer known for creating engaging science books for children and young readers."
        },
        new Author
        {
            Id = 8,
            FirstName = "Robert Louis",
            LastName = "Stevenson",
            Biography = "Robert Louis Stevenson was a Scottish novelist and poet, well known for works such as Treasure Island and the poetry collection A Child's Garden of Verses."
        },
        new Author
        {
            Id = 9,
            FirstName = "Shel",
            LastName = "Silverstein",
            Biography = "Shel Silverstein was an American writer, poet, and illustrator famous for beloved children's poetry collections such as Where the Sidewalk Ends."
        }

        };
        public void Configure(EntityTypeBuilder<Author> entity)
        {
            entity.HasData(this.Author);

        }
    }
}