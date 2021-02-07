using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen faktöriyelini hesaplamak istediğiniz tam sayıyı yazınız.");
            string input = Console.ReadLine();
            int output = Convert.ToInt32(input);
            int result = output;
            if (output!=0)
            {
                for (int i = output - 1; i >= 1; i--)
                {
                    result = result * i;
                  
                }
                Console.WriteLine(output + "! =" + " " + result);
            }
            else // 0!=1 dir ayrı bir kısımda onu da tanımladım.
            {
                 Console.WriteLine(output + "! =" + " " + 1);
            }
            

           
            Console.ReadLine();
        }
        
    }
}
