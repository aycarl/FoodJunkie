using FoodJunkie.Core;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace FoodJunkie.Data
{
    public class FoodJunkieDbContext : DbContext
    {
        public FoodJunkieDbContext(DbContextOptions<FoodJunkieDbContext> options) : base(options)
        {
        }

        public DbSet<Restaurant> Restaurants { get; set; }
    }
}
