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
        string[][] orders = program.Select(x => x.Split(' ')).ToArray();
        
        for(int i = 0; i < program.Length; i++)
        {
            if(orders[i][0] == "mov")
            {
                result.TryAdd(orders[i][1], 0);
            }
            string key = orders[i][1];
            int value = result.TryGetValue(key, out int v) ? v : Convert.ToInt32(key);

            switch(orders[i][0])
            {
                case "mov":
                    value = GetValue(orders[i][2], result);
                    break;
                case "inc":
                    value++;
                    break;
                case "dec":
                    value--;
                    break;
                case "jnz":
                    if(value == 0) break;
                    i += GetValue(orders[i][2], result) -1;
                    break;
            }
            if(result.ContainsKey(key))
            {
                result[key] = value;
            }
                
        }
        return result;
    }

    private int GetValue(string input, Dictionary<string, int> result) 
    {
        return result.TryGetValue(input, out int value) ? value : Convert.ToInt32(input);
    }
    private int[,] unsafeTiles = new int[8,8];
      
        public int BishopsAndRooks(int[][] chessBoard)
        {
            unsafeTiles = new int[8,8];
            for(int i = 0; i < 8; i++)
            {
                for(int n = 0; n < 8; n++)
                {
                    if(chessBoard[i][n] == -1)
                    {
                        Bishop(i, n, chessBoard);
                    }
                    if(chessBoard[i][n] == 1)
                    {
                        Rook(i, n, chessBoard);
                    }
                }
            }
            for(int i = 0; i < 8; i++)
            {
                for(int j = 0; j < 8; j++)
                    Console.Write(unsafeTiles[i,j] + " ");
                Console.WriteLine();
            }
            return unsafeTiles.Cast<int>().Count(x => x == 0);
        }
        
        private void Bishop(int x, int y, int[][] chessBoard)
        {
            for(int i = 0; i < 4; i++)
            {
                int xx = x;
                int yy = y;
                int dy = i == 0 ? 1 : i == 1 ? 1 : -1;
                int dx = i == 0 ? 1 : i == 2 ? 1 : -1;
              
                while(true)
                {
                    unsafeTiles[xx,yy] = 2;
                    xx += dx;
                    yy += dy;
                    if(xx !< 8 || yy !< 8 || xx !> -1 || yy !> -1) break;
                    if(chessBoard[xx][yy] != 0) break;
                }
            }
            
        }
      
        private void Rook(int x, int y, int[][] chessBoard)
        {
            for(int i = 0; i < 4; i++)
            {
                int xx = x;
                int yy = y;
                int dy = i == 0 ? 1 : i == 1 ? -1 : 0;
                int dx = i == 2 ? 1 : i == 3 ? -1 : 0;
              
                while(true)
                {
                    unsafeTiles[xx,yy] = 2;
                    xx += dx;
                    yy += dy;
                    if(xx !< 8 || yy !< 8 || xx !> -1 || yy !> -1) break;
                    if(chessBoard[xx][yy] != 0) break;
                }
            }
        }
}