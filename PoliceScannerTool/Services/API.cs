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
    class API
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
    }
}
