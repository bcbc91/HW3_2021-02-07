using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen bir kelime ya da sayı giriniz. Çıkış için(q) ya basınız. ");
            string input = Console.ReadLine();


            while (input != "q")
            {


                if (input.Length <= 1)
                {
                    Console.WriteLine("Lütfen geçerli bir veri giriniz.");

                }

                else
                {
                    string checkString = "";
                    for (int i = input.Length - 1; i >= 0; i--)
                    {
                        checkString = checkString + input[i];
                    }

                    if (checkString == input)
                    {
                        Console.WriteLine(input + " palindromdur.");
                    }
                    else
                    {
                        Console.WriteLine(input + " palindrom değildir.");
                    }
                    
                }

                input = Console.ReadLine();

            }

        }


    }

}



