using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Stories.Services;
using Stories.ViewModels.Author;
using Stories.ViewModels.Library;
using System.Security.Claims;

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
                BookEditViewModel? book = await service.GetBookEditAsync(id);
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

        [HttpPost]
        public async Task<IActionResult> Edit(BookEditViewModel model)
        {
            if (!ModelState.IsValid)
            {
                model.Authors = await service.GetAllAuthorsAsync();
                model.Categories = await service.GetAllCategoriesAsync();
                return View(model);
            }

            try
            {
                await service.EditBookAsync(model);
            }
            catch (ArgumentException)
            {
                return NotFound();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

            return RedirectToAction(nameof(Details), new { id = model.Id });
        }


        [HttpGet]
        public async Task<IActionResult> Add()
        {
            BookEditViewModel model = await service.GetBookViewModelAsync();

            return View(model);
        }


        [HttpPost]
        public async Task<IActionResult> Add(BookEditViewModel model)
        {
            if (!ModelState.IsValid)
            {
                model.Authors = await service.GetAllAuthorsAsync();
                model.Categories = await service.GetAllCategoriesAsync();
                return View(model);
            }

            string? userId = User?.FindFirstValue(ClaimTypes.NameIdentifier);
            if (string.IsNullOrEmpty(userId))
            {
                return RedirectToAction("Login", "Account");
            }

            model.UserId = userId;

            try
            {
                await service.AddBookAsync(model);
            }
            catch (ArgumentException)
            {
                return NotFound();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

            return RedirectToAction(nameof(Index));
        }
        
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                BookDetailsViewModel? book = await service.GetBookDetailsAsync(id);
                if (book == null)
                {
                    return NotFound();
                }
                await service.DeleteBookAsync(id, book.User.Id);


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
