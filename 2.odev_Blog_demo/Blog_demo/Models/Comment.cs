using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Blog_demo.Models
{
    public class Comment
    {
        [Key]public int CommentId { get; set; }
        public User User { get; set; }
        public Article Article { get; set; }
        public string Description { get; set; }
        public int Star { get; set; } //5 üzerinden

    }
}
