using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Solution
{
    public static int hourglass(int[][] arr)
    {
        int max = -64;
        for (int a = 0; a<arr.GetLength(0)-2; a++)
        {
            for (int i = 0; i < arr[i].Length - 2; i++)
            {
                int sum = 0;

                for (int x = i; x < i + 3; x++)
                {
                    sum = sum + arr[a][x];
                }

                for (int y = i + 1; y >= 0; y++)
                {
                    sum = sum + arr[a + 1][y];

                    break;
                }

                for (int z = i; z < i + 3; z++)
                {
                    sum = sum + arr[a + 2][z];
                }

                if (sum > max)
                {
                    max = sum;
                }
            }
        }      
        return max;
    }


    static void Main(string[] args)
    {
        int[][] arr = new int[6][];

        for (int i = 0; i < 6; i++)
        {
            arr[i] = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
        }

        int result = hourglass(arr);

        Console.WriteLine(result);

        Console.ReadLine();
    }
}
