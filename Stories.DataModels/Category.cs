
using System.ComponentModel.DataAnnotations;
using static Stories.DataModels.Common.EntityValidation;

namespace Stories.DataModels
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(CategoryNameMaxLength)]
        public string CategoryName { get; set; } = null!;

        public virtual ICollection<Book> Books { get; set; } = new HashSet<Book>();
    }
}
