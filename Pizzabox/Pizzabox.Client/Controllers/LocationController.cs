using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Pizzabox.Data;
using Pizzabox.Domain.Models;

namespace Pizzabox.Client.Controllers
{
    public class LocationController : Controller
    {
        PizzaDbContext _db = new PizzaDbContext();

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Address newAddress)
        {
            if(ModelState.IsValid)
            {
                Location newLocation = new Location(){Address = newAddress};
                _db.Locations.Add(newLocation);
                _db.SaveChanges();

                return RedirectToAction("Read");
            }
            return Create();
        }

        public IActionResult Read()
        {
            return View(_db.Addresses.ToList());
        }
    }
}