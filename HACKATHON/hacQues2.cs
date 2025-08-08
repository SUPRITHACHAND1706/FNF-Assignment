using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackathon
{
    internal class Book
    {
        static (string Title, string FirstAuthor) ParseEntry(string entry)

        {

            int titleStart = entry.IndexOf('\"') + 1;

            int titleEnd = entry.IndexOf('\"', titleStart);

            string title = entry.Substring(titleStart, titleEnd - titleStart);

            int authorStart = entry.IndexOf(" by ") + 4;

            string authorPart = entry.Substring(authorStart);

            string firstAuthor = authorPart.Split(new[] { " and " }, StringSplitOptions.None)[0].Trim();

            return (title, firstAuthor);

        }

        static List<string> SortTitles(List<string> bookEntries)

        {

            List<(string Title, string FirstAuthor)> parsedBooks = new List<(string, string)>();

            foreach (string entry in bookEntries)

            {

                var parsed = ParseEntry(entry);

                parsedBooks.Add(parsed);

            }

            parsedBooks.Sort((a, b) =>

            {

                int authorCompare = a.FirstAuthor.CompareTo(b.FirstAuthor);

                if (authorCompare == 0)

                {

                    return a.Title.CompareTo(b.Title);

                }

                return authorCompare;

            });

            List<string> sortedTitles = new List<string>();

            foreach (var item in parsedBooks)

            {

                sortedTitles.Add(item.Title);

            }

            return sortedTitles;

        }

        static void Main()

        {

            List<string> books = new List<string>
            {
                "\"The Canterbury Tales\" by Chaucer",

                "\"Algorithms\" by Sedgewick",

                "\"The C Programming Language\" by Kernighan and Ritchie"

            };

            List<string> sortedTitles = SortTitles(books);

            Console.WriteLine("Sorted Titles:");

            foreach (string title in sortedTitles)

            {

                Console.WriteLine(title);

            }

        }

    }

}
