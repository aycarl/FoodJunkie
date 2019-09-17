using FoodJunkie.Core;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace FoodJunkie.Data
{
    public class FoodJunkieDbContext : DbContext
    {
        public DbSet<Restaurant> Restaurants { get; set; }
    }
}
