using System;
//GET YOUR PERSONAL DETAILS AND PRINT THE SAME
namespace FirstApplication
{
    class PersonalDetails
    {
        static void Main()
        {
            Console.WriteLine("Enter your Name : ");
            string Name = Console.ReadLine();
            Console.WriteLine("Enter your Age : ");
            int Age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your Email : ");
            string Email = Console.ReadLine();
            Console.WriteLine("Enter your Phone Number : ");
            long Phone = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Name : {0}", Name);
            Console.WriteLine("Age : {0}", Age);
            Console.WriteLine("Email : {0}", Email);
            Console.WriteLine("Phone Number : {0}", Phone);
            Console.ReadKey();
        }
    }
}
