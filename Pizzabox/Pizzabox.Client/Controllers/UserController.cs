using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Pizzabox.Data;
using Pizzabox.Domain.Models;
using System.Linq;

namespace Pizzabox.Client.Controllers
{
    public class UserController : Controller
    {
        PizzaDbContext _db = new PizzaDbContext();
        
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(LoginInfo Info)
        {
            LoginInfo siteLogin = _db.LoginInfos.Where(l => l.Email == Info.Email && l.Password == Info.Password).FirstOrDefault();
            
            if(siteLogin == null) return View();

            SessionInfo.CurrentUser = _db.Users.Include("Name").Include("LoginInfo").Where(l => l.LoginInfo == siteLogin).FirstOrDefault();
            return Redirect("/order/create");
        }


        [HttpGet]
        public IActionResult CreateAccount()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateAccount(LoginInfo newUserLoginInfo, Name newUserName)
        {
            if(ModelState.IsValid)
            {
                User newUser=new User(){
                    Name=newUserName,
                    LoginInfo=newUserLoginInfo
                };
                _db.Users.Add(newUser);

                _db.SaveChanges();


                return RedirectToAction("Login");
            }
            return CreateAccount();
        }

        public IActionResult UserInfo()
        {
            return View();
        }
    }
}