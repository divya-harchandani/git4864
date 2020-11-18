using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowControl
{
    class ForEachExample
    {
        static void Main()
        {
            string[] Gender = { "Male", "Female", "male", "female", "MALE" };
            int male = 0;
            int female = 0;
            foreach(string g in Gender)
            {
                if (g.ToLower() == "male")
                    male++;
                else if (g.ToLower() == "female")
                    female++;
            }
            Console.WriteLine("NUmber of Males : {0}", male);
            Console.WriteLine("NUmber of Females : {0}", female);
            Console.ReadKey();
        }
    }
}
