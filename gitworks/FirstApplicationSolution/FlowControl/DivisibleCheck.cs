using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowControl
{
    class DivisibleCheck
    {
        static void Main()
        {
            Console.WriteLine("Enter First Number");
            int first = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Secoond Number");
            int second = Convert.ToInt32(Console.ReadLine());
            if(second != 0)
            {
                if (second > first)
                {
                    Console.WriteLine("Not Divisible");
                }
                else
                {
                    int division = first / second;
                    Console.WriteLine("Result = {0} ", division);
                }
            }
            else
            {
                Console.WriteLine("A number cannot  be divided by zero");
            }
            Console.ReadLine();
        }
    }
}
