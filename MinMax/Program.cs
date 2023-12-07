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

namespace MinMax
{


    class Result
    {

        /*
         * Complete the 'miniMaxSum' function below.
         *
         * The function accepts INTEGER_ARRAY arr as parameter.
         */

        public static void miniMaxSum(List<int> arr)
        {
            long maximum = 0, minimum = 0;
            int max_index = 0, max_element = 0, min_element = 0, min_index = 0;
            List<int> backup = new List<int>(arr);
            int loops = 4;

            // Get maximum first
            for (int i = 0; i < loops; i++)
            {

                max_element = arr.Max();
                max_index = arr.IndexOf(max_element);
                maximum += max_element;
                arr.RemoveAt(max_index);
            }
            //    Console.WriteLine("Maximum: {0}", maximum);
            //        arr.Clear();
            //        arr = backup.ToList();
            // Now min      
            for (int i = 0; i < loops; i++)
            {

                min_element = backup.Min();
                min_index = backup.IndexOf(min_element);
                minimum += min_element;
                backup.RemoveAt(min_index);
            }
            Console.WriteLine("{0} {1}", minimum, maximum);
        }


    }

    class Solution
    {
        public static void Main(string[] args)
        {

            List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

            Result.miniMaxSum(arr);
        }
    }

}
