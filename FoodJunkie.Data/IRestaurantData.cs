using System;
using System.Collections.Generic;
using System.Text;
using FoodJunkie.Core;

namespace FoodJunkie.Data
{
    public interface IRestaurantData
    {
        IEnumerable<Restaurant> Restaurants;
    }
}
