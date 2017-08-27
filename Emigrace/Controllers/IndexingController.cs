using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Emigrace.Controllers
{
    public class IndexingController : Controller
    {
        // GET: Indexing
        public ActionResult Index()
        {
            ViewBag.Message = "Page I";

            return View();
        }

       
    }
}