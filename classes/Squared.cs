using System;

public class Squared
{
  public void IsSquare(int n)
  {
    //skriver ut true om Math.Sqrt(n) % 1 er lik 0;
    //skriver ut false om de ikke er lik.
    Console.WriteLine(Math.Sqrt(n) % 1 == 0);
  }
}