using System;

class Task
{
    static void Solution(string s)
    {
        for (int i = 0; i < s.Length; i++)
        {
            if (i % 2 == 0)
            {
                Console.Write(s[i]);
            }
        }
        Console.Write(" ");
        for (int i = 0; i < s.Length; i++)
        {
            if (i % 2 != 0)
            {
                Console.Write(s[i]);
            }
        }
        Console.WriteLine();
    }

    static void Main(string[] args)
    {
        int t = Convert.ToInt32(Console.ReadLine());
        for (int i = 0; i < t; i++)
        {
            string s = Console.ReadLine();
            Solution(s);
        }
    }
}
