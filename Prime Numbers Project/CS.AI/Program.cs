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
            Console.WriteLine("                                      Welcome to the Prime numbers detector");
            Console.WriteLine("press Enter to start the program .");
            Console.ReadKey();
            Console.WriteLine("\n  Please Enter the 1st value\n");
            int start = int.Parse(Console.ReadLine());

            Console.WriteLine("\n  Please Enter 2nd value\n ");
            int end = int.Parse(Console.ReadLine());

            Console.WriteLine( "\nThe Prime Numbers in the given range are :\n");

            for (int prime = start; prime <= end; prime++) 
            { 
                int b = 0;
                for(int i=2  ;i<=prime/2; i++) 
                {
                    if(prime%i==0)
                    { b ++;
                        break;
                    }
                }
              if(b ==0 && prime!=1)
                {
                    Console.WriteLine(  prime); 
                }


            }
            Console.WriteLine("\n\n\n                                                   End of program\n                                                      Thanks ");
            Console.ReadKey();




            }

            
                
                
               
            
             
            




        }
    }
