using BlockBusters;

namespace BlockBuster
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Blockbuster b = new Blockbuster();

            b.Movies.Add(new DVD("Oblivion", 116, Genre.Action));
            b.Movies.Add(new DVD("Days of Thunder", 115, Genre.Action));
            b.Movies.Add(new DVD("The Outsider", 90, Genre.Drama));
            b.Movies.Add(new VHS("Risky Business", 112, Genre.Drama));
            b.Movies.Add(new VHS("Rain Man", 110, Genre.Drama));
            b.Movies.Add(new VHS("Top Gun", 110, Genre.Action));

            Console.WriteLine("Welcome to the eighties");

            bool keepGoing = true;

            while (keepGoing)
            {

                Movie selectedMovie = b.CheckOut();
                
                Console.WriteLine("Do you want to watch the movie?");
                string answer = Console.ReadLine().Trim().ToLower();
                if (answer == "y")
                {
                    if (selectedMovie is DVD)
                    {
                        selectedMovie.Play();
                        Console.WriteLine("Would you like to watch another scene?");
                        string selection2 = Console.ReadLine().Trim().ToLower();
                        if (selection2 == "y")
                        {
                            selectedMovie.Play();
                        }
                        else
                        {
                            Console.WriteLine("Goodbye");
                            break;
                        }
                    }
                    else
                    {
                        selectedMovie.Play();
                        Console.WriteLine("Would you like to watch another scene?");
                        string selectionVHS = Console.ReadLine().Trim().ToLower();
                        if(selectionVHS == "y")
                        {
                            selectedMovie.Play();
                        }
                    }
                }
                else if (answer == "n")
                {
                    Console.WriteLine("Goodbye");
                }
                
                keepGoing = false;
            }

        }
    }
}