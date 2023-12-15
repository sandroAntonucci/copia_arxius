/*
 * Author: Sandro Antonucci
 * M03. Programació UF1
 * v1. 10/10/2023
 * Exercici X3.1.A partir de la següent especificació de l’algorisme representada (mitjançant el diagrama de flux de l’esquerra), implementa una solució en C#.
 *
 */



using System;

namespace MyApplication
{
    class MinusThree 
    {
        static void Main()
        {

            const string Msg = "Introdueix un nombre: ";

            int num;

            Console.Write(Msg);
            num = Convert.ToInt32(Console.ReadLine());

            int i = num;

            while(i > 0)
            {
                Console.WriteLine(i);
                i -= 3;
            }

        }    
    }
}