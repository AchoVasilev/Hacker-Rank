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
     * Complete the 'miniMaxSum' function below.
     *
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static void miniMaxSum(List<int> arr)
    {
        var smallestNumber = int.MaxValue;
            var biggestNumber = int.MinValue;

            for (var i = 0; i < arr.Count; i++)
            {
                if (smallestNumber >= arr[i])
                {
                    smallestNumber = arr[i];
                }

                if (biggestNumber <= arr[i])
                {
                    biggestNumber = arr[i];
                }
            }

            long biggestSum = 0;
            long smallestSum = 0;

            for (var i = 0; i < arr.Count; i++)
            {
                if (smallestNumber == biggestNumber)
                {
                    if (i < 4)
                    {
                        biggestSum += arr[i];
                        smallestSum += arr[i];
                    }
                    
                    continue;
                }

                if (biggestNumber != arr[i])
                {
                    smallestSum += arr[i];
                }

                if (smallestNumber != arr[i])
                {
                    biggestSum += arr[i];
                }
            }

            Console.Write($"{smallestSum} {biggestSum}");
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
