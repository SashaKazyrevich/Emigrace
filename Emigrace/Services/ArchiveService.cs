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
                    arch.Id,
                    arch.Name,
                    arch.Adress,
                    arch.Country
                FROM Archives arch
                ORDER BY arch.Name
            ";

            return new Repository().SelectAdHoc<ArchiveViewModel>(query);
        }

        public ArchiveViewModel ShowArchive(int id)
        {
            var query = @"
                SELECT
                    arch.Id,
                    arch.Name,
                    arch.Adress,
                    arch.Country,
                    arch.Phone,
                    arch.WebPages
                FROM Archives arch
                WHERE arch.Id = @id
            ";

            return new Repository().SelectAdHoc<ArchiveViewModel>(query, new { id }).SingleOrDefault();
        }
    }
}