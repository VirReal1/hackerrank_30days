using System;
using System.Linq;

class Difference
{
    private int[] elements;
    public int maximumDifference;

    public Difference (int[] e)
    {
        elements = e;
    }
    public int computeDifference()
    {
        int min = Math.Abs(elements[0]);

        int max = min;

        for(int i = 1; i<elements.Length; i++)
        {
            if(Math.Abs(elements[i]) < min)
            {
                min = Math.Abs(elements[i]);
            }
            else if (Math.Abs(elements[i]) > max)
            {
                max = Math.Abs(elements[i]);
            }
        }

        maximumDifference = max - min;

        return maximumDifference;
    }

} 

class Solution
{
    static void Main(string[] args)
    {
        Convert.ToInt32(Console.ReadLine());

        int[] a = Console.ReadLine().Split(' ').Select(x => Convert.ToInt32(x)).ToArray();

        Difference d = new Difference(a);

        d.computeDifference();

        Console.Write(d.maximumDifference);
    }
}