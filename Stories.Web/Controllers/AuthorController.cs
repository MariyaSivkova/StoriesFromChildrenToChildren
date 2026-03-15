using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Stories.Services;
using Stories.ViewModels.Author;

namespace Stories.Web.Controllers
{
    
    public class AuthorController : Controller
    {

        public StoriesService service;

        

        public AuthorController()
        {
            
        }

        
    }
}
