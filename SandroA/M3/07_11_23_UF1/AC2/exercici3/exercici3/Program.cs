/*
 * Author: Sandro Antonucci Rejón
 * M03. Programació UF1
 * v1. 09/10/2023
 * Exercici 3. Implementa un programa que imprimeixi tots els nombres enters divisibles per 3 que hi ha entre num1 i num2 (inclosos), ambdós nombres enters introduïts per teclat.
 *
 */

using System;

namespace MyApplication
{

    class DivBy3 
    { 
        static void Main()
        {

            const string MsgFirstNum = "Introdueix el primer nombre: ";
            const string MsgSecondNum = "Introdueix el segon nombre: ";

            int firstNum, secondNum;

            Console.Write(MsgFirstNum);
            firstNum = Convert.ToInt32(Console.ReadLine());

            Console.Write(MsgSecondNum);
            secondNum = Convert.ToInt32(Console.ReadLine());


            for(int i = firstNum; i <= secondNum; i++) 
            {
                if(i % 3 == 0)
                {
                    Console.Write(i + " ");
                }
            
            
            }

        }
    
    
    }


}