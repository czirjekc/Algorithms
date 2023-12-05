using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanNumbers
{
    internal class Program
    {
        public static int romanToInt(string input) 
        {
            int result = 0;
            for (int i = 0; i < input.Length - 1 ; i++)
            {
                
                if(romanChars(input[i]) < romanChars(input[i+1]))
                    result -= romanChars(input[i]);
                else
                    result += romanChars(input[i]);
            }
            result += romanChars(input[input.Length - 1]);
            return result;
        }

        public static int romanChars(char input)
        {
            if (input == 'I')
                return 1;
            else if (input == 'V')
                return 5;
            else if (input == 'X')
                return 10;
            else if (input == 'L')
                return 50;
            else if (input == 'C')
                return 100;
            else if (input == 'D')
                return 500;
            else if (input == 'M')
                return 1000;
            else return -1;
        }

        static void Main(string[] args)
        {
            string input = "MCMLXXXIII"; //Console.ReadLine();
            Console.WriteLine("{0} = {1}", input, romanToInt(input));
        }
    }
}
