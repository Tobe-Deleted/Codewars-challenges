using System.Security.Cryptography.X509Certificates;

public class Challenge
{
public void TestFunction(int number)
{
    if (number < 0) 
    {
        Console.WriteLine(0);
    }
    else{
    
        int fives = number % 5;
        int threes = number % 3;
        bool check = false;
        if (fives == threes) check = true;

        Console.Write(check);
    }
}

    
}