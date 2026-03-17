using Microsoft.EntityFrameworkCore;
using Stories.Data;
using Stories.DataModels;
using Stories.ViewModels.Author;
using Stories.ViewModels.Category;
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

        // About Authors:
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

        // About Categories:

        public async Task<IEnumerable<CategoryViewModel>> GetAllCategoriesAsync()
        {
            return await dbContext.Categories
                .AsNoTracking()
                .Select(r => new CategoryViewModel
                {
                    Id = r.Id,
                    CategoryName = r.CategoryName,
                })
                .ToListAsync();
        }
        
        public async Task AddCategoryAsync(CategoryAddViewModel model)
        {

            Category newCategory = new Category
            {
                CategoryName = model.CategoryName,
            };

            dbContext.Categories.Add(newCategory);
            await dbContext.SaveChangesAsync();
        }

        public async Task<CategoryViewModel> GetCategoryForEditAsync(int id)
        {
            Category? category = await dbContext.Categories
                .FirstOrDefaultAsync(a => a.Id == id);

            if (category == null)
            {
                throw new ArgumentException("Category not found.");
            }

            return new CategoryViewModel
            {
                Id = category.Id,
                CategoryName = category.CategoryName,
            };
        }

        public async Task EditCategoryAsync(CategoryViewModel model)
        {
            Category? category = await dbContext.Categories
                .FirstOrDefaultAsync(a => a.Id == model.Id);

            if (category == null)
            {
                throw new ArgumentException("Category not found.");
            }

            category.CategoryName = model.CategoryName;

            await dbContext.SaveChangesAsync();
        }

// About Lybrary:

        public async Task<IEnumerable<BookViewModel>> GetAllBooksAsync()
        {
            return await dbContext.Books
                .AsNoTracking()
                .Select(r => new BookViewModel
                {
                    Id = r.Id,
                    Title = r.Title,
                    PathToCover = r.PathToCover,
                    Anotation = r.Annotation
                })
                .ToListAsync();
        }

        public async Task<BookDetailsViewModel?> GetBookDetailsAsync(int id)
        {
            BookDetailsViewModel? book = await dbContext.Books
                .Include(r => r.Category)
                .Include(r => r.Author)
                .Include(r => r.User)
                .Where(r => r.Id == id)
                .Select(r => new BookDetailsViewModel
                {
                    Id = r.Id,
                    Title = r.Title,
                    Annotation = r.Annotation,
                    Date = r.Date,
                    Description = r.Description,
                    PathToAudiobook = r.PathToAudiobook,
                    PathToCover = r.PathToCover,
                    Category = r.Category,
                    Author = r.Author,
                    User = r.User
                })
                .FirstOrDefaultAsync();
            
            if (book == null)
            {
                throw new ArgumentException("Author not found.");
            }

            return book;

        }

        public async Task<BookEditViewModel?> GetBookEditAsync(int id)
        {
            BookEditViewModel? book = await dbContext.Books
                .Include(r => r.Category)
                .Include(r => r.Author)
                .Include(r => r.User)
                .Where(r => r.Id == id)
                .Select(r => new BookEditViewModel
                {
                    Id = r.Id,
                    Title = r.Title,
                    AuthorId = r.AuthorId,
                    CategoryId = r.CategoryId,
                    Annotation = r.Annotation,
                    Date = r.Date,
                    Description = r.Description,
                    PathToAudiobook = r.PathToAudiobook,
                    PathToCover = r.PathToCover,
                    User = r.User
                })
                .FirstOrDefaultAsync();

            if (book == null)
            {
                throw new ArgumentException("Author not found.");
            }

            book.Authors = await GetAllAuthors();

            book.Categories = await GetAllCategories();
            return book;

        }

        public async Task EditBookAsync(BookEditViewModel model)
        {
            Book? book = await dbContext.Books
                .FirstOrDefaultAsync(a => a.Id == model.Id);

            if (book == null)
            {
                throw new ArgumentException("Author not found.");
            }
            book.Id = model.Id;
            book.Annotation = model.Annotation;
            book.AuthorId = model.AuthorId;
            book.CategoryId = model.CategoryId;
            book.Date = model.Date;
            book.Description = model.Description;
            book.PathToAudiobook = model.PathToAudiobook;
            book.PathToCover = model.PathToCover;
            book.Title = model.Title;
            book.User = model.User;

            await dbContext.SaveChangesAsync();
        }

        public async Task<BookEditViewModel> GetBookViewModelAsync()
        {
            IEnumerable<AuthorViewModel> authors = await GetAllAuthors();

            IEnumerable<CategoryViewModel> categories = await GetAllCategories();

            BookEditViewModel model = new BookEditViewModel
            {
                Categories = categories,
                Date = DateTime.Now,
                Authors = authors
            };

            return model;
        }

        public async Task<IEnumerable<AuthorViewModel>> GetAllAuthors()
        {
            IEnumerable<AuthorViewModel> authors = await dbContext.Authors
                .AsNoTracking()
                .Select(ba => new AuthorViewModel
                {
                    Id = ba.Id,
                    FirstName = ba.FirstName,
                    LastName = ba.LastName,
                    Biography = ba.Biography
                })
                .ToListAsync();
            return authors;
        }

        public async Task<IEnumerable<CategoryViewModel>> GetAllCategories()
        {
            IEnumerable<CategoryViewModel> categories = await dbContext.Categories
                .AsNoTracking()
                .Select(ca => new CategoryViewModel
                {
                    Id = ca.Id,
                    CategoryName = ca.CategoryName
                })
                .ToListAsync();
            return categories;
        }


        public async Task AddBookAsync(BookEditViewModel model)
        {
            Book newBook = new Book
            {
                Annotation = model.Annotation,
                AuthorId = model.AuthorId,
                CategoryId = model.CategoryId,
                Date = model.Date,
                Description = model.Description,
                PathToAudiobook = model.PathToAudiobook,
                PathToCover = model.PathToCover,
                Title = model.Title,
                UserId = model.UserId
            };

            dbContext.Books.Add(newBook);
            await dbContext.SaveChangesAsync();

        }

        public async Task DeleteBookAsync(int id, string userId)
        {
            var book = await dbContext.Books
                .FirstOrDefaultAsync(r => r.Id == id);

            if (book == null)
            {
                throw new ArgumentException("Book was not found!");
            }

            if (book.UserId != userId)
            {
                throw new UnauthorizedAccessException("You are not authorized to delete this book!");
            }

            dbContext.Books.Remove(book);
            await dbContext.SaveChangesAsync();
        }
    }
}
