using System.ComponentModel.DataAnnotations;
using static Stories.DataModels.Common.EntityValidation;

namespace Stories.DataModels
{
    public class Author
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        [MaxLength(AuthorFirstNameMaxLength)]
        public string FirstName { get; set; } = null!;
        
        [Required]
        [MaxLength(AuthorLastNameMaxLength)]
        public string LastName { get; set; } = null!;

        [MaxLength(AuthorBiographyMaxLength)]
        public string Biography { get; set; } = null!;

        public virtual ICollection<Book> Books { get; set; }
        = new HashSet<Book>();
    }
}
