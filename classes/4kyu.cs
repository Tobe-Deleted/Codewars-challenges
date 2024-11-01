using System.Formats.Asn1;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;
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
                r += "CCM";
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
                r += "XXC";
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
                r += "IIX";
                break;
            case '9':
                r += "IX";
                break;
            default:
            return "wtf?";
        }
        return r;
    }
}