using System.Numerics;
public interface I3kyu
{
    /// <summary>
    /// Takes in a number x and creates a spiral in a map that is x*x large
    /// https://www.codewars.com/kata/534e01fbbb17187c7e0000c6
    /// </summary>
    /// <param name="size">Size of spiral</param>
    /// <returns>returns a 2d int array that forms a spiral of 1s if each object is printed out per line</returns>
    public int[,] NxNSpiral(int size);

    /// <summary>
    /// streams every prime number from 0 to 16.000.000
    /// https://www.codewars.com/kata/5519a584a73e70fa570005f5
    /// </summary>
    /// <returns>a stream of prime numbers</returns>
    public IEnumerable<int> Stream();

    /// <summary>
    /// takes in an integer of the requested number in the fibonacci sequence
    /// https://www.codewars.com/kata/53d40c1e2f13e331fc000c26
    /// </summary>
    /// <param name="n">nth fibonacci number</param>
    /// <returns>a BigInteger with the fibonacci number at nth position</returns>
    public BigInteger Fib(int n);

    /// <summary>
    /// takes in floors and eggs and calculates what are the maximum floors you can test in order to find safe drop distance
    /// https://www.codewars.com/kata/54cb771c9b30e8b5250011d4
    /// </summary>
    /// <param name="n"></param>
    /// <param name="m"></param>
    /// <returns></returns>
    public BigInteger EggDrop(int n, int m);
}