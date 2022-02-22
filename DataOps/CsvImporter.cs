using System;
using System.IO;

namespace CsStarter.DataOps
{
    public class CsvImporter : IImporter
    {
        public Record[] Import(string path)
        {
            string text = File.ReadAllText(path);
            return new CsvParser().Parse(text);
        }
    }
}
