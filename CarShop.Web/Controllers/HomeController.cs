using CarShop.Mvc.Common.Models.Meta;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace CarShop.Web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewData["MetaTags"] = new MetaTags
            {
                Description = "The home page of a car selling website",
                Title = "The Car Shop",
                Keywords = "cars,shop,ferrari,porsche,lamborghini,bugatti",
                Language = "en-GB",
                ImageUrls = new List<string> { "http://assets.bugatti.com/fileadmin/user_upload/Web/Pages/Models/Super_Sport/BUG_super_sport_02.jpg",
                    "http://o.aolcdn.com/commerce/autodata/images/USC30FRC151A021001.jpg" }
            };

            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
