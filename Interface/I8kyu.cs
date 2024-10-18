public interface I8kyu
{
    /// <summary>
    /// Returns the minimal amount of water in whole litres you should drink per hour
    /// 1 litre per 2 hours is expected.
    /// example: 11.8 should return 5
    /// example: 8 should return 4
    /// </summary>
    /// <param name="time"></param>
    /// <returns>Time / 2 convertet to lowest int</returns>
    public int Litres(double time);
}