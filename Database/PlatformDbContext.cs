using Microsoft.EntityFrameworkCore;
using PlatformForJobSeeking.Database.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlatformForJobSeeking.Database
{
    public class PlatformDbContext:DbContext
    {
        public PlatformDbContext(DbContextOptions options) : base(options){}

        public DbSet<Advert> Adverts { get; set; }
        public DbSet<AdvertType> AdvertTypes { get; set; }
        public DbSet<CustomerEmployer> CustomerEmployers { get; set; }
        public DbSet<CustomerSeeker> CustomerSeekers { get; set; }
        public DbSet<Region> Regions { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<Town> Towns { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           
        }
    }
}
