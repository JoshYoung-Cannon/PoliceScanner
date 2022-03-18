using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoliceScannerTool.Dtos
{
    public class LocationDto
    {
        public string latitude { get; set; }
        public StreetDto street { get; set; }
        public string longitude { get; set; }
    }
}
