using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stories.DataModels
{
    public class Book
    {
        public Book()
        {
            this.Authors = new HashSet<Author>();
            this.Categories = new HashSet<Category>();
            this.Date = DateTime.Now;
            this.PathToCover = StoriesConstants.DefaultCover;

        }

        public int Id { get; set; }
        public string Title { get; set; }
        public string PathToAudiobook { get; set; }
        public string PathToCover { get; set; }
        public string Annotation { get; set; }
        public string Description { get; set; }
        public string ReadersPartiality { get; set; }

        public DateTime Date { get; set; }
        public virtual ICollection<Author> Authors { get; set; } = null!;
        public virtual ICollection<Category> Categories { get; set; } = null!;

        public string UserId { get; set; } = null!;

        public bool IsApproved { get; set; }

    }
}
