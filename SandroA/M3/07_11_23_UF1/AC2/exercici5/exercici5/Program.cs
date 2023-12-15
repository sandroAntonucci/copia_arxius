/*
 * Author: Sandro Antonucci
 * M03. Programació UF1
 * v1. 10/10/2023
 * Exercici 5. Implementa un programa que demani l’any i aquest retorni si és un any de traspàs. NO es poden fer servir funcions pròpies de C#.
 *
 */


using System;

namespace MyApplication
{
    class LeapYear
    {
        static void Main()
        {

            const string MsgYear = "Introdueix un any: ";
            const string MsgLeapYear = "Aquest any és un any de trespàs.";
            const string MsgNotLeapYear = "Aquest any no és un any de trespàs.";

            const int LeapYear = 4, Zero = 0;

            int year;

            Console.Write(MsgYear);
            year = Convert.ToInt32(Console.ReadLine());

            if (year % LeapYear == Zero)
            {
                Console.WriteLine(MsgLeapYear);
            }
            else
            {
                Console.WriteLine(MsgNotLeapYear);
            }
        }
    }
}