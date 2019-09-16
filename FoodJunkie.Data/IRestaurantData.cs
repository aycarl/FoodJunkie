using FoodJunkie.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace FoodJunkie.Data
{
    public interface IRestaurantData
    {
        IEnumerable<Restaurant> GetRestaurantsByName(string name);

        Restaurant GetById(int id);

        Restaurant Add(Restaurant newRestaurant);

        Restaurant Update(Restaurant updatedRestaurant);

        int Commit();
    }
}
