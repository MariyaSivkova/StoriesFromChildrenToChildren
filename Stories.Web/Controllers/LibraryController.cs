using Microsoft.AspNetCore.Mvc;
using Stories.Services;
using Stories.ViewModels.Library;

namespace Stories.Web.Controllers
{
    public class LibraryController : Controller
    {
        public StoriesService service;
        
        public LibraryController()
        {
           
        }

        
    }
}
