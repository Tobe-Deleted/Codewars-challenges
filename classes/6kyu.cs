using System;
using System.Numerics;
using System.Collections;
using System.Linq;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;
using System.Security.Cryptography;

using System.Diagnostics.CodeAnalysis;
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
                if (newStr.Contains(ch) ^ check.Contains(ch)) // could be safer with: && check.Contains(ch)
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

        int w = 0; int e = 0; int s = 0; int n = 0;
        
        foreach (string str in walk)
        {
            if (str == "s")s++;
            if (str == "n")n++;
            if (str == "w")w++;
            if (str == "e")e++;
        }
        return s == n && w == e;
    }

    public int Persistence(long n)
    {
        int calc = 1;
        int result = 0;
        //Kan bruke (n > 9) for while loop
        while (n.ToString().Length > 1)
        {
            foreach (char ch in n.ToString())
            {
                calc *= int.Parse(ch.ToString());
            }
            n = calc;
            calc = 1;
            result++;
        }
        return result;
    }

    public string CamelCase(string str)
    {
        if (str == "") return "";
        TextInfo myTI = new CultureInfo("en-US",false).TextInfo;
        return str[0] + myTI
            .ToTitleCase(str.Replace("-", " ")
                            .Replace("_", " "))
            .Remove(0, 1)
            .Replace(" ", "");
    }

    public void UniqueInOrder<T>(IEnumerable<T> iterable)
    {
        List<T> result = new List<T> {iterable.ToList()[0]};
        for (int i = 1;i < iterable.Count(); i++)
        {
            //alternativ if statement
            //if (!EqualityComparer<T>.Default.Equals(iterable.ElementAt(i), iterable.ElementAt(i - 1)))
            if (Convert.ToString(iterable.ToList()[i]) != 
                Convert.ToString(iterable.ToList()[i-1])) 
            {
                result.Add(iterable.ElementAt(i));
            }
        }


        foreach(T t in result)Console.Write(t);
    }

    public bool IsPangram(string str) =>
        str .ToLower()
            .Distinct()
            .Count("abcdefghijklmnopqrstuvwxyz"
                    .Contains) == 26;

    public bool IsArmstrongNumber(int value)
    {
        long armstrongedNumber = 0;
        foreach (char ch in value.ToString())
        {
            armstrongedNumber += Convert.ToInt64(Math.Pow(
                                         int.Parse(ch.ToString()), value.ToString()
                                                                        .Length));
        }
        return value == armstrongedNumber;
    }

    public string WordOrder(string words)
    {
        //better solution: 
        //return string.Join(" ", words.Split().OrderBy(w => w.SingleOrDefault(char.IsDigit)));
        // SingleOrDefault(source, condition) > returns the only element in source that matches condition
        // w is source, IsDigit is condition.
        if (words == "") return words;
        string[] strArr = words.Split(' ');
        string result = "";
        for (int i = 1; i <= strArr.Length; i++)  
        {  
            //Console.WriteLine(i);
            foreach (string str in strArr)
            {
                //Console.WriteLine(str);
                if (str.Contains(i.ToString())) result += str + " ";
            }
            //Console.WriteLine($"Current result = {result}");
            //Console.ReadLine();
        }
        return result.Trim();
    }

    public int MinimumNumber(int[] numbers)
    {
        int sum = numbers.Sum();
        for(int i = 0; i > -1; i++)
        {
            if(IsPrime(sum +i)) return i;
        }
        return 0;
    }
    public bool IsPrime(int num)
    {
        for(int i = 2; i < Math.Floor(Math.Sqrt(num)) +1; i++) //Could do: i < root of num
        {
            if(num % i == 0) return false;
        }
        return true;
    }

    public double[] Tribonacci(double[] signature, int n)
    {
        double[] result = new double[n];
        if (n == 0) return result;
        result[0] = signature[0];
        if (n == 1) return result;
        result[1] = signature[1];
        if (n == 2) return result;
      
        double a = signature[0], b = signature[1], c = signature[2];
      
        for(int i = 2; i < n; i++)
        {
            result[i] = c;
            (a,b,c) = (b,c,a+b+c);
        }
        return result;
    }

    public int GetUnique(IEnumerable<int> numbers)
    {
        return numbers.Last(n => numbers.Count(i => i == n) == 1);
    }

    public string[] MagicMusicBox(string[] words)
    {
        string [] notes = {"DO", "RE", "MI", "FA", "SOL", "LA", "SI"};
        HashSet<string> usedWords = new HashSet<string>();
        bool loop = false;
        bool loop2 = false;
        int noteNum = 0;
        int wl = words.Length; 
        List<string> result = new List<string>();
        for(int i = 0; i < wl; i++)
        {
            if(noteNum == notes.Length)
            {
                if(loop2)break;
                loop2 = true;
                noteNum = 0;

            }
            Console.Write(words[i]);
            if(words[i].Contains(notes[noteNum]) && usedWords.Add(words[i]))
            {
                Console.WriteLine(" added");
                result.Add(words[i]);
                noteNum++;
                loop2 = false;
                loop = true;
            }
            else Console.WriteLine();
            if (i == wl -1 && loop)
            {
                i = -1;
                loop = false;
            }
        }
        return result.ToArray();
    }

    public int SumOfDigitGroups(BigInteger[] numbers)
    {
        
        string[] strNumbers = new string[numbers.Length];
        Dictionary<string, int> dict = new Dictionary<string, int>();
        List<List<string>> groups = new List<List<string>>();
        for (int i = 0; i < numbers.Length; i++)
        {
            strNumbers[i] = numbers[i].ToString();
        }

        foreach(string str in strNumbers)
        {
            if(dict.TryAdd(new string(str.OrderBy(c => c).ToArray()), groups.Count()))
            {
                groups.Add(new List<string> {str});
            }
            else
            {
                groups[dict[new string(str.OrderBy(c => c).ToArray())]].Add(str);
            }
        }
        
        groups = groups.Select(x => x.OrderBy(y => y).ToList()).ToList(); 

        BigInteger[] result = new BigInteger[groups.Count()];
        for (int i = 0; i < groups.Count(); i++)
        {
            result[i] = BigInteger.Parse(groups[i][0]);
        }
        BigInteger sum = 0;
        foreach(BigInteger bi in result)
        {
            sum += bi;
        }
        Console.WriteLine(sum);
        return sum.ToString().Sum(c => c - '0');
    }
}