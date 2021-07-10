using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog_demo.Models
{
    public class ArticleViewModel
    {
        public int ArticleId { get; set; }
        public List<Category> Categories { get; set; }
        public string ArticleTitle { get; set; }
        public User WriterName { get; set; }
        public DateTime PublishTime { get; set; }
        //public string ArticleText { get; set; }

    }
}
