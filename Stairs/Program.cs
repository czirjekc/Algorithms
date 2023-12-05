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
     * Complete the 'staircase' function below.
     *
     * The function accepts INTEGER n as parameter.
     */

    public static void staircase(int n)
    {
        List<char> stair = new List<char>();
        for (int i = 0; i < n; i++)
        {
            stair.Add(' ');
        }
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j <= i; j++)
            {
                stair.Add('#');
                stair.RemoveAt(0);
            }
            Console.WriteLine(String.Join("", stair.ToArray()));
            // Blanc stairs
            stair.Clear();

            for (int k = 0; k < n; k++)
            {
                stair.Add(' ');
            }

        }
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        Result.staircase(n);
    }
}
