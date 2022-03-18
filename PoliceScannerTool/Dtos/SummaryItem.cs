using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoliceScannerTool.Dtos
{
    public class SummaryItem
    {
        public SummaryItem(string crime)
        {
            Crime = crime;
            Count = 0;
        }

        public SummaryItem(string crime, int count)
        {
            Crime = crime;
            Count = count;
        }

        public string Crime { get; set; }
        public int Count { get; set; }
    }
}
