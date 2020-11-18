using System;

namespace SecondApplication
{
    //Enumeration - Special set of named value
    //float, integer, byte, double, etc
    /* enum enumname(
     * Enumeration list
     * ) */
    enum Feedback { Poor = 1, Fair, Good, VeryGood, Excellent }
    class EnumExample
    {
        static void Main()
        {
            Console.WriteLine("Excellent : {0}", (int)Feedback.Excellent);
            int WorstFeedBack = Convert.ToInt32(Feedback.Poor);
            Console.WriteLine(WorstFeedBack);
            Console.ReadKey();
        }
    }
}
