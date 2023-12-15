using System;

namespace MyApplication
{
    class multiple
    {
        static void Main(string[] args)
        {
            const string MsgMultiple = "Introdueix un número natural: ";
            const string MsgDivider = "Introdueix un altre número natural (no pot ser 0): ";

            int multiple;
            int divider;

            do
            {
                Console.Write(MsgMultiple);
                multiple = Convert.ToInt32(Console.ReadLine());
            
            } while(multiple < 0);

            do
            {
                Console.Write(MsgDivider);
                divider = Convert.ToInt32(Console.ReadLine());

            } while (divider < 0);

            string result = multiple % divider == 0 ? "El número " + multiple + " és múltiple de " + divider : "El número " + multiple + " no és multiple de " + divider;

            Console.WriteLine(result);

        }
    }
}