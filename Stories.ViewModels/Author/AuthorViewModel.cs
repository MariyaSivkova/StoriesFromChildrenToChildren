using System.ComponentModel.DataAnnotations;
using static Stories.DataModels.Common.EntityValidation;

namespace Stories.ViewModels.Author
{
    public class AuthorViewModel
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(AuthorFirstNameMaxLength)]
        public string FirstName { get; set; } = null!;

        [Required]
        [MaxLength(AuthorLastNameMaxLength)]
        public string LastName { get; set; } = null!;

        [Required]
        [MaxLength(AuthorBiographyMaxLength)]
        public string Biography { get; set; } = string.Empty;
    }
}
