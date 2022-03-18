using System;
using System.Linq;

class Solution
{
    static void Main(String[] args)
    {
        var cases = int.Parse(Console.ReadLine());
        for (var c = 0; c < cases; ++c)
        {
            DoCase();
        }
    }

    private static void DoCase()
    {
        var t = Console.ReadLine().Split(' ');
        var n = int.Parse(t[0]);
        var k = int.Parse(t[1]);
        if (k == 0)
        {
            Console.WriteLine(string.Join(" ", Enumerable.Range(1, n)));
            return;
        }
        if (n % (2 * k) != 0)
        {
            Console.WriteLine(-1);
            return;
        }
        var blocks = n / 2 / k;
        var r = Enumerable.Range(1, n).ToArray();
        for (var i = 0; i < blocks; ++i)
        {
            var offset1 = 2 * k * i;
            var offset2 = 2 * k * i + k;
            for (var j = 0; j < k; ++j, ++offset1, ++offset2)
            {
                var v = r[offset1];
                r[offset1] = r[offset2];
                r[offset2] = v;
            }
        }
        Console.WriteLine(string.Join(" ", r));
    }
}