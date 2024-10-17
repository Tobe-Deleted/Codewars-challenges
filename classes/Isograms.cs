using System;
public class Isograms
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
}