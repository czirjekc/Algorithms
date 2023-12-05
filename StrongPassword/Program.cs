using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrongPassword
{
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

    class Result
    {

        /*
         * Complete the 'minimumNumber' function below.
         *
         * The function is expected to return an INTEGER.
         * The function accepts following parameters:
         *  1. INTEGER n
         *  2. STRING password
         */

        public static int minimumNumber(int n, string password)
        {
            // Return the minimum number of characters to make the password strong
            String numbers = "0123456789";
            String lower_case = "abcdefghijklmnopqrstuvwxyz";
            String upper_case = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            String special_characters = "!@#$%^&*()-+";

            const int STRONG_PASS = 6;
            int min_num = 0;
            int nNum, nLow, nUpp, nSpecial;
            nNum = nLow = nUpp = nSpecial = 0;

            for (int i = 0; i < password.Length; i++)
            {
                if (numbers.IndexOf(password[i]) != -1)
                    nNum++;
                if (lower_case.IndexOf(password[i]) != -1)
                    nLow++;
                if (upper_case.IndexOf(password[i]) != -1)
                    nUpp++;
                if (special_characters.IndexOf(password[i]) != -1)
                    nSpecial++;
            }

            //
            if (nNum == 0)
                min_num++;
            if (nLow == 0)
                min_num++;
            if (nUpp == 0)
                min_num++;
            if (nSpecial == 0)
                min_num++;
            //  Min length           
            return Math.Max(min_num, STRONG_PASS - password.Length);
        }

    }

    class Solution
    {
        public static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int n = Convert.ToInt32(Console.ReadLine().Trim());

            string password = Console.ReadLine();

            int answer = Result.minimumNumber(n, password);

            textWriter.WriteLine(answer);

            textWriter.Flush();
            textWriter.Close();
        }
    }

}
