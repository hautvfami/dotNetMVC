using ASPdotNetMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASPdotNetMVC.Controllers
{
    public class UsersController : BaseController
    {
        //
        // GET: /Users/

        public ActionResult Management()
        {
            var dao = new UserDAO();
            var model = dao.getAllUsers();
            return View(model);
        }

        [HttpGet]
        public ActionResult Update(int id)
        {
            var dao = new UserDAO();
            var ob = dao.getUserById(id);
            return View(ob);
        }
        [HttpPost]
        public ActionResult Update(USER entity)
        {
            var dao = new UserDAO();
            dao.handleUpdate(entity);
            return RedirectToAction("Management");
        }

        [HttpGet]
        public ActionResult Insert()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Insert(USER entity)
        {
            var dao = new UserDAO();
            dao.handleInsert(entity);
            return RedirectToAction("Management");
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            var dao = new UserDAO();
            dao.handleDelete(id);
            return RedirectToAction("Management");
        }
    }
}
