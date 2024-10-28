using System.Formats.Asn1;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;

public class FourKyu
{
    public int FindMissingDigit(string expression)
    {
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
                    string[] strArr = expression.Replace('?', Convert.ToChar(
                                                                Convert.ToString(i)))
                                                .Split('*', '=', '+');

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
                        string[] strArr = expression.Insert(expression.IndexOf('-', 
                                                            expression.IndexOf('-') + 1), "=")
                                                    .Remove(expression.IndexOf('-',
                                                            expression.IndexOf('-') + 1) + 1, 1)
                                                    .Replace('?', Convert.ToChar(Convert.ToString(i)))
                                                    .Split('=');

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
                        string[] strArr = expression.Insert(expression.IndexOf('-'), "=")
                                                    .Remove(expression.IndexOf('-') +1, 1)
                                                    .Replace('?', Convert.ToChar(Convert.ToString(i)))
                                                    .Split('=');
                        
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
}