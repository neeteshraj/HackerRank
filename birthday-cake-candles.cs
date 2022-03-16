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
     * Complete the 'birthdayCakeCandles' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts INTEGER_ARRAY candles as parameter.
     */

    public static int birthdayCakeCandles(List<int> candles)
    {
        // Write your code here
        // int max = 0;
        // for (int i = 0; i < candles.size(); i++)
        // {
        //     if (candles[i] > max)
        //     {
        //         max = candles[i];
        //     }
        // }
        // int count = 0;
        // for (int i = 0; i < candles.size(); i++)
        // {
        //     if (candles[i] == max)
        //     {
        //         count++;
        //     }
        // }
        // return count;
        int max = 0;
        for (int i = 0; i < candles.Count; i++)
        {
            if (candles[i] > max)
            {
                max = candles[i];
            }
        }
        int count = 0;
        for (int i = 0; i < candles.Count; i++)
        {
            if (candles[i] == max)
            {
                count++;
            }
        }
        return count;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int candlesCount = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> candles = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(candlesTemp => Convert.ToInt32(candlesTemp)).ToList();

        int result = Result.birthdayCakeCandles(candles);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
