using System;

namespace STEP_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Project_01 proCls_1 = new Project_01();
            Project_02 proCls_2 = new Project_02();

            proCls_1.A046_MinMax();
            Console.WriteLine("==============================================");
            proCls_1.A047_Power();
            Console.WriteLine("==============================================");
            proCls_1.A048_Factorial();
            Console.WriteLine("==============================================");
            proCls_1.A049_PrimeNumber();
            Console.WriteLine("==============================================");
            proCls_1.A050_FindingPI();
            Console.WriteLine("==============================================");

            proCls_2.A051_InfiniteLoop();
            Console.WriteLine("==============================================");
            proCls_2.A052_UsingBreak();
            Console.WriteLine("==============================================");
            proCls_2.A053_SumOfFactorials();
            Console.WriteLine("==============================================");
            proCls_2.A054_TimesTable();
            Console.WriteLine("==============================================");
            proCls_2.A055_PrimeNumbers();
            Console.WriteLine("==============================================");
            proCls_2.A056_LoopPyramid();
            Console.WriteLine("==============================================");
        }
    }
}
