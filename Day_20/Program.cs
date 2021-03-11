using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{
    static void Main(String[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());

        string[] a_temp = Console.ReadLine().Split(' ');

        int[] a = Array.ConvertAll(a_temp, Int32.Parse);

        int numberOfSwaps = 0;

        for (int i = 0; i < a.Length; i++)
        {
            for (int y = 0; y < a.Length - 1; y++)
            {
                int swap = a[y + 1];

                if (a[y] > a[y + 1])
                {
                    a[y + 1] = a[y];

                    a[y] = swap;

                    numberOfSwaps++;
                }
            }

            if (numberOfSwaps == 0)
            {
                break;
            }
        }

        Console.WriteLine("Array is sorted in " + numberOfSwaps + " swaps.");

        Console.WriteLine("First Element: " + a[0]);

        Console.WriteLine("Last Element: " + a[a.Length - 1]);

        Console.ReadKey();
    }
}
