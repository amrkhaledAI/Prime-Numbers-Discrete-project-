using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;
using System.Transactions;

namespace prime.numbers.detector
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("                                      Welcome to the Perfect numbers detector");
            Console.WriteLine("press Enter to start the program .");
            Console.ReadKey();
            Console.WriteLine("\n  Please Enter the 1st value\n");
            int start = int.Parse(Console.ReadLine());

            Console.WriteLine("\n  Please Enter 2nd value\n ");
            int end = int.Parse(Console.ReadLine());

            Console.WriteLine("\nThe Perfect Numbers in the given range are :\n");



            for (int perfect = start; perfect <= end; perfect++)
            {
                int i = 1; int sum = 0;

                while (i < perfect)
                {
                    if (perfect % i == 0)
                        sum = sum+i;
                    i++;
                }
                if (sum == perfect)
                    Console.Write("    "+perfect );
                
            }
            Console.WriteLine("\n\n\n                                                   End of program\n                                                       Thanks ");
            Console.ReadKey();

        }










    }

        }
    
 
