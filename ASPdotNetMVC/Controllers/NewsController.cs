using ASPdotNetMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASPdotNetMVC.Controllers
{
    public class NewsController : BaseController
    {
        //
        // GET: /News/

        public ActionResult Index()
        {
            var dao = new NewsDAO();
            var model = dao.getAllNews();
            return View(model);
        }

        [HttpGet]
        public ActionResult Management()
        {
            var dao = new NewsDAO();
            var model = dao.getAllNews();
            return View(model);
        }

        [HttpGet]
        public ActionResult Update(int id)
        {
            var dao = new NewsDAO();
            var ob = dao.getById(id);
            ob.CONTENT = "";
            return View(ob);
        }
        [HttpPost]
        public ActionResult Update(NEWS entity)
        {
            var dao = new NewsDAO();
            dao.updateNews(entity);
            return RedirectToAction("Management");
        }

        [HttpGet]
        public ActionResult Insert()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Insert(NEWS entity)
        {
            var dao = new NewsDAO();
            dao.insertNews(entity);
            return RedirectToAction("Management");
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            var dao = new NewsDAO();
            dao.deleteNews(id);
            return RedirectToAction("Management");
        }
    }
}
