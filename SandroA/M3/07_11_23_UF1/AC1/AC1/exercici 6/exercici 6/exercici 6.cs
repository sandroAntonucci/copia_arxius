using System;

namespace MyApplication
{
    class OddInRange
    {
        static void Main(string[] args)
        {

            const int FirstRangeNumber = 0;
            const int LastRangeNumber = 100;
            const int Two = 2;
            const int Zero = 0;

            for(int i = FirstRangeNumber; i <= LastRangeNumber; i++)
            {
                if (i % Two == Zero)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}