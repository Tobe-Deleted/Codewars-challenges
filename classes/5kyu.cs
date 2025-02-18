using System;
using System.Collections.Generic;
using System.Globalization;
public class FiveKyu : I5kyu
{
    public int[] MoveZeroes(int[] arr)
    {
        int count = 0;
        List<int> l = new List<int>{};
        foreach (char ch in arr)
        {
            if (ch == 0) count ++;
            else l.Add(ch);
        }
        for (int i = 0; i < count; i++)
        {
            l.Add(0);
        }
        int[] newArray = l.ToArray();
        return newArray;
        
    }

// weight, index, nmbr

    public int[][] Closest(string strng) 
    {
        if(strng == "") return new int[0][];
        int[][] result = new int[2][];
        string[] numbers = strng.Split(' ');
        int[] sortedWeights = new int[numbers.Length];
        int[] weights = new int[numbers.Length];
        int i = 0;
        foreach(string str in numbers)
        {
            int weight = 0;
            foreach(char ch in str)
            {
                weight += Convert.ToInt32(ch) -48;
            }
            sortedWeights[i] = weight;
            weights[i] = weight;
            i++;
        }
        int[] first = new int[3];
        int[] second = new int[3];
        Array.Sort(sortedWeights);
        for(int n = 1; n < weights.Length -1; n++)
        {
            if(Math.Abs(sortedWeights[n-1] - sortedWeights[n]) < Math.Abs(first[0] - second[0]) || first[0] + second[0] == 0)
            {
                int firstNumberIndex = Array.IndexOf(weights,sortedWeights[n-1]);
                int secondNumberIndex;
                if(Math.Abs(sortedWeights[n-1] - sortedWeights[n]) == 0)
                {
                    secondNumberIndex = Array.IndexOf(weights,sortedWeights[n-1], firstNumberIndex  + 1 );
                }
                else
                {
                    secondNumberIndex = Array.IndexOf(weights,sortedWeights[n]);
                }
                first[0] = sortedWeights[n-1]; first[1] = firstNumberIndex; first[2] = Convert.ToInt32(numbers[firstNumberIndex]);
                second[0] = sortedWeights[n]; second[1] = secondNumberIndex; second[2] = Convert.ToInt32(numbers[secondNumberIndex]);
            }
        }
        result[0] = first; result[1] = second;
        return result;
    }



}