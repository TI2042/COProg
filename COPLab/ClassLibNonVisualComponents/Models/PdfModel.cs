using PdfSharp.Drawing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibNonVisualComponents.Models
{
    public class PdfModel
    {
        public string FileName { get; set; }
        public XPoint[] points { get; set; }
        public string NameGraphic { get; set; }

    }
}
