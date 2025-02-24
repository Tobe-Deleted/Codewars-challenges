using System;
using System.Collections.Generic;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;
public class ThreeKyu : I3kyu
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

    public BigInteger EggDrop(int n, int m)
    {
        // Create a 2D array to store results of subproblems
        int[,] dp = new int[n + 1, m + 1];

        // Fill the dp table
        // dp[i][j] will store the maximum number of floors that can be tested with i eggs and j tries
        for (int i = 0; i <= n; i++)
        {
            for (int j = 0; j <= m; j++)
            {
                // Base case: 0 tries or 1 egg, we can only test 0 or 1 floor
                if (i == 0 || j == 0)
                {
                    dp[i, j] = 0;
                }
                else if (i == 1) // If we have only 1 egg, we can test j floors with j tries
                {
                    dp[i, j] = j;
                }
                else
                {
                    // Calculate dp[i][j] by testing from each floor and taking the best result
                    dp[i, j] = dp[i - 1, j - 1] + dp[i, j - 1] + 1;
                }
            }
        }
        return dp[n, m];
    }

    public BigInteger Fib(int n)
    {
        int limit = Math.Abs(n);
        BigInteger[,] matrix = {{0,1},{1,1}};
        
        // iteration method is too slow
        for(int i = 0; i < limit; i++)
        {
            (matrix[0,0], matrix[0,1]) = (matrix[0,1], matrix[0,1] + matrix[0, 0]);
        }
        
        return n < 0 && Math.Abs(n) % 2 == 0 ? -matrix[0,0] : matrix[0,0];
    }
}