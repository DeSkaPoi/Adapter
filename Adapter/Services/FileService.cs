using Adapter.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.Services
{
    public class FileService : IFileService
    {
        private object _locker = new object();
        public int[,] ReadFile(string path, string separatorStart, string separatorEnd)
        {
            int[,] mas = null;
            lock (_locker)
            {
                string[] mass1 = File.ReadAllLines(path);

                int start = 0;
                int end = 0;

                for (int i = 0; i < mass1.Length; i++)
                {
                    if (mass1[i].Contains(separatorStart))
                        start = i;
                    if (mass1[i].Contains(separatorEnd))
                        end = i;
                }

                string[] mass = new string[end - start - 1];
                for (int i = start + 1, ii = 0; i < end; i++, ii++)
                {
                    mass[ii] += mass1[i];
                }

                var m = mass[0]
                    .Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(n => int.Parse(n)).ToArray().Length;
                int n = mass.Length;
                mas = new int[n, m];
                for (int p = 0; p < n; p++)
                {
                    var m1 = mass[p]
                   .Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
                   .Select(n => int.Parse(n)).ToArray();

                    for (int i = 0; i < m1.Length; i++)
                    {
                        mas[p, i] = m1[i];
                    }
                }
            }
            return mas;
        }

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
