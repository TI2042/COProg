using ClassLibNonVisualComponents.Models;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibNonVisualComponents
{
    public partial class SaveToPdf : Component
    {
        public SaveToPdf()
        {
            InitializeComponent();
        }

        public SaveToPdf(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        public void Save(PdfModel pdfModel)
        {
            string[] masStr = pdfModel.FileName.Split('.');
            if (string.IsNullOrEmpty(pdfModel.FileName))
            {
                throw new Exception("File name null");
            }

            string fileName = "";

            if (masStr[masStr.Length - 1].Contains("pdf"))
            {
                fileName = $"{pdfModel.FileName}";
            }
            else
            {
                fileName = $"{pdfModel.FileName}.pdf";
            }

            var s_document = new PdfDocument();
            s_document.Info.Title = pdfModel.FileName;
            XGraphics gfx = XGraphics.FromPdfPage(s_document.AddPage());
            DrawLine(gfx, pdfModel);
            s_document.Save(fileName);
        }

        void DrawLine(XGraphics gfx, PdfModel pdfModel)
        {

            gfx.DrawString(pdfModel.NameGraphic, new XFont("Times New Roman", 12),
                XBrushes.Black, new XPoint(pdfModel.points[0].X, pdfModel.points.Max(z => z.Y) + 10));

            XPen pen = new XPen(XColors.Black, 6);
            pen.LineCap = XLineCap.Round;
            pen.LineJoin = XLineJoin.Bevel;
            XPoint[] points = pdfModel.points;
            gfx.DrawLines(pen, points);

        }
    }
}
