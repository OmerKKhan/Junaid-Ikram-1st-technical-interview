using System;
using System.Collections.Generic;

// Task # 1
// You are given a function which takes an array of integers "seq" and an integer "target". There exist two elements of the array whose sum is equal to the target. You can assume that there exists only one solution. You have to return the indices of those elements
// [1,9,2,19]  Target = 3, Answer

// [2,4]  Target = 6, Answer =0,1


class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello World");
        int[] seq = new[] { 1, 9, 2, 19 };
        int target = 3;
        var result = TwoSum(seq, target);
        foreach (var item in result)
        {
            Console.WriteLine(item);
        }
    }

    public static List<int> TwoSum(int[] seq, int target)
    {
        var indexes = new List<int>();
        var seqDict = new Dictionary<int, int>();
        for (int i = 0; i < seq.Length; i++)
        {
            seqDict.Add(seq[i], i);
        }
        
        for (int i = 0; i < seq.Length; i++)
        {
            var diff = target - seq[i];
            if (seqDict.ContainsKey(diff))
            {
                indexes.Add(i);
                indexes.Add(seqDict[diff]);
                break;
            }
        }
        return indexes;
    }
}