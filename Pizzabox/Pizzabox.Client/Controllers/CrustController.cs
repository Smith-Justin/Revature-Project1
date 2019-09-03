using Microsoft.AspNetCore.Mvc;
using Pizzabox.Data;
using Pizzabox.Domain.Models;

namespace Pizzabox.Client.Controllers
{
    public class CrustController : Controller
    {
        PizzaDbContext _db = new PizzaDbContext();
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Crust crust)
        {
            if(ModelState.IsValid)
            {
                _db.Crusts.Add(crust);
                _db.SaveChanges();

                return Redirect("/home/index");
            }
            return View();
        }
    }
}