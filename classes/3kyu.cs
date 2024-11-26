public class ThreeKyu
{
    public int[,] NxNSpiral(int size)
    {
        for (int i = 0; i < size; i++)
        {
            int[,] = {NxNSpiralBuilder(size, i)};
        }
        return null;
    }

    public int[] NxNSpiralBuilder(int size, int row)
    {
        bool IsZero = false;
        string str = "";
        int HowManyZeros = 0;
        if (row % 2 == 1)
        {
            for(int i = 0; i < size; i++)
            {
                if(row < size /2) // size / 2 should default to highest 25 => 13
                    HowManyZeros = row -2;
                else if (row == size / 2 + 1.5) ;

                if (row == 1)
                    str += 1;
                else if(IsZero)str += 0;
                else str += 1;
                
            }
        }
        else
        {

        }
        return str.Split()
                  .Select(int.Parse)
                  .ToArray();
    }
}