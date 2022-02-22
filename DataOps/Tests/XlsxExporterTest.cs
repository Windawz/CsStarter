﻿using System;
using System.IO;

using CSStarter.TestUtils;

namespace CSStarter.DataOps.Tests
{
    public class XlsxExporterTest : Test
    {
        public XlsxExporterTest(TextWriter writer) : base(writer) { }

        protected override TestResult PerformImpl()
        {
            var data = new Data(1, DateTime.Now, "FirstName", "LastName", "SurName", "City", "Country");
            new XlsxExporter().Export(data, $"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}{Path.DirectorySeparatorChar}testExcelFile");


            return new TestResult(TestStatus.Success);
        }
    }
}
