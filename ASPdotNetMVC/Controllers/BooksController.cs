using ASPdotNetMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASPdotNetMVC.Controllers
{
    public class BooksController : BaseController
    {
        //
        // GET: /Books/

        public ActionResult Management()
        {
            var dao = new BookDAO();
            var model = dao.getAllBooks();
            return View(model);
        }

        [HttpGet]
        public ActionResult Update(int id)
        {
            var dao = new BookDAO();
            var ob = dao.getBookById(id);
            return View(ob);
        }
        [HttpPost]
        public ActionResult Update(BOOK entity)
        {
            var dao = new BookDAO();
            dao.handleUpdate(entity);
            return RedirectToAction("Management");
        }

        [HttpGet]
        public ActionResult Insert()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Insert(BOOK entity)
        {
            var dao = new BookDAO();
            dao.handleInsert(entity);
            return RedirectToAction("Management");
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            var dao = new BookDAO();
            dao.handleDelete(id);
            return RedirectToAction("Management");
        }

    }
}
