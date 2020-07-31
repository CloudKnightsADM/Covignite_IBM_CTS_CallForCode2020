using CsvHelper.Configuration;

namespace Covignite.Models
{
	public class CountryModel
	{
		public string Name { get; set; }
		public string Iso2 { get; set; }
		public string Iso3 { get; set; }
		public string Code3 { get; set; }
		public string Province { get; set; }
		public string CombinedKey { get; set; }
		public decimal? Longitude { get; set; }
		public decimal? Latitude { get; set; }
		public long? Population { get; set; }

	}

	class CsvCountryMapping : ClassMap<CountryModel>
	{
		public CsvCountryMapping() : base()
		{
			Map(x => x.Iso2).Index(1);
			Map(x => x.Iso3).Index(2);
			Map(x => x.Code3).Index(3);
			Map(x => x.Province).Index(6);
			Map(x => x.Name).Index(7);
			Map(x => x.Latitude).Index(8);
			Map(x => x.Longitude).Index(9);
			Map(x => x.CombinedKey).Index(10);
			Map(x => x.Population).Index(11);
		}
	}
}
