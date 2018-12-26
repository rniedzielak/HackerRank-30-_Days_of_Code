using System;
using System.Collections.Generic;
namespace Exercise_from_dictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> phoneBook = new Dictionary<string, int>();
            int T = int.Parse(Console.ReadLine());
            for (int i = 0; i < T; i++)
            {
                string[] position_in_book = Console.ReadLine().Split(' ');
                phoneBook.Add(position_in_book[0], Convert.ToInt32(position_in_book[1]));
            }
            for (int i = 0; i < T; i++)
            {
                string question = Console.ReadLine();
                bool result = phoneBook.ContainsKey(question);
                if (result)
                {
                    Console.WriteLine("{0}={1}", question, phoneBook[question]);
                }
                else
                {
                    Console.WriteLine("Not found");
                }
            }
        }
    }
}
