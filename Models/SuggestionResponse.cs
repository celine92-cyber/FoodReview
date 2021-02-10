using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FoodReview.Models
{
    public class SuggestionResponse
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string RestaurantName { get; set; }

        [Required]
        public string FavoriteDish { get; set; }


        [Required] [PhoneAttribute]
        public string RestaurantPhone { get; set; }

    }
}