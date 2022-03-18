using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        int t = Convert.ToInt32(Console.ReadLine());
        string[] a_temp = Console.ReadLine().Split(' ');
        int[] a = Array.ConvertAll(a_temp,Int32.Parse);
        
        int[] counts = new int[101];
        for (int i = 0; i < t; ++i) {
            counts[a[i]]++;
        }
        
        int maxValue = 0;
        for (int i = 0; i < 101; ++i) {
            maxValue = Math.Max(maxValue, counts[i]);
        }
        
        Console.Out.WriteLine(t - maxValue);
    }
}