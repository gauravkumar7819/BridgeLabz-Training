using System;

namespace movies_scheduler_manager
{
    class MovieUtility : IMovieManager
    {
        // Array to store movies
        private Movie[] movies = new Movie[10];
        private int count = 0;

        // Add movie
        public void AddMovie(string title, string time)
        {
            if (count >= movies.Length)
            {
                Console.WriteLine("Movie list is full.");
                return;
            }

            Movie c = new Movie();
            c.MovieName = title;
            c.ShowTime = time;

            movies[count] = c;
            count++;
       
            
        }

        // Display all movies
        public void DisplayAll()
        {
            if (count == 0)
            {
                Console.WriteLine("No movies available.");
                return;
            }

            Console.WriteLine("\n--- Movie Schedule ---");
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(movies[i]);
            }
        }

        // Search movie using keyword
        public void SearchMovie(string keyword)
        {
                bool found = false;

                for (int i = 0; i < count; i++)
                {
                    if (movies[i].MovieName.Contains(keyword))
                    {
                        Console.WriteLine("movies found");
                        
                        Console.WriteLine(movies[i]);
                        found = true;
                    }
                }

                if (!found)
                {
                    Console.WriteLine("No movie found with given keyword.");
                }
            }

        }
    
}
