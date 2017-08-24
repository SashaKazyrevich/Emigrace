using System.Collections.Generic;
using Emigrace.Core.Database.Generated;

namespace Emigrace.Core.Database
{
	public interface IRepository<TEntity>
		where TEntity : TableEntity
	{
		IEnumerable<TEntity> Select(string sqlWhere = null, dynamic param = null, int timeoutSeconds = 15, bool bypassCache = false);
		bool Save(TEntity item);
	}
}
