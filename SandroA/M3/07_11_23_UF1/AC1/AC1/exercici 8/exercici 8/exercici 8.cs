using System;

namespace MyApplication
{
    class Revert
    {
        static void Main(string[] args)
        {

            const string Msg = "Introdueix un nombre enter (de 1 a 9): ";
            const int QuantNumbers = 3;

            long reversePosition = 1, position = 1, reverseNumbers = 0, copyReverseNumbers = 0, numbers = 0;
            int number = 0;
            string strReverseNumbers, strNumbers;

            for(int i = 0; i < QuantNumbers; i++)
            {
                do
                {
                    Console.Write(Msg);
                    number = Convert.ToInt32(Console.ReadLine());

                } while (number < 1 || number > 9);

                reverseNumbers += number * reversePosition;
                reversePosition *= 10;
            }

            copyReverseNumbers = reverseNumbers;

            for (int i = 0; i < QuantNumbers; i++)
            {
                reversePosition /= 10;

                numbers += (copyReverseNumbers / reversePosition) * position;
                copyReverseNumbers -= (copyReverseNumbers / reversePosition) * reversePosition;

                position *= 10;
            }

            strReverseNumbers = Convert.ToString(reverseNumbers);
            strNumbers = Convert.ToString(numbers);

            Console.WriteLine();
            for (int i = 0; i < strReverseNumbers.Length; i++)
            {
                Console.Write(strReverseNumbers[i] + " ");
            }

            Console.WriteLine();
            for (int i = 0; i < strReverseNumbers.Length; i++)
            {
                Console.Write(strNumbers[i] + " ");
            }

        }
    }
}