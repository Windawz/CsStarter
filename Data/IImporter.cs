using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsStarter.Data
{
    public interface IImporter
    {
        Record[] Import(string path);
    }
}
