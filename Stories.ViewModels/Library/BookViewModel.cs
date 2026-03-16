using Stories.DataModels;
using Stories.ViewModels.Author;
using Stories.ViewModels.Category;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stories.ViewModels.Library
{
    public class BookViewModel
    {
        public int Id { get; set; } 


        public string Title { get; set; } = null!;


        public List<AuthorViewModel> Authors { get; set; } = null!;


        public List<CategoryViewModel> Categories { get; set; } = null!;


        public string Annotation { get; set; } = null!;

        public DateTime Date { get; set; } 

    }
}
