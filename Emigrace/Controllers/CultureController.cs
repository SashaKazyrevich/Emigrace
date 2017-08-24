using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Emigrace.Controllers
{
    public class CultureController : EmigraceController
    {
        public ActionResult SetCulture(string language)
        {
            Language = language;

            return RedirectToAction("Index", "Home");
        }

    }
}