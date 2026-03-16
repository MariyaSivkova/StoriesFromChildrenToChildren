using Microsoft.EntityFrameworkCore;
using Stories.ViewModels.Author;
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
        Task<IEnumerable<AuthorViewModel>> GetAllAuthorsAsync();

        Task AddAuthorAsync(AuthorAddViewModel model);

        Task<AuthorViewModel> GetAuthorForEditAsync(int id);

        Task EditAuthorAsync(AuthorViewModel model);
    }
}
