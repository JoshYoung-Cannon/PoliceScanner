using PoliceScannerTool.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using Newtonsoft.Json;

namespace PoliceScannerTool.Services
{
    public class API
    {
        public API()
        {
            BaseURL = "https://data.police.uk/api/";
            LastUpdate = "crime-last-updated";
        }
        private string BaseURL { get; set; }
        private string LastUpdate { get; set; }

        public DateDto GetLatestUpdate()
        {
            string getDateURL = BaseURL + LastUpdate;
            string jsonHolder = null;
            DateDto dateDto = null;

            WebRequest requestMaxDate = WebRequest.Create(getDateURL);
            requestMaxDate.Method = "GET";
            HttpWebResponse response = (HttpWebResponse)requestMaxDate.GetResponse();

            using (Stream stream = response.GetResponseStream())
            {
                StreamReader sr = new StreamReader(stream);
                jsonHolder = sr.ReadToEnd();
                sr.Close();
            }

            dateDto = JsonConvert.DeserializeObject<DateDto>(jsonHolder);

            return dateDto;
        }

        public string FormatCrimesInLocationParameters(decimal lat, decimal lng, FormDate date)
        {
            string apiExtension = "crimes-street/all-crime?";
            string latParam = "lat=" + lat.ToString();
            string lngParam = "&lng=" + lng.ToString();
            string dateParam = "&date=" + date.ToString();

            string parameters = apiExtension + latParam + lngParam + dateParam;
            return String.Concat(parameters.Where(c => !Char.IsWhiteSpace(c)));
        }

        public List<CrimeDto> GetAllCrimesInLocation(string parameters)
        {
            string getCrimesURL = BaseURL + parameters;
            string jsonHolder = null;
            List<CrimeDto> allCrimes = new List<CrimeDto>();

            WebRequest requestCrimeList = WebRequest.Create(getCrimesURL);
            requestCrimeList.Method = "GET";
            HttpWebResponse response = (HttpWebResponse)requestCrimeList.GetResponse();

            using (Stream stream = response.GetResponseStream())
            {
                StreamReader sr = new StreamReader(stream);
                jsonHolder = sr.ReadToEnd();
                sr.Close();
            }
            allCrimes = JsonConvert.DeserializeObject<List<CrimeDto>>(jsonHolder);
            return allCrimes;
        }
    }
}
