using System.Data;
using System.Formats.Asn1;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks.Dataflow;
using System.Xml.XPath;

public class FourKyu
{
    public int FindMissingDigit(string expression)
    {

        // Kan bruke 
        //new DataTable().Compute(string, emptyString) 
        //for å prosessere mattestykker som string
        if (expression == "") return -1;
        bool isFirstZero = true;
        int a = 0; int b = 0; int c = 0;
        for(int i = 0; i <10; i++)
        {
            if (expression.Contains('+') || expression.Contains('*'))
                { 
                while (isFirstZero)
                {
                    isFirstZero = false;

                    //Splits the string into the different numbers
                    string[] strArr = expression.Replace('?', Convert.ToChar(
                                                              Convert.ToString(i)))
                                                .Split('*', '=', '+');

                    //checks if number starts with 0; Skips testing 0 if it does
                    if (strArr[0][0] == '0' && strArr[0].Length > 1||
                        strArr[1][0] == '0' && strArr[1].Length > 1||
                        strArr[2][0] == '0' && strArr[2].Length > 1)
                    {
                        isFirstZero = true;
                        i++;
                        if(i > 9) return -1;
                    }
                    a = Convert.ToInt32(strArr[0]);
                    b = Convert.ToInt32(strArr[1]);
                    c = Convert.ToInt32(strArr[2]);
                }
            }
            else
            {
                if (expression[0] == '-')
                {   
                    while (isFirstZero)
                    {
                        isFirstZero = false;
                        //Splits the string into the different numbers
                        string[] strArr = expression.Insert(expression.IndexOf('-', 
                                                            expression.IndexOf('-') + 1), "=")
                                                    .Remove(expression.IndexOf('-',
                                                            expression.IndexOf('-') + 1) + 1, 1)
                                                    .Replace('?', Convert.ToChar(Convert.ToString(i)))
                                                    .Split('=');

                        //checks if number starts with 0; Skips testing 0 if it does
                        if (strArr[0][0] == '-' && strArr[0][1] == '0' || 
                            strArr[1][0] == '-' && strArr[1][1] == '0' ||
                            strArr[2][0] == '-' && strArr[2][1] == '0' ||
                            strArr[0][0] == '0' && strArr[0].Length > 1||
                            strArr[1][0] == '0' && strArr[1].Length > 1||
                            strArr[2][0] == '0' && strArr[2].Length > 1)
                        {
                            isFirstZero = true;
                            i++;
                            if(i > 9) return -1;
                        }

                        a = Convert.ToInt32(strArr[0]);
                        b = Convert.ToInt32(strArr[1]);
                        c = Convert.ToInt32(strArr[2]); 
                    }
                }
                else
                {
                    while (isFirstZero)
                    {
                        isFirstZero = false;

                        //Splits the string into the different numbers
                        string[] strArr = expression.Insert(expression.IndexOf('-'), "=")
                                                    .Remove(expression.IndexOf('-') +1, 1)
                                                    .Replace('?', Convert.ToChar(Convert.ToString(i)))
                                                    .Split('=');

                        //checks if number starts with 0; Skips testing 0 if it does
                        if (strArr[0][0] == '-' && strArr[0][1] == '0' || 
                            strArr[1][0] == '-' && strArr[1][1] == '0' ||
                            strArr[2][0] == '-' && strArr[2][1] == '0' ||
                            strArr[0][0] == '0' && strArr[0].Length > 1||
                            strArr[1][0] == '0' && strArr[1].Length > 1||
                            strArr[2][0] == '0' && strArr[2].Length > 1)
                        {
                            isFirstZero = true;
                            i++;
                            if(i > 9) return -1;
                        }

                        a = Convert.ToInt32(strArr[0]);
                        b = Convert.ToInt32(strArr[1]);
                        c = Convert.ToInt32(strArr[2]); 
                    }                                             
                } 
            }
            if(!expression.Contains($"{i}"))
            {
                if (a + b == c && expression.Contains('+') ||
                    a * b == c && expression.Contains('*') ||
                    a - b == c && expression.Contains('-')) return i;
            }
            isFirstZero = true;
        }
        return -1;
    }

    public string ToRoman(int n)
    {
        string r = "";
        string s = n.ToString();
        for (int i = 4; i > s.Length;)
        {
           s = s.Insert(0, "0");
        }
        // 1st digit
        switch (s[0])
        {
            case '0':
                break;
            case '1':
                r += "M";
                break;
            case '2':
                r += "MM";
                break;
            case '3':
                r += "MMM";
                break;
            case '4':
                r += "MMMM";
                break;
            case '5':
                r += "MMMMM";
                break;
            case '6':
                r += "MMMMMM";
                break;
            case '7':
                r += "MMMMMMM";
                break;
            case '8':
                r += "MMMMMMMM";
                break;
            case '9':
                r += "MMMMMMMMM";
                break;
            default:
            return "wtf?";
        }
        // 2nd digit
                switch (s[1])
        {
            case '0':
                break;
            case '1':
                r += "C";
                break;
            case '2':
                r += "CC";
                break;
            case '3':
                r += "CCC";
                break;
            case '4':
                r += "CD";
                break;
            case '5':
                r += "D";
                break;
            case '6':
                r += "DC";
                break;
            case '7':
                r += "DCC";
                break;
            case '8':
                r += "DCCC";
                break;
            case '9':
                r += "CM";
                break;
            default:
            return "wtf?";
        }
        // 3rd digit
                switch (s[2])
        {
            case '0':
                break;
            case '1':
                r += "X";
                break;
            case '2':
                r += "XX";
                break;
            case '3':
                r += "XXX";
                break;
            case '4':
                r += "XL";
                break;
            case '5':
                r += "L";
                break;
            case '6':
                r += "LX";
                break;
            case '7':
                r += "LXX";
                break;
            case '8':
                r += "LXXX";
                break;
            case '9':
                r += "XC";
                break;
            default:
            return "wtf?";
        }
        //4th digit
                switch (s[3])
        {
            case '0':
                break;
            case '1':
                r += "I";
                break;
            case '2':
                r += "II";
                break;
            case '3':
                r += "III";
                break;
            case '4':
                r += "IV";
                break;
            case '5':
                r += "V";
                break;
            case '6':
                r += "VI";
                break;
            case '7':
                r += "VII";
                break;
            case '8':
                r += "VIII";
                break;
            case '9':
                r += "IX";
                break;
            default:
                return "wtf?";
        }
        return r;
    }
    
    public int FromRoman(string romanNumeral)
    {
        DataTable dt = new DataTable();
        string s = "";
        char op;
        romanNumeral += "  "; //to keep index within range
        for(int i = 0; i < romanNumeral.Length; i++)
        {
            op = '+';
            //TODO: Find easier way to do this part
            if (romanNumeral[i] == 'I' && "VXLCDM".Contains(romanNumeral[i+1]) ||
                romanNumeral[i] == 'I' && "VXLCDM".Contains(romanNumeral[i+2]) ||
                romanNumeral[i] == 'X' && "LCDM".Contains(romanNumeral[i+1]) ||
                romanNumeral[i] == 'X' && "LCDM".Contains(romanNumeral[i+2]) ||
                romanNumeral[i] == 'C' && "DM".Contains(romanNumeral[i+1]) ||
                romanNumeral[i] == 'C' && "DM".Contains(romanNumeral[i+2]))
                op = '-';

            switch (romanNumeral[i])
            {
                case 'I':
                    s += $"{op}1";
                    break;
                case 'V':
                    s += $"{op}5";
                    break;
                case 'X':
                    s += $"{op}10";
                    break;
                case 'L':
                    s += $"{op}50";
                    break;
                case 'C':
                    s += $"{op}100";
                    break;
                case 'D':
                    s += $"{op}500";
                    break;
                case 'M':
                    s += $"{op}1000";
                    break;
                default:
                    break;     
            }       
        }
        return Convert.ToInt32(dt.Compute(s, ""));
    }

    public List<string> Top3(string str)
    {
        //A better way to solve + interesting use of string.Split
        // var alphabets = new HashSet<char>(Enumerable.Range('a', 26).Select(i => (char)i));
        // var separators = Enumerable.Range(0, 256).Select(i => (char)i).Where(c => !alphabets.Contains(c) && c != '\'').ToArray();

        // return s.ToLower().Split(separators, StringSplitOptions.RemoveEmptyEntries)
        //   .Select(word => new string(word.Where(alphabets.Append('\'').Contains).ToArray()))
        //   .Where(word => alphabets.Any(word.Contains))
        //   .GroupBy(word => word)
        //   .OrderByDescending(group => group.Count())
        //   .Take(3)
        //   .Select(group => group.Key)
        //   .ToList();
        str = str.ToLower();
        bool letters = false;
        for(int i = 1; i < str.Length; i++)
        {
            if(Char.IsLetter(str.ToCharArray()[i])) letters = true;
            if(str.ToCharArray()[i] == str.ToCharArray()[i-1] &&
               str.ToCharArray()[i] == ' ')
                    str = str.Remove(i, 1);
        }
            if(!letters)return new List<string> { };

        string[] strArr = str.Replace("/", " ")
                             .Replace(",", " ")
                             .Replace(":", " ")
                             .Replace(".", " ")
                             .Replace(";", " ")
                             .Replace("!", " ")
                             .Replace("_", " ")
                             .Replace("-", " ")
                             .Replace("?", " ")
                             .Split(' ');
        
        List<string> strList = strArr.ToList();
        strList.RemoveAll(item => item == "");

        var s1 = (from item in strList group item by item into x orderby 
        x.Count() descending select x.Key).First();

        strList.RemoveAll(item => item == s1);
        if(strList.Count() < 1)
            return new List<string> {s1}; 

        var s2 = (from item in strList group item by item into x orderby
        x.Count() descending select x.Key).First();

        strList.RemoveAll(item => item == s2);
        if(strList.Count() < 1)
            return new List<string> {s1, s2}; 

        var s3 = (from item in strList group item by item into x orderby
        x.Count() descending select x.Key).First();
        return new List<string> {s1, s2, s3};
    }

    public int ParseInt(string s)
    {
        Console.WriteLine(s);
        string[] str = {"zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety", "hundred", "thousand"};
        int[] ints = {0, 1 ,2 ,3 ,4 ,5 ,6 ,7 ,8 ,9 ,10 ,11 ,12 ,13 ,14 ,15 ,16 ,17 ,18 ,19 ,20 ,30 ,40 ,50 ,60 ,70 ,80 ,90 ,100 ,1000};
        int a = 0;
        List<string> stringList = s.Replace(" and", "")
                                   .Split(' ', '-')
                                   .ToList();
        int previous = 1;
        foreach(string st in stringList)
        {
            if (st == "million") 
                return 1000000;//Number will never be more than 1 million
            if (st == "thousand")
                a *= ints[Array.IndexOf(str, st)];
            else if(st == "hundred")
                a += 100 * previous - previous;
            else
                a += ints[Array.IndexOf(str, st)];
            previous = ints[Array.IndexOf(str, st)];
        }
        return a;
    }
    public List<string> GetPINs(string observed)
    {
        List<string> adjacents = new List<string>{"08", "124", "2135", "326", "4157", "52468", "6359", "748", "85790", "968"};
        List<string> Combinations = new List<string>{};
        int possibleCombinations = 1;
        int t = 0;
        foreach(char ch in observed)
        {
            possibleCombinations *= adjacents[ch-48].Length;
        }
        for (int i = 0; i < possibleCombinations; i++)
            Combinations.Add("");
        for (int n = 0; n < observed.Length; n++)
        {
            for (int i = 0; i < possibleCombinations; i++)
            {
                    Combinations[i] += adjacents[observed[n]-48][t];
                    t++;
                    if (t >= adjacents[observed[n]-48].Length)
                        t = 0;
            }
            Combinations.Sort();
        }
        return Combinations;
    }

    public (int, int)[][] BuildMatchesTable(int numberOfTeams)
    {
        int[] teams = Enumerable.Range(1, numberOfTeams).ToArray();
        int numberOfRounds = numberOfTeams -1;
        List<int> rotation = Enumerable.Range(2, numberOfTeams -1).ToList();
        List<(int, int)[]> schedule = new List<(int, int)[]>{};
        for (int round = 0; round < numberOfRounds; round++)
        {
            List<(int, int)> matches = new List<(int, int)>();

            for (int i = 0; i < numberOfTeams / 2; i++)
            {
                matches.Add((teams[i], teams[numberOfTeams -1 -i]));
            }
            schedule.Add(matches.ToArray());

            // rotation algorithm ( team 1 will keep its place)
            int first = rotation[0];
            rotation.RemoveAt(0);
            rotation.Add(first);

            for(int n = 1; n < numberOfTeams; n++)
            {
                teams[n] = rotation[n-1];
            }
        }
        return schedule.ToArray();
    }

    //sudoku constructor:
    // private int[][] sudokuBoard;
    // private int sudokuRowLength;
    // // public FourKyu(int[][] sudokuData)
    // // {
    // //     sudokuBoard = sudokuData;
    // //     sudokuRowLength = sudokuData.Length;
    // // }

    // public bool IsValid()
    // {    
    //     // Checks size
    //     Console.WriteLine(sudokuRowLength);
    //     if(sudokuRowLength < 1 || Math.Sqrt(sudokuRowLength) % 1 != 0) return false;
    //     // Checks that integers are within bounds
    //     foreach(int[] ia in sudokuBoard)
    //         foreach(int i in ia)
    //             if (i < 1 || i > sudokuRowLength) return false;
        
    //     // Checks that each row only contains a single instance of each number
    //     foreach(int[] ia in sudokuBoard)
    //         if(ia.Distinct().Count() != sudokuRowLength) return false;

    //     // Checks that each column only contains a single instance of each number
    //     for(int i = 0; i < sudokuRowLength; i++)
    //     {
    //         int[] column = new int[sudokuRowLength];
    //         for(int n = 0; n < sudokuRowLength; n++)
    //         {
    //             column[n] = sudokuBoard[n][i];
    //         }
    //         if(column.Distinct().Count() != sudokuRowLength) return false;
    //     }

    //     // Checks that each box only contains a single instance of each number
    //     int[][] boxes = new int[sudokuRowLength][];
    //     for(int i = 0; i < sudokuRowLength; i++)
    //         boxes[i] = new int[sudokuRowLength];
    //     int z = 0;
    //     int a = 0;
    //     int counter1 = 0;
    //     for(int i = 0; i < sudokuRowLength; i++)
    //     {
    //         int x = 0;
    //         int y = 0; 
    //         int counter2 = 0;
    //         if(counter1 == Math.Sqrt(sudokuRowLength))
    //         {
    //             a += (int)Math.Sqrt(sudokuRowLength);
    //             counter1 = 0;
    //         }
    //         for(int n = 0; n < sudokuRowLength; n++)
    //         {
    //             if(counter2 == Math.Sqrt(sudokuRowLength))
    //             {
    //                 x++;
    //                 y += (int)Math.Sqrt(sudokuRowLength);
    //                 counter2 = 0;
    //             }
    //             boxes[x+a][n+z-y] = sudokuBoard[i][n];
    //             counter2++;
    //         }
    //         z += (int)Math.Sqrt(sudokuRowLength);
    //         if(z == sudokuRowLength) z = 0;
    //         counter1++;
    //     }
    //     foreach(int[] ia in boxes)
    //     {
    //         if(ia.Distinct().Count() != sudokuRowLength) return false;
    //     }
    //   return true;
    // }

    public int SumIntervals((int, int)[] intervals)
    {       
        if(intervals.Length < 1) return 0;
        (int, int)[] sortedIntervals = intervals.OrderBy(x => x.Item1).ToArray();
        int result = 0;
        int start = sortedIntervals[0].Item1;
        int end = sortedIntervals[0].Item1;
        foreach(var (i1, i2) in sortedIntervals)
        {
            if(i1 >= end)
            {
                Console.WriteLine($"{start} {end}");
                result += Math.Abs(end - start);
                start = i1;
                end = i2;
            }
            if(i2 > end)
            {
                end = i2;
            }
        }
        return result + Math.Abs(end - start);
    }

    public string FormatDuration(int seconds)
    {
        if (seconds == 0) return "now";
        int years = seconds / 31536000;
        seconds %= 31536000;
        int days = seconds / 86400;
        seconds %= 86400;
        int hours = seconds / 3600;
        seconds %= 3600;
        int minutes = seconds / 60;
        seconds %= 60;

        List<string> timeUnits = new List<string>();
        if (years > 0) timeUnits.Add($"{years} year{(years > 1 ? "s" : "")}");
        if (days > 0) timeUnits.Add($"{days} day{(days > 1 ? "s" : "")}");
        if (hours > 0) timeUnits.Add($"{hours} hour{(hours > 1 ? "s" : "")}");
        if (minutes > 0) timeUnits.Add($"{minutes} minute{(minutes > 1 ? "s" : "")}");
        if (seconds > 0) timeUnits.Add($"{seconds} second{(seconds > 1 ? "s" : "")}");

        return string.Join(", ", timeUnits.Take(timeUnits.Count - 1)) +
               (timeUnits.Count > 1 ? " and " : "") +
               timeUnits.Last();
    }
}