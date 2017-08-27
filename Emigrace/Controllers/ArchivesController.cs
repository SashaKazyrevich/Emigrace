using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Emigrace.Models;

namespace Emigrace.Controllers
{
    public class ArchivesController : Controller
    {
        // GET: Archives
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Create()
        {
            return View();
        }

        //public ActionResult Save(ArchiveViewModel model)
        //{
        //    return View();
        //}
    }

}