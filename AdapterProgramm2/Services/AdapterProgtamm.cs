using Adapter.Abstraction;
using Adapter.Services;
using AdapterProgramm2.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterProgramm2.Services
{
    public class AdapterProgtamm : IProgramm1Adapter
    {
        IProgramm1 _programm1;
        IFileService _fileService;
        public AdapterProgtamm(IProgramm1 programm1, IFileService fileService)
        {
            _programm1 = programm1;
            _fileService = fileService;
        }

        public void GetSum(int[,] mas, int[,] mas2)
        {
            _fileService.WriteToFile("C:\\Users\\kntl\\Desktop\\A.txt", mas);
            _fileService.WriteToFile("C:\\Users\\kntl\\Desktop\\A.txt", mas2);
            _programm1.SumMatrix("C:\\Users\\kntl\\Desktop\\A.txt", "C:\\Users\\kntl\\Desktop\\B.txt");
        }
    }
}
