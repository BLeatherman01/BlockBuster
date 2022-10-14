using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlockBusters
{
    
    public enum Genre
    {
        Drama,
        Comedy,
        Horror,
        Romance,
        Action
    }

    public abstract class Movie
    {
        public string Title { get; set; }
        public int RunTime { get; set; }
        public  Genre Category { get; set; }
        public List<string> Scenes  = new List<string>() {"Tom Cruise Sleeps", "Tom Cruise Runs", "Tom Cruise Jumps", "Tom Cruise Flies", "Tom Cruise Drives" };


       public Movie(string Title, int RunTime, Genre Category)
       {
         this.Title = Title;
         this.RunTime = RunTime;
         this.Category = Category;
       
       }

        public virtual void PrintInfo(Movie movie)
        {
            Console.WriteLine($"{movie.Title}, {movie.RunTime}, {movie.Category}");
        }
        public virtual void PrintScenes(List<string> Scenes)
        {
            for(int i = 0; i < Scenes.Count; i++)
            {
               Console.WriteLine(i+1  + " " +Scenes[i] );
            }
        }

        public abstract void Play();

    }

    
}
