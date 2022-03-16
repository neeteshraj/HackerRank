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
     * Complete the 'counterGame' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts LONG_INTEGER n as parameter.
     */
    public static string counterGame(long n)
    {
        long i = 1;
        int count = 0;
        while (n > 1)
        {
            if (2 * i > n)
            {
                if (i == n) n /= 2;
                else n -= i;
                i = 1;
                count++;
            }
            i *= 2;
        }
        return (count % 2 == 0) ? "Richard" : "Louise";
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int t = Convert.ToInt32(Console.ReadLine().Trim());

        for (int tItr = 0; tItr < t; tItr++)
        {
            long n = Convert.ToInt64(Console.ReadLine().Trim());

            string result = Result.counterGame(n);

            textWriter.WriteLine(result);
        }

        textWriter.Flush();
        textWriter.Close();
    }
}
