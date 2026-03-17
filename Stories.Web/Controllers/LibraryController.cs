using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Stories.Services;
using Stories.ViewModels.Author;
using Stories.ViewModels.Library;

namespace Stories.Web.Controllers
{
    public class LibraryController : Controller
    {
        private readonly IStoriesService service;

        public LibraryController(IStoriesService service)
        {
            this.service = service;
        }

        [AllowAnonymous]
        public async Task<IActionResult> Index()
        {
            IEnumerable<BookViewModel> books = await service.GetAllBooksAsync();

            return View(books);
        }

        [AllowAnonymous]
        public async Task<IActionResult> Details(int id)
        {
            try
            {
                BookDetailsViewModel? book = await service.GetBookDetailsAsync(id);
                if (book == null)
                {
                    return NotFound();
                }

                return View(book);
            }
            catch (ArgumentException)
            {
                return NotFound();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            try
            {
                BookDetailsViewModel? book = await service.GetBookDetailsAsync(id);
                if (book == null)
                {
                    return NotFound();
                }

                return View(book);
            }
            catch (ArgumentException)
            {
                return NotFound();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
