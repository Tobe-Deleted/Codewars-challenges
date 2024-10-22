using System;
using System.Linq;
using System.Globalization;
using System.Collections.Generic;
using System.Xml.XPath;
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
}
