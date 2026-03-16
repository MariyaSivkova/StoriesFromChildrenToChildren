using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Stories.DataModels;

namespace Stories.Data.Configuration
{
    public class CategoryEntityTypeConfiguration : IEntityTypeConfiguration<Category>
    {
        private readonly Category[] Category =
            {
            new Category
            {
                Id = 1,
                CategoryName = "Fairy Tales"
            },
            new Category
            {
                Id = 2,
                CategoryName = "Novels for Children"
            },
            new Category
            {
                Id = 3,
                CategoryName = "Science"
            },
            new Category
            {
                Id = 4,
                CategoryName = "Poems"
            }
        };

        public void Configure(EntityTypeBuilder<Category> entity)
        {
            entity.HasData(this.Category);

        }
    }
}


