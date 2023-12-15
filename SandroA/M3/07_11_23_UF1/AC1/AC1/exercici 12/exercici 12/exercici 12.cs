using System;

namespace MyApplication
{
    class MultiplicationTables
    {

        static void Main(string[] args) {
            const string Msg = "Introdueix un número: ";

            int number;

            Console.Write(Msg);
            number = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i + " * " + number + " = " + (i * number));
            }
        }
    }
}