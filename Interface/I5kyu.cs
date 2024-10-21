public interface I5kyu
{
    /// <summary>
    /// Takes in an array and move all 0's to the end of the array
    /// </summary>
    /// <param name="arr"></param>
    /// <returns>new int[] {1, 2, 0, 1, 0, 1, 0, 3, 0, 1} => new int[] {1, 2, 1, 1, 3, 1, 0, 0, 0, 0}</returns>
    public int[] MoveZeroes(int[] arr);
}