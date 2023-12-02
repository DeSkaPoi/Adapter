using Adapter.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.Services
{
    public class Programm1 : IProgramm1
    {
        private readonly IFileService _fileService;

        public Programm1(IFileService fileService)
        {
            _fileService = fileService;
        }

        public void SumMatrix(string pathIn, string pathOut)
        {
            var mas1 = _fileService.ReadFile(pathIn, "/", "*");
            var mas2 = _fileService.ReadFile(pathIn, "+", "-");

            var mas3 = MatrixSum(mas1, mas2);

            _fileService.WriteToFile(pathOut, mas3);
        }

        private int[,] MatrixSum(int[,] matrixA, int[,] matrixB)
        {
            if ((matrixA.GetLength(1) != matrixB.GetLength(1)) || (matrixA.GetLength(0) != matrixB.GetLength(0)))
            {
                throw new Exception("Для матриц с разным размером сложение не возможно!");
            }

            var matrixC = new int[matrixA.GetLength(0), matrixB.GetLength(1)];

            for (var i = 0; i < matrixA.GetLength(0); i++)
            {
                for (var j = 0; j < matrixB.GetLength(1); j++)
                {
                    matrixC[i, j] = matrixA[i, j] + matrixB[i, j];
                }
            }

            return matrixC;
        }
    }
}
