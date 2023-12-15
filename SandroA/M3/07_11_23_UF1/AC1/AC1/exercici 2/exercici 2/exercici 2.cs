using System;

namespace MyApplication
{
    class AbsoluteNum
    {
        static void Main(string[] args)
        {
            const string Msg = "Introdueix un nombre enter: ";

            int integerNum;

            Console.Write(Msg);
            integerNum = Convert.ToInt32(Console.ReadLine());

            if(integerNum < 0)
            {
                integerNum *= -1;
            }

            Console.WriteLine("El nombre absolut és " + integerNum); 
        }
    }
}