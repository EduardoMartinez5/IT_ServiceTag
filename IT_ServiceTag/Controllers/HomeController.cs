using IT_ServiceTag.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IT_ServiceTag.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;

        public HomeController()
        {
            _context = new ApplicationDbContext();
        }

        public ActionResult Login()
        {
            ViewBag.Message = "Acceso al sistema";
            return View();
        }

        public ActionResult DashboardAdmin()
        {
            ViewBag.Message = "Administrador";
            return View();
        }


        [HttpPost]
        public ActionResult Access(string usernameInput, string passwordInput)
        {
            var userData = _context.Users.SingleOrDefault(u => u.Username == usernameInput && u.Pass_User == passwordInput);

            if (userData != null)
            {
                // User exist!, access to dashboard!
                return RedirectToAction("DashboardAdmin");
            }
            else
            {
                // Invalid user or password
                ModelState.AddModelError("", "Credenciales incorrectas");
                return View();

            }
        }
    }
}