using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OdeToFood.Controllers
{
    //about for phone
    //[Route("about")]
    [Route("Darko/[controller]/[action]")]
    public class AboutController
    {
        [Route("")]
        public string Phone()
        {
            return "Phone number 070806508";
        }
        [Route("address")]
        public string Address()
        {
            return "MACEDONIA/Skopje/Kiselavoda";
        }
    }
}
