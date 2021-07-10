using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog_demo.Models
{
    public class ArticleContext :DbContext 
    {
        public ArticleContext(DbContextOptions options) : base(options) //base>miras aldığı sınıfın constructorını kullanıyor
        {

        }

        public DbSet<Article> Articles { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Comment> Comments { get; set; }


    }
}
