using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stories.ViewModels.Library
{
    public class CategoryViewModel
    {
        public CategoryViewModel()
        {
            Checked = true;
        }

        public int Id { get; set; }

        public string CategoryName { get; set; }

        public bool Checked { get; set; }
    }
}
