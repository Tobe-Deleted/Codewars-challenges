using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;

public class FourKyu
{
    public int FindMissingDigit(string expression)
    {
        int a; int b; int c;
        if (expression.Contains('+') || expression.Contains('*'))
        {
            for(int i = 0; i <10; i++)
            {    
                string[] strArr = expression.Replace('?', Convert.ToChar(
                                                              Convert.ToString(i)))
                                                .Split('*', '=', '+');
            
                a = Convert.ToInt32(strArr[0]);
                b = Convert.ToInt32(strArr[1]);
                c = Convert.ToInt32(strArr[2]);
                if(a + b == c && expression.Contains('+')) return i;
                if(a * b == c && expression.Contains('*')) return i;
            }
        }
        else
        {
            for (int i = 0; i < 10; i++)
            {
                if (expression[0] == '-')
                {
                    string[] strArr = expression.Insert(expression.IndexOf('-', 
                                                        expression.IndexOf('-') + 1), "=")
                                                .Replace('?', Convert.ToChar(Convert.ToString(i)))
                                                .Split('=');
                }
                else
                {
                    string[] strArr = expression.Insert(expression.IndexOf('-'), "=").Replace('?', Convert.ToChar(Convert.ToString(i)));
                }
            }
        }
        return -1;
    }
}