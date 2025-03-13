using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq.Expressions;
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
        string[][] orders = program.Select(x => x.Split(' ')) // TODO: can't sort them out. Needs to be executed in order
                                   .ToArray()
                                   .OrderBy(x => x[1]).ToArray();

        for(int i = 0; i < program.Length; i++)
        {
            string key = orders[i][1];
            int value = result.TryGetValue(key, out int k) ? k : 0;
            switch(orders[i][0])
            {
                case "mov":
                    Console.WriteLine($"{i} mov");
                    value = GetValue(orders[i][2], result);
                    break;
                case "inc":
                    Console.WriteLine($"{i} inc");
                    value++;
                    break;
                case "dec":
                    Console.WriteLine($"{i} dec");
                    value--;
                    break;
                case "jnz":
                    Console.WriteLine($"{i} jnz | value = {value} | +-i?{GetValue(orders[i][2], result)}");
                    if(value == 0) break;
                    i += GetValue(orders[i][2], result) -1;
                    Console.WriteLine(i);
                    break;
            }
            Console.ReadKey();
            if(!result.TryAdd(key, value))
            {
                result[key] = value;
            }
        }
        return result;
    }

    private int GetValue(string input, Dictionary<string, int> result) 
    {
        return int.TryParse(input, out int num) ? num : result.GetValueOrDefault(input, 0);
    }
}