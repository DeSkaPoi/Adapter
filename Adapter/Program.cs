using Adapter.Abstraction;
using Adapter.Fabrics;

internal class Program
{
    private static void Main(string[] args)
    {
        var programm1 = FabricCommands.CreateProgramm1();
        programm1.SumMatrix("C:\\Users\\kntl\\Desktop\\A.txt", "C:\\Users\\kntl\\Desktop\\B.txt");
    }
}