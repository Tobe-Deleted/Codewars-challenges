using System.Security.Cryptography.X509Certificates;
using System;
using System.Globalization;
using System.Xml;
using System.Transactions;
using Microsoft.VisualBasic;
using System.Security.AccessControl;
using System.Collections.Generic;
using System.Runtime.InteropServices;
public class Challenge
{
    public void TestFunction(string sentence)
    {   
        char[] chArr;
        string temp = "";
        int i = 0;
        string[] words = sentence.Split(' ').ToArray();
        foreach(string str in words)
        {
            if (str.Length > 4)
            {
                temp = "";
                chArr = str.ToCharArray();
                Array.Reverse(chArr);
                foreach(char ch in chArr) temp += ch;
                words[i] = temp;
            }
            i++;
        }

        
        foreach(string stri in words)Console.WriteLine(stri);
    }

}