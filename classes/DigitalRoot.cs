using System;
public class DigitalRoot
{
  public void GetDigitalRoot(long n)
  {
    //convert unecessary
    if (n == 0 || n % 9 != 0) Console.WriteLine(Convert.ToInt32(n % 9));
    else Console.WriteLine(9);
  }
}