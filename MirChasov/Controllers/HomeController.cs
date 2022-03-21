using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Bson;
using MongoDB.Driver;
using MirChasov.Models;
using System.Diagnostics;
using System.Linq;
using MirChasov.Models.ViewModels;


namespace MirChasov.Controllers
{
    public class HomeController : BaseController
    {

        public IActionResult Index()
        {
            return View(Data.Products);
        }


    }
}
