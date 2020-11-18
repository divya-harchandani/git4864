using System;

namespace FirstApplication
{
    class NullableExample
    {
        static void Main()
        {
            //Age(int) column from tblEmployee
            //NUllable Type
            int? Age = null;
            if(Age != null)
            {
                Console.WriteLine("Age is : {0}", Age);
            }
            else
            {
                Console.WriteLine("Age is null. Please update your Age");
            }
            //NullCoalecing Operator ??
            //It works with other datatypes too which are not made nulltype
            Console.WriteLine("Age is : {0}", Age ?? 0);
            Age = Age ?? 0;
            Console.WriteLine("Age is : {0}", Age);

            String OrgName = null;
            Console.WriteLine("Organization Name : {0}", OrgName ?? "No name ");
            //When occurs type conversion Error
            Console.WriteLine("Organization Name : {0}", (OrgName ?? "No name ").ToString());

            //Tickets Example
            int AvailableTickets, TicketsAvailable = 100;
            int? TicketsOnSale = null;
            AvailableTickets = TicketsAvailable - (TicketsOnSale ?? 0);
            Console.WriteLine("Available Tickets : {0}", AvailableTickets);
            Console.ReadKey();
        }
    }
}
