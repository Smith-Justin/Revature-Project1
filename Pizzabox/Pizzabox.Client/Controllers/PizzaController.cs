using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Pizzabox.Data;
using Pizzabox.Domain.Models;

namespace PizzaBox.Client.Controllers
{
    public class PizzaController : Controller
    {
        private static Pizza _tempPizza;
        PizzaDbContext _db = new PizzaDbContext();
        [HttpGet]
        public IActionResult Create()
        {
            if(SessionInfo.CurrentUser == null) return Redirect("/User/Login");
            if(SessionInfo.CurrentOrder == null) return Redirect("/Order/Create");
            _tempPizza = new Pizza();

            return RedirectToAction("AddSize");
        }

        [HttpGet]
        public IActionResult AddSize()
        {
            return View(_db.Sizes.ToList());
        }
        [HttpPost]
        public IActionResult AddSize(int size)
        {
            if(size != 0)
            {
                _tempPizza.Size = _db.Sizes.Find(size);
                return RedirectToAction("AddCrust");
            }
            return View();
        }

        public IActionResult AddCrust()
        {
            return View(_db.Crusts.ToList());
        }
        [HttpPost]
        public IActionResult AddCrust(int crust)
        {
            if(crust != 0)
            {
                _tempPizza.Crust = _db.Crusts.Find(crust);
                return RedirectToAction("AddToppings");
            }
            return View();
        }

        public IActionResult AddToppings()
        {
            return View(_db.Toppings.ToList());
        }
        [HttpPost]
        public IActionResult AddToppings(List<int> toppings)
        {
            _tempPizza.Toppings = new List<Topping>();
            
            foreach(var t in toppings)
            {
                if(t != 0) _tempPizza.Toppings.Add(_db.Toppings.Find(t));
            }

            return RedirectToAction("Done");
        }

        public IActionResult Done()
        {
            if(_tempPizza.Size != null
                && _tempPizza.Crust != null
                && _tempPizza.Toppings != null)
                    {
                        SessionInfo.CurrentOrder.Pizzas.Add(_tempPizza);
                    }
            return Redirect("/Order/Confirm");
        }
    }
}