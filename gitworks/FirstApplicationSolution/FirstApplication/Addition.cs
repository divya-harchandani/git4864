using System;

namespace FirstApplication
{
    class Addition
    {
        static void Main()
        {
            float value1 = 40.5f, value2 = 60.2f, Result;
            Result = value1 + value2;
            //{0} is iterpolation
            Console.WriteLine("RESULT IS {0}",Result);
            //Concatination
            Console.WriteLine("RESULT IS "+ Result);
            Console.WriteLine("{0} + {1} = {2}", value1, value2, Result);
            Console.ReadKey();
        }
    }
}
