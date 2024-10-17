using System.Security.Cryptography;
using System;
namespace Codewars_test;

class Program
{
    static void Main(string[] args)
    {
        SpinningWords  spnwrd = new SpinningWords();
        //clg.SpinWords("Hey fellow warriors");

        Squared issquare = new Squared();
        //issquare.IsSquare(25);   

        DigitalRoot dgrt = new DigitalRoot();
        //dgrt.GetDigitalRoot(56798);

        MiddleCharacter mdch = new MiddleCharacter();
        //mdch.GetMidChar("testing");
        
        Isograms isgm = new Isograms();
        //isgm.IsIsogram("MoOse");
        
        CountingBits cntb = new CountingBits();
        Console.WriteLine(cntb.HowManyOnes(55));
    }
}
