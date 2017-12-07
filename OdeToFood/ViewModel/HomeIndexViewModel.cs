using OdeToFood.Models;
using System.Collections.Generic;

namespace OdeToFood.ViewModel
{
    public class HomeIndexViewModel
    {
                                       
        public IEnumerable<Restaurant> Resturants { get; set; }
        public string CurreentMessage { get; set; }
    }
}
