using Emigrace.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Emigrace.Models
{
    public class Dropdown
    {
        public static IEnumerable<SelectListItem> Sources
        {
            get
            {
                var service = new SourceService();
                var sourcesMap = service.GetSourcesMap();

                var sources = sourcesMap.Keys.Select(x => new SelectListItem
                {
                    Text = sourcesMap[x],
                    Value = x.ToString()
                }).OrderBy(x => x.Text).ToList();

               
                sources.Insert(0, new SelectListItem { Text = "All", Value = "0" });

                return sources;
            }
        }
    }
}