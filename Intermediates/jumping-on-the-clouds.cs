using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
            string[] c_temp = Console.ReadLine().Split(' ');
            int[] c = Array.ConvertAll(c_temp, Int32.Parse);

            int count = 0;
            int index = 0;
            while (index < n - 1)
            {
                if (index + 2 <= n - 1 && c[index + 2] != 1)
                {
                    index = index + 2;
                }
                else
                {
                    index = index + 1;
                }
                count++;
            }

            Console.WriteLine(count);
    }
}