using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using static RestaurantRater.Models.Restaurant;

namespace RestaurantRater.Controllers
{
    public class RestaurantController : Controller
    {
        // GET: Restaurant
        private RestaurantDBContext db = new RestaurantDBContext();
        
        // GET: Restaurants
        public ActionResult Index()
        {
            return View(db.Restaurants.ToList());
        }
    }
}