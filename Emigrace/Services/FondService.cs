
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Emigrace.Core.Database;
using Emigrace.Core.Database.Generated;
using Emigrace.Models;

namespace Emigrace.Services
{
    public class FondService
    {

        public List<ArchivalFondViewModel> ShowFonds(int id)
        {
            var query = @"
                SELECT
                    arfo.FondName,
                    arfo.Id,
                    arfo.FondNumber,
                    arfo.TimeInterval
                FROM ArchivalFonds arfo
                inner join Archives on
                    arfo.ArchiveId = Archives.Id
                WHERE arfo.ArchiveId = @id
               
            ";


            return new Repository().SelectAdHoc<ArchivalFondViewModel>(query, new { id }).ToList();
        }
    }
}