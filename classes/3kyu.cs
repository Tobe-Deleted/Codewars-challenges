using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
public class ThreeKyu
{
    public int[,] NxNSpiral(int size)
    {
        int[,] spiral = new int[size, size]; //creates a x*x array with zeroes
        int x = 0; int y = 0; //Coordinates x,y
        int steps = size; //steps indicates the amount of steps before hitting the "wall"
        int direction = -1; //using directon and dir to decide what direction to go in
        int dir = 1;

        for (int i = 0; i < size; i++) //direction changes will always be equal to size
        {
            if (i > 2 && i % 2 == 1) // every two iterations(after the first three), we need to decrease steps by 2
                steps -= 2; 
            if (i % 2 == 0) //inverting directions every 2 interation(opposite to step decreases)
                (direction, dir) = (dir, direction);
            
            for(int n = 0; n < steps -1; n++)
            {
                spiral[x, y] = 1; //turns position x,y to 1
                if (i % 2 ==0)
                {
                    y += direction; //takes us one "step" in the y direction
                }
                else
                {
                    x += direction; // takes us one "step" in the x direction
                }

            }
        }
        spiral[x,y] = 1; // This step is usually done as part of the next iteration. This was the last, so we have to do it "manually"
        return spiral;
    }
}