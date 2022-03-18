using Microsoft.VisualStudio.TestTools.UnitTesting;
using PoliceScannerTool.Dtos;
using PoliceScannerTool.Services;

namespace API_TestCases
{
    [TestClass]
    public class SetupServicesUnitTest
    {
        [TestMethod]
        public void ConvertDateDtoToFormTest()
        {
            SetupServices setupTool = new SetupServices();
            FormDate goal = new FormDate(2022, 03);
            DateDto dateDto = new DateDto();
            dateDto.Date = "2022-03-18";

            FormDate result = setupTool.ConvertDateDtoToForm(dateDto);

            Assert.AreEqual(goal.Year, result.Year);
            Assert.AreEqual(goal.Month, result.Month);
        }
        [TestMethod]
        public void GetLatestUpdate()
        {
            SetupServices setupTool = new SetupServices();
            var returnVal = setupTool.GetLatestUpdate();
            Assert.IsInstanceOfType(returnVal, typeof(FormDate));
        }
    }
}
