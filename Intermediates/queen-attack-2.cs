using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

class Solution {

    static int n;
    static void Main(String[] args) {
        var tmp = Console.ReadLine().Split(' ');
        n = int.Parse(tmp[0]);
        int k = int.Parse(tmp[1]);

        tmp = Console.ReadLine().Split(' ');
        int rq = int.Parse(tmp[0]) - 1;
        int cq = int.Parse(tmp[1]) - 1;

        HashSet<long> h = new HashSet<long>();

        for (int i = 0; i < k; i++) {
            tmp = Console.ReadLine().Split(' ');
            long a = long.Parse(tmp[0]) - 1;
            long b = long.Parse(tmp[1]) - 1;
            h.Add(a << 31 | b);
        }

        long x = 0, y = 0;
        int[] _u = { 1, 1, 1, 0, 0, -1, -1, -1 };
        int[] _v = { 0, 1, -1, 1, -1, -1, 0, 1 };

        int ans = 0;
        for (int i = 0; i < 8; i++) {
            int u = _u[i], v = _v[i];
            x = rq + u; y = cq + v;
            while (valid(x, y)) {
                if (h.Contains(x << 31 | y)) break;
                ans++;
                x += u; y += v;
            }
        }
        Console.WriteLine(ans);
    }

    private static bool valid(long x, long y) {
        return x >= 0 && y >= 0 && x < n && y < n;
    }
}