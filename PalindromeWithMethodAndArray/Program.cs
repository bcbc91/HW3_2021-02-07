using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeWithMethodAndArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kelime giriniz, çıkış için (q)");
            string s1 = Console.ReadLine();
            while (s1 != "q")
            {
                string s2 = Rev(s1);
                if (s1.Length <= 1)
                {
                    Console.WriteLine("Lütfen geçerli bir kelime girin. ");
                }
                else if (s1 == s2)
                {
                    Console.WriteLine(s1 + " Palindromdur.");
                }
                else
                {
                    Console.WriteLine(s1 + " Palindrom değildir.");
                }
                s1 = Console.ReadLine();
            }
        }

        static string Rev(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}
