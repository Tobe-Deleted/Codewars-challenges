using System;
using System.Security.Cryptography.X509Certificates;
public class EightKyu : I8kyu
{
    public int Litres(double time)
    {
        time = Math.Floor(time/2);
        int result = Convert.ToInt32(time);
        return result;
        //a better solution:
        //return (int)(time/2);
    }

    public int CenturyFromYear(int year)
    {
        if (year % 100 == 0) return year / 100;
        return year / 100 + 1;
    }

    public double SumOfArray(double[] array) => array.Sum();

    public int Paperwork(int n, int m)
    {
        if(n < 0 || m < 0) 
            return 0;
        return m * n;
    }
}