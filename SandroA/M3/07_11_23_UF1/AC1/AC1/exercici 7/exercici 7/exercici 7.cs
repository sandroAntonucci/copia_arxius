using System;

namespace MyApplication
{
    class Divider
    {
        static void Main(string[] args)
        {

            const string Msg = "Introdueix un nombre enter: ";

            int num;
            int result = 0;
            
            for(int i  = 1; i <= 4; i++)
            {

                Console.Write(Msg);
                num = Convert.ToInt32(Console.ReadLine()); 

                if(num%5==0)
                {
                    result+= num + 3;
                }
                else if((num-2)%3==0){
                    result += num-2;
                }else
                {
                    result += num;
                }
            }

            Console.WriteLine(result);

        }
    }
}