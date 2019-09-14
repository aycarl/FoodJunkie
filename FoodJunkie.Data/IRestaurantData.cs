using FoodJunkie.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace FoodJunkie.Data
{
    public interface IRestaurantData
    {
        IEnumerable<Restaurant> GetRestaurantsByName(string name);
    }
}
