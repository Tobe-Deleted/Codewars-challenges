public interface I4kyu
{
/// <summary>
/// takes in a math problem as a string:[number][op][number]=[number] with one missing digit marked with a '?'
/// and find the missing digit. If several digits fit, it will find the lowest digit that fits
/// </summary>
/// <param name="expression"></param>
/// <returns>The missing digit</returns>
    public int FindMissingDigit(string expression);
}