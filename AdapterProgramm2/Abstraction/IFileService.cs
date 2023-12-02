using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.Abstraction
{
    public interface IFileService2
    {
        public void WriteToFile(string path, int[,] mas);
    }
}
