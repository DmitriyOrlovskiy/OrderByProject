using System;
using System.Linq;

namespace OrderByProject
{
    class Program
    {
        static void Main(string[] args)
        {
         string line = "Summer Tree      List   Auto Candy   Drug";
            Console.WriteLine(line);
         string[] Word = line.Split();
         var orderbywords = Word.OrderBy(c => c).Select(c => c.Trim());
            {
            foreach (string word in orderbywords)
                Console.WriteLine(word);
            }
        }
    }
}
