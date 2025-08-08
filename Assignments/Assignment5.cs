using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Genre { get; set; }
        public int Year { get; set; }

    }
    internal class Assignment5
    {
        static List<Movie> movieList = new List<Movie>();
        static int movieIdCounter = 1;
        static void Main()
        {
            int choice;
            do
            {
                Console.WriteLine("------Movie Datbase software-----");
                Console.WriteLine("1. Add Movie");
                Console.WriteLine("2. Remove Movie");
                Console.WriteLine("3. Find Movie");
                Console.WriteLine("4. Update");
                Console.WriteLine("5. Exit");

                if (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine("Invalid input.");
                    continue;
                }
                switch (choice)
                {
                    case 1:
                        AddMovie();
                        break;
                    case 2:
                        RemoveMovie();
                        break;
                    case 3:
                        FindMovie();
                        break;
                    case 4:
                        UpdateMovie();
                        break;
                    case 5:
                        Console.WriteLine("Exiting");
                        break;
                    default:
                        Console.WriteLine("invalid choice");
                        break;
                }


            } while (choice != 5);

        }


        static void AddMovie()
        {
            Console.WriteLine("----Adding a movie------");
            Console.Write("Enter movie title:");
            string title = Console.ReadLine();

            Console.Write("Enter movie genre:");
            string genre = Console.ReadLine();

            Console.Write("Enter release year:");
            if (!int.TryParse(Console.ReadLine(), out int year))
            {
                Console.WriteLine("Invalid year");
                return;
            }
            Movie newMovie = new Movie()
            {
                Id = movieIdCounter++,
                Title = title,
                Genre = genre,
                Year = year,

            };
            

            movieList.Add(newMovie);
            Console.WriteLine("Movie added successfully");
        }



        static void RemoveMovie()
        {
            Console.Write("Enter movie ID to remove: ");
            if (!int.TryParse(Console.ReadLine(), out int id))
            {
                Console.WriteLine("Invalid ID!");
                return;
            }

            var movie = movieList.FirstOrDefault(m => m.Id == id);
            if (movie != null)
            {
                movieList.Remove(movie);
                Console.WriteLine("Movie removed successfully!");
            }
            else
            {
                Console.WriteLine("Movie not found!");
            }
        }

        static void FindMovie()
        {
            Console.Write("Enter movie title to search: ");
            string search = Console.ReadLine().ToLower();

            var results = movieList.Where(m => m.Title.ToLower().Contains(search)).ToList();

            if (results.Count > 0)
            {
                Console.WriteLine("\nSearch Results:");
                foreach (var movie in results)
                {
                    Console.WriteLine($"ID: {movie.Id}, Title: {movie.Title}, Genre: {movie.Genre}, Year: {movie.Year}");
                }
            }
            else
            {
                Console.WriteLine("No movies found with that title.");
            }
        }

        static void UpdateMovie()
        {
            Console.Write("Enter movie ID to update: ");
            if (!int.TryParse(Console.ReadLine(), out int id))
            {
                Console.WriteLine("Invalid ID!");
                return;
            }

            var movie = movieList.FirstOrDefault(m => m.Id == id);
            if (movie == null)
            {
                Console.WriteLine("Movie not found!");
                return;
            }
            Console.WriteLine($"Current Title: {movie.Title}, Genre: {movie.Genre}, Year: {movie.Year}");

            Console.Write("Enter new title (leave blank to keep current): ");
            string newTitle = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(newTitle))
                movie.Title = newTitle;

            Console.Write("Enter new genre (leave blank to keep current): ");
            string newGenre = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(newGenre))
                movie.Genre = newGenre;

            Console.Write("Enter new year (leave blank to keep current): ");
            string newYearInput = Console.ReadLine();
            if (int.TryParse(newYearInput, out int newYear))
                movie.Year = newYear;

            Console.WriteLine("Movie updated successfully!");

        }

    }
}
