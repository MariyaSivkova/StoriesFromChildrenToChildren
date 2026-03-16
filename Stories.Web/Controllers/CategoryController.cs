using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Stories.Services;
using Stories.ViewModels.Category;
using Stories.ViewModels.Library;

namespace Stories.Web.Controllers
{
    
    public class CategoryController : Controller
    {

        private readonly IStoriesService service;
                

        public CategoryController(IStoriesService service)
        {
            this.service = service;
        }

        [AllowAnonymous]
        public async Task<IActionResult> Index()
        {
            IEnumerable<CategoryViewModel> categories = await service.GetAllCategoriesAsync();

            return View(categories);
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Add(CategoryAddViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            try
            {
                await service.AddCategoryAsync(model);
            }
            catch (Exception ex)
            {
                return NotFound();
            }

            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            CategoryViewModel model = await service.GetCategoryForEditAsync(id);

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(CategoryViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            try
            {
                await service.EditCategoryAsync(model);
            }
            catch (Exception ex)
            {
                return NotFound();
            }
            
            return RedirectToAction(nameof(Index));
        }



    }
}
