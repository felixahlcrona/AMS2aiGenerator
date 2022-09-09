using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.AspNetCore.Mvc;
using System.IO;
using System.Net;
using System.Xml;
using System.Xml.Linq;

namespace AMS2aiGenerator.Data
{

    public class WeatherForecastService : ControllerBase
    {
        public async Task<FileStream> SaveAsync(XElement xml, string filename)
        {
            FileStream fileStream = null;
            await Task.Factory.StartNew(delegate
            {

                using (var fs = new FileStream("myFile", FileMode.Create))
                {
                    xml.Save(fs);
                    fileStream = fs;
                }

            });
            return fileStream;
        }
        public async Task<ActionResult> IndexxAsync(string x, XElement ele)
        {
            var xdoc = new XDocument(ele);

            XmlDocument doc = new XmlDocument();
            string xmlString = doc.InnerText;
            //Read the XML file contents as String.
            string xml = System.IO.File.ReadAllText(xdoc.ToString());
            return File(xml, "application/vnd.ms-word", "documentfile.doc");
        }

    };



}