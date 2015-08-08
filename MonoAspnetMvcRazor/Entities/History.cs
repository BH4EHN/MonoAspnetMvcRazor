using System;

namespace MonoAspnetMvcRazor
{
	public class History 
	{
		public Int32 Id {
			get;
			set;
		}
		public DateTime VisitTime {
			get;
			set;
		}
		public String IPAddress {
			get;
			set;
		}
		public String Uri {
			get;
			set;
		}
	}
}

