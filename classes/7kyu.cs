using System.Linq;
public class SevenKyu : I7kyu
{
    public void IsIsogram(string str)
    {
        str = str.ToLower();
        bool bl = true;
        string newStr;
        foreach(char ch in str)
        {
            newStr = str.Remove(str.IndexOf(ch), 1);
            if (newStr.Contains(ch)) 
            {
                bl = false;
                break;
            }
        }
        Console.WriteLine(bl);
    }
    public void GetMidChar(string str)
    {
        int n = str.Length / 2;
        if(str.Length % 2 == 0) Console.WriteLine($"{str[n-1]}{str[n]}");
        else Console.WriteLine(str[n]);
    }
    public void IsSquare(int n)
    {
        //skriver ut true om Math.Sqrt(n) % 1 er lik 0;
        //skriver ut false hvis ikke.
        Console.WriteLine(Math.Sqrt(n) % 1 == 0);
    }

    public bool XandO(string input)
    {
        
        if(input.ToLower().Count(x => x == 'x') == input.ToLower().Count(o => o == 'o') )
        {
        return true;
        }
        return false;
    }
}
