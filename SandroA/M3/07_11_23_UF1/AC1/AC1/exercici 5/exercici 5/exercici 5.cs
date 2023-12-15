using System;

namespace MyApplication
{
    class Grades
    {
        static void Main(string[] args)
        {

            const string Msg = "Introdueix una nota: ";

            int failedMP = 0;
            int approvedMP = 0;
            
            double grade;
            double averageApproved = 0;
            double averageFailed = 0;

            for(int i=0; i<8; i++)
            {
                do
                {
                    Console.Write(Msg);
                    grade = Convert.ToDouble(Console.ReadLine());

                } while (grade < 0);

                if (grade >= 5)
                {
                    approvedMP++;
                    averageApproved += grade;
                }
                else
                {
                    failedMP++;
                    averageFailed += grade;
                }
            }

            averageApproved /= approvedMP;
            averageFailed /= failedMP;

            Console.WriteLine("\nMP aprovats: " + approvedMP + "\nMP suspesos: " + failedMP + "\nNota mitjana aprovats: " + averageApproved + "\nNota mitjana suspesos: " + averageFailed);

        }
    }
}