using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondApplication
{
    class JaggedArrayExample
    {
        static void Main()
        {
            int[][] JaggedArray = new int[2][];
            JaggedArray[0] = new int[] { 10, 20, 30 };
            JaggedArray[1] = new int[] { 3,7,9,11 };
            for (int i = 0; i < JaggedArray.Length; i++)
            {
                for (int j = 0; j < JaggedArray[i].Length; j++)
                {
                    Console.Write("{0} ", JaggedArray[i][j]);
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
