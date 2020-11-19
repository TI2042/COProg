using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibNonVisualComponents.Models
{
    public class HeaderExcelModel
    {
        public int NumFirstColumnHeader { get; private set; }
        public int NumLastColumnHeader { get; private set; }
        public string Header { get; private set; }

        public HeaderExcelModel(int numFirstColumnHeader, int numLastColumnHeader, string header)
        {
            NumFirstColumnHeader = numFirstColumnHeader;
            NumLastColumnHeader = numLastColumnHeader;
            Header = header;
        }
    }
}
