using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookSave_Demo.Models
{
    public class BookViewModel
    {
        public string BookName { get; set; }
        public string Author { get; set; }
        public int PublishYear { get; set; }

        public string BookDetail => $"{Author} yazarının {BookName} kitabı kaydedildi";

    }
}
