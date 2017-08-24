using Emigrace.Models;
using Emigrace.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Emigrace.Controllers
{
    public class SearchController : Controller
    {
        // GET: Search
        public ActionResult Index(SearchViewModel searchmodel)
        {
            var service = new LibraryService();
            var persons = service.SelectAllPersons(searchmodel); 
            return View(persons);
        }
    }
}