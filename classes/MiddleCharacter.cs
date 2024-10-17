using System;
public class MiddleCharacter
{
    public void GetMidChar(string s)
    {
        int n = s.Length / 2;
        if(s.Length % 2 == 0) Console.WriteLine($"{s[n-1]}{s[n]}");
        else Console.WriteLine(s[n]);
    }
}