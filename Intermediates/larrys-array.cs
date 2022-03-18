using System;
using System.Linq;


public class Solution
{
    static void Main(String[] args)
    {
        var t = byte.Parse(Console.ReadLine());
        for (int i = 0; i < t; i++)
        {
            Console.ReadLine();
            var inp = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            //var sorted = inp.OrderBy(x => x).ToList();
            var sum = 0;
            for (int j = 0; j < inp.Count; j++)
            {
                for (int k = j+1; k < inp.Count; k++)
                {
                    if (inp[k] < inp[j])
                        sum++;
                }
            }
            Console.WriteLine(sum%2==0?"YES":"NO");
        }
    }
}