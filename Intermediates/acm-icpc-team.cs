using System;
using System.Linq;
public class Test
{
    public static void Main()
    {
        int[] num = Console.ReadLine().Trim().Split().Select(x => int.Parse(x)).ToArray();
        int N = num[0]; int M = num[1];
        int maxTopics = -1;
        int maxTopicsGang = 0;
        string[] sel = new string[N];
        for(int i = 0 ; i < N ; i++)
             sel[i] = Console.ReadLine().Trim();
        
        for(int i = 0 ; i < N ; i++){
            
            for(int j = 0 ; j < N ; j++){
                int count = 0;
                if(i == j)
                   continue;
             for(int k = 0 ; k < M ; k++){
                 if(sel[i][k] == '1' || sel[j][k] == '1')
                       count++;
             }
             if(count > maxTopics){
                    maxTopics = count;
                    maxTopicsGang = 1;
            }else if (count == maxTopics){
                maxTopicsGang++;
            }
        }
        
    }
        
        Console.WriteLine(maxTopics);
        Console.WriteLine(maxTopicsGang/2);
}
}