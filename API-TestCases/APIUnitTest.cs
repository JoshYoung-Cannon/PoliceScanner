using Microsoft.VisualStudio.TestTools.UnitTesting;
using PoliceScannerTool.Dtos;
using PoliceScannerTool.Services;
using System;
using System.Collections.Generic;

namespace API_TestCases
{
    [TestClass]
    public class APIUnitTest
    {
        [TestMethod]
        public void GetLatestUpdateTest()
        {
            API apiTool = new API();
            var result = apiTool.GetLatestUpdate();
            Assert.IsInstanceOfType(result, typeof(DateDto));
        }

        [TestMethod]
        public void FormatCrimesInLocationParametersTest()
        {
            API apiTool = new API();
            string goal = "crimes-street/all-crime?lat=51.44237&lng=-2.4981&date=2021-1";
            
            decimal lat = Convert.ToDecimal(51.44237);
            decimal lng = Convert.ToDecimal(-2.49810); // hanging "0" are dropped during decimal.ToString()
            FormDate date = new FormDate(2021, 1);
            string result = apiTool.FormatCrimesInLocationParameters(lat, lng, date);
            Console.WriteLine(result);

            Assert.AreEqual(goal, result);
        }

        [TestMethod]
        public void GetAllCrimesInLocationTest()
        {
            API apiTool = new API();
            string parameters = "crimes-street/all-crime?lat=51.44237&lng=-2.4981&date=2021-1";
            var result = apiTool.GetAllCrimesInLocation(parameters);
            Assert.IsInstanceOfType(result, typeof(List<CrimeDto>));
        }
    }
}
