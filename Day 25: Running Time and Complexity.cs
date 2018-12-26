using System;
using System.Collections.Generic;
using System.IO;
class Solution
{
    static string isPrime(int number)
    {
        if (number == 0 || number == 1)
        {
                return "Not prime";
        }
        int sqrt = (int)Math.Sqrt(number);
        for (int i = 2; i <= sqrt; i++)
        {
            if (number%i == 0)
            {
                return "Not prime";
            }
        }
        return "Prime";            
    }
    static void Main(String[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        int[] c = new int[n];
        for (int i = 0; i < n; i++)
        {
            int newTest = Convert.ToInt32(Console.ReadLine());
            c[i] = newTest;
        }
        for (int i = 0; i < n; i++)
        {
            int number = c[i];
            Console.WriteLine(isPrime(number));
        }
    }
}
