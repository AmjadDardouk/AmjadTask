using System;
using Microsoft.EntityFrameworkCore;
using task.Models;

namespace task
{
    public class DbContext : Microsoft.EntityFrameworkCore.DbContext
    {

        private const string ConnectionString = "Host=localhost;Username=postgres;Port=5433;Password=qqqq;Database=test;";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(ConnectionString);
        }

        public DbSet<UserProfile> UserProfiles { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Post> Posts { get; set; }




    }
}
