public interface I6kyu
{
    /// <summary>
    /// Counts bits with a value of 1. See CountingBits.cs
    /// </summary>
    /// <param name="n"></param>
    /// <returns>number of 1's in the binary translateion of integer n</returns>
    public int HowManyOnes (int n);

    /// <summary>
    /// Prints digital root of n
    /// </summary>
    /// <param name="n"></param>
    public void GetDigitalRoot(long n);

    /// <summary>
    /// reverses each word that are >= 5 characters long in sentence.
    /// </summary>
    /// <param name="sentence"></param>
    public void SpinWords(string sentence);

    /// <summary>
    /// counts how many distinct characters have duplicates
    /// </summary>
    /// <param name="str"></param>
    /// <returns> integer result</returns>
    public int DuplicateCount(string str);
}
