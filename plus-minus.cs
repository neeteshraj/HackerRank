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
        // Write your code here
        // int positive = 0;
        // int negative = 0;
        // int zero = 0;
        // for (int i = 0; i < arr.size(); i++)
        // {
        //     if (arr[i] > 0)
        //     {
        //         positive++;
        //     }
        //     else if (arr[i] < 0)
        //     {
        //         negative++;
        //     }
        //     else
        //     {
        //         zero++;
        //     }
        // }
        // Console.WriteLine((double)positive / arr.size());
        // Console.WriteLine((double)negative / arr.size());
        // Console.WriteLine((double)zero / arr.size());
        int positive = 0;
        int negative = 0;
        int zero = 0;
        for (int i = 0; i < arr.Count; i++)
        {
            if (arr[i] > 0)
            {
                positive++;
            }
            else if (arr[i] < 0)
            {
                negative++;
            }
            else
            {
                zero++;
            }
        }
        Console.WriteLine((double)positive / arr.Count);
        Console.WriteLine((double)negative / arr.Count);
        Console.WriteLine((double)zero / arr.Count);
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
