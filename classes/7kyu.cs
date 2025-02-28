using System;
using System.Linq;
using System.Globalization;
using System.Collections.Generic;
using System.Xml.XPath;
using System.Diagnostics.Metrics;
public class SevenKyu : I7kyu
{
    public void IsIsogram(string str)
    {
        str = str.ToLower();
        bool bl = true;
        string newStr;
        foreach(char ch in str)
        {
            newStr = str.Remove(str.IndexOf(ch), 1);
            if (newStr.Contains(ch)) 
            {
                bl = false;
                break;
            }
        }
        Console.WriteLine(bl);
    }
    public void GetMidChar(string str)
    {
        int n = str.Length / 2;
        if(str.Length % 2 == 0) Console.WriteLine($"{str[n-1]}{str[n]}");
        else Console.WriteLine(str[n]);
    }
    public void IsSquare(int n)
    {
        //skriver ut true om Math.Sqrt(n) % 1 er lik 0;
        //skriver ut false hvis ikke. 
        Console.WriteLine(Math.Sqrt(n) % 1 == 0);
    }

    public bool XandO(string input)
    {
        //bedre løsning:
        //return input.ToLower().Count(x => x == 'x') == input.ToLower().Count(o => o == 'o')
        if(input.ToLower().Count(x => x == 'x') == input.ToLower().Count(o => o == 'o') )
        {
        return true;
        }
        return false;
    }

    public string ToJadenCase(string phrase)
    {
        //trenger TextInfo og System.Globalization(namespace) for å bruke ToTitleCase
        TextInfo myTI = new CultureInfo("en-US",false).TextInfo;
        return myTI.ToTitleCase(phrase);

        //Kan bruke følgende
        //return CultureInfo.CurrentCulture.TextInfo.ToTitleCase(phrase);
    }

    public int ShortWordLength(string s)
    {
        //ToArray er unødvendig
        string[] arr = s.Split(' ').ToArray();
        int result = 0;
        foreach (string str in arr)
        {
            if (str.Length < result || result == 0) result = str.Length;
        }
        return result;
    }

    public string Accumul(string s)
    {
        s = s.ToLower();
        TextInfo myTI = new CultureInfo("en-US",false).TextInfo;
        int counter = 0;
        string result = "";
        foreach (char ch in s)
        {
            counter++;
            for (int i = 0; i < counter; i++) result += ch;
            if(counter < s.Length)result+= "-";
        }
        return myTI.ToTitleCase(result);
    }

    public bool Solution(string str, string ending) //=> str.EndsWith(ending)
    {
        if (str.Length < ending.Length) return false;
        str = str.Remove(0, str.Length - ending.Length);
        return str.Contains(ending);
    }

    public string MakeComplement(string dna)
    {
        string dnaNew = "";
        foreach (char ch in dna)
        {
            if (ch == 'T')dnaNew += "A";
            if (ch == 'A')dnaNew += "T";
            if (ch == 'C')dnaNew += "G";
            if (ch == 'G')dnaNew += "C";
        }
        return dnaNew;
    }

    public int SumOfTwoSmallestNumbers(int[] numbers)
    {
        //Et lettere alternativ:
        //return numbers.OrderBy(i => i).Take(2).Sum();
        int a = int.MaxValue;
        int b = int.MaxValue;

        for(int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] < a) a = numbers[i];
            if (numbers[i] < b && numbers[i] != a) b = numbers[i];
        }
        for(int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] < a) a = numbers[i];
            if (numbers[i] < b && numbers[i] != a) b = numbers[i];
        }
        return a + b;
    }

    public int GetSum(int a, int b)
    {
        int c = 0;
        for (int i = Math.Min(a, b); i <= Math.Max(a, b); i++)
        {
            c += i;
        }
        return c;
    }

    public IEnumerable<string> FriendOrFoe(string[] names)
    {
        List<string> l = new List<string>{};
        foreach (string str in names)
        {
            if (str.Length == 4) l.Add(str);
        }
        return l;
        //return names.Where(names => names.Length == 4); bedre løsning
    }
    public string Mask(string cc)
    {
        if (cc.Length < 5) return cc;
        string result = cc.Remove(0, Math.Min(cc.Length -4, cc.Length - 0));
        for(int i = 0; i < cc.Length -4; i++) result = result.Insert(0, "#");
        return result;
    }

    public long FindNextSquare(long num)
        => Math.Sqrt(num) % 1 == 0 ? (long)Math.Pow(Math.Sqrt(num) +1, 2) : -1 ;
}