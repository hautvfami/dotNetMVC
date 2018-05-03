using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASPdotNetMVC.Controllers
{
    public class DealsController : BaseController
    {
        //
        // GET: /Deals/

        public ActionResult Index()
        {
            return View();
        }

    }
}
