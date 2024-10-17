using System;
using System.Collections.Generic;

public class SpinningWords
{
    public void SpinWords(string sentence)
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