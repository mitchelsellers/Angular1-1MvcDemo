using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AngularDemo.ViewModels.Angular;

namespace AngularDemo.Controllers
{
    public class AngularController : Controller
    {
        // GET: Angular
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ShoppingList()
        {
            //TODO: Something better here!
            if (Session["MyItems"] == null)
            {
                return View(new ShoppingListViewModel()
                {
                    Items =
                        new List<ShoppingItem>()
                        {
                            new ShoppingItem
                            {
                                ItemId = 1,
                                ItemToGet =
                                    "Visual Studio 2013",
                                IsComplete =
                                    true
                            },
                            new ShoppingItem
                            {
                                ItemId = 2,
                                ItemToGet =
                                    "AngularJS",
                                IsComplete =
                                    false
                            }
                        }
                });
            }

            //We have items
            var myList = (List<ShoppingItem>) Session["MyItems"];
            return View(new ShoppingListViewModel {Items = myList});
        }

        [HttpPost]
        public ActionResult StoreShoppingList(List<ShoppingItem> items)
        {
            //TODO: Store somewhere
            Session["MyItems"] = items;
            return Json("List Stored");
        }
    }
}