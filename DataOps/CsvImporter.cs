using System;
using System.IO;

namespace CSStarter.DataOps
{
    public class CsvImporter : IImporter
    {
        public Data[] Import(string path)
        {
            string text = File.ReadAllText(path);
            return new CsvParser().Parse(text);
        }
    }
}
