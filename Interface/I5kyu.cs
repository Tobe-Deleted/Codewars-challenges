public interface I5kyu
{
    /// <summary>
    /// Takes in an array and move all 0's to the end of the array
    /// https://www.codewars.com/kata/52597aa56021e91c93000cb0
    /// </summary>
    /// <param name="arr"></param>
    /// <returns>new int[] {1, 2, 0, 1, 0, 1, 0, 3, 0, 1} => new int[] {1, 2, 1, 1, 3, 1, 0, 0, 0, 0}</returns>
    public int[] MoveZeroes(int[] arr);

    /// <summary>
    /// Takes in a string of numbers seperated by space. Finds the weight(all digits added together) and returns the two closest numbers by weight.
    /// https://www.codewars.com/kata/5868b2de442e3fb2bb000119/csharp
    /// </summary>
    /// <param name="strng"></param>
    /// <returns>An array with two intArrays containing weight, position, number of the two closest numbers by weight</returns>
    public int[][] Closest(string strng);
}