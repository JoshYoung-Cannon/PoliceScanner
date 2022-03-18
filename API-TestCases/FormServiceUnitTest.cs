using Microsoft.VisualStudio.TestTools.UnitTesting;
using PoliceScannerTool.Dtos;
using PoliceScannerTool.Services;
using System;
using System.Collections.Generic;

namespace API_TestCases
{
    [TestClass]
    class FormServiceUnitTest
    {
        [TestMethod]
        public void GetCrimeSummaryTest()
        {
            FormServices formServicesTool = new FormServices();
            CrimeDto crime = new CrimeDto();
            crime.category = "crime1";
            List<CrimeDto> testCrimes = new List<CrimeDto>();
            testCrimes.Add(crime);
            SummaryItem goalItem = new SummaryItem(crime.category, 1);
            
            List<SummaryItem> result = formServicesTool.GetCrimeSummary(testCrimes);

            Assert.AreEqual(goalItem.Crime, result[0].Crime);
            Assert.AreEqual(goalItem.Count, result[0].Count);
        }

        [TestMethod]
        public void FormatSummaryDisplayEmptyTest()
        {
            FormServices formServicesTool = new FormServices();
            List<SummaryItem> emptyTestCrimes = new List<SummaryItem>();

            string goal = "There are no crimes to report in this area.";

            string result = formServicesTool.FormatSummaryDisplay(emptyTestCrimes);

            Assert.AreEqual(goal, result);
        }

        [TestMethod]
        public void FormatSummaryDisplayTest()
        {
            FormServices formServicesTool = new FormServices();
            string crime = "Crime Category";
            int crimeCount = 1;
            SummaryItem testItem = new SummaryItem(crime, crimeCount);
            List<SummaryItem> testCrimes = new List<SummaryItem>();
            testCrimes.Add(testItem);

            string goal = crime + ": " + crimeCount.ToString() + "\n";

            string result = formServicesTool.FormatSummaryDisplay(testCrimes);

            Assert.AreEqual(goal, result);

        }
    }
}
