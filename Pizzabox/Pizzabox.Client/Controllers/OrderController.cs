using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Pizzabox.Data;
using Pizzabox.Domain.Models;
using System.Collections.Generic;
using System.Linq;

namespace Pizzabox.Client.Controllers
{
    public class OrderController : Controller
    {
        PizzaDbContext _db = new PizzaDbContext();


        [HttpGet]
        public IActionResult Create()
        {
            return View(_db.Locations.Include("Address").ToList());
        }

        [HttpPost]
        public IActionResult Create(int chosenLocationId)
        {
            if(SessionInfo.CurrentUser is null) return Redirect("/user/login");
            if(chosenLocationId != 0)
            {
                SessionInfo.CurrentOrder = new Order()
                {
                    Location = _db.Locations.Include("Address").SingleOrDefault(l => l.Id == chosenLocationId),
                    User = SessionInfo.CurrentUser,
                    Pizzas = new List<Pizza>()
                };

                return Redirect("/pizza/create");
            }
            return Create();
        }
        public IActionResult Test(){return View();}

        [HttpGet]
        public IActionResult Confirm()
        {
            return View(SessionInfo.CurrentOrder);
        }

        [HttpPost]
        public IActionResult Confirm(string confirmation)
        {
            if(SessionInfo.CurrentOrder != null && SessionInfo.CurrentOrder.Pizzas.Count > 0)
            {
                _db.Orders.Add(SessionInfo.CurrentOrder);
                _db.SaveChanges();
                SessionInfo.CurrentOrder = null;

                return RedirectToAction("History");
            }
            return RedirectToAction("Create");
        }
    }
}