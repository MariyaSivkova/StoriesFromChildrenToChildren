using System.ComponentModel.DataAnnotations;

namespace Stories.ViewModels.Author
{
    public class AuthorAddViewModel
    {
        [Required]
        public string FirstName { get; set; } = null!;

        [Required]
        public string LastName { get; set; } = null!;

        public string Biography { get; set; } = string.Empty;
    }
}
