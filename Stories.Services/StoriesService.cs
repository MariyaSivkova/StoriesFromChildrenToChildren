using Microsoft.EntityFrameworkCore;
using Stories.Data;
using Stories.DataModels;
using Stories.ViewModels.Author;
using Stories.ViewModels.Library;

namespace Stories.Services
{
    public class StoriesService : IStoriesService
    {
        private readonly ApplicationDbContext dbContext;

        public StoriesService(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<IEnumerable<AuthorViewModel>> GetAllAuthorsAsync()
        {
            return await dbContext.Authors
                .AsNoTracking()
                .Select(r => new AuthorViewModel
                {
                    Id = r.Id,
                    FirstName = r.FirstName,
                    LastName = r.LastName,
                    Biography = r.Biography,
                })
                .ToListAsync();
        }

        public async Task AddAuthorAsync(AuthorAddViewModel model)
        {

            Author newAuthor = new Author
            {
                FirstName = model.FirstName,
                LastName = model.LastName,
                Biography = model.Biography,
            };

            dbContext.Authors.Add(newAuthor);
            await dbContext.SaveChangesAsync();
        }

        public async Task<AuthorViewModel> GetAuthorForEditAsync(int id)
        {
            Author? author = await dbContext.Authors
                .FirstOrDefaultAsync(a => a.Id == id);

            if (author == null)
            {
                throw new ArgumentException("Author not found.");
            }

            return new AuthorViewModel
            {
                Id = author.Id,
                FirstName = author.FirstName,
                LastName = author.LastName,
                Biography = author.Biography,
            };
        }

        public async Task EditAuthorAsync(AuthorViewModel model)
        {
            Author? author = await dbContext.Authors
                .FirstOrDefaultAsync(a => a.Id == model.Id);

            if (author == null)
            {
                throw new ArgumentException("Author not found.");
            }

            author.FirstName = model.FirstName;
            author.LastName = model.LastName;
            author.Biography = model.Biography;

            await dbContext.SaveChangesAsync();
        }
    }
}
