using System;
using System.Linq;
public class CountingBits
{
    public void HowManyOnes(int n)
    {
        string binary = Convert.ToString(n, 2);
        binary = binary.Replace("0", "");
        Console.WriteLine(binary.Count());
    }
}