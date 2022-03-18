using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        int k = int.Parse(Console.ReadLine().Split(' ').Last());
        int[] a = Console.ReadLine().Split(' ').Select(p => int.Parse(p)).ToArray();
        int[] mk = new int[k];
        for (int i = 0; i < a.Length; i++) mk[a[i] % k]++;
        long x = 0;
        if (mk[0] > 0) x++;
        for (int i = 1; i < (k + 1) / 2; i++)
            x += Math.Max(mk[i], mk[k - i]);
        if (k % 2 == 0 && mk[k / 2] > 0) x++;
        Console.WriteLine(x);
    }
}