using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FoodReview.Models
{
    public static class AddedSuggestions
    {
        private static List<SuggestionResponse> suggestions = new List<SuggestionResponse>();

        public static IEnumerable<SuggestionResponse> Suggestions => suggestions;

        public static void AddSuggestions(SuggestionResponse suggestion)
        {
             suggestions.Add(suggestion);//add submitted suggestion
        }
    }
}
