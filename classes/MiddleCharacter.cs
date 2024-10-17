using System;
public class MiddleCharacter
{
    public void GetMidChar(string str)
    {
        int n = str.Length / 2;
        if(str.Length % 2 == 0) Console.WriteLine($"{str[n-1]}{str[n]}");
        else Console.WriteLine(str[n]);
    }
}