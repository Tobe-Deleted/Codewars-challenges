using System;
using System.Linq;
public class CountingBits : ICountingBits
{
    public int HowManyOnes(int n)
    {
        string binary = Convert.ToString(n, 2);
        //count x. return all x that = 1
        return binary.Count(x => x == '1');
    }
}