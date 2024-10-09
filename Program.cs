using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main(string[] args)
    {

        int k1 = 5;
        int k2 = 10;
        int[] a = { 1, 7, 3, 9, 2, 6, 8 };
        int[] b = { 4, 11, 5, 2, 12, 7 };


        List<int> result = GetCombinedSequence(k1, k2, a, b);

 
        Console.WriteLine(string.Join(", ", result));
    }

    public static List<int> GetCombinedSequence(int k1, int k2, int[] a, int[] b)
    {

        List<int> filteredA = a.Where(x => x > k1).ToList();

  
        List<int> filteredB = b.Where(x => x < k2).ToList();


        List<int> combinedSequence = filteredA.Concat(filteredB).ToList();

 
        combinedSequence.Sort();


        return combinedSequence;
    }
}