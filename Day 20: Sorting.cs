using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        string[] a_temp = Console.ReadLine().Split(' ');
        int[] a = Array.ConvertAll(a_temp,Int32.Parse);
        // Write Your Code Here
        int number_of_Swaps = 0;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n-1; j++)
            {
                if (a[j]>a[j+1])
                {
                    int temp = a[j + 1];
                    a[j + 1] = a[j];
                    a[j] = temp;
                    number_of_Swaps++;                    
                }
            }
            if (number_of_Swaps == 0)
            {
                break;
            }
        }
        Console.WriteLine("Array is sorted in {0} swaps.",number_of_Swaps);
        Console.WriteLine("First Element: {0}",a[0]);
        Console.WriteLine("Last Element: {0}", a[n-1]);
    }
}
