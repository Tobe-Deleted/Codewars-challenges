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
            Console.WriteLine($"iteration {i}");
            if (i > 3 && counter == 2 ||
                i > 3 && counter == 0
               ) 
                steps -= 2; 
            
            for(int n = 0; n < steps -1; n++)
            {
                Console.WriteLine($"x:{x} y:{y}");
                spiral[x, y] = 1; //turns position x,y to 1
                if (i % 2 ==0)
                {
                    x += direction;
                }
                else
                {
                    y += direction;
                }

            }
            if (x == steps -1 && y == steps -1)
                direction = -1;
            else if (x == size - steps && y == size - steps)
                direction = +1;
        }
        return spiral;
    }
}