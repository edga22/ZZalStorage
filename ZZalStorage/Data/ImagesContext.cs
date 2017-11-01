using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZZalStorage.Models;
using Microsoft.EntityFrameworkCore;

namespace ZZalStorage.Data
{
    public class ImagesContext : DbContext
    {
        public ImagesContext(DbContextOptions<ImagesContext> options) : base(options)
        {
        }

        public DbSet<Image> Images { get; set; }
        public DbSet<Tag> Tags { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Image>().ToTable("Image");
            modelBuilder.Entity<Tag>().ToTable("Tag");
        }
    }
}
