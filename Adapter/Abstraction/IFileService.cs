using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.Abstraction
{
    public interface IFileService
    {
        public int[,] ReadFile(string path, string separatorStart, string separatorEnd);
        public void WriteToFile(string path, int[,] mas);
    }
}
