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
     * Complete the 'compareTriplets' function below.
     *
     * The function is expected to return an INTEGER_ARRAY.
     * The function accepts following parameters:
     *  1. INTEGER_ARRAY a
     *  2. INTEGER_ARRAY b
     */

    // public static async List<int> compareTriplets(List<int> a, List<int> b)
    // {
    //     int aliceScore = 0, bobScore = 0, totalTests = 3;
    //     for(int i =0; i<totalTests; i++){
    //         aliceScore += a[i] > b[i] ? 1 : 0;
    //         bobScore += a[i] < b[i] ? 1 : 0;
    //     }
    //     return new List<int>{aliceScore, bobScore};
    // }
    //return type of async method must be void or Task<T>
    public static List<int> compareTriplets(List<int> a, List<int> b)
    {
        int aliceScore = 0, bobScore = 0, totalTests = 3;
        for(int i =0; i<totalTests; i++){
            aliceScore += a[i] > b[i] ? 1 : 0;
            bobScore += a[i] < b[i] ? 1 : 0;
        }
        return new List<int>{aliceScore, bobScore};
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

        List<int> b = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(bTemp => Convert.ToInt32(bTemp)).ToList();

        List<int> result = Result.compareTriplets(a, b);

        textWriter.WriteLine(String.Join(" ", result));

        textWriter.Flush();
        textWriter.Close();
    }
}
