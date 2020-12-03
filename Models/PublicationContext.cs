using System;
using Microsoft.EntityFrameworkCore;
using WikiPedia.Data;

namespace WikiPedia.Models
{
    
        public class PublicationContext : DbContext
        {
            public DbSet<Publication> Publications { get; set; }
         
           
            public DbSet<PartInfo> PartsInfo { get; set; }
            public DbSet<Picture> Pictures { get; set; }

            public PublicationContext(DbContextOptions<ApplicationDbContext> options)
                : base(options)
            {
                Database.EnsureCreated();
            }
        }
    
}
