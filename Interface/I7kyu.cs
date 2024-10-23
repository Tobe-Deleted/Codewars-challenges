public interface I7kyu
{
    /// <summary>
    /// Checks if there are repeating characters in str
    /// </summary>
    /// <param name="str"></param>
    public void IsIsogram(string str);

    /// <summary>
    /// prints out middle character(s) of string 
    /// test => es
    /// testing => t 
    /// </summary>
    /// <param name="str"></param>
    public void GetMidChar(string str);

    /// <summary>
    /// Checks if root of n is a whole number(not decimal)
    /// </summary>
    /// <param name="n"></param>
    public void IsSquare(int n);

/// <summary>
/// Returns true if the amount of X's and O's are equal or false if not
/// </summary>
/// <param name="input"></param>
/// <returns>true || false</returns>
    public bool XandO(string input);

/// <summary>
/// changes first letters of words in a string to upper case and all other letters to lower case
/// </summary>
/// <param name="phrase"></param>
/// <returns>Firstletters.ToUpper && AllOtherLetters.ToLower</returns>
    public string ToJadenCase(string phrase);

/// <summary>
/// Finds the length of the shortest word in a string
/// </summary>
/// <param name="s"></param>
/// <returns>int = length of shortest word</returns>
    public int ShortWordLength(string s);

/// <summary>
/// Returns each char x amount of times where x is position of char
/// </summary>
/// <param name="s"></param>
/// <returns>string where each char is put in x times where x = IndexOf(char +1)</returns>
    public string Accumul(string s);

/// <summary>
/// checks if str ends with ending
/// </summary>
/// <param name="str"></param>
/// <param name="ending"></param>
/// <returns>true or false</returns>
    public bool Solution(string str, string ending);


/// <summary>
/// returns the opposite DNA A = T, C = G and reversed
/// </summary>
/// <param name="dna"></param>
/// <returns>string</returns>
    public string MakeComplement(string dna);

/// <summary>
/// Takes in an int array and prints out the sum of the two smallest numbers
/// </summary>
/// <param name="numbers"></param>
/// <returns>int = sum of two smallest numbers</returns>
    public int SumOfTwoSmallestNumbers(int[] numbers);
}