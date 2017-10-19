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

        public List<InventoryViewModel> ShowInventory(int fondId)
        {
            var query = @"
                SELECT
                    foin.InventoryNumber 
                FROM FondInventories foin
                inner join ArchivalFonds on
                    foin.FondId = ArchivalFonds.Id
                WHERE foin.FondId = @fondId
               
            ";


            return new Repository().SelectAdHoc<InventoryViewModel>(query, new { fondId }).ToList();
        }
    }
}
