/*
 * Author: Sandro Antonucci Rejón
 * M03. Programació UF1
 * v1. 09/10/2023
 * Exercici 1. Revisa el programa d’exemple al repositori i adjunta una captura indicant quines són les parts principals del programa. Després, modifica’l de manera que el missatge de validació per a l’usuari sigui diferent en cas que sigui la primera vegada que fa la petició o si ja hi ha hagut un error.
 *
 */



using System;
namespace DataTypes
{
    class MyDataTypes
    {
        static void Main()
        {
            const string MsgFirstNum = "Introdueix un nombre natural";
            const string MsgFirstNumError = "El nombre no pot ser negatiu o 0. Introdueix un primer nombre natural: ";
            const string MsgSecondNum = "Introdueix un segon nombre natural";
            const string MsgSecondNumError = "El nombre no pot ser negatiu o 0. Introdueix un segon nombre natural: ";
            const string MsgOK = "El primer valor és múltiple del segon valor";
            const string MsgKO = "El primer valor no és múltiple del segon valor";
            const string MsgExit = "Pulsa qualsevol tecla per sortir";

            int firstNum, secondNum;
            
          
            Console.WriteLine(MsgFirstNum);
            firstNum = Convert.ToInt16(Console.ReadLine());
           
            while (firstNum < 1)
            {
                Console.WriteLine(MsgFirstNumError);
                firstNum = Convert.ToInt16(Console.ReadLine());
            }


            Console.WriteLine(MsgSecondNum);
            secondNum = Convert.ToInt16(Console.ReadLine());

            while (secondNum < 1)
            {
                Console.WriteLine(MsgSecondNumError);
                secondNum = Convert.ToInt16(Console.ReadLine());
            }

            Console.WriteLine(firstNum % secondNum == 0 ? MsgOK : MsgKO);
            Console.WriteLine(MsgExit);
            Console.ReadKey();
        }
    }
}