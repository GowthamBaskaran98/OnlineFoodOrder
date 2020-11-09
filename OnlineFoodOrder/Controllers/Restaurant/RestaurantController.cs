using OnlineFoodOrder.Models;
using System.Collections.Generic;
using System.Web.Mvc;

namespace OnlineFoodOrder.Controllers.Restaurant
{
    public class RestaurantController : Controller
    {
        public ActionResult DisplayAllRestaurants()
        {
            RestaurantViewModel restaurantViewModel = new RestaurantViewModel();
            List<RestaurantViewModel> list = new List<RestaurantViewModel>();
            restaurantViewModel.RestaurantName = "ParkPlaza";
            restaurantViewModel.MobileNumber = 8778613988;
            restaurantViewModel.Address = "Salem";
            restaurantViewModel.FoodType = "Veg";
            restaurantViewModel.State = "TamilNadu";
            list.Add(restaurantViewModel);
            restaurantViewModel.RestaurantName = "Radisan";
            restaurantViewModel.MobileNumber = 8903940293;
            restaurantViewModel.Address = "Salem";
            restaurantViewModel.FoodType = "Veg";
            restaurantViewModel.State = "TamilNadu";
            list.Add(restaurantViewModel);
            return View(list);
        }
    }
}