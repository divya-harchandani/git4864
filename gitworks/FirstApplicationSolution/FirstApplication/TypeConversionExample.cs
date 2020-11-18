using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstApplication
{
    class TypeConversionExample
    {
        static void Main()
        {
            //Implicit Conversion
            //no data loss
            //no exception
            int i = 100;
            float f = i;
            double d = f;
            Console.WriteLine("Implicit Conversion");
            Console.WriteLine("Int-->Float-->Double : {0}", d);
            //Explicit Conversion
            i = Convert.ToInt32(f);
            Console.WriteLine("Explicit Conversion");
            Console.WriteLine("IFloat-->Int : {0}", i);
            Console.ReadKey();
        }
    }
}
