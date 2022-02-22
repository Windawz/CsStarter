using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSStarter.DataOps
{
    public interface IImporter
    {
        Data[] Import(string path);
    }
}
