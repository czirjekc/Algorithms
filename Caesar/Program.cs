using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

namespace Caesar
{
    class Result
    {

        /*
         * Complete the 'caesarCipher' function below.
         *
         * The function is expected to return a STRING.
         * The function accepts following parameters:
         *  1. STRING s
         *  2. INTEGER k
         */

        public static string caesarCipher(string s, int k)
        {
            string alphabet = "abcdefghijklmnopqrstuvwxyz";
            string caesar = rotateString(alphabet, k);
            List<char> encryptedString = new List<char>();
            Console.WriteLine(caesar);

            int newIndex = 0;
            for (int i = 0; i < s.Length; i++)
            {
                char current;
                newIndex = alphabet.IndexOf(s[i].ToString(), StringComparison.OrdinalIgnoreCase);
                // non-alphabetic characters are unchanged
                if (newIndex == -1)
                    encryptedString.Add(s[i]);
                else
                {
                    if (char.IsUpper(s[i]))
                        encryptedString.Add(char.ToUpper(caesar[newIndex]));
                    else
                        encryptedString.Add(caesar[newIndex]);
                }
            }
            return string.Join("", encryptedString.ToArray());

        }


        public static string rotateString(string s, int k)
        {
            List<char> list = new List<char>();
            list = s.ToList();
            for (int rot = 0; rot < k; rot++)
            {
                char current = list[0];
                list.Add(current);
                list.RemoveAt(0);
            }
            return string.Join("", list.ToArray());
        }
    }

    class Solution
    {
        public static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int n = Convert.ToInt32(Console.ReadLine().Trim());

            string s = Console.ReadLine();

            int k = Convert.ToInt32(Console.ReadLine().Trim());

            string result = Result.caesarCipher(s, k);

            textWriter.WriteLine(result);

            textWriter.Flush();
            textWriter.Close();
        }
    }

}
