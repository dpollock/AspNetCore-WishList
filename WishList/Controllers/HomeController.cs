using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WishList.Models;

namespace WishList.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View("Index",  new List<Item>());
        }

        public IActionResult Error()
        {
            return View("Error");
        }

        public IActionResult Create()
        {
            return View("Create", new Item());
        }

        public IActionResult Delete(int id)
        {
            return Index();
        }
    }
}
