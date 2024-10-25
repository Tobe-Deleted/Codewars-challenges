public class FourKyu
{
    public int FindMissingDigit(string expression)
    {
        string tempExpression = expression;
        int a; int b; int c;
        if (expression.Contains('+') || expression.Contains('*'))
        {
            for(int i = 0; i <10; i++)
            {
                //tempExpression = tempExpression.Replace('?', Convert.ToChar(Convert.ToString(i)));
                string[] strArr = tempExpression.Replace('?', 
                                                    Convert.ToChar(Convert.ToString(i)))
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
            
        }
        return -1;
    }
}