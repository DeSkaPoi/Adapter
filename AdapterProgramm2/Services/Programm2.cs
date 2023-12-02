using Adapter.Abstraction;
using AdapterProgramm2.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.Services
{
    public class Programm2 : IProgramm2
    {
        IFileService _fileService;
        IProgramm1Adapter _adapter;

        public Programm2(IFileService fileService, IProgramm1Adapter adapter)
        {
            _fileService = fileService;
            _adapter = adapter;
        }

        public void GenerateMatrix(string path)
        {
            var mas = RandomMatrix();
            var mas1 = RandomMatrix();

            _adapter.GetSum(mas, mas1);

            _fileService.WriteToFile(path, mas);
            _fileService.WriteToFile(path, mas1);
        }

        private int[,] RandomMatrix()
        {
            Random rnd = new Random();
            int[,] mas = new int[5, 5];
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    mas[i, j] = rnd.Next();
                }
            }
            return mas;
        }
    }
}
