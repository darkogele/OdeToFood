using OdeToFood.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OdeToFood.Services
{
    //public class InMemoryRestaurantData :IRestaurantData
    //{
        //public InMemoryRestaurantData()
        //{
        //    _restaurants = new List<Restaurant>
        //    {
        //        new Restaurant{Id = 1, Name = "Darko Pizza Place"},
        //        new Restaurant{Id = 2, Name = "Jakomo"},
        //        new Restaurant{Id = 3, Name = "Sedmica"}
        //    }; 
        //}
       
        //public IEnumerable<Restaurant> GetAll()
        //{
        //    return _restaurants.OrderBy(r => r.Name);
        //}

        //public Restaurant Get(int id)
        //{
        //    return _restaurants.FirstOrDefault(r => r.Id == id);
        //}

        //public Restaurant Add(Restaurant resturant)
        //{
        //    resturant.Id = _restaurants.Max(r => r.Id) + 1;
        //    _restaurants.Add(resturant);
        //    return resturant;
        //}

        //List<Restaurant> _restaurants;
    //}
}
