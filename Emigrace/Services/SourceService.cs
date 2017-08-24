using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Emigrace.Core.Database;
using Emigrace.Core.Database.Generated;

namespace Emigrace.Services
{
    public class SourceService
    {
        internal IDictionary<long, string> GetSourcesMap()
        {
            var repository = new Repository<SourceType>();
            return repository.Select().ToDictionary(x => x.Id, x => x.Name);
        }
    }
}