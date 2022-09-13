
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace MovieRental
{
    class Movie
    {
        private static string title;
        private static string genre;
        private static double price;
        private static bool availability;

        private void addMovie()
        {
        }

        public string test(string test)
        {
            readInMovieFile();
            return "Test";
        }
        private void removeMovie()
        {
        }

        private void searchMovie()
        {
        }

        private void readInMovieFile()
        {
            StreamReader sr = new StreamReader("Movies.txt");
            try
            {
                while (sr.ReadLine() != null)
                {
                    String line = sr.ReadLine();
                    Console.WriteLine(line);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("File could not be read: ");
                Console.Write(e.Message);
            }
        }

        private void writeToMovieFile()
        {
        }
    }

}