using System;

namespace MyApplication
{
    class OddEven
    {
        static void Main(string[] args)
        {
            const string Msg = "Introdueix un número: ";
            const string MsgEven = "Total parells: ";
            const string MsgOdd = "Total senars: ";
            
            const int QuantNumbers = 20;
            const int Zero = 0;

            int num;
            int oddNum = Zero;
            int evenNum = Zero;

            for(int i = Zero; i < QuantNumbers; i++)
            {
                Console.WriteLine(Msg);
                num = Convert.ToInt32(Console.ReadLine());

                if (num % 2 == Zero ) { evenNum++; }
                else { oddNum++; }
            }

            Console.WriteLine(MsgEven + evenNum);
            Console.WriteLine(MsgOdd + oddNum);
        }
    }
}