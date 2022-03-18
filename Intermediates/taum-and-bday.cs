using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{
    static void Main(String[] args)
    {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        int t = int.Parse(Console.ReadLine());
        while (t-- > 0)
        {
            long[] q = Console.ReadLine().Trim().Split().Select(x => long.Parse(x)).ToArray();
            long b = q[0];
            long w = q[1];
            long[] num = Console.ReadLine().Trim().Split().Select(x => long.Parse(x)).ToArray();
            long bcost = num[0];
            long wcost = num[1];
            long conversion = num[2];
            long total = -1;
            if (wcost + conversion < bcost)
            {
                total = w * wcost + (b * (wcost + conversion));
            }
            else if (bcost + conversion < wcost)
            {
                total = b * bcost + (w * (bcost + conversion));
            }
            else
            {
                total = b * bcost + w * wcost;
            }
            Console.WriteLine(total);
        }
    }
}