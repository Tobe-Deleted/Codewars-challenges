public interface I4kyu
{
    /// <summary>
    /// takes in a math problem as a string:[number][op][number]=[number] with one missing digit marked with a '?'
    /// and find the missing digit. If several digits fit, it will find the lowest digit that fits
    /// https://www.codewars.com/kata/546d15cebed2e10334000ed9
    /// </summary>
    /// <param name="expression"></param>
    /// <returns>The missing digit</returns>
    public int FindMissingDigit(string expression);

    /// <summary>
    /// Takes in an int up to 4 digits long and converts it to Roman numerals 
    /// https://www.codewars.com/kata/51b66044bce5799a7f000003
    /// </summary>
    /// <param name="n"></param>
    /// <returns>String with n as romal numerals</returns>
    public string ToRoman(int n);

    /// <summary>
    /// takes in a string with a roman numeral and turns it into the decimal equivalent
    /// https://www.codewars.com/kata/51b66044bce5799a7f000003
    /// </summary>
    /// <param name="romanNumeral"></param>
    /// <returns>int with romanNumerals converted to decimal</returns>
    public int FromRoman(string romanNumeral);

    /// <summary>
    /// Takes in a string and finds the most used words in string. Will ignore all special characters
    /// https://www.codewars.com/kata/51e056fe544cf36c410000fb
    /// </summary>
    /// <param name="str"></param>
    /// <returns>Returns a list containing Top 3 most repeated word in string in descending order</returns>
    public List<string> Top3(string str);

    /// <summary>
    /// Parses numbers written as words in a string to integers. zero to 1 million
    /// https://www.codewars.com/kata/525c7c5ab6aecef16e0001a5
    /// </summary>
    /// <param name="s"></param>
    /// <returns>int with number parsed from string</returns>
    public int ParseInt(string s);

    /// <summary>
    /// takes in a pin number and returns every possible combination if each digit
    /// could also be one of the adjacent numbers on the keypad.
    ///  https://www.codewars.com/kata/5263c6999e0f40dee200059d/
    /// </summary>
    /// <returns>list with each possible pin as string</returns>
    public List<string> GetPINs();

    /// <summary>
    /// Takes in a number and creates a round robin tournament with that many teams
    /// https://www.codewars.com/kata/561c20edc71c01139000017c
    /// </summary>
    /// <param name="numberOfTeams"></param>
    /// <returns>a list of match ups between each team for each round</returns>
    public (int, int)[][] BuildMatchesTable(int numberOfTeams);

    /// <summary>
    /// validates a sudoku solution
    /// https://www.codewars.com/kata/540afbe2dc9f615d5e000425
    /// </summary>
    /// <returns>true or false depending on the state of the sudoku board</returns>
    public bool IsValid();
}