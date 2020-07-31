using Covignite.Models;
using CsvHelper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;

namespace Covignite.Data
{
	public static class DataHelper
	{
		public static string HandleRequest(string url)
		{
			try
			{
				var response = string.Empty;
				using (WebClient wc = new WebClient())
					response = wc.DownloadString(url);
				return response;
			}
			catch { return string.Empty; }
		}

		public static void ReadCsvFile(DataTable dt, string csvContent)
		{
			string[] rows = csvContent.Split('\n'); //split full file text into rows
			for (int i = 0; i < rows.Count() - 1; i++)
			{

				string[] rowValues = Regex.Split(rows[i], ",(?=(?:[^\"]*\"[^\"]*\")*[^\"]*$)"); //split each row with comma to get individual values
				if (i == 0)
				{
					for (int j = 0; j < rowValues.Count(); j++)
					{
						dt.Columns.Add(rowValues[j]); //add headers
					}
				}
				else
				{
					DataRow dr = dt.NewRow();
					for (int k = 0; k < rowValues.Count(); k++)
					{
						dr[k] = rowValues[k].ToString();
					}
					dt.Rows.Add(dr); //add other rows
				}
			}
		}

		public static List<CountryModel> GetCountries(string countryLookupFilePath)
		{
			using (var reader = new StreamReader(countryLookupFilePath, Encoding.Default))
			using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
			{
				csv.Configuration.RegisterClassMap<CsvCountryMapping>();
				csv.Configuration.HasHeaderRecord = true;
				csv.Configuration.Delimiter = ",";
				csv.Configuration.HeaderValidated = null;
				csv.Configuration.MissingFieldFound = null;
				List<CountryModel> countries = csv.GetRecords<CountryModel>().OrderBy(c => c.Name).ToList();
				return countries;
			}
		}

		public static List<GlobalData> GetCovidGlobalData(string confirmedGlobalUrl, string deathsGlobalUrl)
		{
			var globalData = new List<GlobalData>();
			string confirmedGlobalResponse = HandleRequest(confirmedGlobalUrl);
			string deathsGlobalResponse = HandleRequest(deathsGlobalUrl);
			var dtConfirmedGlobal = new DataTable();
			var dtDeathsGlobal = new DataTable();
			ReadCsvFile(dtConfirmedGlobal, confirmedGlobalResponse);
			ReadCsvFile(dtDeathsGlobal, deathsGlobalResponse);

			foreach (DataRow row in dtConfirmedGlobal.Rows)
			{
				var province = Convert.ToString(row[0]);
				var country = Convert.ToString(row[1]);
				var lat = Convert.ToDouble(row[2]);
				var _long = Convert.ToDouble(row[3]);

				var columns = dtConfirmedGlobal.Columns;
				for (int i = 4; i < dtConfirmedGlobal.Columns.Count; i++)
				{
					var dateParts = dtConfirmedGlobal.Columns[i].ColumnName.Split('/');
					var date = new DateTime(Convert.ToInt32("20" + dateParts[2]), Convert.ToInt32(dateParts[0]), Convert.ToInt32(dateParts[1]));
					globalData.Add(new GlobalData
					{
						Date = date,
						CountryName = country,
						Province = province,
						Confirmed = Convert.ToInt64(row[i]),
						Deaths = dtDeathsGlobal.Columns.IndexOf(dtConfirmedGlobal.Columns[i].ColumnName) != -1 ?
								Convert.ToInt64(dtDeathsGlobal.Rows.Cast<DataRow>().First(r =>
								Convert.ToString(r[0]) == province &&
								Convert.ToString(r[1]) == country)
								[dtDeathsGlobal.Columns.IndexOf(dtConfirmedGlobal.Columns[i].ColumnName)]) : 0
					});
				}
			}
			globalData = globalData.OrderBy(d => d.Date).ToList();
			return globalData;
		}
	}
}
