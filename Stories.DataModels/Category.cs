using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stories.DataModels
{
    public class Category
    {
        public Category()
        {
            this.Books = new HashSet<Book>();
        }
        public int Id { get; set; }
        public string CategoryName { get; set; }
        public virtual ICollection<Book> Books { get; set; }
    }
}
