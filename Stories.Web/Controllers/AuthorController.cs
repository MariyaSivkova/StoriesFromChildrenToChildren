using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Stories.Services;
using Stories.ViewModels.Author;

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
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(AuthorAddViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            try
            {
                await service.AddAuthorAsync(model);
            }
            catch (Exception ex)
            {
                return NotFound();
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
            catch (Exception ex)
            {
                return NotFound();
            }
            
            return RedirectToAction(nameof(Index));
        }

    }
}
