using System.Linq;
public class ForFun
{
    public void WhatNumber()
    {
        int sumOfDigits;
        int[] prime = {2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47, 53, 59, 61, 67, 71, 73, 79, 83, 89, 97};
        for (int i = 10; i < 100; i++)
        {
            string[] digits = i.ToString().Insert(1, " ").Split(" ").ToArray();
            sumOfDigits = Convert.ToInt32(digits[0]) + Convert.ToInt32(digits[1]);

            
            if(!i.ToString().Contains('8') &&
                                i % 3 != 0 &&
                     Math.Sqrt(i) % 1 != 0 &&
                        !prime.Contains(i) &&
              !prime.Contains(sumOfDigits) && 
                sumOfDigits != 8)
            {
                Console.WriteLine(i);
            }
        }
    }
}