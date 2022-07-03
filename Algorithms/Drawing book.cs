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
     * Complete the 'pageCount' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER n
     *  2. INTEGER p
     */

    public static int pageCount(int n, int p)
    {
        var count = 0;
        var page = 1;
        
        while(page < p)
        {
            count++;
            page += 2;
        }
        
        if(n % 2 != 0)
        {
            page = n - 1;
        }
        else
        {
            page = n;
        }
        
        var secondCount = 0;
        while(page > p)
        {
            secondCount++;
            page -= 2;
        }
        
        if(count < secondCount)
        {
            return count;
        }
        else
        {
            return secondCount;
        }
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        int p = Convert.ToInt32(Console.ReadLine().Trim());

        int result = Result.pageCount(n, p);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
