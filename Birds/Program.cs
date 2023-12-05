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
     * Complete the 'migratoryBirds' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static int migratoryBirds(List<int> arr)
    {
        int[] sights = new int[6];
        sights[0] = 0;
        // Initialize sightings
        for (int i = 1; i < sights.Length; i++)
            sights[i] = 0;

        int index = 1;
        foreach (var item in arr)
        {
            sights[item]++;
            index++;
        }


        return getSightings(sights, sights.Length);

    }

    public static int getSightings(int[] arr, int length)
    {
        int max = 0;
        int species = 0;
        for (int i = 1; i < length; i++)
        {
            if (arr[i] > max)
            {
                max = arr[i];
                species = i;
            }

        }
        return species;

    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int arrCount = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        int result = Result.migratoryBirds(arr);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
