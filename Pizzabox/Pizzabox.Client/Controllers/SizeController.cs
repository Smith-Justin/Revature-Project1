using Microsoft.AspNetCore.Mvc;
using Pizzabox.Data;
using Pizzabox.Domain.Models;

namespace Pizzabox.Client.Controllers
{
    public class SizeController : Controller
    {
        PizzaDbContext _db = new PizzaDbContext();
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Size size)
        {
            if(ModelState.IsValid)
            {
                _db.Sizes.Add(size);
                _db.SaveChanges();

                return Redirect("/home/index");
            }
            return View();
        }
    }
}