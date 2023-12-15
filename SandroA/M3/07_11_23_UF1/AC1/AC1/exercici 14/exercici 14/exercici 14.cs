using System;

namespace MyApplication
{
    class Diamond
    {
        static void Main()
        {

            const string Msg = "Introduce el número de asteriscos: ";

            int numRequired, spaces, asterisks = 1;


            Console.Write(Msg);
            numRequired = Convert.ToInt32(Console.ReadLine());
            spaces = numRequired;

            while (spaces > 0)
            {
                for(int i = 0; i < spaces; i++) Console.Write(" ");
                for (int i = 0; i < asterisks; i++) Console.Write("* ");
                Console.WriteLine();
                spaces--;
                asterisks++;
            }

            spaces = 2;
            asterisks -= 2;

            while (spaces <= numRequired)
            {
                for (int i = 0; i < spaces; i++) Console.Write(" ");
                for (int i = 0; i < asterisks; i++) Console.Write("* ");
                Console.WriteLine();
                spaces++;
                asterisks--;
            }
        }
    }
}