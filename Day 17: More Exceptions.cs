using System;
//Write your code here
class Calculator
{
    public int power(int n, int p)
    {
        Exception e = new Exception("n and p should be non-negative");
        int result = 0;
        if (p == 0 && n >= 0)
        {
            result = 1;
        }
        else if (p > 0 && n >= 0)
        {
            result = 1;
            for (int i = 0; i < p; i++)
            {
                result = result * n;
            }
        }
        else
        {
            throw e;
        }
        return result;
    }
}
class Solution
{
    static void Main(String[] args)
    {
        Calculator myCalculator=new  Calculator();
        int T=Int32.Parse(Console.ReadLine());
        while(T-->0)
        {
            string[] num = Console.ReadLine().Split();
            int n = int.Parse(num[0]);
            int p = int.Parse(num[1]); 
            try
            {
                int ans=myCalculator.power(n,p);
                Console.WriteLine(ans);
            }
            catch(Exception e)
            {
               Console.WriteLine(e.Message);
            }
        }       
    }
}
