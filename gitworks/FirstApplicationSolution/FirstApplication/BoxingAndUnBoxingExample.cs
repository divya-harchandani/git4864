using System;

namespace FirstApplication
{
    class BoxingAndUnBoxingExample
    {
        static void Main()
        {
            int Data = 10;
            Object O = Data; //boxing
            int Data1 = Convert.ToInt32(O); //Unboxing
            int Data2 = (int)O; //Unboxing
        }
    }
}
