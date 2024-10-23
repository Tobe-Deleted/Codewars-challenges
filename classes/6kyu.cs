using System;
using System.Collections;
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

    public int ParityOutlier(int[] arr)
    {
    // could use GroupBy(x => x%2, x => x) instead
    int odd = 0;
    int even = 0;
    for (int i = 0; i < 3; i++)
    {
        if (arr[i] % 2 == 0) even++;
        else odd++;
    }
    if (odd > even)
    {
        foreach(int a in arr)
        {
            if (a % 2 == 0) return a;
        }
    }
    foreach (int a in arr)
    {
        if (a % 2 != 0) return a;
    }
    return 0;
    }

    public string ReplaceWithAlphabetPosition(string text)
    {
        //stor A i alphaet for å flytte alle bokstavene til riktig index#
        string alphabet = "Aabcdefghijklmnopqrstuvwxyz";
        string result = "";
        text = text.ToLower();
        foreach (char ch in text)
        {
            if(alphabet.Contains(ch))result += alphabet.IndexOf(ch) + " ";
        }
        if (result != "")result = result.Remove(result.Length - 1, 1);
        return result;

    }

    public bool ValidWalk(string[] walk)
    {
        if (walk.Length != 10) return false;
        int w = 0;
        int e = 0;
        int s = 0;
        int n = 0;
        foreach (string str in walk)
        {
            if (str == "s")s++;
            if (str == "n")n++;
            if (str == "w")w++;
            if (str == "e")e++;
        }
        return s == n && w == e;
    }

}