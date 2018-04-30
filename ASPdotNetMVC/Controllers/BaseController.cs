using ASPdotNetMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace ASPdotNetMVC.Controllers
{
    public class BaseController : Controller
    {
        //
        // GET: /Base/
        protected override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            if (Session["localInfo"] == null)
                filterContext.Result = new RedirectToRouteResult(
                    new RouteValueDictionary(new { action = "Index", controller = "Login"}));
            else
                base.OnActionExecuting(filterContext);
        }
    }
}
