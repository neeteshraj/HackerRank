using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;


class Solution {

    public static List<int[]> Combinations( List<int> numberList ) 
    {


        List<int[]> result = new List<int[]>();                 

        while (numberList.Count > 0) 
        {
            
            int stackLast = numberList.Count - 1;

            for (int i =0; i < numberList.Count; i++) 
            {            
                  
                result.Add(new int[] {numberList[stackLast], numberList[i]});
            }
            numberList.RemoveAt(stackLast);
        }

        return result;

    }

    static int MaxXor(int l, int r) 
    {

        List<int> numList = new List<int>(Enumerable.Range(l, r - l + 1));

        // Inserts the list combinations as int arrays
        List<int[]> comboList = Combinations(numList); 

        int max = 0;
        
        foreach(var two in comboList)
        {

            int xorValue = two[0] ^ two[1];

            max = ( max > xorValue )? max : xorValue;
           
        }

        return max;
    }

    static void Main(String[] args) 
    {

        int l;
        int r;

        l = Convert.ToInt32(Console.ReadLine());

        r = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine(MaxXor(l, r));
    }
}