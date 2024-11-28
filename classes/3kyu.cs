using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
public class ThreeKyu
{
    public int[,] NxNSpiral(int size)
    {
        int[,] spiral = new int[size, size]; //creates a x*x array with zeroes
        int x = 0; int y = 0; //Coordinates x,y
        int steps = size;
        int direction = 1;

        for (int i = 0; i < size; i++)
        {
            if (i < 3)
                steps -= 2;
            
            for(int n = 0; n < steps; n++)
            {
                spiral[x, y] = 1;
                if (i % 2 ==0)
                {
                    x += direction;
                }
                else
                {
                    y += direction;
                }

            }
            if (i % 2 == 0)
                direction = 1;
            else
                direction = -1;
        }
        return spiral;
    }
}