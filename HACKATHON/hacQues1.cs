using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackathon
{
    internal class hacQues1
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter the input:");
            string input = Console.ReadLine();
            freqCounter(input);
        }
        static void freqCounter(string input)
        {
            if (!input.Any(char.IsLetter))
            {
                Console.WriteLine("0");
                return;
            }

            input = input.ToLower();

            char[] CharClean = input.Select(c => char.IsLetter(c) || c == ' ' ? c : ' ').ToArray();
            string cleanInput = new string(CharClean);

            string[] words = cleanInput.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            Dictionary<string, int> freq = new Dictionary<string, int>();
            foreach (string word in words)
            {
                if (freq.ContainsKey(word))
                {
                    freq[word]++;
                }
                else
                {
                    freq[word] = 1;
                }
            }

            var sortedWords = freq.OrderByDescending(x => x.Value).ThenByDescending(x => x.Key);

            foreach (var pair in sortedWords)
            {
                Console.WriteLine($"{pair.Value} {pair.Key}");
            }
            
        }
        
    }
}


