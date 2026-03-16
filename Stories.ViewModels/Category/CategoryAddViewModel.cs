using System.ComponentModel.DataAnnotations;

namespace Stories.ViewModels.Category
{
    public class CategoryAddViewModel
    {
        [Required]
        public string CategoryName { get; set; } = null!;

        
    }
}
