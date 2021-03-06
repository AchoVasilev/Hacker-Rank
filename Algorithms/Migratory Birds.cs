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
        var res = new SortedDictionary<int, int>();
        
        for(var i = 0; i < arr.Count; i++)
        {
            if(!res.ContainsKey(arr[i]))
            {
                res[arr[i]] = 0;
            }
            
            res[arr[i]]++;
        }
        
        var lowestNum = int.MaxValue;
        var lowestNumCount = int.MinValue;
        
        foreach(var kvp in res)
        {
            if(lowestNumCount < kvp.Value)
            {
                lowestNumCount = kvp.Value;
                lowestNum = kvp.Key;
            }
        }
        
        return lowestNum;
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
