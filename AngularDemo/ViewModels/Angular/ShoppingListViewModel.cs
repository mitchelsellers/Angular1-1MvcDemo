using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AngularDemo.ViewModels.Angular
{
    public class ShoppingListViewModel
    {
        public List<ShoppingItem> Items { get; set; } 
    }

    public class ShoppingItem
    {
        public int ItemId { get; set; }
        public string ItemToGet { get; set; }
        public bool IsComplete { get; set; }
    }
}