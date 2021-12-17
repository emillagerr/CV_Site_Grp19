using CV_Site_Grp19.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CV_Site_Grp19.Controllers
{
    public class UserController : Controller
    {
        // GET: UserList
        public ActionResult Index()
        {
            using(OurDBContext db = new OurDBContext())
            {
                return View(db.users.ToList());
            }
            
        }

        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register(User user)
        {
            if (ModelState.IsValid)
            {
                using(OurDBContext db = new OurDBContext())
                {
                    db.users.Add(user);
                    db.SaveChanges();
                }
                ModelState.Clear();
                ViewBag.Message = user.Name + " har registrerats";
            }
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(User user)
        {
            using(OurDBContext db = new OurDBContext())
            {
                var usr = db.users.Single(u => u.Username == user.Username && u.Password == user.Password);
                if(usr != null)
                {
                    Session["ID"]  = usr.ID.ToString();
                    Session["Username"] = usr.Username.ToString();
                    return RedirectToAction("LoggedIn");
                }
                else
                {
                    ModelState.AddModelError(" ", "Användarnamn eller lösenord är fel");
                }
            }
            return View();
        }

        public ActionResult LoggedIn()
        {
            if(Session["ID"] != null)
            {
                return View();
            }
            else
            {
                return RedirectToAction("Login");
            }
        }
    }
}