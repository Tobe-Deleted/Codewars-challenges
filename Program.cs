using System.Security.Cryptography;
using System;
using System.Runtime.InteropServices;
using System.Numerics;
namespace Codewars_test;

class Program
{
    static void Main(string[] args)
    {
        ForFun ff = new ForFun();
        //ff.WhatNumber();

        EightKyu kyu8 = new EightKyu();
        //Console.WriteLine(kyu8.Litres(11.8));
        //Console.WriteLine(kyu8.CenturyFromYear(1705));
        // double[] d = {5, 6, 1, 8};
        // Console.WriteLine(kyu8.SumOfArray(d));
        //Console.WriteLine(kyu8.Paperwork(5, 5));

        
        SevenKyu kyu7 = new SevenKyu();
        //kyu7.IsIsogram("MoOse");
        //kyu7.GetMidChar("testing");
        //kyu7.IsSquare(25);
        //Console.WriteLine(kyu7.XandO("xmXmoo"));
        //Console.WriteLine(kyu7.ToJadenCase("fiskene svømmer forbi i full faRt"));
        //Console.WriteLine(kyu7.ShortWordLength("dette kan ikke fiskene huske"));
        //Console.WriteLine(kyu7.Accumul("abcde"));
        //Console.WriteLine(kyu7.Solution("abc", "bc"));
        //Console.WriteLine(kyu7.MakeComplement("ATGC"));
        //int[] arr = {5, 22, 55, 40, 2, 6};
        //Console.WriteLine(kyu7.SumOfTwoSmallestNumbers(arr));
        //Console.WriteLine(kyu7.GetSum(1, 15));
        //string[] input = {"Ryan", "Kieran", "Jason", "Yous"};
        //foreach (string str in kyu7.FriendOrFoe(input)) Console.WriteLine(str);
        //Console.WriteLine(kyu7.Mask("55500770"));
        
        
        SixKyu kyu6 = new SixKyu();
        // int[] arr = {1,2,3};
        // Console.WriteLine(kyu6.MinimumNumber(arr));
        //Console.WriteLine(kyu6.HowManyOnes(55));
        //kyu6.GetDigitalRoot(56798);
        //kyu6.SpinWords("Hey fellow warriors");
        //Console.WriteLine(kyu6.DuplicateCount("bro bro brille klokken ringer elleve"));
        //Console.WriteLine(kyu6.DuplicateEncoder("rEcede"));
        //int[] arr = {2, 2, 12, 5, 6, 2};
        //Console.WriteLine(kyu6.ParityOutlier(arr));
        //Console.WriteLine(kyu6.ReplaceWithAlphabetPosition("555"));
        //string[] arr = {"n","s","n","s","n","s","n","s","n","w"};
        //Console.WriteLine(kyu6.ValidWalk(arr));
        //Console.WriteLine(kyu6.Persistence(39));
        //Console.WriteLine(kyu6.CamelCase("the-StEalth_warrior_talks"));
        //kyu6.UniqueInOrder("ffffiiiiissssskkkkk1223334fffiiisssk");
        //Console.WriteLine(kyu6.IsPangram("The quick brown fox jumps over the lazy dog"));
        //Console.WriteLine(kyu6.IsArmstrongNumber(153));
        //Console.WriteLine(kyu6.WordOrder("is2 Thi1s T4est 3a"));
        

        FiveKyu kyu5 = new FiveKyu();
        // int[] arr = {1, 0, 2, 0, 1, 0, 1, 0, 3, 1};
        // kyu5.MoveZeroes(arr);
        // int[][] close = kyu5.Closest("239382 162 254765 182 485944 134 468751 62 49780 108 54");
        // foreach(int[] arr in close)
        //     foreach(int i in arr)Console.WriteLine($"{i}");

        FourKyu kyu4 = new FourKyu();
        //Console.WriteLine(kyu4.FindMissingDigit("123?45-?=123?45")); //?
        //Console.WriteLine(kyu4.ToRoman(2024));
        //Console.WriteLine(kyu4.FromRoman("MMXXIV"));
        //foreach(string str in kyu4.Top3("  , e   .. "))Console.WriteLine(str);
        //Console.WriteLine(kyu4.ParseInt("one thousand three hundred and thirty-seven"));
        //foreach (string str in kyu4.GetPINs("893869"))Console.WriteLine(str);

        ThreeKyu kyu3 = new ThreeKyu();

        Console.WriteLine(kyu3.Fib(10));
        // Console.Write("Enter number:");
        // int size = Convert.ToInt32(Console.ReadLine());
        // int tempSize = size;
        // int n = 1;
        // foreach(int i in kyu3.NxNSpiral(size))
        // {    
        //     n++;
        //     Console.Write(i); 
        //     if (n > tempSize)
        //     {
        //         Console.WriteLine();
        //         tempSize += size;
        //     }

        // }
        // int eggs = 2;
        // int tries = 20;
        // BigInteger maxFloors = kyu3.EggDrop(eggs, tries);
        // Console.WriteLine($"With {eggs} eggs and {tries} tries, you can test up to {maxFloors} floors.");

    }

    //example for coworker:
    public class Product()
    {
        public int amount;
        public int cost;
    }
    
    public int ProdSum(List<Product> productList)
    {
        productList[0].amount = 1;
        productList[0].cost = 2;

        int sum = 0;
        for(int i = 0; i > productList.Count(); i++)
        {
            sum += productList[i].amount * productList[i].cost;
        }
        return sum;
    }
}
