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


namespace PlusMinus
{ 
    class Result
    {

        /*
         * Complete the 'plusMinus' function below.
         *
         * The function accepts INTEGER_ARRAY arr as parameter.
         */

        public static void plusMinus(List<int> arr)
        {
            int len = arr.Count;
            int sum_plus, sum_minus, sum_zero;
            sum_plus = sum_minus = sum_zero = 0;
            foreach (var item in arr)
            {
                if (item < 0) sum_minus++;
                else if (item > 0) sum_plus++;
                else sum_zero++;
            }
            //Positive
            Console.WriteLine("{0,8:0.000000}", (double)sum_plus / len);
            Console.WriteLine("{0,8:0.000000}", (double)sum_minus / len);
            Console.WriteLine("{0,8:0.000000}", (double)sum_zero / len);
        }

    }

    class Solution
    {
        public static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

            Result.plusMinus(arr);
        }
    }

}