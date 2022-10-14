using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace BlockBusters
{
    public class Blockbuster 
    {

       public List<Movie> Movies { get; set; } = new List<Movie>();


        public void PrintMovies()
        {
            
            for (int i = 0; i < Movies.Count; i++)
            { 

                Console.WriteLine(i+1 + " " +Movies[i].Title );
            }
        }
        public Movie CheckOut()
        {
            PrintMovies();

            Console.WriteLine("which movie would you like checkout. Please select 1-6");
            string selection = Console.ReadLine();
            int index = int.Parse(selection);

            Movie selectedMovie = Movies.ElementAt(index -1);
            Console.WriteLine($"{selectedMovie.Title} \n{selectedMovie.RunTime} minutes \n{selectedMovie.Category}");
            return selectedMovie;
           
            //Based on the instructions it seems like BlockBuster should not be child of Movie. 
            //But printinfo isn't reachable bc its not a child
            //PrintInfo(selectedMovie);

        }
       
    }         
}  
