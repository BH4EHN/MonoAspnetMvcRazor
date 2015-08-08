using System;
using System.Data.Entity;

namespace MonoAspnetMvcRazor
{
	public class DatabaseContext : DbContext
	{
		public IDbSet<History> Histories { get; set;}

		public DatabaseContext () : base("name=defaultConnection")
		{
			
		}
	}
}

