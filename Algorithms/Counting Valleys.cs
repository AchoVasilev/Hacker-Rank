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
     * Complete the 'countingValleys' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER steps
     *  2. STRING path
     */

    public static int countingValleys(int steps, string path)
    {
        var seaLevelCount = 0;
        var valleysCount = 0;
        var isValley = false;
        
        for(var i = 0; i < steps; i++)
        {
            if(path[i] == 'U')
            {
                seaLevelCount++;
            }
            else
            {
                seaLevelCount--;
            }
            
            if(!isValley && seaLevelCount < 0)
            {
                isValley = true;
            }
            
            if(isValley && seaLevelCount == 0)
            {
                valleysCount++;
                isValley = false;
            }
        }
        
        return valleysCount;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int steps = Convert.ToInt32(Console.ReadLine().Trim());

        string path = Console.ReadLine();

        int result = Result.countingValleys(steps, path);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
