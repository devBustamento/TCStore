using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using Microsoft.AspNetCore.Mvc;
using TrueStore.Models;

namespace TrueStore.Controllers
{
    public class StoreController : Controller
    {
        public ActionResult Index()
        {
            var category = new List<Category>
            {
                new Category {Name = "Electronics"},
                new Category {Name = "Furniture"},
                new Category {Name = "Accessories"},
            };
            return View(category);
        }

        public ActionResult Browse(string category)
        {
            var categoryModel = new Category { Name = category };
            return View(categoryModel);
        }

        public ActionResult Details(int id)
        {
            var Item = new Item { Title = "Item" + id };
            return View(Item);
        }
    }
}