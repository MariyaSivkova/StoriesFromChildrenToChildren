using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Stories.Services;
using Stories.ViewModels.Author;
using Stories.ViewModels.Library;

namespace Stories.Web.Controllers
{
    
    public class AuthorController : Controller
    {

        private readonly IStoriesService service;
                

        public AuthorController(IStoriesService service)
        {
            this.service = service;
        }

        [AllowAnonymous]
        public async Task<IActionResult> Index()
        {
            IEnumerable<AuthorViewModel> authors = await service.GetAllAuthorsAsync();

            return View(authors);
        }

        [HttpGet]
        public async Task<IActionResult> Add()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Add(AuthorAddViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            try
            {
                await service.AddAuthorAsync(model);
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

        [HttpGet]
        public async Task<IActionResult> Edit(int Id)
        {
            AuthorViewModel model = await service.GetAuthorForEditAsync(Id);

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(AuthorViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            try
            {
                await service.EditAuthorAsync(model);
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

    }
}
