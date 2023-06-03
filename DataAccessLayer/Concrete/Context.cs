using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.Concrete
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string sql_statment = "server=AbdullahPC\\SQLEXPRESS;database=CoreBlogDb;integrated security=true;";
            optionsBuilder.UseSqlServer(sql_statment);
        }
        public DbSet<NewsLetter> newsLetters { get; set; }   
        public DbSet<About> abouts { get; set; }
        public DbSet<Blog> blogs { get; set; }
        public DbSet<Category> categories { get; set; }
        public DbSet<Commend> commends { get; set; }    
        public DbSet<Contact> contacts { get; set; }    
        public DbSet<Writer> writers { get; set; }  
    }
}
