/*
 * Author: Sandro Antonucci Rejón
 * M03. Programació UF1
 * v1. 09/10/2023
 * Exercici 2. Implementa un programa on l’usuari introdueixi dos valors enters: el valor final i el salt. 
 * El programa haurà d’escriure tots els números des de l'1 fins al valor final (inclòs), amb una distància del salt indicat.
 *
 */


using System;

namespace MyApplication
{

    class Step
    {
        static void Main()
        {

            const string MsgRange = "Introdueix el nombre final del rang: ";
            const string MsgStep = "Introdueix el nombre amb el qual s'ha de contar: ";

            int numRange, numStep;

            Console.Write(MsgRange);
            numRange = Convert.ToInt32(Console.ReadLine());

            Console.Write(MsgStep);
            numStep = Convert.ToInt32(Console.ReadLine());

            for(int i = 1; i <= numRange; i+=numStep)
            {
                Console.Write(i + " ");
            }

        }
    }

}