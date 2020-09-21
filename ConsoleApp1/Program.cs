using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var maxSum = new MaxSum();
            if (4 == maxSum.FindSum(new int[] { 1, 2, 3, 1 })) Console.WriteLine("1.1: Pass");
            if (12 == maxSum.FindSum(new int[] { 2, 7, 9, 3, 1 })) Console.WriteLine("1.2: Pass");
            if (10 == maxSum.FindSum(new int[] { 5, 1, 2, 5 })) Console.WriteLine("1.3: Pass");
            if (15 == maxSum.FindSum(new int[] { 7, 1, 1, 1, 7 })) Console.WriteLine("1.4: Pass");

            Console.WriteLine();
            var deadPixels = new DeadPixels();

            if(5 == deadPixels.CountGroups(new char[][] {
                new char[] { '1', '0', '1' },
                new char[] { '0', '1', '0' },
                new char[] { '1', '0', '1' }
            })) Console.WriteLine("2.1: Pass");

            if (2 == deadPixels.CountGroups(new char[][] {
                new char[] { '1', '1', '1' },
                new char[] { '1', '0', '0' },
                new char[] { '1', '0', '1' }
            })) Console.WriteLine("2.2: Pass");

            if (0 == deadPixels.CountGroups(new char[][] {
                new char[] { '0', '0', '0' },
                new char[] { '0', '0', '0' },
                new char[] { '0', '0', '0' }
            })) Console.WriteLine("2.3: Pass");
            
            if (1 == deadPixels.CountGroups(new char[][] {
                new char[] { '1', '1', '1' },
                new char[] { '1', '1', '1' },
                new char[] { '1', '1', '1' }
            })) Console.WriteLine("2.4: Pass");

            Console.ReadKey();            
        }
    }
}
