using System;
using Microsoft.EntityFrameworkCore;
using WikiPedia.Data;
using WikiPedia.Models;

namespace WikiPedia.Data

{
    
        public class PublicationContext : DbContext
        {
            public DbSet<Publication> Publications { get; set; }
         
           
            public DbSet<PartInfo> PartsInfo { get; set; }
            public DbSet<Picture> Pictures { get; set; }

            public PublicationContext(DbContextOptions<PublicationContext> options)
                : base(options)
            {
                Database.EnsureCreated();
            }
        }
    
}
