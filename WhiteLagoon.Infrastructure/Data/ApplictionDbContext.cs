using System;
using Microsoft.EntityFrameworkCore;
using WhiteLagoon.Domain.Entities;

namespace WhiteLagoon.Infrastructure.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : DbContext(options)
    {
        public DbSet<Villa> Villas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Villa>().HasData(
                new Villa()
                {
                    Id = 1,
                    Name = "Premium Pool Villa",
                    Description = "Premium Pool villa with attached bathroom",
                    Price = 1000,
                    SqFt = 2000,
                    Occupancy = 4,
                    ImageUrl = "https://via.placeholder.com/150",
                    CreatedAt = new DateTime(2024, 1, 1, 12, 0, 0),
                    UpdatedAt = new DateTime(2024, 1, 1, 12, 0, 0)
                },
                new Villa()
                {
                    Id = 2,
                    Name = "Super Premium Villa ",
                    Description = "Super premium villa",
                    Price = 2000,
                    SqFt = 3000,
                    Occupancy = 6,
                    ImageUrl = "https://via.placeholder.com/150",
                    CreatedAt = new DateTime(2024, 1, 1, 12, 0, 0),
                    UpdatedAt = new DateTime(2024, 1, 1, 12, 0, 0)
                },
                new Villa()
                {
                    Id = 3,
                    Name = "Suite Villa",
                    Description = "Presidential Suite villa for exotic experience",
                    Price = 3000,
                    SqFt = 4000,
                    Occupancy = 8,
                    ImageUrl = "https://via.placeholder.com/150",
                    CreatedAt = new DateTime(2024, 1, 1, 12, 0, 0),
                    UpdatedAt = new DateTime(2024, 1, 1, 12, 0, 0)
                }
            );
        }
    }
}
