using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


using ASPdotNetMVC.Models;

namespace ASPdotNetMVC.Controllers
{
    public class LoginController : Controller
    {
        //
        // GET: /Login/
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult handleLogin(USER entity)
        {
            var dao = new UserDAO();
            var model = dao.handleLogin(entity.USERNAME, entity.PASSWORD);
            if (model != null)
            {
                Session["localInfo"] = model;
                return RedirectToAction("Index", "Home");
            }
            return Content("Hi, Login fail!");
        }

    }
}
