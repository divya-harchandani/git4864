using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondApplication
{
    class StringFunctionsExample
    {
        static void Main()
        {
            Console.WriteLine("Enter Your Name : ");
            string name = Console.ReadLine();
            Console.WriteLine("Upper Case : {0}", name.ToUpper());
            Console.WriteLine("Lower Case : {0}", name.ToLower());
            Console.WriteLine("Length : {0}", name.Length);
            bool check = name.Contains("UP");
            Console.WriteLine("Contains : {0}", check);
            Console.WriteLine("Substring : {0}", name.Substring(1, 2)); //start index and length of substring
            Console.WriteLine("Trim : {0}", name.Trim());
            Console.ReadLine();
        }
    }
}
