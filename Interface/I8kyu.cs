public interface I8kyu
{
    /// <summary>
    /// Returns the minimal amount of water in whole litres you should drink per hour
    /// 1 litre per 2 hours.
    /// https://www.codewars.com/kata/582cb0224e56e068d800003c
    /// </summary>
    /// <param name="time"></param>
    /// <returns>Time / 2 convertet to lowest int</returns>
    public int Litres(double time);

    /// <summary>
    /// takes in a year and returns the century that year was in
    /// https://www.codewars.com/kata/5a3fe3dde1ce0e8ed6000097/csharp
    /// </summary>
    /// <param name="year"></param>
    /// <returns>returns int representing the century</returns>
    public int CenturyFromYear(int year);

    /// <summary>
    /// Adds together every number of given array
    /// </summary>
    /// <param name="array"></param>
    /// <returns>double with sum of all numbers in given array</returns>
    public double SumOfArray(double[] array);
}