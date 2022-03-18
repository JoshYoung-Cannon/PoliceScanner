using PoliceScannerTool.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoliceScannerTool.Services
{
    public class SetupServices
    {
        public FormDate ConvertDateDtoToForm(DateDto inputDto)
        {
            string[] components = inputDto.Date.Split('-');
            int year = Convert.ToInt32(components[0]);
            int month = Convert.ToInt32(components[1]);

            return new FormDate(year, month);
        }

        public FormDate GetLatestUpdate()
        {
            API apiTool = new API();
            DateDto apiResponse = apiTool.GetLatestUpdate();

            return ConvertDateDtoToForm(apiResponse);
        }
    }
}
