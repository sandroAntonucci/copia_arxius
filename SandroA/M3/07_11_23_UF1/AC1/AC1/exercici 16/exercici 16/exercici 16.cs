using System;

namespace MyApplication
{
    class Sum
    {
        static void Main()
        {
            const string Msg = "Introdueix un nombre: ";
            const int Divider = 10;

            int num, result = 0;

            Console.Write(Msg);
            num = Convert.ToInt32(Console.ReadLine());

            while(num > 0)
            {
                result += num % Divider;
                num /= Divider;
            }

            Console.WriteLine(result);

        }
     
    }
}