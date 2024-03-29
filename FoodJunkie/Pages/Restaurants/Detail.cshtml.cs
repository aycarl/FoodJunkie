﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoodJunkie.Core;
using FoodJunkie.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FoodJunkie.Pages.Restaurants
{
		public class DetailModel : PageModel
		{
				private readonly IRestaurantData restaurantData;

				[TempData]
				public string Message { get; set; }

				public DetailModel(IRestaurantData restaurantData)
				{
						this.restaurantData = restaurantData;
				}

				public Restaurant Restaurant { get; set; }

				/// <summary>
				/// Gets restaurant by Id
				/// </summary>
				/// <param name="restaurantId"></param>
				/// <returns>Restaurant Object</returns>
				public IActionResult OnGet(int restaurantId)
				{
						Restaurant = restaurantData.GetById(restaurantId);
						if (Restaurant == null)
						{
								return RedirectToPage("./NotFound");
						}
						return Page();
				}
		}
}