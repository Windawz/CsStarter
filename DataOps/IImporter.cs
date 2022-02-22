using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsStarter.DataOps
{
    public interface IImporter
    {
        Record[] Import(string path);
    }
}
