using System;

namespace MyApplication
{
    class Swap
    {
        static void Main(string[] args)
        {

            const string Msg = "Introdueix un número: ";

            int num1, num2, saveNum;

            Console.Write(Msg);
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write(Msg);
            num2 = Convert.ToInt32(Console.ReadLine());

            saveNum = num1;

            num1 = num2;
            num1 = saveNum;

            Console.Write(num2 + " ");
            Console.Write(num1);

        }
    }
}