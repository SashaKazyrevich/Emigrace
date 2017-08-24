using System.Collections.Generic;

namespace Emigrace.Core.Database.Generator
{
	public class TableIndex
	{
		public string Name;
		public List<IndexColumn> IndexColumns;
		public bool IsUnique;
		public string SQL;
	}
}