using Adapter.Fabrics;

namespace AdadpterTest
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            try
            {
                var programm1 = FabricCommands.CreateProgramm1();
                programm1.SumMatrix("C:\\Users\\kntl\\Desktop\\A.txt", "C:\\Users\\kntl\\Desktop\\B.txt");
            }
            catch (Exception e)
            {
                Assert.Fail(e.Message);
            }
            
        }

        [Fact]
        public void Test2()
        {
            try
            {
                var programm2 = FabricCommands2.CreateProgramm2();
                programm2.GenerateMatrix("C:\\Users\\kntl\\Desktop\\C.txt");
            }
            catch (Exception e)
            {
                Assert.Fail(e.Message);
            }
            
        }
    }
}