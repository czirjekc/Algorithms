using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Containers
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
         * Complete the 'toys' function below.
         *
         * The function is expected to return an INTEGER.
         * The function accepts INTEGER_ARRAY w as parameter.
         */

        public static int toys(List<int> w)
        {
            int containerCnt = 0;
            int min, index = 0;
            bool isContainerEmpty = true;

            List<int> container = new List<int>(w.Count);
            List<List<int>> containers = new List<List<int>>();

            while (w.Count > 0)
            {
                // Get minimum weighting item
                min = w.Min();
                index = 0;
                isContainerEmpty = true;
                while(index <  w.Count) 
                {
                    if (w[index] <= (4 + min))
                    {
                        if (isContainerEmpty)
                        {
                            containers.Add(new List<int>());
                            isContainerEmpty = false;
                            containerCnt++;
                        }
                        containers[containerCnt - 1].Add(w[index]);
                        w.RemoveAt(index);
                        index--;
                    }
                    index++;
                    
                }
                
            }
            return containerCnt;
        }
    }

    class Solution
    {
        public static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@"C:\temp\containers.out", true);

            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> w = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(wTemp => Convert.ToInt32(wTemp)).ToList();

            int result = Result.toys(w);

            textWriter.WriteLine(result);

            textWriter.Flush();
            textWriter.Close();
        }
    }
}
