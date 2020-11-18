using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondApplication
{
    class ArrayExample
    {
        static void Main()
        {
            //1D Array
            //datatype[] arrayname = new datatype[size];

            string[] Fruits = new string[5];
            Console.WriteLine("Enter 5 friut names : ");
            for(int i = 0; i < Fruits.Length; i++)
            {
                Fruits[i] = Console.ReadLine();
            }
            Array.Sort(Fruits);
            Console.WriteLine("The 5 fruits entered are in sorted order : ");
            for (int i = 0; i < Fruits.Length; i++)
            {
                Console.WriteLine(Fruits[i]);
            }
            Console.WriteLine("Do array contains mango? : {0}", Fruits.Contains("Mango"));

            //MultiDimensional Array
            //datatype[,] array = new datatype[,]
            //int[,] arr = new int[3,3] 2D
            //int[,,] arr = new int[3,3,3] 3D
            Console.WriteLine("Enter row size : ");
            int RowSize = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter col size : ");
            int ColSize = Convert.ToInt32(Console.ReadLine());
            int[,] array = new int[RowSize, ColSize];
            Console.WriteLine("Enter values : ");
            for(int i = 0; i < RowSize; i++)
            {
                for(int j = 0; j < ColSize; j++)
                {
                    array[i,j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("Entered values are : ");
            for (int i = 0; i < RowSize; i++)
            {
                for (int j = 0; j < ColSize; j++)
                {
                    Console.Write("{0} ",array[i, j]);
                }
                Console.WriteLine();
            }

            Console.Read();
        }
    }
}
