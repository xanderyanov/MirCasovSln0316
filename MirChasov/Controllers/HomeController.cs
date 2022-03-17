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
    public class HomeController : Controller
    {
        public int PageSize = 24;

        public IActionResult Index()
        {
            var productsCollection = Program.DB.GetCollection<Product>("products");
            BsonDocument filter = new BsonDocument();
            IEnumerable<Product> products = productsCollection.Find(filter).ToList();

            return View(products);
        }

        public IActionResult Catalog(string category, int productPage = 1)
        {
            var productsCollection = Program.DB.GetCollection<Product>("products");
            BsonDocument filter = new BsonDocument();
            IEnumerable<Product> products = productsCollection.Find(filter).ToList();

            return View(new ProductsListViewModel
            {
                Products = products
                   .Where(p => category == null || p.Brand == category)
                   .OrderBy(p => p.Id)
                   .Skip((productPage - 1) * PageSize)
                   .Take(PageSize),
                PagingInfo = new PagingInfo
                {
                    CurrentPage = productPage,
                    ItemsPerPage = PageSize,
                    TotalItems = products.Count()
                },
                CurrentCategory = category
            });
        }
    }
}
