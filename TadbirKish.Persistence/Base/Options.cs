using TadbirKish.Base;
using TadbirKish.Base.Enums;

namespace TadbirKish.Persistence.Base
{
	public class Options : object
	{
		public Options() : base()
		{
		}

		public Provider Provider { get; set; }

		public string ConnectionString { get; set; }

		public string InMemoryDatabaseName { get; set; }
	}
}
