using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Mvc;
using Test.Auth;

namespace Test.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            HttpContext.Session["user"] = "唐健";
            return View();
        }
         
        [HttpPost]
        [AuthAttribute]
        public ContentResult GetData(string json,int count)
        { 
            return Content("尖子");
        }

        public ActionResult Login()
        {
            return View();
        }
    }
}