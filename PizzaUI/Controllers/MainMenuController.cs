using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Entities;
using Microsoft.AspNetCore.Mvc;
using PizzaUI.BusinessLogic;

namespace PizzaAppUI.Controllers
{
    public class MainMenuController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Pizza()
        {
            Dictionary<string, string> menuImageDictionary = Operations.BuildPizzaImageDictionary(); // returns dictionry of image urls

            var categoryId = Operations.CategoryList.Find(m => m.Name == "PIZZA").CategoryId;

            UIHelperModel<List<Product>, Dictionary<string, string>> uIHelperModel = MenuBuilder(categoryId, menuImageDictionary);

            return View(uIHelperModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Pizza([Bind("qty")] Item item, int id)
        {
            if (ModelState.IsValid)
            {
                AddToCart(item, id);
                return RedirectToAction(nameof(Order));
            }
            Dictionary<string, string> menuImageDictionary = Operations.BuildDrinksImageDictionary(); // returns dictionry of image urls

            var categoryId = Operations.CategoryList.Find(m => m.Name == "PIZZA").CategoryId;

            UIOrderHelperModel<List<Product>, Dictionary<string, string>, List<ItemProductModel>> uIOrderHelperModel = MenuBuilder1(categoryId, menuImageDictionary);

            return View(uIOrderHelperModel);
        }

        public IActionResult Stromboli()
        {
            Dictionary<string, string> menuImageDictionary = Operations.BuildStromboliImageDictionary(); // returns dictionry of image urls

            var categoryId = Operations.CategoryList.Find(m => m.Name == "STROMBOLI").CategoryId;

            UIHelperModel<List<Product>, Dictionary<string, string>> uIHelperModel = MenuBuilder(categoryId, menuImageDictionary);

            return View(uIHelperModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Stromboli([Bind("qty")] Item item, int id)
        {
            if (ModelState.IsValid)
            {
                AddToCart(item, id);
                return RedirectToAction(nameof(Order));
            }
            Dictionary<string, string> menuImageDictionary = Operations.BuildDrinksImageDictionary(); // returns dictionry of image urls

            var categoryId = Operations.CategoryList.Find(m => m.Name == "STROMBOLI").CategoryId;

            UIOrderHelperModel<List<Product>, Dictionary<string, string>, List<ItemProductModel>> uIOrderHelperModel = MenuBuilder1(categoryId, menuImageDictionary);

            return View(uIOrderHelperModel);
        }

        public IActionResult Calzone()
        {
            Dictionary<string, string> menuImageDictionary = Operations.BuildCalzoneImageDictionary(); // returns dictionry of image urls

            var categoryId = Operations.CategoryList.Find(m => m.Name == "CALZONE").CategoryId;

            UIHelperModel<List<Product>, Dictionary<string, string>> uIHelperModel = MenuBuilder(categoryId, menuImageDictionary);

            return View(uIHelperModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Calzone([Bind("qty")] Item item, int id)
        {
            if (ModelState.IsValid)
            {
                AddToCart(item, id);
                return RedirectToAction(nameof(Order));
            }
            Dictionary<string, string> menuImageDictionary = Operations.BuildDrinksImageDictionary(); // returns dictionry of image urls

            var categoryId = Operations.CategoryList.Find(m => m.Name == "CALZONE").CategoryId;

            UIOrderHelperModel<List<Product>, Dictionary<string, string>, List<ItemProductModel>> uIOrderHelperModel = MenuBuilder1(categoryId, menuImageDictionary);

            return View(uIOrderHelperModel);
        }

        public IActionResult Sides()
        {
            Dictionary<string, string> menuImageDictionary = Operations.BuildSidesImageDictionary(); // returns dictionry of image urls

            var categoryId = Operations.CategoryList.Find(m => m.Name == "SIDE").CategoryId;

            UIHelperModel<List<Product>, Dictionary<string, string>> uIHelperModel = MenuBuilder(categoryId, menuImageDictionary);

            return View(uIHelperModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Sides([Bind("qty")] Item item, int id)
        {
            if (ModelState.IsValid)
            {
                AddToCart(item, id);
                return RedirectToAction(nameof(Order));
            }
            Dictionary<string, string> menuImageDictionary = Operations.BuildDrinksImageDictionary(); // returns dictionry of image urls

            var categoryId = Operations.CategoryList.Find(m => m.Name == "SIDE").CategoryId;

            UIOrderHelperModel<List<Product>, Dictionary<string, string>, List<ItemProductModel>> uIOrderHelperModel = MenuBuilder1(categoryId, menuImageDictionary);

            return View(uIOrderHelperModel);
        }

        public IActionResult Drinks()
        {
            Dictionary<string, string> menuImageDictionary = Operations.BuildDrinksImageDictionary(); // returns dictionry of image urls

            var categoryId = Operations.CategoryList.Find(m => m.Name == "DRINK").CategoryId;

            UIHelperModel<List<Product>, Dictionary<string, string>> uIHelperModel = MenuBuilder(categoryId, menuImageDictionary);

            return View(uIHelperModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Drinks([Bind("qty")] Item item, int id)
        {
            if (ModelState.IsValid)
            {
                AddToCart(item, id);
                return RedirectToAction(nameof(Order));
            }
            Dictionary<string, string> menuImageDictionary = Operations.BuildDrinksImageDictionary(); // returns dictionry of image urls

            var categoryId = Operations.CategoryList.Find(m => m.Name == "DRINK").CategoryId;

            UIOrderHelperModel<List<Product>, Dictionary<string, string>, List<ItemProductModel>> uIOrderHelperModel = MenuBuilder1(categoryId, menuImageDictionary);

            return View(uIOrderHelperModel);
        }

        public IActionResult Order()
        {
            var order = Operations.currentOrder;
            var model = new OrderViewModel(){
                Order =order,
                ItemList = order.ItemList,
                ProductList = Operations.ProductList,
                CategoryList = Operations.CategoryList
            };
            return View(model);
        }

        public IActionResult Remove(int id)
        {
            var order = Operations.currentOrder;
            var item = order.ItemList.Find(m=>m.ProductId==id);
            order.ItemList.Remove(item);
            Operations.CalculateOrderAmount(order);
            return RedirectToAction(nameof(Order));
        }

        public IActionResult CheckOut()
        {
            if (Operations.currentOrder.TotalAmount == 0)
            {
                return RedirectToAction(nameof(Order));
            }
            var order = Operations.currentOrder;
            var model = new OrderViewModel()
            {
                Order = order,
                CardTypeList = Operations.CardTypeList,
            };
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CheckOut([Bind("CardType,ExpDate,CardNumber,Address,City,State,ZipCode,SecurityCode")] Payment payment)
        {
            payment.CardTypeId = 1;
            if (ModelState.IsValid)
            {
                if (payment.ExpDate<=DateTime.Now)
                {
                    var order1 = Operations.currentOrder;
                    var model1 = new OrderViewModel()
                    {
                        Order = order1,
                        CardTypeList = Operations.CardTypeList,
                    };
                    ModelState.AddModelError(string.Empty, "The Card has expired! Entera new card..");
                    return View(model1);
                }
                payment.DateCreated = DateTime.Now;        
                var customer = Operations.currentCustomer;
                if (customer.OrdersList == null)
                {
                    customer.OrdersList = new List<Order>();
                }
                customer.OrdersList.Add(Operations.currentOrder);
                if (customer.PaymentList == null)
                {
                    customer.PaymentList = new List<Payment>();
                }
                customer.PaymentList.Add(payment);
                string url = "http://localhost:51953/api/customers/" + Operations.currentCustomer.CustomerID ;
                Operations.PutToAPI<Customer>(new Uri(url), customer);
                Operations.currentCustomer.OrdersList = new List<Order>();
                Operations.currentOrder = new Order()
                {
                    ItemList = new List<Item>(),
                    DateCreated =DateTime.Now
                };
                return View("ThankYou");
            }

            var order = Operations.currentOrder;
            var model = new OrderViewModel()
            {
                Order = order,
                CardTypeList = Operations.CardTypeList,
            };
            return View(model);
        }

        public IActionResult OrderHistory()
        {
            var orderList = Operations.GetAllFromAPI<Order>(new Uri("http://localhost:51953/api/orders"));
            var items = Operations.GetAllFromAPI<Item>(new Uri("http://localhost:51953/api/items"));
            var orders = new List<Order>();

            foreach (Order order in orderList)
            {
                if (order.CustomerId == Operations.currentCustomer.CustomerID)
                {
                    order.ItemList = new List<Item>();
                    foreach (Item item in items)
                    {
                        if (item.OrderId == order.OrderId)
                        {
                            order.ItemList.Add(item);
                        }
                    }
                    orders.Add(order);
                }
            }
            return View(orders);
        }

        

        public IActionResult OrderDetails(int id)
        {
            var orders = Operations.GetAllFromAPI<Order>(new Uri("http://localhost:51953/api/orders"));
            var order = orders.Find(m=>m.OrderId==id);
            order.ItemList = new List<Item>();
            var items = Operations.GetAllFromAPI<Item>(new Uri("http://localhost:51953/api/items"));
            foreach (Item item in items)
            {
                if (item.OrderId == order.OrderId)
                {
                    order.ItemList.Add(item);
                }
            }
            
            var model = new OrderViewModel()
            {
                Order = order, 
                ItemList = order.ItemList,
                ProductList = Operations.ProductList,
                CategoryList = Operations.CategoryList
            };
            return View(model);
        }

        private UIHelperModel<List<Product>, Dictionary<string, string>> MenuBuilder(int categoryId, Dictionary<string, string> menuImageDictionary)
        {
            List<Product> products = Operations.ProductList;
            Operations.ProductList = products;
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

        private UIOrderHelperModel<List<Product>, Dictionary<string, string>, List<ItemProductModel>> MenuBuilder1(int categoryId, Dictionary<string, string> menuImageDictionary)
        {
            var products = Operations.ProductList;
            Operations.ProductList = products;
            List<Product> menuProducts = new List<Product>(); //For storing only the products in category indicated by the catergoryId
            UIOrderHelperModel<List<Product>, Dictionary<string, string>, List<ItemProductModel>> uIOrderHelperModel;
            List<ItemProductModel> itemProductModels = new List<Entities.ItemProductModel>();
            foreach (Product product in products)
            {
                if (product.CategoryId == categoryId)
                {
                    menuProducts.Add(product);
                    var productItem = new ItemProductModel()
                    {
                        Item = new Item()
                        {
                            ProductId =product.ProductId,
                        },
                        ProductName = product.Name
                    };
                    itemProductModels.Add(productItem);
                }
            }

            uIOrderHelperModel = new UIOrderHelperModel<List<Product>, Dictionary<string, string>, List<ItemProductModel>>()
            {
                ProductModel = menuProducts,
                ImageDictionary = menuImageDictionary,
                ItemModel = itemProductModels
            };

            return uIOrderHelperModel;
        }

        private void AddToCart(Item item, int id)
        {
            Order order;

            if (Operations.currentOrder == null)
            {
                Operations.currentOrder = new Order()
                {
                    ItemList = new List<Item>()
                };
            }

            order = Operations.currentOrder;

            if (order.ItemList.Count > 0)
            {
                var orderItem = order.ItemList.Find(m => m.ProductId == id);
                if (orderItem != null)
                {
                    orderItem.qty += item.qty;

                    var amount = Operations.ProductList.Find(m => m.ProductId == orderItem.ProductId).Price * orderItem.qty;

                    orderItem.Amount = amount;
                }
                else
                {
                    AddToEmptyCart(item, id);
                }
            }
            else
            {
                AddToEmptyCart(item, id);
            }
            Operations.CalculateOrderAmount(Operations.currentOrder);
        }

        private void AddToEmptyCart(Item item, int id) //A helper method that is used in the AddToCart Method 
        {
            item.ProductId = id;
            var order = Operations.currentOrder;
            var amount = Operations.ProductList.Find(m => m.ProductId == id).Price * item.qty;
            item.Amount = amount;
            order.ItemList.Add(item);
        }

    }
}