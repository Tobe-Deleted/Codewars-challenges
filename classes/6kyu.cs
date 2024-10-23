using System;
using System.Linq;
public class SixKyu : I6kyu
{
    public int HowManyOnes(int n)
    {
        string binary = Convert.ToString(n, 2);
        //count x. return all x that = 1
        return binary.Count(x => x == '1');
    }


    public void GetDigitalRoot(long n)
    {
        //convert unecessary unless required to return int
        if (n == 0 || n % 9 != 0) Console.WriteLine(Convert.ToInt32(n % 9));
        else Console.WriteLine(9);
    }

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

    public int DuplicateCount(string str)
    {
        str = str.ToLower();
        int count = 0;
        string newStr;
        string check = "";
        foreach(char ch in str)
        {
            if (ch != '*')
            {
                newStr = str.Remove(str.IndexOf(ch), 1);
                if (newStr.Contains(ch) ^ check.Contains(ch)) 
                {
                    count++;
                    check += Convert.ToString(ch);
                }
            }
        }

        return count;
  }

  public string DuplicateEncoder(string word)
  {
    word = word.ToLower();
    string encodedWord = "";
    string check = "";
    foreach (char ch in word)
    {
        check = word.Remove(word.IndexOf(ch), 1);
        if (check.Contains(ch)) encodedWord += ")";
        else encodedWord += "(";
    }
    return encodedWord;
  }
}