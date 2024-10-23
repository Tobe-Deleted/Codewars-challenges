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

/// <summary>
/// Encodes a string turning characters only occuring once into ( 
/// and characters with multiple occurances into )
/// </summary>
/// <param name="word"></param>
/// <returns>string with word encoded</returns>
    public string DuplicateEncoder(string word);

/// <summary>
/// Takes in an int array and returns the first number that doesn't fit
/// </summary>
/// <param name="arr"></param>
/// <returns>int = first odd/even number</returns>
    public int ParityOutlier(int[] arr);

/// <summary>
/// Will take in string and replace all letters with their corresponding number in the alphabet
/// </summary>
/// <param name="text"></param>
/// <returns></returns>
    public string ReplaceWithAlphabetPosition(string text);

/// <summary>
/// Checking if a walk will take 10 minutes and return you to the starting point
/// </summary>
/// <returns>false || true</returns>
    public bool ValidWalk();
}
