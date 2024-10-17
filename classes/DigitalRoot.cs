using System;
public class Digital_Root
{
  public void DigitalRoot(long n)
  {
    if (n == 0 || n % 9 != 0) Console.WriteLine(Convert.ToInt32(n % 9));
    else Console.WriteLine(9);
  }
}