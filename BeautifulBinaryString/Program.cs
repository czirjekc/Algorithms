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
     * Complete the 'beautifulBinaryString' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts STRING b as parameter.
     */

    public static int beautifulBinaryString(string b)
    {
        string window = "010";
        string saveString = b;
        int length = b.Length;

        List<char> input = new List<char>();
        input = b.ToList();
        string workingString = String.Join("", input.ToArray());

        Console.WriteLine(workingString);

        int changeCount = 0;
        for (int i = 0; i <= length - window.Length; i++)
        {
            // Flip last
            string sub = workingString.Substring(i, 3);
            if (sub.Equals(window))
            {
                changeCount++;
                input[i + 2] = input[i + 2] == '0' ? '1' : '0';
                workingString = String.Join("", input.ToArray());
            }
        }
        Console.WriteLine(workingString);
        return changeCount;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        string b = Console.ReadLine();

        int result = Result.beautifulBinaryString(b);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
