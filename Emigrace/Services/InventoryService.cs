using System.Linq;
using System.Web;
using Emigrace.Core.Database;
using Emigrace.Core.Database.Generated;
using Emigrace.Models;
using System.Collections.Generic;

namespace Emigrace.Services
{
    public class InventoryService
    {

        public List<InventoryViewModel> ShowInventory(int id)
        {
            var query = @"
                SELECT
                    foin
                FROM FondInventories foin
                inner join ArchivalFonds on
                    foin.FondId = ArchivalFonds.Id
                WHERE foin.FondId = @id
               
            ";


            return new Repository().SelectAdHoc<ArchivalFondViewModel>(query, new { id }).ToList();
        }
    }
}
