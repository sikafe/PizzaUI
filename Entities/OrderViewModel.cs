using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class OrderViewModel
    {
        public Order Order { set; get; }
        public List<Item> ItemList { set; get; }
        public List<Product> ProductList { set; get; }
        public List<Category> CategoryList { set; get; }
        public List<CardType> CardTypeList { set; get; }
    }
}
