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

class Solution {

    // Complete the minimumSwaps function below.
    static int minimumSwaps(int[] arr) 
    {
        var minSwaps = 0;
        for(var index = 0; index < arr.Length - 1; index++)
        {
            while(arr[index] != index + 1)
            {
                var current = arr[index];
                var temp = arr[current - 1];
                arr[current - 1] = current;
                arr[index] = temp;
                
                minSwaps++;
            }
        }
        
        return minSwaps;
    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine());

        int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
        ;
        int res = minimumSwaps(arr);

        textWriter.WriteLine(res);

        textWriter.Flush();
        textWriter.Close();
    }
}
