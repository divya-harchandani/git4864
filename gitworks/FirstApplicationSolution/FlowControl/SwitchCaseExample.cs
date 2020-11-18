using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowControl
{

    //1. Add the user details
    //2. Update the details
    //3. Print No change
    //4. Quit
    // Default

    /*switch(expression) {
   case constant-expression1  :
      statement(s);
      break;
   case constant-expression2  :
   case constant-expression3  :
      statement(s);
      break;
   default :
   statement(s);
}*/
    class SwitchCaseExample
    {
        static void Main()
        {
            int ch;
            string name = "";
            int age;
            do
            {
                Console.WriteLine("Menu");
                Console.WriteLine("1. Add the user details");
                Console.WriteLine("2. Update the details");
                Console.WriteLine("3. Print No Change");
                Console.WriteLine("4. Quit");
                Console.WriteLine("Enter your choice : ");
                ch = Convert.ToInt32(Console.ReadLine());
                switch(ch)
                {
                    case 1 :
                        Console.WriteLine("Enter your name : ");
                        name = Console.ReadLine();
                        Console.WriteLine("Enter your age : ");
                        age = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Name : {0} and Age : {1}", name, age);
                        break;
                    case 2 :
                        Console.WriteLine("Enter your age to be updated: ");
                        age = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Name : {0} and Age : {1}", name, age);
                        break;
                    case 3 :
                        Console.WriteLine("No Change");
                        break;
                    case 4 :
                        Environment.Exit(0);
                        break;
                    default :
                        Console.WriteLine("Please enter correct choice");
                        break;
                }

            } while (ch < 20);
            Console.ReadKey();
        }
    }
}
