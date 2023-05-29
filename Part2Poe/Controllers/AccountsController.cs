using System;
using System.Collections.Generic;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using Part2Poe.Models;
using System.Linq;

namespace Part2Poe.Controllers
{
    //this is the account controller where users will be able to register, login and log out.
    public class AccountsController : Controller
    {
        //the project was taken and adabted by The Amazing Codeverse youtube channel
        //link to video : https://youtu.be/6AP7SmIIJIE
        Task2ProgEntities entity = new Task2ProgEntities();
        // GET: Accounts
        public ActionResult Login()
        {
            return View();
        }

        public ActionResult Signup()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(LoginViewModel credentials)
        {
            bool userExist = entity.Userstbls.Any(x => x.Email == credentials.Email && x.Passcode == credentials.Password);
            Userstbl u = entity.Userstbls.FirstOrDefault(x => x.Email == credentials.Email && x.Passcode == credentials.Password);

            if (userExist)
            {
                FormsAuthentication.SetAuthCookie(u.Username, false);
                return RedirectToAction("Index", "Home");
            }

            ModelState.AddModelError("", "Username or Password is incorrect");
            return View();
        }
        [HttpPost]
        public ActionResult Signup(Userstbl userinfo)
        {
            entity.Userstbls.Add(userinfo);
            entity.SaveChanges();
            return RedirectToAction("Login");
            
        }
        public ActionResult Signout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Login");
        }
    }
}