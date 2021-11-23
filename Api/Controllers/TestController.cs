using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Http;
using CommonSolution;
using iText.Html2pdf;
using iText.Kernel.Geom;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;

namespace Api.Controllers
{
    public class TestController : ApiController
    {
        [HttpPost]
        [ActionName("PDF")]
        public string crearPdf([FromBody] PlantillaPDF plantilla)
        {
            /*PdfWriter wr = new PdfWriter(@"K:\INGDDA\DAK\ticket.pdf");
            PdfDocument documentoPdf = new PdfDocument(wr);
            Document documento = new Document(documentoPdf,PageSize.A4);
            Paragraph parrafo = new Paragraph("Titulo");
            documento.Add(parrafo);
            documento.Close();
            documentoPdf.Close();
            wr.Close();*/

            /* string html = File.ReadAllText(@"K:\INGDDA\DAK\templates\facturatemplate.html");
             ConverterProperties CP = new ConverterProperties();
             PdfWriter pdw = new PdfWriter(@"K:\INGDDA\DAK\ticket.pdf");
             PdfDocument documentoPdf = new PdfDocument(pdw);
             documentoPdf.SetDefaultPageSize(new PageSize(PageSize.A4));
             Document documento = HtmlConverter.ConvertToDocument(html, documentoPdf, CP);
             documento.Close();*/
            /*
             string source = "K:/INGDDA/DAK/templates/facturatemplate.html";
             string dest = "K:/INGDDA/DAK/ticket.pdf";



             HtmlConverter.ConvertToPdf(new FileInfo(source), new FileInfo(dest));*/
            string path = @"K:\INGDDA\DAK\templates\factura.svg";
            string archivo = File.ReadAllText(path);
            archivo.Replace("{NOMBRE}", "Esteban");
            File.WriteAllText(@"K:\INGDDA\DAK\templates\factura.svg", archivo);


            string str = "HOLA {ME} LLAMO LOCO";
            int start = str.IndexOf("{ME}");
            //int end = str.LastIndexOf("ME");

            int end = 1;
            int i = start;
            while (str[i] != '}')
            {
                i++;
                end++;
            }

            string nombre = str.Substring(start,4);
            return nombre+nombre.Length;
        }
    }
}
