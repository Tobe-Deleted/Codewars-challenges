using System;
using System.Collections.Generic;
public class ThreeKyu
{
    public int[,] NxNSpiral(int size)
    {
        
        int[,] spiral = new int[size, size];
        int[] lengths = new int[size];
        lengths[0] = lengths[1] = lengths[2] = size;
        int x = 0, y = 0, dx = 0, dy = 1;

        for (int i = 3; i < size; i++)
        {
            lengths[i] = lengths[i - 1];

            if (i % 2 == 1)
                lengths[i] -= 2;
        }
        foreach (var l in lengths)Console.WriteLine($"length: {l}");
        foreach (var length in lengths)
        {
            spiral = Move(spiral, ref x, ref y, dx, dy, length);
            (dy, dx) = (-dx, dy);
        }

        return spiral;
    }

    public static int[,] Move(int[,] spiral, ref int x, ref int y, int dx, int dy, int length)
    {
        for (int i = 0; i < length; i++)
        {
            spiral[x, y] = 1;
            Console.WriteLine($"dx:{dx} dy:{dy} x:{x} y:{y}");
            x += dx;
            y += dy;
        }

        x -= dx;
        y -= dy;

        return spiral;
    }
}