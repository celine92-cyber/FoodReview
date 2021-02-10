using FoodReview.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace FoodReview.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        //output the prepopulated array to the index view
        public IActionResult Index()
        {
            List<string> restaurantList;
            restaurantList = new List<string>();

            foreach (Restaurants r in Restaurants.GetRestaurants())
            {

                restaurantList.Add($"Rank:{r.RestaurantRanking} stars {r.RestaurantName} {r.FavoriteDish} {r.Address} {r.RestaurantPhone} {r.WebsiteLink}");
            }

            return View(restaurantList);
        }

        //get the suggestion info
        [HttpGet]
        public IActionResult SubmitSuggestion()
        {
            return View();
        }


        //return suggestion completition confirmation to the user
        [HttpPost]
        public IActionResult SubmitSuggestion(SuggestionResponse suggestionResponse)
        {
            AddedSuggestions.AddSuggestions(suggestionResponse);
            return View("Confirmation", suggestionResponse);
        }

        //return all suggestions input
        public IActionResult ViewSuggestions()
        {
            return View(AddedSuggestions.Suggestions);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
