using System.Security.Cryptography;
using System;
namespace Codewars_test;

class Program
{
    static void Main(string[] args)
    {
        EightKyu kyu8 = new EightKyu();
        //Console.WriteLine(kyu8.Litres(11.8));

        
        SevenKyu kyu7 = new SevenKyu();
        //kyu7.IsIsogram("MoOse");
        //kyu7.GetMidChar("testing");
        //kyu7.IsSquare(25);
        
        SixKyu kyu6 = new SixKyu();
        //Console.WriteLine(kyu6.HowManyOnes(55));
        //kyu6.GetDigitalRoot(56798);
        //kyu6.SpinWords("Hey fellow warriors");
        Console.WriteLine(kyu6.DuplicateCount("fisk i øret ned elven"));
    }
}
