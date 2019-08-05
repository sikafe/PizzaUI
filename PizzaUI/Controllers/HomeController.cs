using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Entities;
using Microsoft.AspNetCore.Mvc;
using PizzaUI.BusinessLogic;
using PizzaUI.Models;

namespace PizzaAUI.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            Operations.ProductList = Operations.GetAllFromAPI<Product>(new Uri("http://localhost:51953/api/Products")); //gets  list of products from API 
            Operations.CategoryList = Operations.GetAllFromAPI<Category>(new Uri("http://localhost:51953/api/Categories")); //gets  list of categories from API
            Operations.CardTypeList = Operations.GetAllFromAPI<CardType>(new Uri("http://localhost:51953/api/CardTypes")); //gets  list of cardtypes from API
            return View();
        }

        public IActionResult Pizza()
        {
            Dictionary<string, string> menuImageDictionary = Operations.BuildPizzaImageDictionary(); // returns dictionry of image urls

            var categoryId = Operations.CategoryList.Find(m => m.Name == "PIZZA").CategoryId;

            UIHelperModel<List<Product>, Dictionary<string, string>> uIHelperModel = MenuBuilder(categoryId, menuImageDictionary);

            return View(uIHelperModel);
        }

        public IActionResult Stromboli()
        {
            Dictionary<string, string> menuImageDictionary = Operations.BuildStromboliImageDictionary(); // returns dictionry of image urls

            var categoryId = Operations.CategoryList.Find(m => m.Name == "STROMBOLI").CategoryId;

            UIHelperModel<List<Product>, Dictionary<string,string>> uIHelperModel = MenuBuilder(3, menuImageDictionary);

            return View(uIHelperModel);
        }

        public IActionResult Calzone()
        {
            Dictionary<string, string> menuImageDictionary = Operations.BuildCalzoneImageDictionary(); // returns dictionry of image urls

            var categoryId = Operations.CategoryList.Find(m => m.Name == "CALZONE").CategoryId;

            UIHelperModel<List<Product>, Dictionary<string, string>> uIHelperModel = MenuBuilder(4, menuImageDictionary);

            return View(uIHelperModel);
        }

        public IActionResult Sides()
        {
            Dictionary<string, string> menuImageDictionary = Operations.BuildSidesImageDictionary(); // returns dictionry of image urls

            var categoryId = Operations.CategoryList.Find(m => m.Name == "SIDE").CategoryId;

            UIHelperModel<List<Product>, Dictionary<string, string>> uIHelperModel = MenuBuilder(categoryId, menuImageDictionary);

            return View(uIHelperModel);
        }

        public IActionResult Drinks()
        {
            Dictionary<string, string> menuImageDictionary = Operations.BuildDrinksImageDictionary(); // returns dictionry of image urls

            var categoryId = Operations.CategoryList.Find(m => m.Name == "DRINK").CategoryId;

            UIHelperModel<List<Product>, Dictionary<string, string>> uIHelperModel = MenuBuilder(categoryId, menuImageDictionary);

            return View(uIHelperModel);
        }

        private UIHelperModel<List<Product>, Dictionary<string, string>> MenuBuilder(int categoryId, Dictionary<string, string> menuImageDictionary)
        {
            var products = Operations.ProductList;
            List<Product> menuProducts = new List<Product>(); //For storing only the products in category indicated by the catergoryId
            UIHelperModel<List<Product>, Dictionary<string, string>> uIHelperModel;

            foreach (Product product in products)
            {
                if (product.CategoryId == categoryId)
                {
                    menuProducts.Add(product);

                }
            }

            uIHelperModel = new UIHelperModel<List<Product>, Dictionary<string, string>>()
            {
                DataModel = menuProducts,
                ImageDictionary = menuImageDictionary
            };

            return uIHelperModel;
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
