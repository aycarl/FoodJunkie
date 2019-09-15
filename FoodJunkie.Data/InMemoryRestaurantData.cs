using FoodJunkie.Core;
using System.Collections.Generic;
using System.Linq;

namespace FoodJunkie.Data
{
    public class InMemoryRestaurantData : IRestaurantData
    {
        List<Restaurant> restaurants;

        public InMemoryRestaurantData()
        {
            restaurants = new List<Restaurant>()
            {
                new Restaurant { Id = 1, Name = "Carl's Tortillas", Cuisine = Restaurant.CuisineType.Mexican, Location = "ABQ" },
                new Restaurant { Id = 2, Name = "Dee's Noodles", Cuisine = Restaurant.CuisineType.Chinese, Location = "Detroit"},
                new Restaurant { Id = 3, Name ="La Bouchette", Cuisine = Restaurant.CuisineType.Italian, Location = "Novi" }
            };
        }

        public int Commit()
        {
            return 01;
        }

        public Restaurant GetById(int id)
        {
            return restaurants.SingleOrDefault(restaurant => restaurant.Id == id);
        }

        public IEnumerable<Restaurant> GetRestaurantsByName(string name = null)
        {
            return from restaurant in restaurants
                   where string.IsNullOrEmpty(name) || restaurant.Name.StartsWith(name)
                   orderby restaurant.Name
                   select restaurant;
        }

        public Restaurant Update(Restaurant updatedRestaurant)
        {
            var restaurant = restaurants.SingleOrDefault(r => r.Id == updatedRestaurant.Id);
            if (restaurant != null)
            {
                restaurant.Name = updatedRestaurant.Name;
                restaurant.Location = updatedRestaurant.Location;
                restaurant.Cuisine = updatedRestaurant.Cuisine;
            }
            return restaurant;
        }
    }
}
