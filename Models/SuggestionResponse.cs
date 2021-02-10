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


        [Required(ErrorMessage ="You need to enter a valid phone number")]
        //[DataType(DataType.PhoneNumber)]
        [Phone(ErrorMessage = "Please enter a valid phone number")]
        [MaxLength(10,ErrorMessage ="Please enter 10 digits phone number without any symbols")]
        [MinLength(10, ErrorMessage = "Please enter 10 digits phone number without any symbols")]
        public string RestaurantPhone { get; set; }

    }
}