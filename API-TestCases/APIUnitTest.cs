using Microsoft.VisualStudio.TestTools.UnitTesting;
using PoliceScannerTool.Dtos;
using PoliceScannerTool.Services;

namespace API_TestCases
{
    [TestClass]
    public class APIUnitTest
    {
        [TestMethod]
        public void GetLatestUpdateTest()
        {
            API apiTool = new API();
            var returnVal = apiTool.GetLatestUpdate();
            Assert.IsInstanceOfType(returnVal, typeof(DateDto));
        }
    }
}
