using System;

namespace MyApplication
{
    class Power
    {
        static void Main()
        {
            const string Msg = "Introdueix un número: ";
            const string MsgAnswer = "El resultat de la potència és ";

            int nBase, exponent;

            Console.Write(Msg);
            nBase = Convert.ToInt32(Console.ReadLine());

            Console.Write(Msg);
            exponent = Convert.ToInt32(Console.ReadLine());

            int result = nBase;

            while (exponent > 1)
            {
                result *= nBase;
                exponent--;
            }

            Console.WriteLine(MsgAnswer + result);
        }
    }
}