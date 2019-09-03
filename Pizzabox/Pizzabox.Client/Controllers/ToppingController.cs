using Microsoft.AspNetCore.Mvc;
using Pizzabox.Data;
using Pizzabox.Domain.Models;

namespace Pizzabox.Client.Controllers
{
    public class ToppingController : Controller
    {
        PizzaDbContext _db = new PizzaDbContext();
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Topping topping)
        {
            if(ModelState.IsValid)
            {
                _db.Toppings.Add(topping);
                _db.SaveChanges();

                return Redirect("/home/index");
            }
            return View();
        }
    }
}