using System;

namespace Covignite.Models
{
	public class GlobalData
	{
		public string CountryName { get; set; }
		public string Province { get; set; }
		public long Confirmed { get; set; }
		public long Deaths { get; set; }
		public long Recovered { get; set; }
		public DateTime Date { get; set; }
	}
}
