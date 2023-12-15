using System;

namespace MyApplication
{
    class CountBackwards
    {
        static void Main()
        {

            const string Msg = "Introdueix un número: ";

            int num;

            Console.Write(Msg);
            num = Convert.ToInt32(Console.ReadLine());

            while(num > 0)
            {
                Console.Write(num + " ");
                num--;
            }

        }
    }
}