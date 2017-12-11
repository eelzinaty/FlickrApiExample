using FlickerApiApp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FlickerApiApp.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            ViewBag.Title = "Flickr API - Search Photos";
            
            FlickerApiService api = new FlickerApiService();
            ViewBag.Photos = api.GetPhotos().GetAwaiter().GetResult().photos;
            return View();
        }
    }
}