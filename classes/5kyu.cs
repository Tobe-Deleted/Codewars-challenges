using System;
using System.Collections.Generic;
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
        int[][] result = new int[2][];
        string[] numbers = strng.Split(' ');
        int[] weights = new int[numbers.Length];
        Console.WriteLine(Convert.ToInt32('1'));
        int i = 0;
        foreach(string str in numbers)
        {
            int weight = 0;
            foreach(char ch in str)
            {
                weight += Convert.ToInt32(ch) -48;
            }
            weights[i] = weight;
            i++;
        }
        int[] first = new int[3];
        int[] second = new int[3];
        for(int n = 1; n < weights.Length; i++)
        {
            if(Math.Abs(weights[i-1] - weights[i]) < Math.Abs(first[0] - second[0]) || first[0] == null)
            {

            }
        }
        return result;
    }



}