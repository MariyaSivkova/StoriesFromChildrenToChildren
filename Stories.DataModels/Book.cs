
using System.ComponentModel.DataAnnotations;
using static Stories.DataModels.Common.EntityValidation;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace Stories.DataModels
{
    public class Book
    {       
        [Key]
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
        public string Description { get; set; }
        
        public DateTime Date { get; set; } = DateTime.Now;

        [Required]
        [ForeignKey(nameof(IdentityUser))]
        public string UserId { get; set; } = null!;
        public virtual IdentityUser User { get; set; } = null!;

        [Required]
        [ForeignKey(nameof(Author))]
        public int AuthorId { get; set; } 
        public virtual Author Author { get; set; } = null!;

        [Required]
        [ForeignKey(nameof(Category))]
        public int CategoryId { get; set; } 
        public virtual Category Category { get; set; } = null!;

        //public bool IsDeleted { get; set; } = false;


        //TODO at stage 2: 
        //public bool IsApproved { get; set; }
        //public string ReadersPartiality { get; set; }
        //public virtual ICollection<Author> Authors { get; set; } = new HashSet<Author>();
        //public virtual ICollection<Category> Categories { get; set; } = new HashSet<Category>();

    }
}
