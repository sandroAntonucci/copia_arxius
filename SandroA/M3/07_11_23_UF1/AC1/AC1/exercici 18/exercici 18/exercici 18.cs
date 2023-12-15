using System;

namespace MyApplication
{

    class Pyramid
    {
        static void Main()
        {

            const string Msg = "Introdueix un nombre: ";

            int hashtag;
            

            Console.Write(Msg);
            hashtag = Convert.ToInt32(Console.ReadLine());

            for(int i = 1; i <= hashtag; i++)
            {
                for(int j = 1; j <= i; j++)
                {
                    Console.Write("#");
                }

                Console.WriteLine();
            }
           

        }
    }

}