using System;

namespace Covignite.Models
{
	public class CountryTotalAllStatus
	{
		public long Confirmed { get; set; }
		public long Deaths { get; set; }
		public long Recovered { get; set; }
		public long Active { get; set; }
		public DateTime Date { get; set; }
	}
}
