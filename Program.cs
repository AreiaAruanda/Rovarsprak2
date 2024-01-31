using System.Diagnostics.Metrics;
using System.Numerics;

namespace Rövarsprak
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("What would you like to translate from rövarspråk?\n");
            Console.WriteLine("Please enter a word or sentence: ");
            string word = Console.ReadLine();
            string wordNew = word.ToLower();
            string consonants = "bcdfghjklmnpqrstvxy";

            for (int i = 0; i < wordNew.Length; i++)
            {
                if (consonants.Contains(wordNew[i]))
                {
                    wordNew = wordNew.Remove(i + 1, 2);
                }
                else
                      continue;
            };
            Console.WriteLine(wordNew);
        }
    }
}