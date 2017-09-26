using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Emigrace.Models;
using Emigrace.Services;

namespace Emigrace.Controllers
{
    public class ArchivesController : Controller
    {
        // GET: Archives
        public ActionResult Index()
        {
            var archives = new ArchiveService().SelectArchives();

            return View(archives);
        }

        public ActionResult Create()
        {
            return View();
        }

        public ActionResult Remove()
        {
            return View();
        }

        public ActionResult Update()
        {
            return View();
        }


        //public ActionResult Save(ArchiveViewModel model)
        //{
        //    return View();
        //}
    }

}