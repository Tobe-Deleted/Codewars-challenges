using System.Formats.Asn1;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;

public class FourKyu
{
    public int FindMissingDigit(string expression)
    {
        if (expression == "") return -1;
        bool isFirstZero = true;
        int a; int b; int c;
        for(int i = 0; i <10; i++)
        {
            if (expression.Contains('+') || expression.Contains('*'))
            { 
                string[] strArr = expression.Replace('?', Convert.ToChar(
                                                            Convert.ToString(i)))
                                                .Split('*', '=', '+');
                a = Convert.ToInt32(strArr[0]);
                b = Convert.ToInt32(strArr[1]);
                c = Convert.ToInt32(strArr[2]);
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
                                                    .Replace('?', Convert.ToChar(Convert.ToString(i)))
                                                    .Split('=');
                        if (strArr[0][0] == '0' || strArr[1][0] == '0' || strArr[2][0] == '0')
                        {
                            isFirstZero = true;
                            i++;
                        }
                        else if (strArr[0][0] == '-' || strArr[1][0] == '-' || strArr[2][0] == '-')
                        {
                            if (strArr[0][1] == '0' || strArr[1][1] == '0' || strArr[2][1] == '0')
                            {
                                isFirstZero = true;
                                i++;
                            }
                        }

                        a = Convert.ToInt32(strArr[0]);
                        b = Convert.ToInt32(strArr[1].Remove(0,1));
                        c = Convert.ToInt32(strArr[2]); 
                    }
                }
                else
                {
                    while (isFirstZero)
                    {
                        isFirstZero = false;
                        string[] strArr = expression.Insert(expression.IndexOf('-'), "=")
                                                    .Replace('?', Convert.ToChar(Convert.ToString(i)))
                                                    .Split('=');
                        if (strArr[0][0] == '0' || strArr[1][0] == '0' || strArr[2][0] == '0')
                        {
                            isFirstZero = true;
                            i++;
                        }
                        else if (strArr[0][0] == '-' || strArr[1][0] == '-' || strArr[2][0] == '-')
                        {
                            if (strArr[0][1] == '0' || strArr[1][1] == '0' || strArr[2][1] == '0')
                            {
                                isFirstZero = true;
                                i++;
                            }
                        }

                        a = Convert.ToInt32(strArr[0]);
                        b = Convert.ToInt32(strArr[1].Remove(0,1));
                        c = Convert.ToInt32(strArr[2]); 
                    }                                             
                } 
            }

            if(a + b == c && expression.Contains('+')) return i;
            if(a * b == c && expression.Contains('*')) return i;
            if(a - b == c && expression.Contains('-')) return i;
        }
        return -1;
    }
}