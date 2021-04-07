using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp22
{
    class Html
    {
        static void Main(string[] args)
        {
            using (FileStream htmlSource = File.Open("input.html", FileMode.Open))
            using (FileStream pdfDest = File.Open("output.pdf", FileMode.OpenOrCreate))
            {
                ConverterProperties converterProperties = new ConverterProperties();
                HtmlConverter.ConvertToPdf(htmlSource, pdfDest, converterProperties);
            }
        }
    }
}
