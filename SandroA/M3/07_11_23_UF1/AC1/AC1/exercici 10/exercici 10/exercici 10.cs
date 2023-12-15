using System;

namespace MyApplication
{
    class Tables
    {
        static void Main(string[] args)
        {

            const string Msg = "Introdueix el nombre d'alumnes: ";
            const string MsgResult = "El nombre de taules necessàries és: ";
            const int two = 2;

            int students = 0, tables = 0, i = 1;

            while(i <= 3)
            {
                Console.Write(Msg);
                students = Convert.ToInt32(Console.ReadLine());

                if (students % two == 0)
                {
                    tables += students / two;
                }
                else
                {
                    tables += (students / two) + 1;
                }

                i++;
            }

            Console.WriteLine(MsgResult + tables);
           
        }
    }
}