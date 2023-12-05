using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trains
{

    namespace DriverCode
    {

        class Trains
        {
            static void Main(string[] args)
            {
                int testcases; // Taking testcase as input
                testcases = Convert.ToInt32(Console.ReadLine());
                while (testcases-- > 0)// Looping through all testcases
                {

                    int n = Convert.ToInt32(Console.ReadLine());
                    int[] arr = new int[n];
                    var stringArray = Console.ReadLine().Split(' ');
                    int j = 0;
                    for (int i = 0; i < stringArray.Length; i++)
                    {

                        if (stringArray[i].CompareTo(" ") != -1)
                        {
                            arr[j] = int.Parse(stringArray[i]);
                            j++;
                        }
                    }
                    int[] dep = new int[n];
                    stringArray = Console.ReadLine().Split(' ');
                    j = 0;
                    for (int i = 0; i < stringArray.Length; i++)
                    {

                        if (stringArray[i].CompareTo(" ") != -1)
                        {
                            dep[j] = int.Parse(stringArray[i]);
                            j++;
                        }
                    }
                    Solution obj = new Solution();
                    var res = obj.findPlatform(arr, dep, n);
                    Console.WriteLine(res);
                }

            }
        }




        // } Driver Code Ends
        //User function Template for C#

        class Solution
        {

            //Function to find the minimum number of platforms required at the
            //railway station such that no train waits.
            public int findPlatform(int[] arr, int[] dep, int n)
            {
                //code here
                int plat_needed = 1, result = 1;
                int i = 1, j = 0;

                // Similar to merge in merge sort to process
                // all events in sorted order
                while (i < n && j < n)
                {
                    // If next event in sorted order is arrival,
                    // increment count of platforms needed
                    if (arr[i] <= dep[j])
                    {
                        plat_needed++;
                        i++;

                        // Update result if needed
                        if (plat_needed > result)
                            result = plat_needed;
                    }

                    // Else decrement count of platforms needed
                    else
                    {
                        plat_needed-- ;
                        j++;
                    }
                }

                return result;

            }
        }

    }

}
