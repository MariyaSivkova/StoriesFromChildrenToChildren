using Microsoft.AspNetCore.Identity;
using Stories.DataModels;
using Stories.ViewModels.Author;
using Stories.ViewModels.Category;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static Stories.DataModels.Common.EntityValidation;

namespace Stories.ViewModels.Library
{
    public class BookEditViewModel
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(BookTitleMaxLength)]
        public string Title { get; set; } = null!;

        [Required]
        public string PathToAudiobook { get; set; } = null!;

        public string PathToCover { get; set; } = StoriesConstants.DefaultCover;

        [Required]
        [MaxLength(BookAnnotationMaxLength)]
        public string Annotation { get; set; } = null!;

        [MaxLength(BookDescriptionMaxLength)]
        public string Description { get; set; } = string.Empty;

        public DateTime Date { get; set; } = DateTime.Now;

        public virtual IdentityUser? User { get; set; }

        public string? UserId { get; set; }

        [Required]
        public int AuthorId { get; set; }

        public IEnumerable<AuthorViewModel>? Authors { get; set; }

        [Required]
        public int CategoryId { get; set; }

        public IEnumerable<CategoryViewModel>? Categories { get; set; }


    }
}
