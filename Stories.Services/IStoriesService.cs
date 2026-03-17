using Microsoft.EntityFrameworkCore;
using Stories.ViewModels.Author;
using Stories.ViewModels.Category;
using Stories.ViewModels.Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stories.Services
{
    public interface IStoriesService
    {
// Author service methods
        Task<IEnumerable<AuthorViewModel>> GetAllAuthorsAsync();

        Task AddAuthorAsync(AuthorAddViewModel model);

        Task<AuthorViewModel> GetAuthorForEditAsync(int id);

        Task EditAuthorAsync(AuthorViewModel model);

// Category service methods
        Task<IEnumerable<CategoryViewModel>> GetAllCategoriesAsync();

        Task AddCategoryAsync(CategoryAddViewModel model);

        Task<CategoryViewModel> GetCategoryForEditAsync(int id);

        Task EditCategoryAsync(CategoryViewModel model);

// Library service methods
        Task<IEnumerable<BookViewModel>> GetAllBooksAsync();

        Task<BookDetailsViewModel?> GetBookDetailsAsync(int id);
        
        Task<BookEditViewModel?> GetBookEditAsync(int id);

        Task EditBookAsync(BookEditViewModel model);

        Task<BookEditViewModel> GetBookViewModelAsync();

        Task<IEnumerable<AuthorViewModel>> GetAllAuthors();
        
        Task<IEnumerable<CategoryViewModel>> GetAllCategories();

        Task AddBookAsync(BookEditViewModel model);

        Task DeleteBookAsync(int id, string userId);
    }
}
