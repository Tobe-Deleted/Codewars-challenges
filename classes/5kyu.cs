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


}