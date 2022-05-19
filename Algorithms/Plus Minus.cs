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
     * Complete the 'plusMinus' function below.
     *
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static void plusMinus(List<int> arr)
    {
        var positiveNumsCount = 0m;
        var negativeNumsCount = 0m;
        var zeroNumsCount = 0m;
        
        for(var i = 0; i < arr.Count; i++)
        {
            if(arr[i] > 0)
            {
                positiveNumsCount++;
            }
            else if(arr[i] < 0)
            {
                negativeNumsCount++;    
            }
            else
            {
                zeroNumsCount++;
            }
        }
        
        Console.WriteLine(positiveNumsCount / arr.Count);
        Console.WriteLine(negativeNumsCount / arr.Count);
        Console.WriteLine(zeroNumsCount / arr.Count);
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
