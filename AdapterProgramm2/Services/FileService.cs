using Adapter.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.Services
{
    public class FileService2 : IFileService2
    {
        private object _locker = new object();

        public void WriteToFile(string path, int[,] mas)
        {
            lock (_locker)
            {
                string str = "";
                StringBuilder sb = new StringBuilder();
                for (var i = 0; i < mas.GetLength(0); i++)
                {
                    for (var j = 0; j < mas.GetLength(1); j++)
                    {
                        sb.Append($"{mas[i, j]} ");
                    }
                    sb.Append($"\n");
                }
                File.WriteAllText(path, sb.ToString());
            }
        }
    }
}
