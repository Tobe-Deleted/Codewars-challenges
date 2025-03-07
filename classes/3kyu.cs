using System;
using System.Data;
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

    public BigInteger FibAttemptOne(int n)
    {
        // iteration method is too slow
        BigInteger a = 0; BigInteger b = 1;
        int limit = Math.Abs(n);
        for(int i = 0; i < limit; i++)
        {
            (a, b) = (b, b + a);
        }
        return n < 0 && Math.Abs(n) % 2 == 0 ? -a : a;
    }
    public BigInteger FibAttemptTwo(int n)
    {
        // deep recursive causes stack overflow
        if(n == 1)return 1;
        if(n == 0)return 0;
        BigInteger[,] baseMatrix = {{1,1},{1,0}};
        int absN = Math.Abs(n);
        
        BigInteger[,] result = NTarget(baseMatrix, absN -1);
        
        return n < 0 && Math.Abs(n) % 2 == 0 ? -result[0,0] : result[0,0];
    }

    private BigInteger[,] NTarget(BigInteger[,] matrix, int n) 
    {
        //belongs to FibAttemptTwo()
        if(n == 1) return matrix;

        if(n % 2 == 0)
        {

            BigInteger[,] halfN = NTarget(matrix, n/2);
            
            return FibonacciCalculations(halfN, halfN);
        }
        else 
        {
            Console.WriteLine("else");
            return FibonacciCalculations(matrix, NTarget(matrix, n-1));
        }
    }

    private BigInteger[,] FibonacciCalculations(BigInteger[,] matrixA, BigInteger[,] matrixB)
    { 
        // belongs to FibAttemptTwo()
        return new BigInteger[,] 
                   {
                        {   matrixA[0,0] * matrixB[0,0] + matrixA[0,1] * matrixB[1,0], 
                            matrixA[0,0] * matrixB[0,1] + matrixA[0,1] * matrixB[1,1]   },
                        {   matrixA[1,0] * matrixB[0,0] + matrixA[1,1] * matrixB[1,0], 
                            matrixA[1,0] * matrixB[0,1] + matrixA[1,1] * matrixB[1,1]   }
                   };
    }

    public BigInteger Fib(int n)
    {
        if (n == 0) return 0;
        if (n == 1) return 1;

        int absN = Math.Abs(n);
        BigInteger[,] baseMatrix = { { 1, 1 }, { 1, 0 } };

        BigInteger[,] result = IterativeMatrixPower(baseMatrix, absN - 1);

        return (n < 0 && absN % 2 == 0) ? -result[0, 0] : result[0, 0];
    }

    private BigInteger[,] IterativeMatrixPower(BigInteger[,] matrix, int n)
    {
        BigInteger[,] result = { { 1, 0 }, { 0, 1 } }; 

        while (n > 0)
        {
            if ((n&1)==1) 
                result = MultiplyMatrices(result, matrix);

            matrix = MultiplyMatrices(matrix, matrix); 
            n >>= 1; 
        }

        return result;
    }

    private BigInteger[,] MultiplyMatrices(BigInteger[,] matrixA, BigInteger[,] matrixB)
    {
        return new BigInteger[,]
        {
            { matrixA[0,0] * matrixB[0,0] + matrixA[0,1] * matrixB[1,0], 
              matrixA[0,0] * matrixB[0,1] + matrixA[0,1] * matrixB[1,1] },
            { matrixA[1,0] * matrixB[0,0] + matrixA[1,1] * matrixB[1,0],  
              matrixA[1,0] * matrixB[0,1] + matrixA[1,1] * matrixB[1,1] }
        };
    }

    public IEnumerable<int> Stream()
    {
        yield return 2;
        const int max = 16000000;
        
        List<int> primes = new List<int> {2};
        for(int i = 3; i < max; i += 2)
        {
            bool isPrime = true;
            int boundary = (int)Math.Sqrt(i);
            
            foreach(int p in primes)
            {
                if(p > boundary) break;

                if(i % p == 0)
                {
                    isPrime = false;
                    break;
                }
            }

            if(isPrime) 
            {
                primes.Add(i);
                yield return i;
            }
        }
    }

    public double Calculate(string s) // not working
    {
        // s = Regex.Replace(s, @"(\d+)\s*\^\s*(\d+)", match =>
        // {
        //     double baseNum = Convert.ToDouble(match.Groups[1].Value);
        //     double exponent = Convert.ToDouble(match.Groups[2].Value);
        //     return Math.Pow(baseNum, exponent).ToString();
        // });
        DataTable dt = new DataTable();
        return Convert.ToDouble(dt.Compute(s, ""));
    }

    public string Decode(string p_what)
    {
        string alphabet = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789.,? ";
        var dict1 = new Dictionary<int, char>();
        for(int i = 0; i < alphabet.Length; i++)
        {
            dict1.Add(i+1, alphabet[i]);
        }

        var dict2 = new Dictionary<char, int>();
        for(int i = 0; i < alphabet.Length; i++)
        {
            dict2.Add(alphabet[i], i+1);
        }

        string result = "";
        for(int i = 0; i <= alphabet.Length; i++)
        {
            if(!alphabet.Contains(p_what[i]))
            {
                result += p_what[i];
                continue;
            }
            var tempDict = new Dictionary<char, int>();
            for(int n = 0; n < alphabet.Length; n++)
            {
                tempDict.Add(alphabet[n], dict2[alphabet[n]]* (2 + i));
            }

        }
        
        return result;
    }

}