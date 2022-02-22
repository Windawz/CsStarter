using System;
using System.IO;
using System.Linq;
using System.Xml;
using System.Xml.Linq;

namespace CSStarter.DataOps
{
    public class XmlExporter : IExporter
    {
        public void Export(object? data, string path)
        {
            var xDocument = new XDocument(new XElement("TestProgram", new XmlConverter().Convert(data)));
            xDocument.Save(Path.ChangeExtension(path, ".xml"));
        }
    }
}
