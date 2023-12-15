using System;
using System.Runtime.CompilerServices;

namespace MyApplication
{
    class Module
    {
        static void Main(string[] args)
        {

            const string Msg = "Introdueix ún número: ";

            int module = 0;
            int result = 0;

            for (int i = 1; i<=3; i++)
            {
                if(i == 3)
                {
                    Console.WriteLine(Msg);
                    module += Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(Msg);
                    module = module % Convert.ToInt32(Console.ReadLine());
                }
                else
                {
                    Console.WriteLine(Msg);
                    result += Convert.ToInt32(Console.ReadLine());
                }
            }

            result *= module;

            Console.WriteLine(result);
            

        }
    }
}