public interface I3kyu
{
    /// <summary>
    /// Takes in a number x and creates a spiral in a map that is x*x large
    /// </summary>
    /// <param name="size"></param>
    /// <returns>returns a 2d int array that forms a spiral of 1s if each object is printed out per line</returns>
    public int[,] NxNSpiral(int size);
}