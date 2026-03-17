using System.ComponentModel.DataAnnotations;
using static Stories.DataModels.Common.EntityValidation;

namespace Stories.ViewModels.Author
{
    public class AuthorAddViewModel
    {
        [Required]
        [MaxLength(AuthorFirstNameMaxLength)]
        public string FirstName { get; set; } = null!;

        [Required]
        [MaxLength(AuthorLastNameMaxLength)]
        public string LastName { get; set; } = null!;

        [MaxLength(AuthorBiographyMaxLength)]
        public string Biography { get; set; } = string.Empty;
    }
}
