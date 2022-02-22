using System;
using System.IO;

using CsStarter.TestUtils;

namespace CsStarter.DataOps.Tests
{
    public class XmlExporterTest : Test
    {
        public XmlExporterTest(TextWriter writer) : base(writer) { }

        protected override TestResult PerformImpl()
        {
            var data = new Record(1, DateTime.Now, "FirstName", "LastName", "SurName", "City", "Country");
            new XmlExporter().Export(data, $"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}{Path.DirectorySeparatorChar}testExcelFile");

            return new TestResult(TestStatus.Success);
        }
    }
}
