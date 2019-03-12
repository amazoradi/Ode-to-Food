using OdeToFood.Core;
using System.Collections.Generic;
using System.Linq;

namespace OdeToFood.Data
{
    public interface IRestaurantData
    {
        IEnumerable<Restaurant> GetAll();
    }

    public class InMemoryRestaurantData : IRestaurantData
    {

        readonly List<Restaurant> restaurants;

        public InMemoryRestaurantData()
        {
           restaurants = new List<Restaurant>()
            {
                new Restaurant {Id = 1, Name = "Zoradi's Pizza", Location="Nashville", Cuisine = CuisineType.Italian},
                new Restaurant {Id = 2, Name = "Manju's Place", Location="Nashville", Cuisine = CuisineType.Indian},
                new Restaurant {Id = 3, Name = "Supper Cuccas", Location="Santa Barbara", Cuisine = CuisineType.Mexican},
                new Restaurant {Id = 4, Name = "The Habbit", Location="Santa Barbara", Cuisine = CuisineType.None},
                new Restaurant {Id = 5, Name = "Maggianos", Location="Naperville", Cuisine = CuisineType.Italian}
            };

        }
        public IEnumerable<Restaurant> GetAll()
        {
            return from r in restaurants
                   orderby r.Name
                   select r;
        }
    }
}
