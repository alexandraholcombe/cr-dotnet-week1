using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using GummiBearKingdom.Models;

namespace GummiBearKingdom.Models
{
    public class GummiBearKingdomDbContext : DbContext
    {
        public GummiBearKingdomDbContext()
        {
        }

        public DbSet<Product> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=IsabellaBirdBlog;integrated security=True");
        }

        public GummiBearKingdomDbContext(DbContextOptions<GummiBearKingdomDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}