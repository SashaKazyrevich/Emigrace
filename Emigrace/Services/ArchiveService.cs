using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Emigrace.Core.Database;
using Emigrace.Core.Database.Generated;
using Emigrace.Models;

namespace Emigrace.Services
{
    public class ArchiveService
    {
        public IEnumerable<ArchiveViewModel> SelectArchives()
        {
            var query = @"
                SELECT 
                    arch.Name,
                    arch.Adress,
                    arch.Country,
                    arch.Phone,
                    arch.WebPages
                FROM Archives arch
                ORDER BY arch.Name
            ";

            return new Repository().SelectAdHoc<ArchiveViewModel>(query);
        }
    }
}