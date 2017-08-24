using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Mvc;

namespace Emigrace.Controllers
{
    public abstract class EmigraceController : Controller
    {
        protected override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            var culture = CultureInfo.GetCultureInfo(Language);
            Thread.CurrentThread.CurrentCulture = culture;
            Thread.CurrentThread.CurrentUICulture = culture;
            base.OnActionExecuting(filterContext);
        }

        protected string Language
        {
            get
            {
                return Session["language"] as string ?? "en";
            }
            set
            {
                Session["language"] = value;
            }
        }
    }
}