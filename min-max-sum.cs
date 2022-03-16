// using System.CodeDom.Compiler;
// using System.Collections.Generic;
// using System.Collections;
// using System.ComponentModel;
// using System.Diagnostics.CodeAnalysis;
// using System.Globalization;
// using System.IO;
// using System.Linq;
// using System.Reflection;
// using System.Runtime.Serialization;
// using System.Text.RegularExpressions;
// using System.Text;
// using System;
// using static System.Console;

// class Result
// {

//     /*
//      * Complete the 'miniMaxSum' function below.
//      *
//      * The function accepts INTEGER_ARRAY arr as parameter.
//      */

//     public static void miniMaxSum(List<int> arr)
//     {
//         var numbers = ReadLine().Split(' ').Select(x=>long.Parse).ToList();
//         var min = long.MaxValue;
//         var max = 0L;
//         var sum = 0L;
//         foreach (var number in numbers)
//         {
//             sum += number;
//             if (number < min)
//             {
//                 min = number;
//             }
//             if (number > max)
//             {
//                 max = number;
//             }
//         }
//         WriteLine(string.Format("{0} {1}", sum - max, sum - min));
//     }

// }

// class Solution
// {
//     public static void Main(string[] args)
//     {

//         List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

//         Result.miniMaxSum(arr);
//     }
// }



using System;
using static System.Console;
using System.Linq;

class Solution
{

    static void Main(String[] args)
    {
        var numbers = ReadLine().Split(' ').Select(x => long.Parse(x)).ToList();
        var sumOfAllNumbers = 0L;
        var minimum = long.MaxValue;
        var maximum = 0L;
        for (int i = 0; i < 5; i++)
        {
            sumOfAllNumbers += numbers[i];
            if (numbers[i] < minimum)
                minimum = numbers[i];

            if (numbers[i] > maximum)
                maximum = numbers[i];

        }
        WriteLine(string.Format("{0} {1}", sumOfAllNumbers - maximum, sumOfAllNumbers - minimum));
    }
}