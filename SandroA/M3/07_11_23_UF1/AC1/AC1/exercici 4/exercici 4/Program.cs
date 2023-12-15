using System;

namespace MyApplication
{
    class PoundToKg
    {
        static void Main(string[] args)
        {

            const string Msg = "Introdueix quantes lliures pesa el producte: ";
            const string MsgEndProgram = "\nSi vols finalitzar la operació introdueix 0, si vols continuar introdueix 1: ";
            const double PoundToKgRatio = 0.454;
            

            int exit = 1;
            double pounds;

            while (exit != 0)
            {
                Console.Write(Msg);
                pounds = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("El pes en kg és " + (pounds * PoundToKgRatio));

                Console.Write(MsgEndProgram);
                exit = Convert.ToInt32(Console.ReadLine());
            }
        }
    }
}