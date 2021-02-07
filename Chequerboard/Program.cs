using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chequerboard
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 8; i++)
            {
                if (i%2 ==0)
                {
                    for (int j = 0; j <= 8; j++)
                    {
                        Console.Write("* ");
                    }
                }
                else
                {
                    Console.Write(" ");

                    for (int j = 0; j <= 8; j++)
                    {
                        Console.Write("* ");
                    }
                }

                Console.WriteLine();
                

               
            }

            Console.ReadLine();
        }
        
    }
}
