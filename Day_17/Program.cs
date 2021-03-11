using System;

class Calculator
{
    public int power(int a, int b)
    {
        if (a < 0 || b < 0)
        {
            throw new Exception("n and p should be non-negative");
        }
        else
        {
            int sum = 1;
            for (int i = 0; i < b; i++)
            {
                sum = sum * a;
            }

            return sum;
        }
    }
}
class Solution
{
    static void Main(String[] args)
    {
        Calculator myCalculator = new Calculator();
        int T = Int32.Parse(Console.ReadLine());
        while (T-- > 0)
        {
            string[] num = Console.ReadLine().Split();
            int n = int.Parse(num[0]);
            int p = int.Parse(num[1]);
            try
            {
                int ans = myCalculator.power(n, p);
                Console.WriteLine(ans);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);

            }
        }



    }
}