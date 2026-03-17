using Stories.DataModels;
using Stories.ViewModels.Author;
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

        [Required]
        public string Title { get; set; } = null!;

        public string PathToCover { get; set; } = StoriesConstants.DefaultCover;

        public string Anotation { get; set; } = null!;
    }
}
