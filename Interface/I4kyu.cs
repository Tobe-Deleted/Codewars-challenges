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
}