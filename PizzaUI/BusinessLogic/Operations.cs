using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Entities;

namespace PizzaUI.BusinessLogic
{
    public class Operations
    {
        private static Dictionary<string, string> PizzaImageDictionary;
        private static Dictionary<string, string> StromboliImageDictionary;
        private static Dictionary<string, string> CalzoneImageDictionary;
        private static Dictionary<string, string> SidesImageDictionary;
        private static Dictionary<string, string> DrinksImageDictionary;

        public static Customer currentCustomer;
        public static Order currentOrder = new Order()
        {
            ItemList = new List<Item>(),
            DateCreated = DateTime.Now,
        };

        public static List<Product> ProductList;
        public static List<Category> CategoryList;
        public static List<Order> OrderList;
        public static List<CardType> CardTypeList;

        public static void CalculateOrderAmount(Order order)
        {
            double amount = 0;
            if (order.ItemList.Count>0) {
                foreach (Item item in order.ItemList)
                {
                    amount += item.Amount;
                }
            }
            order.PreTaxAmount = amount;
            order.Tax = amount * .05;
            order.TotalAmount = order.PreTaxAmount + order.Tax;
        }
        //calls an API and returns a list
        public static List<T> GetAllFromAPI<T>(Uri address)
        {
            var info = new List<T>();
            using (var client = new HttpClient())
            {
                client.BaseAddress = address;

                var request = client.GetAsync(client.BaseAddress);
                request.Wait();

                var result = request.Result;
                if (result.IsSuccessStatusCode)
                {
                    var read = result.Content.ReadAsAsync<List<T>>();
                    read.Wait();
                    info = read.Result;     
                }
            }
            return info;
        }

        //calls an API and posts an object
        public static HttpResponseMessage PostToAPI<T>(Uri address, T value)
        {
            HttpResponseMessage result = null;
            using (var client = new HttpClient())
            {
                client.BaseAddress = address;
                var response = client.PostAsJsonAsync(client.BaseAddress, value);
                response.Wait();
                result = response.Result;
                result.EnsureSuccessStatusCode();              
            }

            return result; ;
        }

        //calls an API and posts an object
        public static HttpResponseMessage PutToAPI<T>(Uri address, T value)
        {
            HttpResponseMessage result = null;
            using (var client = new HttpClient())
            {
                client.BaseAddress = address;
                var response = client.PutAsJsonAsync(client.BaseAddress, value);
                response.Wait();
                result = response.Result;
                result.EnsureSuccessStatusCode();
            }

            return result; ;
        }

        public static Dictionary<string,string> BuildPizzaImageDictionary()
        {
            PizzaImageDictionary = new Dictionary<string, string>()
            {
                {"MEAT LOVERS BREAKFAST","~/resources/imgs/MeatLoversBreakfastPizza.jpg"},
                {"PUTTANESCA","~/resources/imgs/pizza_puttanesca.jpg"},
                {"PORCINI","~/resources/imgs/blceleryporcinipizza.jpg"},
                {"TRUFFLED MUSHROOM","~/resources/imgs/truffledmushrrom.jpg"},
                {"BUFFALO CHICKEN","~/resources/imgs/buffalochicken.jpg"},
                {"THE BEAST","~/resources/imgs/thebeast.jpg"},
                {"THE VEGAN","~/resources/imgs/vegan.jpg"},
                {"THE VEGETARIAN","~/resources/imgs/VeggiePizza.jpg"}
            };
            return PizzaImageDictionary;
        }

        public static Dictionary<string, string> BuildStromboliImageDictionary()
        {
            StromboliImageDictionary = new Dictionary<string, string>()
            {
                {"CHICKEN PARMESIAN","~/resources/imgs/Chicken_Parm_Stromboli.jpg"},
                {"MEAT LOVERS","~/resources/imgs/Meat-Lovers-Stromboli.jpg"},
                {"GARLIC BUTTER","~/resources/imgs/Garlic Butter Stromboli.jpg"},
                {"PHILLY CHEESE STEAK","~/resources/imgs/PhillyCheeseSteakStromboli.jpg"},
                {"SAUSAGE & PEPPERONI","~/resources/imgs/stromboli-Sausage-Pepperoni.jpg"},
                {"CHEESY MEATBALL","~/resources/imgs/cheesymeatballstromboli.jpg"},
                {"CLASSIC","~/resources/imgs/classicstromboli.jpg"},
            };
            return StromboliImageDictionary;
        }

        public static Dictionary<string, string> BuildCalzoneImageDictionary()
        {
            CalzoneImageDictionary = new Dictionary<string, string>()
            {
                {"MEAT LOVERS","~/resources/imgs/Calzone_MeatLovers.jpg"},
                {"BUFFALO CHICKEN","~/resources/imgs/BuffaloChickenCalzone.jpg"},
                {"SPINACH RICOTTA & SAUSAGE","~/resources/imgs/SpinachRicottaSausageCalzone.jpg"},
                {"CHICKEN & SAUSAGE","~/resources/imgs/CheesySausageCalzone.jpg"},
                {"CHEESE & MUSHROOM","~/resources/imgs/Cheese_Mushroom_Calzone_-_(1865)_.jpg"},
                {"CHICKEN & BASIL","~/resources/imgs/chickenbasilcalzones.jpg"},
                {"HAM & CHEESE","~/resources/imgs/ham-and-cheese-calzone.jpg"},
            };
            return CalzoneImageDictionary;
        }

        public static Dictionary<string, string> BuildSidesImageDictionary()
        {
            SidesImageDictionary = new Dictionary<string, string>()
            {
                {"CLASSIC CHICKEN CAESAR","~/resources/imgs/classicChickenCaesar.jpg"},
                {"CHOPPED ANTIPASTO","~/resources//imgs/choppedAntiPasto.jpg"},
                {"BACON & BLU","~/resources/imgs/baconblu.jpg"},
                {"BONELESS WINGS","~/resources/imgs/bonelesswings.jpg"},
                {"BONE-IN WINGS","~/resources/imgs/boneinwings.jpg"},
            };
            return SidesImageDictionary;
        }

        public static Dictionary<string, string> BuildDrinksImageDictionary()
        {
            DrinksImageDictionary = new Dictionary<string, string>()
            {
                {"BIG RED","~/resources/imgs/BigRedSoda.jpg"},
                {"MOUNTAIN DEW","~/resources/imgs/MountainDew.jpg"},
                {"MOUNTAIN DEW VOLTAGE","~/resources/imgs/MountainDewVoltage.jpg"},
                {"NEHI PEACH","~/resources/imgs/Nehi Peach Soda.jpg"},
                {"FANTA","~/resources/imgs/Fanta.jpg"},
                {"ORANGE CREAM","~/resources/imgs/OrangeCreamSoda.jpg"},
                {"STRAWBERRY CREAM","~/resources/imgs/strawberry-cream-soda-16oz.jpg"},
            };
            return DrinksImageDictionary;
        }

    }
}
