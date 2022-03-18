using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoliceScannerTool.Dtos
{
    public class FormDate
    {
        public FormDate(int year, int month)
        {
            Year = year;
            Month = month;
        }
        public int Year { get; set; }
        public int Month { get; set; }

    }
}
