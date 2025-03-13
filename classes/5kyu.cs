using System;
using System.Collections.Generic;
using System.Globalization;
using System.Xml.XPath;
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

    public string PigIt(string str)
    {
        string result = "";
        foreach(string s in str.Split(' '))
        {
            if(Char.IsLetter(s[0]))
            {
                result += $"{s.Remove(0,1)}{s[0]}ay ";
            }
            else
            {
                result += s;
            }
        }
        return result.Trim();
    }

    public Dictionary<string, int> Interpret(string[] program)
    {
        Dictionary<string, int> result = new Dictionary<string, int>();
        foreach(string str in program)
        {
            string[] order = str.Split(' ');
            string key = order[1];
            int value = 0;
            value = Jump(program, value, key, 1);
            if(!result.TryAdd(key, value))
            {
                result[key] = value;
            }
        }
        return result;
    }

    private int Jump(string[] program, int value, string key, int index)
    {
        string[] order = program[index].Split(' ');
        switch(order[0])
            {
                case "mov":
                    value = Convert.ToInt32(order[2]);
                    break;
                case "inc":
                    value++;
                    break;
                case "dec":
                    value--;
                    break;
                case "jnz":
                    if(value == 0) break;
                    value = Jump(program, value, key, index + Convert.ToInt32(order[3]));
                    break;
            }
            return value;
    }
}