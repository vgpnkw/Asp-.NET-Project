using System;
using Microsoft.EntityFrameworkCore;
using WikiPedia.Data;

namespace WikiPedia.Models
{
    public class PublicationContext
    {
        public class ArticleContext : DbContext
        {
            public DbSet<Publication> Articles { get; set; }
         
           
            public DbSet<PartInfo> BlocksInfo { get; set; }
            public DbSet<Picture> Pictures { get; set; }

            public ArticleContext(DbContextOptions<ApplicationDbContext> options)
                : base(options)
            {
                Database.EnsureCreated();
            }
        }
    }
}
