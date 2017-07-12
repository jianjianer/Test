using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Test.Auth
{
    public class AuthAttribute:ActionFilterAttribute
    {
        public int iss = 1;
        public override void OnActionExecuting(ActionExecutingContext filterContext)
         {
            base.OnActionExecuting(filterContext); 
            
            string requestedWith = filterContext.RequestContext.HttpContext.Request.Params["HTTP_X_REQUESTED_WITH"];
            if (!string.IsNullOrEmpty(requestedWith) && requestedWith.Equals("XMLHttpRequest")) {
                filterContext.HttpContext.Response.Headers.Set("sessionstatus","timeout");
            }  
            var user = filterContext.RequestContext.HttpContext.Session["user"];

            //if (count % 2 == 0)
            //{
            //    var session = filterContext.HttpContext.Session["user"];
            //    filterContext.HttpContext.Response.Redirect("~/Account/Login", true);
            //    filterContext.HttpContext.Response.End();
            //    filterContext.Result = new ContentResult();
            //    return;
            //}
            //else {
            //    filterContext.HttpContext.Session["user"] = "唐健";
            //}
            filterContext.HttpContext.Session["user"] = "阿凡达";
            
        }
    }
}