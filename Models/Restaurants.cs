using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FoodReview.Models
{
    public class Restaurants
    {

        public Restaurants(int rank)
        {
            RestaurantRanking = rank;
        }

        [Required]
        public int? RestaurantRanking { get;} = 999;//preventing null breaking my program

        [Required]
        public string RestaurantName { get; set; }

        #nullable enable
        public string? FavoriteDish { get; set; } = "It's all tasty!";

        [Required]
        public string Address { get; set; }

        [Phone]
        public string RestaurantPhone { get; set; }

        #nullable enable
        public string WebsiteLink { get; set; } = "Coming Soon!";


        public static Restaurants[] GetRestaurants()
        {
            Restaurants r1 = new Restaurants(5)
            {
                RestaurantName = "Bombay House",
                FavoriteDish = "Lamb Boti Kabob Masala",
                Address = "463 N University Ave, Provo, UT 84601-2834",
                RestaurantPhone = "801-373-6677",
                WebsiteLink = "https://bombayhouse.com/"
            };

            Restaurants r3 = new Restaurants(4)
            {
                RestaurantName = "PhoPlus Provo",
                FavoriteDish = "Steak and Flank Pho",
                Address = "68 W Center St, Provo, UT 84601-4417",
                RestaurantPhone = "801-377-8808"
            };

            Restaurants r2 = new Restaurants(4)
            {
                RestaurantName = "Tucanos Brazilian Grill",
                FavoriteDish = "Grilled Meat",
                Address = "545 E University Pkwy, Provo, UT 84097",
                RestaurantPhone = "801-224-4774",
                WebsiteLink = "https://www.tucanos.com/location/orm"
            };

            Restaurants r4 = new Restaurants(4)
            {
                RestaurantName = "The Habit Burger Grill",
                FavoriteDish = "DoubleChar Burger",
                Address = "52245 University Parkway, Provo, UT 84604",
                RestaurantPhone = "385-254-0940",
                WebsiteLink = "https://www.habitburger.com/"
            };

            Restaurants r5 = new Restaurants(3)
            {
                RestaurantName = "Spicy Thai",
                FavoriteDish = "Pad Thai",
                Address = "3230 N University Ave, Provo, UT 84604-4405",
                RestaurantPhone = "801-370-0707",
                WebsiteLink = "https://www.spicythaiprovo.com/"
            };



            //Return the restaurants array
            return new Restaurants[] { r1, r2 ,r3, r4, r5};
        }
    }
}
