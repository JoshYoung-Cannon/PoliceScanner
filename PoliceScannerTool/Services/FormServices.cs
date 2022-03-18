using PoliceScannerTool.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoliceScannerTool.Services
{
    public class FormServices
    {
        public List<SummaryItem> GetCrimeSummary(List<CrimeDto> allCrimeInfo)
        {
            List<string> crimeCategories = new List<string>();
            List<string> simpleCrimeList = new List<string>();

            foreach (CrimeDto crime in allCrimeInfo)
            {
                if (!crimeCategories.Contains(crime.category))
                {
                    crimeCategories.Add(crime.category);
                }
                simpleCrimeList.Add(crime.category);
            }

            List<SummaryItem> summary = new List<SummaryItem>();
            foreach (string crimeLabel in crimeCategories)
            {
                SummaryItem crimeSummary = new SummaryItem(crimeLabel);
                foreach (string simpleCrime in simpleCrimeList)
                {
                    if (simpleCrime.Equals(crimeLabel))
                    {
                        crimeSummary.Count++;
                    }
                }
                summary.Add(crimeSummary);
            }

            return summary;
        }

        public string FormatSummaryDisplay(List<SummaryItem> summaryItems)
        {
            string output = null;
            if (summaryItems.Count == 0)
            {
                output = "There are no crimes to report in this area.";
            }
            foreach (SummaryItem item in summaryItems)
            {
                output = output + item.Crime + ": " + item.Count.ToString() + "\n";
            }
            return output;
        }

        public List<CrimeDto> GetAllCrimeInLocation(decimal lat, decimal lng, FormDate date)
        {
            API apiTool = new API();
            string parameters = apiTool.FormatCrimesInLocationParameters(lat, lng, date);
            List<CrimeDto> allCrimes = apiTool.GetAllCrimesInLocation(parameters);
            return allCrimes;
        }

        public string FindAndDisplayAllCrimeInLocation(decimal lat, decimal lng, FormDate date)
        {
            List<CrimeDto> allCrimes = GetAllCrimeInLocation(lat, lng, date);
            List<SummaryItem> crimeSummary = GetCrimeSummary(allCrimes);
            return FormatSummaryDisplay(crimeSummary);
        }
    }
}
