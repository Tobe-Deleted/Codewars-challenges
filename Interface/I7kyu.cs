public interface I7kyu
{
    /// <summary>
    /// Checks if there are repeating characters in str
    /// https://www.codewars.com/kata/54ba84be607a92aa900000f1
    /// </summary>
    /// <param name="str"></param>
    public void IsIsogram(string str);

    /// <summary>
    /// prints out middle character(s) of a string 
    /// https://www.codewars.com/kata/56747fd5cb988479af000028
    /// </summary>
    /// <param name="str"></param>
    public void GetMidChar(string str);

    /// <summary>
    /// Checks if root of n is a whole number(not decimal)
    /// https://www.codewars.com/kata/54c27a33fb7da0db0100040e
    /// </summary>
    /// <param name="n"></param>
    public void IsSquare(int n);

    /// <summary>
    /// Returns true if the amount of X's and O's are equal or false if not
    /// https://www.codewars.com/kata/55908aad6620c066bc00002a
    /// </summary>
    /// <param name="input"></param>
    /// <returns>true || false</returns>
    public bool XandO(string input);

    /// <summary>
    /// changes first letters of words in a string to upper case and all other letters to lower case
    /// https://www.codewars.com/kata/5390bac347d09b7da40006f6
    /// </summary>
    /// <param name="phrase"></param>
    /// <returns>Firstletters.ToUpper && AllOtherLetters.ToLower</returns>
    public string ToJadenCase(string phrase);

    /// <summary>
    /// Finds the length of the shortest word in a string
    /// https://www.codewars.com/kata/57cebe1dc6fdc20c57000ac9
    /// </summary>
    /// <param name="s"></param>
    /// <returns>int = length of shortest word</returns>
    public int ShortWordLength(string s);

    /// <summary>
    /// Returns each char x amount of times where x is position of char
    /// https://www.codewars.com/kata/5667e8f4e3f572a8f2000039
    /// </summary>
    /// <param name="s"></param>
    /// <returns>string where each char is put in x times where x = IndexOf(char +1)</returns>
    public string Accumul(string s);

    /// <summary>
    /// checks if str ends with ending
    /// https://www.codewars.com/kata/51f2d1cafc9c0f745c00037d
    /// </summary>
    /// <param name="str"></param>
    /// <param name="ending"></param>
    /// <returns>true or false</returns>
    public bool Solution(string str, string ending);


    /// <summary>
    /// returns the opposite DNA A = T, C = G and reversed
    /// https://www.codewars.com/kata/554e4a2f232cdd87d9000038
    /// </summary>
    /// <param name="dna"></param>
    /// <returns>string</returns>
    public string MakeComplement(string dna);

    /// <summary>
    /// Takes in an int array and prints out the sum of the two smallest numbers
    /// https://www.codewars.com/kata/558fc85d8fd1938afb000014
    /// </summary>
    /// <param name="numbers"></param>
    /// <returns>int = sum of two smallest numbers</returns>
    public int SumOfTwoSmallestNumbers(int[] numbers);

    /// <summary>
    /// Takes in two integers and adds them and every whole number in between them together.
    /// https://www.codewars.com/kata/55f2b110f61eb01779000053
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <returns>sum of every int between a and b</returns>
    public int GetSum(int a, int b);

    /// <summary>
    /// takes in an array of names and return the ones with length 4
    /// https://www.codewars.com/kata/55b42574ff091733d900002f/csharp
    /// </summary>
    /// <param name="names"></param>
    /// <returns>return names.Length == 4</returns>
    public IEnumerable<string> FriendOrFoe(string[] names);
    
    /// <summary>
    /// takes a string and masks all but 4 characters
    /// https://www.codewars.com/kata/5412509bd436bd33920011bc
    /// </summary>
    /// <param name="cc"></param>
    /// <returns>string with only 4 last characters revealed</returns>
    public string Mask(string cc);

    /// <summary>
    /// takes in a binary int array and returns the decimal equivalent
    /// https://www.codewars.com/kata/578553c3a1b8d5c40300037c
    /// </summary>
    /// <param name="BinaryArray"></param>
    /// <returns>integer with decimal value of the binary array</returns>
    public int binaryArrayToNumber(int[] BinaryArray);

    /// <summary>
    /// takes in a string and returns each words reversed in the same order
    /// </summary>
    /// <param name="str"></param>
    /// <returns>string</returns>
    public string ReverseWords(string str);
}